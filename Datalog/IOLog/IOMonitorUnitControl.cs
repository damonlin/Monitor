using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using IniTool;
using ModuleInterface;
using System.Collections;

namespace Datalog
{
    public partial class CCIOMonitorUnitControl : UserControl
    {
        public const string IOLogListINIPath = "INI\\IOLogList.INI";
        public enum IOType { DI_TYPE = 0, DO_TYPE, VIO_TYPE };
        
        private const int _DISPLAY_IO_NUM_PER_PAGE_ = 32;
        private const int _DISPLAY_IO_NUM_PER_COLUMN_ = 8;      

        private System.Windows.Forms.TabPage[] tabPage;
        private System.Windows.Forms.Label[] diLEDLabel;
        private System.Windows.Forms.Label[] diNameLabel;

        private System.Windows.Forms.DataGridView[] ioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn[,] IdxTest;
        private System.Windows.Forms.DataGridViewCheckBoxColumn[,] CheckStatus;
        private System.Windows.Forms.DataGridViewButtonColumn[,] IoStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn[,] DescriptionTest;

        private int TotalCount = 0;
        private int tabPageNumber = 0;
        private int IoLogCheckBoxUsable = 0;
        private CCIOMonitorUnitControl.IOType nowioType;

        public CCIOMonitorUnitControl()
        {
            InitializeComponent();
        }
        //慶忠版本
        public int LoadUI(string iniFilePath, CCIOMonitorUnitControl.IOType ioType)
        {
            string SectionName, KeyName;

            SuspendLayout();
            nowioType = ioType;

            IniFile iniFile = new IniFile(iniFilePath);
            IniFile iniIOLogListFile = new IniFile(IOLogListINIPath);

            int dioNumber = iniFile.GetInt32("Info", (ioType == IOType.DI_TYPE) ? "DITotal" : "DOTotal", 0);
            IoLogCheckBoxUsable = iniFile.GetInt16("Info", "IoLogCheckBoxUsable", 1);

            tabPage = new System.Windows.Forms.TabPage[(dioNumber % _DISPLAY_IO_NUM_PER_PAGE_) == 0 ? dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ : dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ + 1];
            diLEDLabel = new System.Windows.Forms.Label[dioNumber];
            diNameLabel = new System.Windows.Forms.Label[dioNumber];

            //////////////////////////////////////////////////////////////////////////
            ioDataGridView = new System.Windows.Forms.DataGridView[(dioNumber % _DISPLAY_IO_NUM_PER_PAGE_) == 0 ? dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ : dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ + 1];

            IdxTest = new System.Windows.Forms.DataGridViewTextBoxColumn[(dioNumber % _DISPLAY_IO_NUM_PER_PAGE_) == 0 ? dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ : dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ + 1, 4];
            CheckStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn[(dioNumber % _DISPLAY_IO_NUM_PER_PAGE_) == 0 ? dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ : dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ + 1, 4];
            IoStatus = new System.Windows.Forms.DataGridViewButtonColumn[(dioNumber % _DISPLAY_IO_NUM_PER_PAGE_) == 0 ? dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ : dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ + 1, 4];
            DescriptionTest = new System.Windows.Forms.DataGridViewTextBoxColumn[(dioNumber % _DISPLAY_IO_NUM_PER_PAGE_) == 0 ? dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ : dioNumber / _DISPLAY_IO_NUM_PER_PAGE_ + 1, 4];
            //////////////////////////////////////////////////////////////////////////

            tabControlEX.Controls.Clear();

            for (int tabIdx = 0; tabIdx < tabPage.Length; tabIdx++)
            {
                // 
                // 建立TabPage
                // 
                tabPage[tabIdx] = new Dotnetrix.Controls.TabPageEX();
                tabPage[tabIdx].Location = new System.Drawing.Point(4, 21);
                tabPage[tabIdx].Name = "sampleTabPage";
                tabPage[tabIdx].Padding = new System.Windows.Forms.Padding(3);
                tabPage[tabIdx].Size = new System.Drawing.Size(368, 434);
                tabPage[tabIdx].TabIndex = 0;
                tabPage[tabIdx].Text = string.Format("{0}~{1}", tabIdx * _DISPLAY_IO_NUM_PER_PAGE_, (tabIdx + 1) * _DISPLAY_IO_NUM_PER_PAGE_ - 1);
                tabPage[tabIdx].UseVisualStyleBackColor = true;

                tabControlEX.Controls.Add(tabPage[tabIdx]);

                for (int i = 0; i < 4; i++)
                {
                    ////////////////////////////////////////////// 
                    // Idx
                    // 
                    IdxTest[tabIdx, i] = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    IdxTest[tabIdx, i].HeaderText = "Idx";
                    IdxTest[tabIdx, i].Name = "Column1";
                    IdxTest[tabIdx, i].ReadOnly = true;
                    IdxTest[tabIdx, i].Width = 30;//26

                    //////////////////////////////////////////////
                    // 
                    // Log Check Box
                    // 
                    CheckStatus[tabIdx, i] = new System.Windows.Forms.DataGridViewCheckBoxColumn();
                    CheckStatus[tabIdx, i].FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    CheckStatus[tabIdx, i].HeaderText = "Pass";
                    CheckStatus[tabIdx, i].Name = "Pass";
                    CheckStatus[tabIdx, i].Width = 25;//20
                    CheckStatus[tabIdx, i].ReadOnly = false;
                    CheckStatus[tabIdx, i].FalseValue = false;
                    CheckStatus[tabIdx, i].TrueValue = true;
                    
                    //////////////////////////////////////////////
                    // 
                    // Status
                    // 
                    System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
                    IoStatus[tabIdx, i] = new System.Windows.Forms.DataGridViewButtonColumn();
                    dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                    dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lime;
                    dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
                    IoStatus[tabIdx, i].DefaultCellStyle = dataGridViewCellStyle2;
                    IoStatus[tabIdx, i].FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    IoStatus[tabIdx, i].HeaderText = "Status";
                    IoStatus[tabIdx, i].Name = "Status";
                    IoStatus[tabIdx, i].ReadOnly = true;
                    IoStatus[tabIdx, i].Width = 25;//20

                    /////////////////////////////////////////////////////////////////////////
                    // 
                    // Description
                    //
                    DescriptionTest[tabIdx, i] = new System.Windows.Forms.DataGridViewTextBoxColumn();
                    //DescriptionTest[tabIdx, i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    DescriptionTest[tabIdx, i].HeaderText = "Description";
                    DescriptionTest[tabIdx, i].Name = "Description";
                    DescriptionTest[tabIdx, i].ReadOnly = true;
                    DescriptionTest[tabIdx, i].Width = 194;//180                    
                }

                // 
                // sampleDataGridView
                // 
                ioDataGridView[tabIdx] = new System.Windows.Forms.DataGridView();
                tabPage[tabIdx].Controls.Add(ioDataGridView[tabIdx]);

                ioDataGridView[tabIdx].AllowUserToAddRows = false;
                ioDataGridView[tabIdx].AllowUserToDeleteRows = false;
                ioDataGridView[tabIdx].AllowUserToResizeColumns = false;
                ioDataGridView[tabIdx].AllowUserToResizeRows = false;
                //ioDataGridView[tabIdx].AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
                //ioDataGridView[tabIdx].ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                ioDataGridView[tabIdx].ColumnHeadersVisible = false;
                ioDataGridView[tabIdx].Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    IdxTest[tabIdx, 0],
                    CheckStatus[tabIdx, 0],
                    IoStatus[tabIdx, 0],
                    DescriptionTest[tabIdx, 0],
                    IdxTest[tabIdx, 1],
                    CheckStatus[tabIdx, 1],
                    IoStatus[tabIdx, 1],
                    DescriptionTest[tabIdx, 1],
                    IdxTest[tabIdx, 2],
                    CheckStatus[tabIdx,2],
                    IoStatus[tabIdx, 2],
                    DescriptionTest[tabIdx, 2],
                    IdxTest[tabIdx, 3],
                    CheckStatus[tabIdx, 3],
                    IoStatus[tabIdx, 3],
                    DescriptionTest[tabIdx, 3]});

                System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

                dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
                dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
                dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
                dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
                ioDataGridView[tabIdx].DefaultCellStyle = dataGridViewCellStyle3;

                //ioDataGridView[tabIdx].Dock = System.Windows.Forms.DockStyle.Fill;
                ioDataGridView[tabIdx].EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;

                ioDataGridView[tabIdx].Location = sampleDataGridView.Location;
                ioDataGridView[tabIdx].MultiSelect = false;
                ioDataGridView[tabIdx].Name = "sampleDataGridView";
                //ioDataGridView[tabIdx].ReadOnly = true;
                ioDataGridView[tabIdx].RowHeadersVisible = false;
                ioDataGridView[tabIdx].RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                ioDataGridView[tabIdx].SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
                ioDataGridView[tabIdx].ScrollBars = System.Windows.Forms.ScrollBars.None;
                ioDataGridView[tabIdx].Size = sampleDataGridView.Size;
                ioDataGridView[tabIdx].TabIndex = 15;

                ioDataGridView[tabIdx].Rows.Add(_DISPLAY_IO_NUM_PER_COLUMN_);

                foreach (DataGridViewRow de in ioDataGridView[tabIdx].Rows)
                    de.Height = 25;//19                

                string ioName;
                int iColumnIdx = 0;
                int iRowIdx = 0;

                for (int ioIdx = 0; ioIdx < _DISPLAY_IO_NUM_PER_PAGE_; ioIdx++)
                {
                    //ioName = string.Format("{0}. ", ioIdx + _DISPLAY_IO_NUM_PER_PAGE_ * tabIdx) + iniFile.GetString((ioType == IOType.DI_TYPE) ? "DIName" : "DOName", string.Format("{0:D4}", ioIdx + _DISPLAY_IO_NUM_PER_PAGE_ * tabIdx), "");
                    ioName = iniFile.GetString((ioType == IOType.DI_TYPE) ? "DIName" : "DOName", string.Format("{0:D4}", ioIdx + _DISPLAY_IO_NUM_PER_PAGE_ * tabIdx), "");

                    if (ioIdx != 0 && ioIdx % _DISPLAY_IO_NUM_PER_COLUMN_ == 0)
                    {
                        iColumnIdx++;
                        iRowIdx = 0;
                    }
                    ioDataGridView[tabIdx].Rows[iRowIdx].Cells[0 + 4 * iColumnIdx].Value = string.Format("{0}", ioIdx + _DISPLAY_IO_NUM_PER_PAGE_ * tabIdx);
                    ioDataGridView[tabIdx].Rows[iRowIdx].Cells[0 + 4 * iColumnIdx].Style.BackColor = Color.Black;
                    ioDataGridView[tabIdx].Rows[iRowIdx].Cells[0 + 4 * iColumnIdx].Style.ForeColor = Color.White;
                    ioDataGridView[tabIdx].Rows[iRowIdx].Cells[1 + 4 * iColumnIdx].Style.BackColor = Color.Black;
                    ioDataGridView[tabIdx].Rows[iRowIdx].Cells[1 + 4 * iColumnIdx].Style.ForeColor = Color.White;
                    ioDataGridView[tabIdx].Rows[iRowIdx].Cells[1 + 4 * iColumnIdx].Value = false;
                    ioDataGridView[tabIdx].Rows[iRowIdx].Cells[2 + 4 * iColumnIdx].Style.BackColor = Color.Red;
                    ioDataGridView[tabIdx].Rows[iRowIdx].Cells[3 + 4 * iColumnIdx].Value = ioName;
                    ioDataGridView[tabIdx].Rows[iRowIdx].Cells[3 + 4 * iColumnIdx].Style.ForeColor = Color.White;
                    ioDataGridView[tabIdx].Rows[iRowIdx].Cells[3 + 4 * iColumnIdx].Style.BackColor = Color.Gray;

                    //Load IO Log Check List
                    SectionName = (nowioType == IOType.DI_TYPE) ? "DI Check List" : "DO Check List";
                    KeyName = ((nowioType == IOType.DI_TYPE) ? "DI" : "DO") + (string)ioDataGridView[tabIdx].Rows[iRowIdx].Cells[0 + 4 * iColumnIdx].Value;
                    ioDataGridView[tabIdx].Rows[iRowIdx].Cells[1 + 4 * iColumnIdx].Value = iniIOLogListFile.GetInt32(SectionName, KeyName, 1) == 1;

                    iRowIdx++;
                }

                tabPageNumber++;
            }

            for (int i = 0; i < tabPageNumber; i++)
            {
                ioDataGridView[i].CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(IoLogDataGridView_CellContentClick);
            }

            ResumeLayout();
            return 0;
        }

        public int RefreshUI(bool[] IOValue)
        {
            SuspendLayout();
            for (int tabIdx = 0; tabIdx < tabPageNumber; tabIdx++)
            {
                int iColumnIdx = 0;
                int iRowIdx = 0;

                for (int ioIdx = 0; ioIdx < _DISPLAY_IO_NUM_PER_PAGE_ && ioIdx + _DISPLAY_IO_NUM_PER_PAGE_ * tabIdx < IOValue.Length; ioIdx++)
                {
                    if (ioIdx != 0 && ioIdx % _DISPLAY_IO_NUM_PER_COLUMN_ == 0)
                    {
                        iColumnIdx++;
                        iRowIdx = 0;
                    }
                    if ((bool)IOValue[ioIdx + _DISPLAY_IO_NUM_PER_PAGE_ * tabIdx])
                    {
                        ioDataGridView[tabIdx].Rows[iRowIdx].Cells[2 + 4 * iColumnIdx].Style.BackColor = Color.Lime;
                        ioDataGridView[tabIdx].Rows[iRowIdx].Cells[2 + 4 * iColumnIdx].Style.SelectionBackColor = Color.Lime;
                    }
                    else
                    {
                        ioDataGridView[tabIdx].Rows[iRowIdx].Cells[2 + 4 * iColumnIdx].Style.BackColor = Color.Red;
                        ioDataGridView[tabIdx].Rows[iRowIdx].Cells[2 + 4 * iColumnIdx].Style.SelectionBackColor = Color.Red;
                    }                                        

                    iRowIdx++;
                }
            }
            ResumeLayout();

            return 0;
        }

        private void IoLogDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IniFile iniFile = new IniFile(IOLogListINIPath);
            IniFile iniDioNameFile = new IniFile(Application.StartupPath + "\\" + DIOMonitorUnitControl.strDIOINIPath);

            IoLogCheckBoxUsable = iniDioNameFile.GetInt16("Info", "IoLogCheckBoxUsable", 1);

            if (IoLogCheckBoxUsable == 0)
                return;

            if (e.ColumnIndex % 4 == 1)
            {
                string SectionName, keyName;

                ioDataGridView[tabControlEX.SelectedIndex].Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !(bool)ioDataGridView[tabControlEX.SelectedIndex].Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                
                //Ini Save
                SectionName = (nowioType == IOType.DI_TYPE) ? "DI Check List" : "DO Check List";
                keyName = ((nowioType == IOType.DI_TYPE) ? "DI" : "DO") + (string)ioDataGridView[tabControlEX.SelectedIndex].Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value;
                iniFile.WriteValue(SectionName, keyName, ((bool)ioDataGridView[tabControlEX.SelectedIndex].Rows[e.RowIndex].Cells[e.ColumnIndex].Value == true) ? 1 : 0);
            }
        }

        public void GetIoName(string IoNum, ref string IoName)
        {
            IniFile iniFile = new IniFile("INI\\DIOName.ini");
            IoName = iniFile.GetString((nowioType == IOType.DI_TYPE) ? "DIName" : "DOName", IoNum, ((nowioType == IOType.DI_TYPE) ? "DI" : "DO") + IoNum);
        }

    }
}
