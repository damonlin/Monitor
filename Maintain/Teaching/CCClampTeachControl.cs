using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using IniTool;

namespace Maintain.Teaching
{    
    public partial class CCClampTeachControl : Common.Wizard.CCInteriorWizardPage
    {
        #region Private Member
        private CCClampTeachInfo m_info = new CCClampTeachInfo();
        #endregion

        #region Ctor
        public CCClampTeachControl()
        {
            InitializeComponent();

            // 將資料交由 TeachingInfoFactory 管理            
            TeachingInfoFactory.RegisterTeachInfoToFactory(m_info);            
       
            m_cbAxis.SelectedIndex = 0;
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
        private void m_btnDecrease_Click(object sender, EventArgs e)
        {
            string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            switch (m_cbAxis.Text)
            {
                case "C1C2":
                    //szCmd = "C410," + Convert.ToInt32(PulseAndSensor.dMotionPulse[17] * 10 - iOffset ) + ",0";
                    szCmd = string.Format("C410,{0},0,0",int.Parse(m_tbxAxisDistance.Text));
                    SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
                    break;
                case "SA1&SA2":
                    //szCmd = "C411," + Convert.ToInt32(PulseAndSensor.dMotionPulse[18] * 10 - iOffset ) + ",0";
                    szCmd = string.Format("C410,0,{0},0", int.Parse(m_tbxAxisDistance.Text));
                    SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
                    break;
            }
            /*
            if (CC_C1C2_Axis.IsC1C2AxisRunning() || CC_SA1SA2_Axis.IsSA1SA2AxisRunning())
            {
                MessageBox.Show("目前 C1C2 或 SA1SA2 軸正在移動，請勿操作 !!");
                return;
            }

            switch (m_cbAxis.Text)
            {
                case "C1C2":
                    {
                        CC_C1C2_Axis axis = new CC_C1C2_Axis();
                        axis.IsAbsoulte = false;
                        axis.SpeedPercentage = double.Parse(m_txbSpeedPercentage.Text) / 100;
                        axis.C1C2Position = double.Parse(m_tbxAxisDistance.Text) * (-1);
                        axis.Run();
                    }
                    break;

                case "SA1&SA2":
                    {
                        CC_SA1SA2_Axis axis = new CC_SA1SA2_Axis();
                        axis.IsAbsoulte = false;
                        axis.SpeedPercentage = double.Parse(m_txbSpeedPercentage.Text) / 100;
                        axis.SA1SA2Position = double.Parse(m_tbxAxisDistance.Text) * (-1);
                        axis.Run();
                    }
                    break;
            } 
            */
        }        

        private void m_btnIncrease_Click(object sender, EventArgs e)
        {
            string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            int iOffset = int.Parse(m_tbxAxisDistance.Text);

            switch (m_cbAxis.Text)
            {
                case "C1C2":
                    //szCmd = "C410," + Convert.ToInt32(PulseAndSensor.dMotionPulse[17] * 10 + iOffset) + ",0";
                    szCmd = string.Format("C410,{0},0,0", int.Parse(m_tbxAxisDistance.Text)*(-1));
                    SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
                    break;
                case "SA1&SA2":
                    //szCmd = "C411," + Convert.ToInt32(PulseAndSensor.dMotionPulse[18] * 10 + iOffset) + ",0";
                    szCmd = string.Format("C410,0,{0},0", int.Parse(m_tbxAxisDistance.Text) * (-1));
                    SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
                    break;
            }
            /*
            if (CC_C1C2_Axis.IsC1C2AxisRunning() || CC_SA1SA2_Axis.IsSA1SA2AxisRunning())
            {
                MessageBox.Show("目前 C1C2 或 SA1SA2 軸正在移動，請勿操作 !!");
                return;
            }

            switch (m_cbAxis.Text)
            {
                case "C1C2":
                    {
                        CC_C1C2_Axis axis = new CC_C1C2_Axis();
                        axis.IsAbsoulte = false;
                        axis.SpeedPercentage = double.Parse(m_txbSpeedPercentage.Text) / 100;
                        axis.C1C2Position = double.Parse(m_tbxAxisDistance.Text);
                        axis.Run();
                    }
                    break;

                case "SA1&SA2":
                    {
                        CC_SA1SA2_Axis axis = new CC_SA1SA2_Axis();
                        axis.IsAbsoulte = false;
                        axis.SpeedPercentage = double.Parse(m_txbSpeedPercentage.Text) / 100;
                        axis.SA1SA2Position = double.Parse(m_tbxAxisDistance.Text);
                        axis.Run();
                    }
                    break;
            }  
            */
        }

        private void m_btnAbsoluteMove_Click(object sender, EventArgs e)
        {
            string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            switch (m_cbAxis.Text)
            {
                case "C1C2":
                    //szCmd = "C410," + Convert.ToInt32(m_tbxAbsPosition.Text) + Convert.ToInt32(PulseAndSensor.dMotionPulse[18] * 10) + ",1";
                    szCmd = string.Format("C410,{0},0,1", int.Parse(m_tbxAbsPosition.Text));
                    SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
                    break;
                case "SA1&SA2":
                    //szCmd = "C410," + Convert.ToInt32(PulseAndSensor.dMotionPulse[17] * 10) + Convert.ToInt32(m_tbxAbsPosition.Text) + ",1";
                    szCmd = string.Format("C410,0,{0},1", int.Parse(m_tbxAxisDistance.Text));
                    SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
                    break;
            }
            /*
            if (CC_C1C2_Axis.IsC1C2AxisRunning() || CC_SA1SA2_Axis.IsSA1SA2AxisRunning())
            {
                MessageBox.Show("目前 C1C2 或 SA1SA2 軸正在移動，請勿操作 !!");
                return;
            }

            switch (m_cbAxis.Text)
            {
                case "C1C2":
                    {
                        CC_C1C2_Axis axis = new CC_C1C2_Axis();
                        axis.IsAbsoulte = true;
                        axis.SpeedPercentage = double.Parse(m_txbSpeedPercentage.Text) / 100;
                        axis.C1C2Position = double.Parse(m_tbxAbsPosition.Text);
                        axis.Run();
                    }
                    break;

                case "SA1&SA2":
                    {
                        CC_SA1SA2_Axis axis = new CC_SA1SA2_Axis();
                        axis.IsAbsoulte = true;
                        axis.SpeedPercentage = double.Parse(m_txbSpeedPercentage.Text) / 100;
                        axis.SA1SA2Position = double.Parse(m_tbxAbsPosition.Text);
                        axis.Run();
                    }
                    break;
            }
            */
        }

        private void m_btnAxisSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog DialogSave = new SaveFileDialog();
            DialogSave.InitialDirectory = TeachingInfoFactory.GetTeachInfoObject("Clamp Teach").IniDirPath;
            DialogSave.Filter = "Ini file (*.ini)|";
            DialogSave.DefaultExt = "ini";         

            if (DialogSave.ShowDialog() == DialogResult.OK)
            {
                if (DialogSave.FileName != "")
                {
                    IniFile iniFile = new IniFile(DialogSave.FileName);

                    iniFile.WriteValue("Alignment C1C2", "Position", CC_C1C2_Axis.GetC1C2AxisPosition());
                    iniFile.WriteValue("Alignment SA1SA2", "Position", CC_SA1SA2_Axis.GetSA1SA2AxisPosition());
                    iniFile.WriteValue("Bar1", "Position", CC_Bar_Axis.GetBar1AxisPosition());
                    iniFile.WriteValue("Bar2", "Position", CC_Bar_Axis.GetBar2AxisPosition());                    
                }
            }
            DialogSave.Dispose();
            DialogSave = null;
        }

        private void m_btnBar1LeftAdjust_Click(object sender, EventArgs e)
        {
            string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);
             
            if (tabControl1.SelectedIndex == 0) // Bar 1
            {
                //int iOffset = int.Parse(m_tbxBar1Distance.Text);
                //szCmd = "C409," + Convert.ToInt32(PulseAndSensor.dMotionPulse[20] * 10 - iOffset) + Convert.ToInt32(PulseAndSensor.dMotionPulse[21] * 10) + ",0";
                szCmd = string.Format("C409,{0},0,0", int.Parse(m_tbxBar1Distance.Text));
                SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
            }
            else if (tabControl1.SelectedIndex == 1) // Bar 2
            {
                //int iOffset = int.Parse(m_tbxBar2Distance.Text);
                //szCmd = "C409,0," + Convert.ToInt32(PulseAndSensor.dMotionPulse[20] * 10) + Convert.ToInt32(PulseAndSensor.dMotionPulse[21] * 10 - iOffset) + ",0";
                szCmd = string.Format("C409,0,{0},0", int.Parse(m_tbxBar2Distance.Text));
                SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
            }
            /*
            if (CC_Bar_Axis.IsBar1AxisRunning() || CC_Bar_Axis.IsBar2AxisRunning())
            {
                MessageBox.Show("目前 Bar 軸正在移動，請勿操作 !!");
                return;
            }

            CC_Bar_Axis axis = new CC_Bar_Axis();
            axis.MoveDirection = CC_Bar_Axis.Direction.Left;            

            Button activeBtn = sender as Button;
            if (activeBtn.Name == m_btnBar1LeftAdjust.Name)
            {
                axis.BarNumber =  CC_Bar_Axis.Bar.Bar1;
                axis.BarPosition = CC_Bar_Axis.GetBar1AxisPosition() - double.Parse(m_tbxBar1Distance.Text);
            }
            else if (activeBtn.Name == m_btnBar2LeftAdjust.Name)
            {
                axis.BarNumber = CC_Bar_Axis.Bar.Bar2;
                axis.BarPosition = CC_Bar_Axis.GetBar1AxisPosition() - double.Parse(m_tbxBar2Distance.Text);            
            }

            axis.Run();
            */
        }

        private void m_btnBar1RightAdjust_Click(object sender, EventArgs e)
        {
            string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);
            
            if (tabControl1.SelectedIndex == 0) // Bar1
            {
                //int iOffset = int.Parse(m_tbxBar1Distance.Text);
                //szCmd = "C409," + Convert.ToInt32(PulseAndSensor.dMotionPulse[20] * 10 + iOffset ) + Convert.ToInt32(PulseAndSensor.dMotionPulse[21] * 10) + ",0";
                szCmd = string.Format("C409,{0},0,0", int.Parse(m_tbxBar1Distance.Text)*(-1));
                SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
            }
            else if (tabControl1.SelectedIndex == 1) // Bar2
            {
                //int iOffset = int.Parse(m_tbxBar2Distance.Text);
                //szCmd = "C409,0," + Convert.ToInt32(PulseAndSensor.dMotionPulse[20] * 10) + Convert.ToInt32(PulseAndSensor.dMotionPulse[21] * 10 + iOffset) + ",0";
                szCmd = string.Format("C409,0,{0},0", int.Parse(m_tbxBar2Distance.Text) * (-1));
                SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
            }
            /*
            if (CC_Bar_Axis.IsBar1AxisRunning() || CC_Bar_Axis.IsBar2AxisRunning() )
            {
                MessageBox.Show("目前 Bar 軸正在移動，請勿操作 !!");
                return;
            }

            CC_Bar_Axis axis = new CC_Bar_Axis();
            axis.MoveDirection = CC_Bar_Axis.Direction.Right;

            Button activeBtn = sender as Button;
            if (activeBtn.Name == m_btnBar1RightAdjust.Name)
            {
                axis.BarNumber = CC_Bar_Axis.Bar.Bar1;
                axis.BarPosition = CC_Bar_Axis.GetBar1AxisPosition() + double.Parse(m_tbxBar1Distance.Text);
            }
            else if (activeBtn.Name == m_btnBar2RightAdjust.Name)
            {
                axis.BarNumber = CC_Bar_Axis.Bar.Bar2;
                axis.BarPosition = CC_Bar_Axis.GetBar2AxisPosition() + double.Parse(m_tbxBar2Distance.Text);
            }

            axis.Run();
             * */
        }

        private void m_UITimer_Tick(object sender, EventArgs e)
        {
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            m_txbBar1Pos.Text = (Convert.ToInt32(PulseAndSensor.dMotionPulse[20] * 10)).ToString();
            m_txbBar2Pos.Text = (Convert.ToInt32(PulseAndSensor.dMotionPulse[21] * 10)).ToString();

            switch (m_cbAxis.Text)
            {
                case "C1C2":
                    //m_tbxCurrentPos.Text = CC_C1C2_Axis.GetC1C2AxisPosition().ToString();
                    m_tbxCurrentPos.Text = Convert.ToInt32(PulseAndSensor.dMotionPulse[17] * 10).ToString();
                    break;

                case "SA1&SA2":
                    //m_tbxCurrentPos.Text = CC_SA1SA2_Axis.GetSA1SA2AxisPosition().ToString();
                    m_tbxCurrentPos.Text = Convert.ToInt32(PulseAndSensor.dMotionPulse[18] * 10).ToString();
                    break;

                default:
                    m_tbxCurrentPos.Text = "0";
                    break;
            }
            /*
            m_txbBar1Pos.Text = CC_Bar_Axis.GetBar1AxisPosition().ToString();
            m_txbBar2Pos.Text = CC_Bar_Axis.GetBar1AxisPosition().ToString();

            switch(m_cbAxis.Text)
            {
                case "C1C2":
                    m_tbxCurrentPos.Text = CC_C1C2_Axis.GetC1C2AxisPosition().ToString();
                    break;

                case "SA1&SA2":
                    m_tbxCurrentPos.Text = CC_SA1SA2_Axis.GetSA1SA2AxisPosition().ToString();
                    break;

                default:
                    m_tbxCurrentPos.Text = "0";
                    break;
            }   
            */
        }

        private void m_txbSpeedPercentage_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(m_txbSpeedPercentage.Text) > 100 || int.Parse(m_txbSpeedPercentage.Text) <= 0)
            {
                e.Cancel = true;
                m_errorProvider.SetError(m_txbSpeedPercentage, "輸入值大於100或是小於0 !!");
            }
        }

        private void m_txbSpeedPercentage_TextChanged(object sender, EventArgs e)
        {
            m_errorProvider.SetError(m_txbSpeedPercentage, "");
        }
        
        private void m_cbAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            if (m_cbAxis.SelectedIndex == 0)
            {
                m_tbxCurrentPos.Text = (Convert.ToInt32(PulseAndSensor.dMotionPulse[17] * 10)).ToString();
            }
            else if (m_cbAxis.SelectedIndex == 1)
            {
                m_tbxCurrentPos.Text = (Convert.ToInt32(PulseAndSensor.dMotionPulse[18] * 10)).ToString();
            }
        }

        #endregion
    }

    /// <summary>
    /// 存放教點相關資訊
    /// </summary>
    public class CCClampTeachInfo : CCAbstractTeachingInfo
    {
        public int itest = 0;
        #region Ctor
        public CCClampTeachInfo()
        {
            m_strTeachName = "Clamp Teach";
        }
        #endregion
    }
}
