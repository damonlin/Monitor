using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using IniTool;
using System.IO;
using ContrelModule;

namespace Maintain.Teaching
{
    public partial class CCMarkTeachControl : Common.Wizard.CCInteriorWizardPage
    {
        #region Private Member
        private CCMarkTeachInfo m_info = new CCMarkTeachInfo();
        private static CCMarkTeachControl Signleton;
        #endregion

        #region Ctor

        public CCMarkTeachControl()
        {
            InitializeComponent();

            // 將資料交由 TeachingInfoFactory 管理            
            TeachingInfoFactory.RegisterTeachInfoToFactory(m_info);
        }

        public static CCMarkTeachControl GetSignleton()
        {
            if (Signleton == null)
                Signleton = new CCMarkTeachControl();
            return Signleton;
        }

        #endregion

        #region Protected Method
        protected override bool OnSetActive()
        {
            if (!base.OnSetActive())
                return false;

            // Enable both the Next and Back buttons on this page    
            //Wizard.SetWizardButtons(Common.Wizard.WizardButton.Back | Common.Wizard.WizardButton.Finish);
            Wizard.SetWizardButtons(Common.Wizard.WizardButton.Back | Common.Wizard.WizardButton.Next);
            return true;
        }
        #endregion

        #region Private Method

        private void m_UITimer_Tick(object sender, EventArgs e)
        {
            //m_txbGCurrentPos.Text = CC_GSY_Axis.GetGAxisPosition().ToString();
            //m_txbSCurrentPos.Text = CC_GSY_Axis.GetSAxisPosition().ToString();
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            m_txbGCurrentPos.Text = Convert.ToInt32(PulseAndSensor.dMotionPulse[1] * 10).ToString();
            m_txbSCurrentPos.Text = Convert.ToInt32(PulseAndSensor.dMotionPulse[0] * 10).ToString();
            m_txbZCurrentPos.Text = ZMotion.ZMGetCurrentPosition().ToString();

        }

        private void m_btnGetMarkA_Click(object sender, EventArgs e)
        {
            m_txbMarkA_G.Text = m_txbGCurrentPos.Text;
            m_txbMarkA_S.Text = m_txbSCurrentPos.Text;
            m_txbMarkA_Z.Text = m_txbZCurrentPos.Text;
        }

        private void m_btnGetMarkB_Click(object sender, EventArgs e)
        {
            m_txbMarkB_G.Text = m_txbGCurrentPos.Text;
            m_txbMarkB_S.Text = m_txbSCurrentPos.Text;
            m_txbMarkB_Z.Text = m_txbZCurrentPos.Text;
        }

        private void m_btnGetSubC_Click(object sender, EventArgs e)
        {
            m_txbSubpixelC_G.Text = m_txbGCurrentPos.Text;
            m_txbSubpixelC_S.Text = m_txbSCurrentPos.Text;
            m_txbSubpixelC_Z.Text = m_txbZCurrentPos.Text;
        }

        private void m_btnGetSubD_Click(object sender, EventArgs e)
        {
            m_txbSubpixelD_G.Text = m_txbGCurrentPos.Text;
            m_txbSubpixelD_S.Text = m_txbSCurrentPos.Text;
            m_txbSubpixelD_Z.Text = m_txbZCurrentPos.Text;
        }

        private void m_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog DialogSave = new SaveFileDialog();
            DialogSave.Filter = "Ini file (*.ini)|";
            DialogSave.DefaultExt = "ini";
            DialogSave.InitialDirectory = TeachingInfoFactory.GetTeachInfoObject("Mark Teach").IniDirPath;

            if (DialogSave.ShowDialog() == DialogResult.OK)
            {
                if (DialogSave.FileName != "")
                {
                    IniFile iniFile = new IniFile(DialogSave.FileName);

                    iniFile.WriteValue("Mark A", "G Position", m_txbMarkA_G.Text);
                    iniFile.WriteValue("Mark A", "S Position", m_txbMarkA_S.Text);
                    iniFile.WriteValue("Mark A", "Z Position", m_txbZCurrentPos.Text);

                    iniFile.WriteValue("Mark B", "G Position", m_txbMarkB_G.Text);
                    iniFile.WriteValue("Mark B", "S Position", m_txbMarkB_S.Text);
                    iniFile.WriteValue("Mark B", "Z Position", m_txbZCurrentPos.Text);

                    iniFile.WriteValue("Subpixel C", "G Position", m_txbSubpixelC_G.Text);
                    iniFile.WriteValue("Subpixel C", "S Position", m_txbSubpixelC_S.Text);
                    iniFile.WriteValue("Subpixel C", "Z Position", m_txbZCurrentPos.Text);

                    iniFile.WriteValue("Subpixel D", "G Position", m_txbSubpixelD_G.Text);
                    iniFile.WriteValue("Subpixel D", "S Position", m_txbSubpixelD_S.Text);
                    iniFile.WriteValue("Subpixel D", "Z Position", m_txbZCurrentPos.Text);

                    iniFile.WriteValue("Light Source", "Front Light", lightControl1.m_aiLightTextControl[0].Value.ToString());
                    iniFile.WriteValue("Light Source", "Back Light", lightControl1.m_aiLightTextControl[1].Value.ToString());


                    iniFile.WriteValue("MarkModal", "ModalName", m_lblModalName.Text);
                    iniFile.WriteValue("Serach Pitch", "Pitch", m_numPitch.Value.ToString());
                }
            }
            DialogSave.Dispose();
            DialogSave = null;
        }

        private void m_btnAbsoluteMove_Click(object sender, EventArgs e)
        {           
            double iSpeed = int.Parse(m_txbSpeedPercentage.Text) / 100 * 200;

            //szCmd = "C401," + m_txbSAbsPosition.Text + ","
            //                + m_txbGAbsPosition.Text + ","
            //                + m_txbGAbsPosition.Text + "," + iSpeed.ToString() + ",300,300,1";
            string szCmd = string.Format("C401,{0},{1},0,{2},300,300,0", int.Parse(m_tbxSDistance.Text),
                                                                         int.Parse(m_tbxGDistance.Text),
                                                                         iSpeed);

            SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
            /*
            if (CC_GSY_Axis.IsGAxisRunning() || CC_GSY_Axis.IsLAxisRunning() || CC_GSY_Axis.IsSAxisRunning() )
            {
                MessageBox.Show("目前 G 或 S 或 Y 軸正在移動，請勿操作 !!");
                return;
            }

            CC_GSY_Axis axis = new CC_GSY_Axis();

            axis.IsAbsoulte = true;
            axis.SpeedPercentage = double.Parse(m_txbSpeedPercentage.Text) / 100;
            axis.GPosition = double.Parse(m_txbGAbsPosition.Text);
            axis.SPosition = double.Parse(m_txbSAbsPosition.Text);
            axis.Run();
            */
        }

        private void m_btnIncrease_Click(object sender, EventArgs e)
        {
            
            int iSpeed = int.Parse(m_txbSpeedPercentage.Text) / 100 * 200;
            //int iSPosition = int.Parse(m_tbxSDistance.Text) + int.Parse(m_txbSCurrentPos.Text);
            //int iGPosition = int.Parse(m_tbxGDistance.Text) + int.Parse(m_txbGCurrentPos.Text);

            //szCmd = "C401," + iSPosition.ToString() + ","
            //                + iGPosition.ToString() + ","
            //                + iGPosition.ToString() + "," + iSpeed.ToString() + iSpeed.ToString() + ",300,0";
            string szCmd = string.Format("C401,{0},{1},0,{2},300,300,0", int.Parse(m_tbxSDistance.Text) * (-1),
                                                                         int.Parse(m_tbxGDistance.Text) * (-1),
                                                                         iSpeed);

            SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
            /*
            if (CC_GSY_Axis.IsGAxisRunning() || CC_GSY_Axis.IsLAxisRunning() || CC_GSY_Axis.IsSAxisRunning())
            {
                MessageBox.Show("目前 G 或 S 或 Y 軸正在移動，請勿操作 !!");
                return;
            }

            CC_GSY_Axis axis = new CC_GSY_Axis();

            axis.IsAbsoulte = false;
            axis.SpeedPercentage = double.Parse(m_txbSpeedPercentage.Text) / 100;
            axis.GPosition = double.Parse(m_tbxGDistance.Text);
            axis.SPosition = double.Parse(m_tbxSDistance.Text);
            axis.Run();
             * */
        }

        private void m_txbSpeedPercentage_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(m_txbSpeedPercentage.Text) > 100 || int.Parse(m_txbSpeedPercentage.Text) <= 0)
            {
                e.Cancel = true;
                m_errorProvider.SetError(m_txbSpeedPercentage, "輸入值大於100或是小於0 !!");
            }
        }

        private void m_txbSpeedPercentage_Validated(object sender, EventArgs e)
        {
            m_errorProvider.SetError(m_txbSpeedPercentage, "");
        }

        #endregion

        private void SubPixelGO_Click(object sender, EventArgs e)
        {
            string szCmd;

            szCmd = "C401," + SubPixel_X_Point.Text + "," + SubPixel_Y_Point.Text + ",1";

            SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
        }

        private void m_btnInitPF_Click(object sender, EventArgs e)
        {
            ccd1.PatternFindInit();
            m_btnInitPF.Enabled = false;
            m_btnTeachModal.Enabled = true;
            m_btnReleasePF.Enabled = true;
        }

        private void m_btnTeachModal_Click(object sender, EventArgs e)
        {
            ccd1.PatternFindTeachModal(1);
        }

        private void m_btnReleasePF_Click(object sender, EventArgs e)
        {
            ccd1.PatternFindRelease();
            m_btnInitPF.Enabled = true;
            m_btnTeachModal.Enabled = false;
            m_btnReleasePF.Enabled = false;
        }

        private void m_btnSelectModal_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                m_lblModalName.Text = openFileDialog2.FileName;
            }
        }

        private void m_btnTestBtn_Click(object sender, EventArgs e)
        {
            if (m_lblModalName.Text != "")
            {
                ccd1.PatternFindInit();
                ccd1.PatternFindLoadModal(m_lblModalName.Text);
                if (ccd1.PatternFindModalResult(1, m_lblModalName.Text) == 1)
                {
                    double dScore = 0D, dX = 0, dY = 0;
                    ccd1.PatternGetPFResult(ref dScore, ref dX, ref dY);
                    m_tbxResultX.Text = dX.ToString();
                    m_tbxResultY.Text = dY.ToString();
                    m_tbxResultScore.Text = dScore.ToString();
                    ccd1.DrawCross(1, 1, 1, 320, 240, 640, 480, 0x0000FF);

                }
                ccd1.PatternFindRelease();
            }
            else
            {
                MessageBox.Show("Please Select a Modal");
            }
        }

        

    }

    /// <summary>
    /// 存放教點相關資訊
    /// </summary>
    public class CCMarkTeachInfo : CCAbstractTeachingInfo
    {
        #region Ctor
        public CCMarkTeachInfo()
        {
            m_strTeachName = "Mark Teach";
        }
        #endregion
    }
}
