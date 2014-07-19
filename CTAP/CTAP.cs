using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Monitor
{
    public partial class CTAP : Form
    {
        public static CTAP singleton = null;
        private Dictionary<string, Control> navigationHashtable = new Dictionary<string, Control>();
        private string szNavigationString = "";
        
        public CTAP()
        {
            Thread th = new Thread(new ThreadStart(ShowLoadingForm));
            th.Start();

            AlarmList.AlarmReportForm.getSingleton();
                        
            InitializeComponent();
            InitControl();
            
            SearchControl(this);           
            this.BringToFront();
            th.Abort();
        }

        public static CTAP getSingleton()
        {
            if (singleton == null)
            {
                singleton = new CTAP();
            }
            return singleton;
        }

        private void ShowLoadingForm()
        {
            LoadingForm objLoadingForm = new LoadingForm();
            objLoadingForm.ShowDialog();
        }

        private void InitControl()
        {           
            Common.Template.InfoPanelTemplate Operation = new Operate.Operate();

            // Recipe Panel
            Common.Template.NavigationPanelTemplate recipePanel = new Common.Template.NavigationPanelTemplate();           

            // CIM Panel
            Common.Template.NavigationPanelTemplate cimPanel = new Common.Template.NavigationPanelTemplate();   

            // Datalog Panel
            Common.Template.NavigationPanelTemplate datalogPanel = new Common.Template.NavigationPanelTemplate();
                       
            // Navigation Button             
            navigationHashtable.Add("Operation", Operation);
            navigationHashtable.Add("Inspect", Operation);
            navigationHashtable.Add("CIM", Operation);
            navigationHashtable.Add("Recipe", Operation);
            navigationHashtable.Add("Datalog", Operation);
            navigationHashtable.Add("Maintain", Operation);

            foreach (string de in navigationHashtable.Keys)
            {
                navigationHashtable[de].Dock = System.Windows.Forms.DockStyle.Fill;
                navigationHashtable[de].Location = new System.Drawing.Point(0, 0);
                navigationHashtable[de].Name = "CTAP" + de.ToString();
                navigationHashtable[de].Tag = "";
                navigationHashtable[de].Visible = false;

                if (navigationHashtable[de] is Common.Template.NavigationPanelTemplate)
                {
                    ((Common.Template.NavigationPanelTemplate)navigationHashtable[de]).InitNavigationPanel();
                }

                viewPanel.Controls.Add(navigationHashtable[de]);
            }                            
        }

        private void baseTimer_Tick(object sender, EventArgs e)
        {
            if (singleton != null)
            {
                displayDateLabel.Text = DateTime.Now.ToLongDateString();
                displayTimeLabel.Text = DateTime.Now.ToLongTimeString();               

                if (Common.GlobalValue.AlarmQueue.Count != 0)
                {
                    AlarmList.AlarmReportForm.getSingleton().ReportAlarm(Common.GlobalValue.AlarmQueue.Dequeue());
                    Alarmlist_Click(sender, EventArgs.Empty);
                }
            }
        }

        private void navigatorBtn_CheckedChanged(object sender, EventArgs e)
        {
            // 顯示對應的畫面
            foreach (string de in navigationHashtable.Keys)
            {
                (navigationHashtable[de]).Visible = ((RadioButton)sender).Name.Contains((string)de) ? true : false;
                if (navigationHashtable[de].Visible == true)
                {
                    szNavigationString = de;
                }
            }
            btnDecPanel.Location = new Point(((RadioButton)sender).Location.X + ((RadioButton)sender).Size.Width / 2 - btnDecPanel.Size.Width / 2, btnDecPanel.Location.Y);
        }

        private void functionBtn_CheckedChanged(object sender, EventArgs e)
        {/*
            if (sender == ioMonitorButton)
            {
                if (Monitor.IOMonitorForm.getSingleton(ref sender).Visible == false)
                    Monitor.IOMonitorForm.getSingleton(ref sender).Show(this);
                else
                    Monitor.IOMonitorForm.getSingleton(ref sender).Activate();
            }
                
            else */
            if (sender == AlarmlistRadioButton)
            {

                if (AlarmList.AlarmReportForm.getSingleton().Visible == false)
                    AlarmList.AlarmReportForm.getSingleton().Show(this);
                else
                    AlarmList.AlarmReportForm.getSingleton().Activate();
            }
        }

        private void Alarmlist_Click(object sender, EventArgs e)
        {
            if (AlarmList.AlarmReportForm.getSingleton().Visible == false)
                AlarmList.AlarmReportForm.getSingleton().Show(this);
            else
                AlarmList.AlarmReportForm.getSingleton().Activate();
        }

        private void Shutdown_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Shutdown The Application", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {                                
                Application.Exit();                
            }
        }

        private void navigationBtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        public static void SetOperatorID(string pszOperatorID)
        {
            singleton.operatorIDButton.Text = pszOperatorID;
        }

        private void SearchControl(Control p_Control)
        {
            foreach (Control tmpControl in p_Control.Controls)
            {
                if (tmpControl is Panel || tmpControl is Form || tmpControl is UserControl || tmpControl is GroupBox
                    || tmpControl is Dotnetrix.Controls.TabControlEX || tmpControl is SplitContainer)
                {
                    SearchControl(tmpControl);
                }
                else if (tmpControl is TreeView)
                {
                    ((TreeView)tmpControl).AfterSelect += new TreeViewEventHandler(ControlLog);
                }
                else if (tmpControl is RadioButton || tmpControl is CheckBox || tmpControl is Button)
                {
                    tmpControl.Click += new EventHandler(ControlLog);
                }
            }
        }

        private void ControlLog(object sender, EventArgs e)
        {
            string szLogInfo = "";
            if (sender is TreeView)
            {
                if (((TreeView)sender).SelectedNode != null)
                    szLogInfo = ((TreeView)sender).Name + "   " + ((TreeView)sender).SelectedNode.Text;
            }
            else
            {
                szLogInfo = ((Control)sender).Name + "   " + ((Control)sender).Text;
            }            

            //if (!Maintain.UserLoginForm.getSingleton().SuperUserLoginStatus)
            {
                //string szFunctionName = "";

                /*if (navigationHashtable[szNavigationString] is Common.Template.NavigationPanelTemplate)
                {
                    szFunctionName = szNavigationString + "_" + ((Common.Template.NavigationPanelTemplate)navigationHashtable[szNavigationString]).NowGunction.FuncName;
                }
                else
                {
                    szFunctionName = szNavigationString;
                }*/

                //if (Maintain.UserAccountPanelControl.getSingleton().accessFunctionTable.ContainsFunction(szFunctionName))
                {
                    //bool bAuthority = Maintain.UserAccountPanelControl.getSingleton().accessFunctionTable.GetAccessAccountType(szFunctionName).ContainsKey(Maintain.UserLoginForm.getSingleton().NowUserAccount.AccountType.GetFirstAccountTypeName()) || Maintain.UserLoginForm.getSingleton().NowUserAccount.AccessFunction.ContainsFunction(szFunctionName);
                    
                    if (navigationHashtable[szNavigationString] is Common.Template.NavigationPanelTemplate)
                    {
                        ((Common.Template.NavigationPanelTemplate)navigationHashtable[szNavigationString]).NowGunction.Control.Enabled = true;
                    }
                    else
                    {
                        //navigationHashtable[szNavigationString].Enabled = bAuthority;
                    }

                    //if (!bAuthority)
                    //{
                     //   MessageBox.Show("Please Check Your Authority");
                    //}
                }
            }
            //else
            //{
            //    if (navigationHashtable[szNavigationString] is Common.Template.NavigationPanelTemplate)
            //    {
            //        ((Common.Template.NavigationPanelTemplate)navigationHashtable[szNavigationString]).NowGunction.Control.Enabled = true;
            //    }
            //    else
            //    {
           //         navigationHashtable[szNavigationString].Enabled = true;
            //    }
            //}
        }        
    }
}