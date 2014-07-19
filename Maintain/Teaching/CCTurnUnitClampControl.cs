using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Maintain.Teaching
{
    public partial class CCTurnUnitClampControl : Common.Wizard.CCInteriorWizardPage
    {
        #region Private Member
        private CCTurnUnitClampInfo m_info = new CCTurnUnitClampInfo();
        #endregion

        #region Ctor
        public CCTurnUnitClampControl()
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
        private void m_UITimer_Tick(object sender, EventArgs e)
        {
            switch (m_cbAxis.Text)
            {
                case "TG":
                    m_tbxCurrentPos.Text = CC_TG_Axis.GetTGAxisPosition().ToString();
                    break;

                case "TS":
                    m_tbxCurrentPos.Text = CC_TS_Axis.GetTSAxisPosition().ToString();
                    break;

                case "TZ":
                    m_tbxCurrentPos.Text = CC_TZ_Axis.GetTZAxisPosition().ToString();
                    break;
            }
        }

        private void m_btnAxisSave_Click(object sender, EventArgs e)
        {

        }

        private void m_btnDecrease_Click(object sender, EventArgs e)
        {
            string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            switch (m_cbAxis.Text)
            {
                case "TS":
                    //szCmd = "C412," + Convert.ToInt32(PulseAndSensor.dMotionPulse[22] * 10) + ",0";
                    szCmd = string.Format("C411,{0},0,0", int.Parse(m_tbxAxisDistance.Text)*(-1));
                    SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
                    break;
                case "TG":
                    //szCmd = "C413," + Convert.ToInt32(PulseAndSensor.dMotionPulse[23] * 10) + ",0";
                    szCmd = string.Format("C411,0,{0},0", int.Parse(m_tbxAxisDistance.Text)*(-1));
                    SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
                    break;
            }
            /*
            if (CC_TG_Axis.IsTGAxisRunning() || CC_TS_Axis.IsTSAxisRunning() || CC_TZ_Axis.IsTZAxisRunning())
            {
                MessageBox.Show("目前 TG 或 TS 或 TZ 軸正在移動，請勿操作 !!");
                return;
            }

            CCAbstractAxis axis = null;

            switch (m_cbAxis.Text)
            {
                case "TG":
                    axis = new CC_TG_Axis();
                    (axis as CC_TG_Axis).TGPosition = double.Parse(m_tbxAxisDistance.Text) * (-1);
                    break;

                case "TS":
                    axis = new CC_TS_Axis();
                    (axis as CC_TS_Axis).TSPosition = double.Parse(m_tbxAxisDistance.Text) * (-1);
                    break;

                case "TZ":
                    axis = new CC_TZ_Axis();
                    (axis as CC_TZ_Axis).TZPosition = double.Parse(m_tbxAxisDistance.Text) * (-1);
                    break;
            }

            axis.IsAbsoulte = false;
            axis.SpeedPercentage = double.Parse(m_txbSpeedPercentage.Text) / 100;
            axis.Run();
            */
        }
       
        private void m_btnIncrease_Click(object sender, EventArgs e)
        {
            string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            switch (m_cbAxis.Text)
            {
                case "TS":
                    szCmd = string.Format("C411,{0},0,0", int.Parse(m_tbxAxisDistance.Text));
                    //szCmd = "C411," + Convert.ToInt32(PulseAndSensor.dMotionPulse[22] * 10) + ",0";
                    SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
                    break;
                case "TG":
                    //szCmd = "C411," + Convert.ToInt32(PulseAndSensor.dMotionPulse[23] * 10) + ",0";
                    szCmd = string.Format("C411,0,{0},0", int.Parse(m_tbxAxisDistance.Text));
                    SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
                    break;
            }
            /*
            CCAbstractAxis axis = null;

            switch (m_cbAxis.Text)
            {                
                case "TG":                    
                    axis = new CC_TG_Axis();                        
                    (axis as CC_TG_Axis).TGPosition = double.Parse(m_tbxAxisDistance.Text);                    
                    break;

                case "TS":
                    axis = new CC_TS_Axis();
                    (axis as CC_TS_Axis).TSPosition = double.Parse(m_tbxAxisDistance.Text);
                    break;

                case "TZ":
                    axis = new CC_TZ_Axis();
                    (axis as CC_TZ_Axis).TZPosition = double.Parse(m_tbxAxisDistance.Text);
                    break;
            }

            axis.IsAbsoulte = false;
            axis.SpeedPercentage = double.Parse(m_txbSpeedPercentage.Text) / 100;
            axis.Run();
            */
        }

        private void m_btnAbsoluteMove_Click(object sender, EventArgs e)
        {
            string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            switch (m_cbAxis.Text)
            {
                case "TS":
                    //szCmd = "C412," + Convert.ToInt32(PulseAndSensor.dMotionPulse[22] * 10) + ",1";
                    szCmd = string.Format("C411,{0},0,1", int.Parse(m_tbxAbsPosition.Text));
                    SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
                    break;
                case "TG":
                    //szCmd = "C413," + Convert.ToInt32(PulseAndSensor.dMotionPulse[23] * 10) + ",1";
                    szCmd = string.Format("C411,0,{0},1", int.Parse(m_tbxAbsPosition.Text));
                    SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
                    break;
            }
            /*
            CCAbstractAxis axis = null;

            switch (m_cbAxis.Text)
            {
                case "TG":
                    axis = new CC_TG_Axis();
                    (axis as CC_TG_Axis).TGPosition = double.Parse(m_tbxAbsPosition.Text);
                    break;

                case "TS":
                    axis = new CC_TS_Axis();
                    (axis as CC_TS_Axis).TSPosition = double.Parse(m_tbxAbsPosition.Text);
                    break;

                case "TZ":
                    axis = new CC_TZ_Axis();
                    (axis as CC_TZ_Axis).TZPosition = double.Parse(m_tbxAbsPosition.Text);
                    break;
            }

            axis.IsAbsoulte = true;
            axis.SpeedPercentage = double.Parse(m_txbSpeedPercentage.Text) / 100;
            axis.Run();
            */
        }

        private void m_cbAxis_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            if (m_cbAxis.SelectedIndex == 0)
            {
                m_tbxCurrentPos.Text = (Convert.ToInt32(PulseAndSensor.dMotionPulse[22] * 10)).ToString();
            }
            else if (m_cbAxis.SelectedIndex == 1)
            {
                m_tbxCurrentPos.Text = (Convert.ToInt32(PulseAndSensor.dMotionPulse[23] * 10)).ToString();
            }
        }

        private void m_btnHome_Click(object sender, EventArgs e)
        {
            SDDEMsg.SDDE.GetSingleton().SendMessageToTK("C100");
        }

        private void m_btnClamp_Click(object sender, EventArgs e)
        {
            string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            szCmd = "C412," + Convert.ToInt32(PulseAndSensor.dMotionPulse[22] * 10) + ",1";
            SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
        }

        private void m_btnUnclamp_Click(object sender, EventArgs e)
        {
            string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            szCmd = "C413," + Convert.ToInt32(PulseAndSensor.dMotionPulse[23] * 10) + ",1";
            SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
        }

        #endregion
    }

    /// <summary>
    /// 存放教點相關資訊
    /// </summary>
    public class CCTurnUnitClampInfo : CCAbstractTeachingInfo
    {
        #region Ctor
        public CCTurnUnitClampInfo()
        {
            m_strTeachName = "TurnUnit Clamp";
        }
        #endregion
    }
}
