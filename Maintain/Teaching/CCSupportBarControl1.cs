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
    public partial class CCSupportBarControl1 : Common.Wizard.CCInteriorWizardPage
    {
        #region Ctor
        public CCSupportBarControl1()
        {
            InitializeComponent();

            // 將資料交由 InfoObjectFactory 管理
            CCSupportBarInfo info = new CCSupportBarInfo();
            InfoObjectFactory.AddInfoObj(info.Name, info);
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
        private void m_btnGlassBar1Save_Click(object sender, EventArgs e)
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

                    iniFile.WriteValue("Glass Bar 1", "Start Position", m_tbxBar1Start.Text);
                    iniFile.WriteValue("Glass Bar 1", "End Position", m_tbxBar1End.Text);

                    iniFile.WriteValue("Glass Bar 2", "Start Position", m_tbxBar2Start.Text);
                    iniFile.WriteValue("Glass Bar 2", "End Position", m_tbxBar2End.Text);                    
                }
            }
            DialogSave.Dispose();
            DialogSave = null;
        }
        #endregion

        private void m_btnGlassBar1Save_Click_1(object sender, EventArgs e)
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

                    iniFile.WriteValue("Glass Bar 1", "Start Position", m_tbxBar1Start.Text);
                    iniFile.WriteValue("Glass Bar 1", "End Position", m_tbxBar1End.Text);

                    iniFile.WriteValue("Glass Bar 2", "Start Position", m_tbxBar2Start.Text);
                    iniFile.WriteValue("Glass Bar 2", "End Position", m_tbxBar2End.Text);
                }
            }
            DialogSave.Dispose();
            DialogSave = null;
        }

        private void m_btnBar1StartPosMove_Click(object sender, EventArgs e)
        {
            Button activeBtn = sender as Button;

            int iPos = 0, iDirection = 0;
            if (activeBtn.Name == m_btnBar1StartPosMove.Name)
            {
                iPos = int.Parse(m_tbxBar1Start.Text);

                // TODO: Determine which direction by getting current 
                iDirection = 1;//() ? 1: 0; // 1: Left, 0: Right
                
            }
            else if (activeBtn.Name == m_btnBar2StartPosMove.Name)
            {
                iPos = int.Parse(m_tbxBar2Start.Text);

                // TODO: Determine which direction by getting current 
                iDirection = 1;//() ? 1: 0; // 1: Left, 0: Right                
            }

            TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C033,{0},{1},{2}",
                                                                                                                                    1,
                                                                                                                                    iPos,
                                                                                                                                    iDirection));
        }

        private void m_btnBar1EndPosMove_Click(object sender, EventArgs e)
        {
            Button activeBtn = sender as Button;

            int iPos = 0, iDirection = 0;
            if (activeBtn.Name == m_btnBar1EndPosMove.Name)
            {
                iPos = int.Parse(m_tbxBar1End.Text);

                // TODO: Determine which direction by getting current 
                iDirection = 1;//() ? 1: 0; // 1: Left, 0: Right
            }
            else if (activeBtn.Name == m_btnBar2EndPosMove.Name)
            {
                iPos = int.Parse(m_tbxBar2End.Text);

                // TODO: Determine which direction by getting current 
                iDirection = 1;//() ? 1: 0; // 1: Left, 0: Right
            }
            TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C033,{0},{1},{2}",
                                                                                                                                    1,
                                                                                                                                    iPos,
                                                                                                                                    iDirection));
        }
        
    }

    public class CCSupportBarInfo : CCAbstractInfoObj
    {
        #region Ctor
        public CCSupportBarInfo()
        {
            m_strInfoName = "Support Bar";
        }
        #endregion
    }
}
