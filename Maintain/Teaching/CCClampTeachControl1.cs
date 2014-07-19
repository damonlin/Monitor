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
    public partial class CCClampTeachControl1 : Common.Wizard.CCInteriorWizardPage
    {
        #region Ctor
        public CCClampTeachControl1()
        {
            InitializeComponent();

            // 將資料交由 InfoObjectFactory 管理
            CCClampTeachInfo info = new CCClampTeachInfo();
            InfoObjectFactory.AddInfoObj(info.Name, info);

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

        private void CallC031_C1C2MotorMove(bool p_bAbsMove, bool p_bIncMove)
        {
            //C031,C1C2 position,Speed,Acc,Dec,1/0: C1C2 馬達移動(夾片)  
            int iPos = 0, iType = 0;
            if (p_bAbsMove)
            {
                iPos = int.Parse(m_tbxAbsPosition.Text);
                iType = 1;
            }
            else
            {
                if (p_bIncMove)
                    iPos = int.Parse(m_tbxAxisDistance.Text);
                else
                    iPos = int.Parse(m_tbxAxisDistance.Text) * (-1);

                iType = 0;
            }

            int iSpeed = 50000 * (int.Parse(m_txbSpeedPercentage.Text) / 100);
            int iAcc = 500;
            int iDec = 500;
            
            TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C031,{0},{1},{2},{3},{4}", iPos, iSpeed, iAcc, iDec, iType));            
        }
       
        private int GetAxisPosition(int p_iAxis)
        {
            int iPitch = 0, iPulse = 0, itemp2 = 0, itemp3 = 0, itemp4 = 0;
            TK.CCTKform.TK_Motion.CCMotionModule_GetPitch(p_iAxis, ref iPitch, ref itemp2, ref itemp3, ref itemp4);
            TK.CCTKform.TK_Motion.CCMotionModule_GetMotorPulse(p_iAxis, ref iPulse, ref itemp2, ref itemp3, ref itemp4);
            return (iPitch / iPulse);
        }

        private void m_btnDecrease_Click(object sender, EventArgs e)
        {
            CallC031_C1C2MotorMove(false,false);                        
        }        

        private void m_btnIncrease_Click(object sender, EventArgs e)
        {
            CallC031_C1C2MotorMove(false,true);
        }

        private void m_btnAbsoluteMove_Click(object sender, EventArgs e)
        {
            CallC031_C1C2MotorMove(true, false);
        }

        private void m_btnAxisSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog DialogSave = new SaveFileDialog();
            DialogSave.InitialDirectory = InfoObjectFactory.GetInfoObject("Clamp Teach").IniDirPath;
            DialogSave.Filter = "Ini file (*.ini)|";
            DialogSave.DefaultExt = "ini";

            if (DialogSave.ShowDialog() == DialogResult.OK)
            {
                if (DialogSave.FileName != "")
                {
                    IniFile iniFile = new IniFile(DialogSave.FileName);

                    /*iniFile.WriteValue("Alignment X", "Position", m_tbxAlignXClamp.Text);
                    iniFile.WriteValue("Alignment Y", "Position", m_tbxAlignYClamp.Text);
                    iniFile.WriteValue("Bar1", "Position", m_tbxAlignYClamp.Text);
                    iniFile.WriteValue("Bar2", "Position", m_tbxAlignYClamp.Text);     */
                }
            }
            DialogSave.Dispose();
            DialogSave = null;
        }

        private void m_btnBar1LeftAdjust_Click(object sender, EventArgs e)
        {
            int iPos = 0;
            Button activeBtn = sender as Button;
            if (activeBtn.Name == m_btnBar1LeftAdjust.Name)
            {
                iPos = int.Parse(m_tbxBar1Distance.Text);
                TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C033,{0},{1},{2}", 
                                                                                                                                    1, 
                                                                                                                                    iPos, 
                                                                                                                                    1));            
            }
            else if (activeBtn.Name == m_btnBar2LeftAdjust.Name)
            {
                iPos = int.Parse(m_tbxBar2Distance.Text);
                TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C033,{0},{1},{2}",
                                                                                                                                    2,
                                                                                                                                    iPos,
                                                                                                                                    0));  
            }            
        }

        private void m_btnBar1RightAdjust_Click(object sender, EventArgs e)
        {
            int iPos = 0;
            Button activeBtn = sender as Button;
            if (activeBtn.Name == m_btnBar1RightAdjust.Name)
            {
                iPos = int.Parse(m_tbxBar1Distance.Text);
                TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C033,{0},{1},{2}",
                                                                                                                                    1,
                                                                                                                                    iPos,
                                                                                                                                    1));
            }
            else if (activeBtn.Name == m_btnBar2RightAdjust.Name)
            {
                iPos = int.Parse(m_tbxBar2Distance.Text);
                TKUnit.Process.GetSingleton().ProcessCommandForMMICall(String.Format("C033,{0},{1},{2}",
                                                                                                                                    2,
                                                                                                                                    iPos,
                                                                                                                                    0));
            } 
        }

        private void m_UITimer_Tick(object sender, EventArgs e)
        {
            switch(m_cbAxis.Text)
            {
                case "C1C2":
                    m_tbxCurrentPos.Text = GetAxisPosition(1).ToString();
                    break;

                case "SA1&SA2":
                    m_tbxCurrentPos.Text = GetAxisPosition(2).ToString();
                    break;

                default:
                    m_tbxCurrentPos.Text = "0";
                    break;
            }                        
        }       
    }

    public class CCClampTeachInfo : CCAbstractInfoObj
    {
        #region Ctor
        public CCClampTeachInfo()
        {
            m_strInfoName = "Clamp Teach";
        }
        #endregion
    }
}
