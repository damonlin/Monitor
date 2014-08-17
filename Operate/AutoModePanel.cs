//#define PLC_ON

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Common.Template;
using ContrelModule;
using System.IO.Ports;
using System.Threading;

namespace AutoMode
{
    public partial class AutoModePanel : InfoPanelTemplate
    {
        private static AutoModePanel singleton = null;
        private ContrelModule.CPLCInterface m_PLCInterface = ContrelModule.CPLCInterface.GetSingleton();
        private Thread plcThread;

        public AutoModePanel()
        {
            InitializeComponent();
           
            try
            {
#if PLC_ON
                m_PLCInterface.Open();
#endif
            }
            catch (Exception e)
            {
                MessageBox.Show("[" + e.Message + "]" + " Can't Open : " + m_PLCInterface.PortNumber);
            }

#if PLC_ON
            // For Threading
            m_PLCInterface.receiving = true;
            plcThread = new Thread(m_PLCInterface.DoReceive);
            plcThread.IsBackground = true;
            plcThread.Start();
#endif
        }     

        public static AutoModePanel getSingleton()
        {
            if (singleton == null)
            {
                singleton = new AutoModePanel();
            }
            return singleton;
        }

        private void plcTimer_Tick(object sender, EventArgs e)
        {
            m_PLCInterface.PLCReadWord_D();
            Thread.Sleep(100);
           
            CPLCInterface.PLCData data = m_PLCInterface.PLCRcvData;
            if (data != null)
            {
                //labelLVG.Text = ConvertToTorr(data.m_RcvData.Substring(0, 4));
                //labelHVG.Text = ConvertToTorr(data.m_RcvData.Substring(4, 4));
                labelLVG.Text = data.m_RcvData.Substring(0, 4);
                labelHVG.Text = data.m_RcvData.Substring(4, 4);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //m_PLCInterface.PLCWriteWord_D("aa");
            //ConvertToTorr("AB12");
        }     

        private string ConvertToTorr(string value)
        {            
            double voltage = Convert.ToInt32(value,16) * 0.005;
            return Math.Pow(10, voltage-5.625).ToString();
        }
    }
}
