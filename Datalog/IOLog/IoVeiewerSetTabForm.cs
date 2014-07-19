using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IniTool;

namespace Datalog
{
    public partial class IoVeiewerSetTabForm : Form
    {
        public const string IoViwerSetPath = "INI\\IoViwerSet.INI";
        private static IoVeiewerSetTabForm singleton;
        
        public IoVeiewerSetTabForm()
        {
            InitializeComponent();
            LoadIoViewerSectionNamesList();
        }

        public static IoVeiewerSetTabForm getSingleton(IOViewerUnitControl UnitControl)
        {
            if (singleton == null)
            {
                singleton = new IoVeiewerSetTabForm();
            }
            return singleton;
        }

        private void SaveIoViewerSetIniFile(string DioType, int DioNum, string Value)
        {
            IniFile iniIoViwerSetFile = new IniFile(Application.StartupPath + "\\" + IoViwerSetPath);
            iniIoViwerSetFile.WriteValue(ViewerTextBox.Text, DioType + DioNum.ToString(), Value);
        }

        private void LoadIoViewerSectionNamesList()
        {
            IniFile iniIoViwerSetFile = new IniFile(Application.StartupPath + "\\" + IoViwerSetPath);

            ViewerListBox.Items.Clear();
            ViewerListBox.Items.AddRange(iniIoViwerSetFile.GetSectionNames());
        }

        private void DelIoViewerSectionNamesList(string SectionName)
        {
            IniFile iniIoViwerSetFile = new IniFile(Application.StartupPath + "\\" + IoViwerSetPath);
            iniIoViwerSetFile.DeleteSection(SectionName);
        }

        private void ViewerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IniFile iniDioNameFile = new IniFile(Application.StartupPath + "\\" + DIOMonitorUnitControl.strDIOINIPath);
            IniFile iniIoViwerSetFile = new IniFile(Application.StartupPath + "\\" + IoViwerSetPath);

            string DioVeiwerValue = "";
            
            DIcheckedListBox.Items.Clear();
            DOcheckedListBox.Items.Clear();

            if (ViewerListBox.SelectedIndex < 0)
            {
                ViewerTextBox.Text = "";
                return;
            }

            ViewerTextBox.Text = ViewerListBox.Items[ViewerListBox.SelectedIndex].ToString();

            int DITotal = iniDioNameFile.GetInt32("Info", "DITotal", 0);
            int DOTotal = iniDioNameFile.GetInt32("Info", "DOTotal", 0);            

            for (int DiNum = 0; DiNum < DITotal; DiNum++)
            {
                DIcheckedListBox.Items.Add("DI" + DiNum.ToString() + ":" + iniDioNameFile.GetString("DIName", string.Format("{0:D4}", DiNum), ""));
                DioVeiwerValue = iniIoViwerSetFile.GetString(ViewerListBox.Items[ViewerListBox.SelectedIndex].ToString(), "DI" + DiNum.ToString(), "");

                if (DioVeiwerValue == "1")
                {
                    DIcheckedListBox.SetItemChecked(DiNum, true);
                }
            }

            for (int DoNum = 0; DoNum < DOTotal; DoNum++)
            {
                DOcheckedListBox.Items.Add("DO" + DoNum.ToString() + ":" + iniDioNameFile.GetString("DOName", string.Format("{0:D4}", DoNum), ""));
                DioVeiwerValue = iniIoViwerSetFile.GetString(ViewerListBox.Items[ViewerListBox.SelectedIndex].ToString(), "DO" + DoNum.ToString(), "");

                if (DioVeiwerValue == "1")
                {
                    DOcheckedListBox.SetItemChecked(DoNum, true);
                }
            }
        }
        

        private void Addbutton_Click(object sender, EventArgs e)
        {            
            for (int ListBoxNum = 0; ListBoxNum < ViewerListBox.Items.Count; ListBoxNum++)
            {
                if (ViewerListBox.Items[ListBoxNum].ToString().CompareTo(ViewerTextBox.Text) == 0)
                {
                    MessageBox.Show("指定的項目名稱已存在，請重新命名","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return; 
                }
            }
            SaveIoViewerSetIniFile("DI", 0, "0");
            ViewerListBox.Items.Add(ViewerTextBox.Text);
        }

        private void Delbutton_Click(object sender, EventArgs e)
        {
            for (int ListBoxNum = 0; ListBoxNum < ViewerListBox.Items.Count; ListBoxNum++)
            {
                if (ViewerListBox.Items[ListBoxNum].ToString().CompareTo(ViewerTextBox.Text) == 0)
                {
                    if (MessageBox.Show("確定刪除" + ViewerTextBox.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        DelIoViewerSectionNamesList(ViewerTextBox.Text); 
                        ViewerListBox.Items.Remove(ViewerTextBox.Text);
                    }
                    return; 
                }
            }
            MessageBox.Show("Error", "指定的項目名稱存在，請重新命名", MessageBoxButtons.OK, MessageBoxIcon.Error);            
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DIcheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (DIcheckedListBox.SelectedIndex < 0)
            {
                return;
            }
            SaveIoViewerSetIniFile("DI", DIcheckedListBox.SelectedIndex, e.NewValue == CheckState.Checked ? "1" : "0");
        }

        private void DOcheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (DOcheckedListBox.SelectedIndex < 0)
            {
                return;
            }
            SaveIoViewerSetIniFile("DO", DOcheckedListBox.SelectedIndex, e.NewValue == CheckState.Checked ? "1" : "0");
        }

        private void IoVeiewerSetTabForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

    }
}