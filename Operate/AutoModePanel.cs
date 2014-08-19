#define PLC_ON

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

        private bool bRVON = false;
        private bool bVVON = false;
        private bool bAuto = false;

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
                labelLVG.Text = ConvertToTorr(data.m_RcvData.Substring(0, 4));
                labelHVG.Text = ConvertToTorr(data.m_RcvData.Substring(4, 4));
                //labelLVG.Text = data.m_RcvData.Substring(0, 4);
                //labelHVG.Text = data.m_RcvData.Substring(4, 4);
            }

            m_PLCInterface.PLCReadBit_M();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //m_PLCInterface.PLCWriteWord_D("aa");
            //ConvertToTorr("AB12");
        }     

        private string ConvertToTorr(string value)
        {            
            double voltage = Convert.ToInt32(value,16) * 0.005;
            return Math.Round(Math.Pow(10, voltage - 5.625), 2).ToString("E2");
        }
      
        private void btnRVSwitch_Click(object sender, EventArgs e)
        {
            bRVON = !bRVON;

            if (bRVON)
                btnRVSwitch.Text = "RV ON";
            else
                btnRVSwitch.Text = "RV OFF";

            m_PLCInterface.PLCWriteBit_M("M2020",2,  bRVON);
        }

        private void btnVVSwitch_Click(object sender, EventArgs e)
        {
            bVVON = !bVVON;

            if (bVVON)
                btnVVSwitch.Text = "VV ON";
            else
                btnVVSwitch.Text = "VV OFF";

            m_PLCInterface.PLCWriteBit_M("M2022", 2,  bVVON);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {            
            bAuto = !bAuto;

            if (bAuto)
                button1.Text = "AUTO";
            else
                button1.Text = "MANUAL";

            m_PLCInterface.PLCWriteBit_M("M2000", 2, bAuto);
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            m_PLCInterface.PLCWriteBit_M("M2001", 1, true);
        }

     
    }
}
