using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using IniTool;
using System.Threading;
using System.IO.Ports;

namespace Maintain.Teaching
{
    public partial class CCVcrTeachControl : Common.Wizard.CCInteriorWizardPage
    {
        #region Private Member
        private CCVcrTeachInfo m_info = new CCVcrTeachInfo();
        private ContrelModule.CCVCRInterface m_VcrInterface = ContrelModule.CCVCRInterface.GetSingleton();
        #endregion

        #region Ctor
        public CCVcrTeachControl()
        {
            InitializeComponent();

            // 將資料交由 TeachingInfoFactory 管理            
            TeachingInfoFactory.RegisterTeachInfoToFactory(m_info);

            // Setup VCR Protocol
            m_VcrInterface.PortBoudrate = 9600;
            m_VcrInterface.PortStopBits = StopBits.One;
            m_VcrInterface.PortNumber = string.Format("COM{0:d}", 5);
            m_VcrInterface.PortParity = Parity.None;
            m_VcrInterface.PortDataBits = 8;
            //m_VcrInterface.DataReceiveHandler = new SerialDataReceivedEventHandler(m_VcrInterface.VCRDataReceived);
         
            try
            {
                m_VcrInterface.Open();
                //m_ConnectHandler(this, null);
            }
            catch (Exception e)
            {
                //MessageBox.Show("[" + e.Message + "]" + " Can't Open : " + m_SerialPort.PortName);     
            }

        }
        #endregion             

        #region Protected Method
        protected override bool OnSetActive()
        {
            if (!base.OnSetActive())
                return false;

            // Enable both the Next and Back buttons on this page    
            Wizard.SetWizardButtons(Common.Wizard.WizardButton.Back | Common.Wizard.WizardButton.Next);
            return true;
        }
        #endregion

        #region Private Method
        private void m_btnGAxisGet_Click(object sender, EventArgs e)
        {
            m_tbxGAxis.Text = m_tbxGAxisPos.Text;
        }

        private void m_btnSAxisGet_Click(object sender, EventArgs e)
        {
            m_tbxSAxis.Text = m_tbxSAxisPos.Text;
        }

        private void m_btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog DialogSave = new SaveFileDialog();
            DialogSave.InitialDirectory = TeachingInfoFactory.GetTeachInfoObject("VCR Teach").IniDirPath;
            DialogSave.Filter = "Ini file (*.ini)|";
            DialogSave.DefaultExt = "ini";

            if (DialogSave.ShowDialog() == DialogResult.OK)
            {
                if (DialogSave.FileName != "")
                {
                    IniFile iniFile = new IniFile(DialogSave.FileName);

                    iniFile.WriteValue("VCR", "G Axis", m_tbxGAxisPos.Text);
                    iniFile.WriteValue("VCR", "S Axis", m_tbxSAxisPos.Text);
                    iniFile.WriteValue("VCR", "Z Axis", m_tbxZAxisPos.Text);
                }
            }
            DialogSave.Dispose();
            DialogSave = null;
        }

        private void m_btnUp_Click(object sender, EventArgs e)
        {
            double iSpeed = int.Parse(m_txbSpeedPercentage.Text) / 100 * 200;
            string szCmd = string.Format("C401,{0},0,0,{1},300,300,0", int.Parse(m_tbxAxisDistance.Text), iSpeed);
            SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
            /*string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            szCmd = "C401," + Convert.ToInt32(PulseAndSensor.dMotionPulse[0] * 10) + "," + Convert.ToInt32(PulseAndSensor.dMotionPulse[1] * 10) +
                        "," + Convert.ToInt32(PulseAndSensor.dMotionPulse[1] * 10) + ",0";

            SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);*/
            /*
            if (CC_GSY_Axis.IsGAxisRunning() || CC_GSY_Axis.IsLAxisRunning() || CC_GSY_Axis.IsSAxisRunning())
            {
                MessageBox.Show("目前 G 或 S 或 L 軸正在移動，請勿操作 !!");
                return;
            }

            CC_GSY_Axis axis = new CC_GSY_Axis();

            axis.IsAbsoulte = false;
            axis.SPosition = double.Parse(m_tbxAxisDistance.Text);
            axis.Run();
            */
        }

        private void m_btnDown_Click(object sender, EventArgs e)
        {
            /*string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            szCmd = "C401," + Convert.ToInt32(PulseAndSensor.dMotionPulse[0] * 10) + "," + Convert.ToInt32(PulseAndSensor.dMotionPulse[1] * 10) +
                        "," + Convert.ToInt32(PulseAndSensor.dMotionPulse[1] * 10) + ",0";*/

            double iSpeed = int.Parse( m_txbSpeedPercentage.Text ) * 200 / 100;
            string szCmd = string.Format("C401,{0},0,0,{1},300,300,0", int.Parse(m_tbxAxisDistance.Text)*(-1), iSpeed);             
            SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
            /*
            if (CC_GSY_Axis.IsGAxisRunning() || CC_GSY_Axis.IsLAxisRunning() || CC_GSY_Axis.IsSAxisRunning())
            {
                MessageBox.Show("目前 G 或 S 或 L 軸正在移動，請勿操作 !!");
                return;
            }

            CC_GSY_Axis axis = new CC_GSY_Axis();

            axis.IsAbsoulte = false;
            axis.SPosition = double.Parse(m_tbxAxisDistance.Text) * (-1);
            axis.Run();
            */
        }

        private void m_btnLeft_Click(object sender, EventArgs e)
        {
            double iSpeed = int.Parse(m_txbSpeedPercentage.Text) * 200 / 100;
            string szCmd = string.Format("C401,0,{0},{0},{1},300,300,0", int.Parse(m_tbxAxisDistance.Text) * (-1), iSpeed);
            SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);

            /*string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            int iGPosition = int.Parse( m_tbxAxisDistance.Text) * (-1);

            szCmd = "C401," + "0," + iGPosition.ToString() + "," + iGPosition.ToString();*/
                        

            //SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
            /*
            if (CC_GSY_Axis.IsGAxisRunning() || CC_GSY_Axis.IsLAxisRunning() || CC_GSY_Axis.IsSAxisRunning())
            {
                MessageBox.Show("目前 G 或 S 或 L 軸正在移動，請勿操作 !!");
                return;
            }
            
            CC_GSY_Axis axis = new CC_GSY_Axis();

            axis.IsAbsoulte = false;
            axis.GPosition = double.Parse(m_tbxAxisDistance.Text) * (-1);
            axis.Run();
            */
        }

        private void m_btnRight_Click(object sender, EventArgs e)
        {
            double iSpeed = int.Parse(m_txbSpeedPercentage.Text) * 200 / 100;
            string szCmd = string.Format("C401,0,{0},{0},{1},300,300,0", int.Parse(m_tbxAxisDistance.Text), iSpeed);
            SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);

            /*string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            szCmd = "C401," + Convert.ToInt32(PulseAndSensor.dMotionPulse[0] * 10) + "," + Convert.ToInt32(PulseAndSensor.dMotionPulse[1] * 10) +
                        "," + Convert.ToInt32(PulseAndSensor.dMotionPulse[1] * 10) + ",0";

            SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);*/
            /*
            if (CC_GSY_Axis.IsGAxisRunning() || CC_GSY_Axis.IsLAxisRunning() || CC_GSY_Axis.IsSAxisRunning())
            {
                MessageBox.Show("目前 G 或 S 或 L 軸正在移動，請勿操作 !!");
                return;
            }

            CC_GSY_Axis axis = new CC_GSY_Axis();

            axis.IsAbsoulte = false;
            axis.GPosition = double.Parse(m_tbxAxisDistance.Text);
            axis.Run();
            */
        }

        private void m_UITimer_Tick(object sender, EventArgs e)
        {
            //m_tbxGAxisPos.Text = CC_GSY_Axis.GetGAxisPosition().ToString();
            //m_tbxSAxisPos.Text = CC_GSY_Axis.GetSAxisPosition().ToString();       
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            m_tbxGAxisPos.Text = (Convert.ToInt32(PulseAndSensor.dMotionPulse[1] * 10)).ToString();
            m_tbxSAxisPos.Text = (Convert.ToInt32(PulseAndSensor.dMotionPulse[0] * 10)).ToString();
            m_tbxZAxisPos.Text = ContrelModule.ZMotion.ZMGetCurrentPosition().ToString();           
        }

        private void m_txbSpeedPercentage_Validated(object sender, EventArgs e)
        {
            m_UIerrorProvider.SetError(m_txbSpeedPercentage, "");
        }

        private void m_txbSpeedPercentage_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(m_txbSpeedPercentage.Text) > 100 || int.Parse(m_txbSpeedPercentage.Text) <= 0)
            {
                e.Cancel = true;
                m_UIerrorProvider.SetError(m_txbSpeedPercentage, "輸入值大於100或是小於0 !!");
            }
        }
        
        private void m_btnVCRReadTest_Click(object sender, EventArgs e)
        {
            if (m_chkContiousVCR.CheckState == CheckState.Checked)
            {
                m_VcrInterface.StartContinusReadVCR();
            }
            else
            {
                m_VcrInterface.ReadVCR();
            }
        }

        private void m_btnVCRReadPosition_Click(object sender, EventArgs e)
        {
            /*string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            szCmd = "C401," + Convert.ToInt32(PulseAndSensor.dMotionPulse[0] * 10) + "," + Convert.ToInt32(PulseAndSensor.dMotionPulse[1] * 10) +
                        "," + Convert.ToInt32(PulseAndSensor.dMotionPulse[1] * 10) + ",1";

            SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);*/

            
        }

        #endregion

        private void m_chkContiousVCR_CheckedChanged(object sender, EventArgs e)
        {
            if (m_chkContiousVCR.CheckState == CheckState.Unchecked)
            {
                m_VcrInterface.StopContinueReadVCR();
            }
        }

        private void m_btnZAxisGet_Click(object sender, EventArgs e)
        {
            // 取得 Z 軸 位置
            m_tbxZAxis.Text = m_tbxZAxisPos.Text;
        }
    }

    /// <summary>
    /// 存放教點相關資訊
    /// </summary>
    public class CCVcrTeachInfo : CCAbstractTeachingInfo
    {
        #region Ctor
        public CCVcrTeachInfo()
        {
            m_strTeachName = "VCR Teach";
        }
        #endregion
    }

    /*public class CCVCRInterface
    {
        #region Private Member
        private SerialPort m_SerialPort = null;
        #endregion

        #region Ctor
        public CCVCRInterface()
        {
            m_SerialPort = new SerialPort();
            m_SerialPort.DataReceived += new SerialDataReceivedEventHandler(this.VCRDataReceived);
        }
        #endregion

        #region properties

        // COM port
        public string PortNumber
        {
            get { return m_SerialPort.PortName; }
            set
            {
                if (m_SerialPort.IsOpen == false)
                    m_SerialPort.PortName = value;
            }
        }

        // Port Boudrate
        public int PortBoudrate
        {
            get { return m_SerialPort.BaudRate; }
            set
            {
                if (m_SerialPort.IsOpen == false)
                    m_SerialPort.BaudRate = value;
            }
        }

        // Port DataBits
        public int PortDataBits
        {
            get { return m_SerialPort.DataBits; }
            set
            {
                if (m_SerialPort.IsOpen == false)
                    m_SerialPort.DataBits = value;
            }
        }

        // Port StopBits
        public StopBits PortStopBits
        {
            get { return m_SerialPort.StopBits; }
            set
            {
                if (m_SerialPort.IsOpen == false)
                    m_SerialPort.StopBits = value;
            }
        }

        // Port Parity
        public Parity PortParity
        {
            get { return m_SerialPort.Parity; }
            set
            {
                if (m_SerialPort.IsOpen == false)
                    m_SerialPort.Parity = value;
            }
        }

        // Port DataReceived        
        public SerialDataReceivedEventHandler DataReceiveHandler
        {
            set
            {
                if (m_SerialPort.IsOpen == false)
                    m_SerialPort.DataReceived += value;
            }       
        }        
        #endregion

        #region Public Method
        public void Open()
        {
            m_SerialPort.Open();
        }

        public void Close()
        {
            m_SerialPort.Close();
        }

        public byte[] Receive()
        {
            int nbytes = m_SerialPort.BytesToRead;
            byte[] data = new byte[nbytes];
            m_SerialPort.Read(data, 0, data.Length);
            return data;
        }

        public void ReadVCR()
        {
            byte[] msg = new byte[5] { 0x1B, (byte)'P', 0x00, 0xFF, 0x0D };
            m_SerialPort.Write(msg, 0, msg.Length);
        }

        public void StartContinusReadVCR()
        {
            byte[] initialVCR = new byte[2] { (byte)'g', 0x0D };
            m_SerialPort.Write(initialVCR, 0, initialVCR.Length);
            Thread.Sleep(10);

            byte[] continusCMD = new byte[8 + 1] { (byte)'c', (byte)'o', (byte)'n', (byte)'t', (byte)'i', (byte)'n', (byte)'u', (byte)'e', 0x0D };            
            m_SerialPort.Write(continusCMD, 0, continusCMD.Length);
        }

        public void StopContinueReadVCR()
        {
            byte[] continusCMD = new byte[4 + 1] { (byte)'s', (byte)'t', (byte)'o', (byte)'p', 0x0D };
            m_SerialPort.Write(continusCMD, 0, continusCMD.Length);
        }

        #region Private Method
        public void VCRDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] data = Receive();
            int iOffset = 0;

            if (data.Length <= 0)
                return;

            switch (data[iOffset])
            {
                case 0x56: // 'V'
                case 0x44: // 'D'

                    // 1. Header
                    iOffset++;

                    // 2. Data Length
                    int iDatalen = Convert.ToInt16(data[iOffset]);
                    iOffset += 2;

                    // 3. ID
                    byte[] id = new byte[iDatalen];
                    Array.Copy(data, iOffset, id,0, id.Length);
                    string panelID = Encoding.Default.GetString(id);

                    MessageBox.Show("讀取ID: " + panelID);

                    break;

                case 0x52: // 'R'
                    // TODO: Retry
                    break;
            }


        }

        #endregion
       
        #endregion

    }*/

}