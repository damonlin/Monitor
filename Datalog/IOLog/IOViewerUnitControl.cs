using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using IniTool;
using Common;

namespace Datalog
{
    public partial class IOViewerUnitControl : Common.Template.SubInfoPanelTemplate
    {
        List<string> szDIIO = new List<string>();
        List<string> szDOIO = new List<string>();
        List<string> szAllHeadersTime = new List<string>();
        List<string> szDIHeadersTime = new List<string>();
        List<string> szDOHeadersTime = new List<string>();
        List<string> CollectIoInfo = new List<string>();
        List<string> CollectTimeHeads = new List<string>();
        List<string> CollectIoNameHeads = new List<string>();
        DataGridViewImageColumn[] IoStatusImageColumn;

        public IOViewerUnitControl()
        {
            InitializeComponent();
            LoadComBoxInfo();
        }

        private void LoadComBoxInfo()
        {
            string TextTemp;
            IniFile iniIoViwerSetFile = new IniFile(Application.StartupPath + "\\" + IoVeiewerSetTabForm.IoViwerSetPath);

            TextTemp = (string)comboBox.SelectedItem;

            comboBox.Items.Clear();
            comboBox.Items.AddRange(iniIoViwerSetFile.GetSectionNames());
            comboBox.Text = TextTemp;
        }

        private void LoadImageColumn()
        {
            IniFile iniFile = new IniFile(Application.StartupPath + "\\" + DIOMonitorUnitControl.strDIOINIPath);
            IniFile iniIoVeiewerSetFile = new IniFile(Application.StartupPath + "\\" + IoVeiewerSetTabForm.IoViwerSetPath);

            List<int> ViewDiList = new List<int>();
            List<int> ViewDoList = new List<int>();

            int DiHeadsCount = 1;
            int DoHeadsCount = 1;
            int DiHeadsCountTemp = 0;
            int DoHeadsCountTemp = 0;

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            CollectIoInfo.Clear();
            CollectTimeHeads.Clear();
            CollectIoNameHeads.Clear();

            //整理需顯示的Di Do 
            for (int DiNum = 0; DiNum < szDIIO[0].Length; DiNum++)
            {
                if (iniIoVeiewerSetFile.GetInt16(comboBox.Text, "DI" + DiNum.ToString(), 0) == 1)
                {
                    CollectIoNameHeads.Add("DI" + DiNum.ToString() + ":" + iniFile.GetString("DIName", string.Format("{0:D4}", DiNum), ""));
                    ViewDiList.Add(DiNum);
                }
            }

            for (int DoNum = 0; DoNum < szDOIO[0].Length; DoNum++)
            {
                if (iniIoVeiewerSetFile.GetInt16(comboBox.Text, "DO" + DoNum.ToString(), 0) == 1)
                {
                    CollectIoNameHeads.Add("DO" + DoNum.ToString() + ":" + iniFile.GetString("DOName", string.Format("{0:D4}", DoNum), ""));
                    ViewDoList.Add(DoNum);
                }
            }

            //DI DO 時間軸資料整合
            for (int HeaderNum = 0; HeaderNum < szAllHeadersTime.Count - 1; HeaderNum++)
            {
                string DioInfo = "";
                bool FindStatus = false;

                if (DiHeadsCount<szDIHeadersTime.Count &&  szAllHeadersTime[HeaderNum] == szDIHeadersTime[DiHeadsCount])
                {
                    for (int ViewDiCount = 0; ViewDiCount < ViewDiList.Count; ViewDiCount++)
                    {
                        if (szDIIO[DiHeadsCount - 1][ViewDiList[ViewDiCount]] != szDIIO[DiHeadsCount][ViewDiList[ViewDiCount]])
                        {
                            if (szDIIO[DiHeadsCount - 1][ViewDiList[ViewDiCount]] != '-' && szDIIO[DiHeadsCount][ViewDiList[ViewDiCount]] != '-')
                            {
                                FindStatus = true;
                                break;
                            }
                        }
                    }
                    DiHeadsCount++;
                }
                else if (DoHeadsCount < szDOHeadersTime.Count && szAllHeadersTime[HeaderNum] == szDOHeadersTime[DoHeadsCount])
                {
                    for (int ViewDoCount = 0; ViewDoCount < ViewDoList.Count; ViewDoCount++)
                    {
                        if (szDOIO[DoHeadsCount - 1][ViewDoList[ViewDoCount]] != szDOIO[DoHeadsCount][ViewDoList[ViewDoCount]])
                        {
                            if (szDOIO[DoHeadsCount - 1][ViewDoList[ViewDoCount]] != '-' && szDOIO[DoHeadsCount][ViewDoList[ViewDoCount]] != '-')
                            {
                                FindStatus = true;
                                break;
                            }
                        }
                    }
                    DoHeadsCount++;
                }

                if (FindStatus)
                {
                    //初使狀態記錄
                    if (DiHeadsCountTemp == 0 && DoHeadsCountTemp == 0)
                    {
                        for (int ViewDiCount = 0; ViewDiCount < ViewDiList.Count; ViewDiCount++)
                        {
                            DioInfo += szDIIO[DiHeadsCountTemp][ViewDiList[ViewDiCount]];
                        }

                        for (int ViewDoCount = 0; ViewDoCount < ViewDoList.Count; ViewDoCount++)
                        {
                            DioInfo += szDOIO[DoHeadsCountTemp][ViewDoList[ViewDoCount]];
                        }
                        CollectTimeHeads.Add(szAllHeadersTime[HeaderNum]);
                        CollectIoInfo.Add(DioInfo);
                        DioInfo = "";
                    }

                    if (DiHeadsCount != DiHeadsCountTemp && szDIIO.Count >= DiHeadsCount)
                    {
                        DiHeadsCountTemp = DiHeadsCount - 1;
                    }
                    if (DoHeadsCount != DoHeadsCountTemp && szDOIO.Count >= DoHeadsCount)
                    {
                        DoHeadsCountTemp = DoHeadsCount - 1;
                    }

                    for (int ViewDiCount = 0; ViewDiCount < ViewDiList.Count; ViewDiCount++)
                    {
                        DioInfo += szDIIO[DiHeadsCountTemp][ViewDiList[ViewDiCount]];
                    }

                    for (int ViewDoCount = 0; ViewDoCount < ViewDoList.Count; ViewDoCount++)
                    {
                        DioInfo += szDOIO[DoHeadsCountTemp][ViewDoList[ViewDoCount]];
                    }

                    CollectTimeHeads.Add(szAllHeadersTime[HeaderNum]);
                    CollectIoInfo.Add(DioInfo);
                }
            }

            //確認有收集到資料後開始轉換圖形
            if (CollectIoInfo.Count != 0)
            {
                object[] IoStatusImageInfo = new object[CollectTimeHeads.Count - 1];

                IoStatusImageColumn = new DataGridViewImageColumn[CollectIoInfo.Count - 1];
                for (int IoTimeStatus = 0; IoTimeStatus < CollectIoInfo.Count - 1; IoTimeStatus++)
                {
                    IoStatusImageColumn[IoTimeStatus] = new DataGridViewImageColumn();
                    IoStatusImageColumn[IoTimeStatus].ImageLayout = DataGridViewImageCellLayout.Stretch;
                    IoStatusImageColumn[IoTimeStatus].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dataGridView.Columns.AddRange(IoStatusImageColumn);

                for (int DioCount = 0; DioCount < CollectIoNameHeads.Count; DioCount++)
                {
                    IoStatusImageInfo.Initialize();
                    for (int TimeHeadsCount = 1; TimeHeadsCount < CollectTimeHeads.Count; TimeHeadsCount++)
                    {
                        if (CollectIoInfo[TimeHeadsCount - 1][DioCount] != CollectIoInfo[TimeHeadsCount][DioCount])
                        {
                            if (CollectIoInfo[TimeHeadsCount - 1][DioCount] == '0')
                            {
                                IoStatusImageInfo[TimeHeadsCount - 1] = Properties.Resources._01;
                            }
                            else if (CollectIoInfo[TimeHeadsCount - 1][DioCount] == '1')
                            {
                                IoStatusImageInfo[TimeHeadsCount - 1] = Properties.Resources._10;
                            }
                            else
                            {
                                IoStatusImageInfo[TimeHeadsCount - 1] = Properties.Resources.Non;
                            }
                        }
                        else if (CollectIoInfo[TimeHeadsCount - 1][DioCount] == CollectIoInfo[TimeHeadsCount][DioCount])
                        {
                            if (CollectIoInfo[TimeHeadsCount - 1][DioCount] == '0')
                            {
                                IoStatusImageInfo[TimeHeadsCount - 1] = Properties.Resources._0;
                            }
                            else if (CollectIoInfo[TimeHeadsCount - 1][DioCount] == '1')
                            {
                                IoStatusImageInfo[TimeHeadsCount - 1] = Properties.Resources._1;
                            }
                            else
                            {
                                IoStatusImageInfo[TimeHeadsCount - 1] = Properties.Resources.Non;
                            }
                        }
                        dataGridView.Columns[TimeHeadsCount - 1].HeaderCell.Value = CollectTimeHeads[TimeHeadsCount];
                    }
                    dataGridView.Rows.Add(IoStatusImageInfo);

                    dataGridView.Rows[DioCount].HeaderCell.Value = CollectIoNameHeads[DioCount];
                    dataGridView.AutoResizeRowHeadersWidth(DioCount, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
                }
            }
        }

        private int LoadLogFile(string LogFilePath)
        {
            StreamReader Reader = new StreamReader(LogFilePath);
            string IoInfo, IoType;

            szDIIO.Clear();
            szDOIO.Clear();
            szAllHeadersTime.Clear();
            szDIHeadersTime.Clear();
            szDOHeadersTime.Clear();

            while (true)
            {
                IoInfo = Reader.ReadLine();

                if (string.IsNullOrEmpty(IoInfo))
                {
                    return 0;
                }

                IoType = IoInfo.Substring(24, 2);
                if (IoType == "DI" || IoType == "DO")
                {
                    szAllHeadersTime.Add(IoInfo.Substring(11, 12));
                }

                if (IoType == "DI")
                {
                    szDIIO.Add(IoInfo.Substring(27));
                    szDIHeadersTime.Add(IoInfo.Substring(11, 12));
                }
                else if (IoType == "DO")
                {
                    szDOIO.Add(IoInfo.Substring(27));
                    szDOHeadersTime.Add(IoInfo.Substring(11, 12));
                }
            }
        }

        private int SearchTimeHeads()
        {
            DateTime SearchTime = searchTimePicker.Value;

            if (CollectTimeHeads.Count == 0)
            {
                return -1;
            }

            for (int TimeHeadsIndex = 1; TimeHeadsIndex < CollectTimeHeads.Count; TimeHeadsIndex++)
            {
                DateTime HeadsTime = DateTime.Parse(CollectTimeHeads[TimeHeadsIndex]);
                if (DateTime.Compare(SearchTime, HeadsTime) < 0)
                {
                    return TimeHeadsIndex;
                }
            }
            return CollectTimeHeads.Count - 1;
        }

        private void selectLogFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Log files (*.log)|*.log|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = "D:\\log\\";
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            logFileTextBox.Text = openFileDialog.FileName;
            LoadLogFile(logFileTextBox.Text);
            if (comboBox.Text != "")
            {
                LoadImageColumn();
            }
        }

        private void ViewerSetupbutton_Click(object sender, EventArgs e)
        {
            if (IoVeiewerSetTabForm.getSingleton(this).Visible == false)
                IoVeiewerSetTabForm.getSingleton(this).Show(this);
            else
                IoVeiewerSetTabForm.getSingleton(this).Activate();
        }

        private void comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadComBoxInfo();
            if (szDIIO.Count > 0)
            {
                LoadImageColumn();
            }
        }

        private void comboBox_DropDown(object sender, EventArgs e)
        {
            LoadComBoxInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int columnIndex = 0;

            columnIndex = SearchTimeHeads();
            if (columnIndex >= 0)
            {
                dataGridView.FirstDisplayedCell = dataGridView[columnIndex - 1, 0];
            }
        }
    }
}
