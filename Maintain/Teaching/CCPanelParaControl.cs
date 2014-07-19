using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using IniTool;
using System.IO;

namespace Maintain.Teaching
{
    public partial class CCPanelParaControl : Common.Wizard.CCInteriorWizardPage
    {
        #region Private Member
        private CCPanelParaInfo m_info = new CCPanelParaInfo();
        #endregion

        #region Ctor
        public CCPanelParaControl()
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
        private void m_btnGSave_Click(object sender, EventArgs e)
        {            
            SaveFileDialog DialogSave = new SaveFileDialog();
            DialogSave.Filter = "Ini file (*.ini)|";                        
            DialogSave.DefaultExt = "ini";
            DialogSave.InitialDirectory = TeachingInfoFactory.GetTeachInfoObject("Panel Para").IniDirPath;

            if (DialogSave.ShowDialog() == DialogResult.OK)
            {
                if (DialogSave.FileName != "")
                {
                    IniFile iniFile = new IniFile(DialogSave.FileName);                    

                    iniFile.WriteValue("G1", "Y", m_tbxG1Y.Text);
                    iniFile.WriteValue("G1", "Subpixel Start", m_tbxG1SubPixelStart.Text);
                    iniFile.WriteValue("G1", "Subpixel End", m_tbxG1SubPixelEnd.Text);

                    iniFile.WriteValue("G2", "Y", m_tbxG2Y.Text);
                    iniFile.WriteValue("G2", "Subpixel Start", m_tbxG2SubPixelStart.Text);
                    iniFile.WriteValue("G2", "Subpixel End", m_tbxG2SubPixelEnd.Text);

                    iniFile.WriteValue("G6", "Y", m_tbxG1Y.Text);
                    iniFile.WriteValue("G6", "Subpixel Start", m_tbxG6SubPixelStart.Text);
                    iniFile.WriteValue("G6", "Subpixel End", m_tbxG6SubPixelEnd.Text);

                    iniFile.WriteValue("G3", "X", m_tbxG3X.Text);
                    iniFile.WriteValue("G3", "X", m_tbxG3Y.Text);

                    iniFile.WriteValue("G4", "X", m_tbxG4X.Text);
                    iniFile.WriteValue("G4", "X", m_tbxG4Y.Text);

                    iniFile.WriteValue("G5", "X", m_tbxG5X.Text);
                    iniFile.WriteValue("G5", "X", m_tbxG5Y.Text);

                    iniFile.WriteValue("G7", "X", m_tbxG7X.Text);
                    iniFile.WriteValue("G7", "X", m_tbxG7Y.Text);

                    iniFile.WriteValue("Panel", "Width", m_tbxPanelWidth.Text);
                    iniFile.WriteValue("Panel", "Height", m_tbxPanelHeight.Text);                    
                }
            }
            DialogSave.Dispose();
            DialogSave = null;
        }
        #endregion
    }

    /// <summary>
    /// 存放教點相關資訊
    /// </summary>
    public class CCPanelParaInfo : CCAbstractTeachingInfo
    {
        #region Ctor
        public CCPanelParaInfo()
        {
            m_strTeachName = "Panel Para";
        }
        #endregion 
    }    
}
