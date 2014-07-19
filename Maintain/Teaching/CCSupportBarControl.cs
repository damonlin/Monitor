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
    public partial class CCSupportBarControl : Common.Wizard.CCInteriorWizardPage
    {
        #region Private Member
        private CCSupportBarInfo m_info = new CCSupportBarInfo();
        #endregion

        #region Ctor
        public CCSupportBarControl()
        {
            InitializeComponent();

            // 將資料交由 TeachingInfoFactory 管理            
            TeachingInfoFactory.RegisterTeachInfoToFactory(m_info);           
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
        private void m_tbxBar1StartGet_Click(object sender, EventArgs e)
        {
            m_tbxBar1StartPos.Text = m_tbxBar1Pos.Text;
        }

        private void m_tbxBar1EndtGet_Click(object sender, EventArgs e)
        {
            m_tbxBar1EndPos.Text = m_tbxBar1Pos.Text;
        }

        private void m_tbxBar2StartGet_Click(object sender, EventArgs e)
        {
            m_tbxBar2StartPos.Text = m_tbxBar2Pos.Text;
        }

        private void m_tbxBar2EndtGet_Click(object sender, EventArgs e)
        {
            m_tbxBar2EndPos.Text = m_tbxBar2Pos.Text;
        }

        private void m_btnBar1LeftAdjust_Click(object sender, EventArgs e)
        {
            string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            if (m_tabControlBar.SelectedIndex == 0) // Bar1
            {
                int Bar1Pos = Convert.ToInt32(PulseAndSensor.dMotionPulse[20] * 10) + Convert.ToInt32(m_tbxBar1Distance.Text);

                szCmd = "C409," + Bar1Pos.ToString() + ",0,0";
                SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
            }
            else if (m_tabControlBar.SelectedIndex == 1) // Bar2
            {
                int Bar2Pos = Convert.ToInt32(PulseAndSensor.dMotionPulse[21] * 10) + Convert.ToInt32(m_tbxBar2Distance.Text);
                szCmd = "C409,0," + Bar2Pos.ToString() + ",0";
                SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
            }
            /*
            if (CC_Bar_Axis.IsBar1AxisRunning() || CC_Bar_Axis.IsBar2AxisRunning())
            {
                MessageBox.Show("目前 Bar1 或 Bar2 軸正在移動，請勿操作 !!");
                return;
            }

            CC_Bar_Axis axis = new CC_Bar_Axis();
            axis.MoveDirection = CC_Bar_Axis.Direction.Left;  

            Button activeBtn = sender as Button;
            if (activeBtn.Name == m_btnBar1LeftAdjust.Name)
            {
                axis.BarNumber = CC_Bar_Axis.Bar.Bar1;
                axis.BarPosition = CC_Bar_Axis.GetBar1AxisPosition() - double.Parse(m_tbxBar1Distance.Text);
            }
            else if (activeBtn.Name == m_btnBar2LeftAdjust.Name)
            {
                axis.BarNumber = CC_Bar_Axis.Bar.Bar2;
                axis.BarPosition = CC_Bar_Axis.GetBar2AxisPosition() - double.Parse(m_tbxBar2Distance.Text);   
            }
            axis.Run();  
             * */
        }

        private void m_btnBar1RightAdjust_Click(object sender, EventArgs e)
        {
            string szCmd;
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);

            if (m_tabControlBar.SelectedIndex == 0)
            {
                szCmd = "C409," + Convert.ToInt32(PulseAndSensor.dMotionPulse[20] * 10) + ",0,0";
                SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
            }
            else if (m_tabControlBar.SelectedIndex == 1)
            {
                szCmd = "C409,0," + Convert.ToInt32(PulseAndSensor.dMotionPulse[20] * 10) + ",0";
                SDDEMsg.SDDE.GetSingleton().SendMessageToTK(szCmd);
            }
            /*
            if (CC_Bar_Axis.IsBar1AxisRunning() || CC_Bar_Axis.IsBar2AxisRunning())
            {
                MessageBox.Show("目前 Bar1 或 Bar2 軸正在移動，請勿操作 !!");
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
            */
        }

        private void m_btnBar1Save_Click(object sender, EventArgs e)
        {
            CCSupportBarInfo info = new CCSupportBarInfo();
            SaveFileDialog DialogSave = new SaveFileDialog();
            DialogSave.Filter = "Ini file (*.ini)|";
            DialogSave.DefaultExt = "ini";
            DialogSave.InitialDirectory = info.IniDirPath;
            DialogSave.RestoreDirectory = false;

            if (DialogSave.ShowDialog() == DialogResult.OK)
            {
                if (DialogSave.FileName != "")
                {
                    IniFile iniFile = new IniFile(DialogSave.FileName);

                    iniFile.WriteValue("Glass Bar 1", "Start Position", m_tbxBar1StartPos.Text);
                    iniFile.WriteValue("Glass Bar 1", "End Position", m_tbxBar1EndPos.Text);

                    iniFile.WriteValue("Glass Bar 2", "Start Position", m_tbxBar2StartPos.Text);
                    iniFile.WriteValue("Glass Bar 2", "End Position", m_tbxBar2EndPos.Text);
                }
            }
            DialogSave.Dispose();
            DialogSave = null;
        }

        private void m_UITimer_Tick(object sender, EventArgs e)
        {
            //m_tbxBar1Pos.Text = CC_Bar_Axis.GetBar1AxisPosition().ToString();
            //m_tbxBar2Pos.Text = CC_Bar_Axis.GetBar2AxisPosition().ToString();
            ShareMemory.CCShareData.tag_PulseAndSensor PulseAndSensor = new ShareMemory.CCShareData.tag_PulseAndSensor();

            ShareMemory.CCShareData.GetSingleton().PulseAndSensor_Get(ref PulseAndSensor);
            
            if(m_tabControlBar.SelectedIndex == 0)
            {
                m_tbxBar1Pos.Text = (Convert.ToInt32(PulseAndSensor.dMotionPulse[20] * 10)).ToString();
            }
            else if(m_tabControlBar.SelectedIndex == 1)
            {
                m_tbxBar1Pos.Text = (Convert.ToInt32(PulseAndSensor.dMotionPulse[21] * 10)).ToString();
            }
        }
        
        #endregion

    }

    /// <summary>
    /// 存放教點相關資訊
    /// </summary>
    public class CCSupportBarInfo : CCAbstractTeachingInfo
    {
        #region Ctor
        public CCSupportBarInfo()
        {
            m_strTeachName = "Support Bar";
        }
        #endregion
    }
}
