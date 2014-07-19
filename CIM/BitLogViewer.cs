using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CIM
{
    public partial class BitLogViewer : Common.Template.SubInfoPanelTemplate
    {
        Queue<LogInfo> allInfo = new Queue<LogInfo>();
        private string szType = "";

        public BitLogViewer(string type)
        {
            InitializeComponent();
            szType = type;

            DispalyItem();
        }

        private void selectLogFileFolderButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(openFileDialog1.FileName);
                string tmpString = "";
                while (!Reader.EndOfStream)
                {
                    tmpString = Reader.ReadLine();
                    string[] allstring = tmpString.Split(' ');

                    LogInfo tmpInfo = new LogInfo();
                    tmpInfo.logTime = DateTime.Parse(allstring[0] + " " + allstring[1]);
                    tmpInfo.logValue = int.Parse(allstring[2]);

                    allInfo.Enqueue(tmpInfo);
                }
                ShowValue();
                logFolderTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void ShowValue()
        {
            dataGridView1.Rows.Clear();

            while (allInfo.Count != 0)
            {
                LogInfo tmpInfo = allInfo.Dequeue();

                DataGridViewRow tmprow = new DataGridViewRow();
                tmprow.CreateCells(dataGridView1);

                tmprow.HeaderCell.Value = tmpInfo.logTime.ToString();
                SetValue(ref tmprow, tmpInfo.logValue);
                SetColor(ref tmprow);

                dataGridView1.Rows.Add(tmprow);
            }
        }

        private void SetValue(ref DataGridViewRow tmprow, Int64 value)
        {
            for (int icount = 0; icount < tmprow.Cells.Count; icount++)
            {
                tmprow.Cells[icount].Value = (value >> tmprow.Cells.Count - icount - 1) & 0x1;
            }
        }

        private void SetColor(ref DataGridViewRow tmprow)
        {
            for (int icount = 0; icount < tmprow.Cells.Count; icount++)
            {
                tmprow.Cells[icount].Style.BackColor = int.Parse(tmprow.Cells[icount].Value.ToString()) == 1 ? Color.Lime : Color.Red;
            }
        }

        private void DispalyItem()
        {
            if (szType == CIM_Schedule.getSingleton().USLog.LogName)
            {
                DataGridViewTextBoxColumn[] AllColumn = new DataGridViewTextBoxColumn[16];

                AllColumn[0] = new DataGridViewTextBoxColumn();
                AllColumn[0].HeaderText = "InlineStatus";
                AllColumn[1] = new DataGridViewTextBoxColumn();
                AllColumn[1].HeaderText = "AutoOperationStatus";
                AllColumn[2] = new DataGridViewTextBoxColumn();
                AllColumn[2].HeaderText = "HeavyAlarmStatus";
                AllColumn[3] = new DataGridViewTextBoxColumn();
                AllColumn[3].HeaderText = "LightAlarmStatus";
                AllColumn[4] = new DataGridViewTextBoxColumn();
                AllColumn[4].HeaderText = "RecipeModificationOKReply";
                AllColumn[5] = new DataGridViewTextBoxColumn();
                AllColumn[5].HeaderText = "RecipeModificationNGReply";
                AllColumn[6] = new DataGridViewTextBoxColumn();
                AllColumn[6].HeaderText = "OperatorCallClear";
                AllColumn[7] = new DataGridViewTextBoxColumn();
                AllColumn[7].HeaderText = "ModifiedRecipeReport";
                AllColumn[8] = new DataGridViewTextBoxColumn();
                AllColumn[8].HeaderText = "GlassRemoveReport";
                AllColumn[9] = new DataGridViewTextBoxColumn();
                AllColumn[9].HeaderText = "GlassTakeoutReport";
                AllColumn[10] = new DataGridViewTextBoxColumn();
                AllColumn[10].HeaderText = "GlassStorageReport";
                AllColumn[11] = new DataGridViewTextBoxColumn();
                AllColumn[11].HeaderText = "PortPauseStatus";
                AllColumn[12] = new DataGridViewTextBoxColumn();
                AllColumn[12].HeaderText = "Glassloadingmovement";
                AllColumn[13] = new DataGridViewTextBoxColumn();
                AllColumn[13].HeaderText = "Glassunloadingmovement";
                AllColumn[14] = new DataGridViewTextBoxColumn();
                AllColumn[14].HeaderText = "SupplyEnd";
                AllColumn[15] = new DataGridViewTextBoxColumn();
                AllColumn[15].HeaderText = "GlassInformationRequest";

                openFileDialog1.InitialDirectory = CIM_Schedule.getSingleton().USLog.LogFloder;
                dataGridView1.Columns.AddRange(AllColumn);
            }
            else if (szType == CIM_Schedule.getSingleton().EQLog.LogName)
            {
                DataGridViewTextBoxColumn[] AllColumn = new DataGridViewTextBoxColumn[8];

                AllColumn[0] = new DataGridViewTextBoxColumn();
                AllColumn[0].HeaderText = "InlineStatus";
                AllColumn[1] = new DataGridViewTextBoxColumn();
                AllColumn[1].HeaderText = "AutoOperationStatus";
                AllColumn[2] = new DataGridViewTextBoxColumn();
                AllColumn[2].HeaderText = "HeavyAlarmStatus";
                AllColumn[3] = new DataGridViewTextBoxColumn();
                AllColumn[3].HeaderText = "LightAlarmStatus";
                AllColumn[4] = new DataGridViewTextBoxColumn();
                AllColumn[4].HeaderText = "GlassRemoveReport";
                AllColumn[5] = new DataGridViewTextBoxColumn();
                AllColumn[5].HeaderText = "GlassIDReport";
                AllColumn[6] = new DataGridViewTextBoxColumn();
                AllColumn[6].HeaderText = "RecipeChangeAcceptance";
                AllColumn[7] = new DataGridViewTextBoxColumn();
                AllColumn[7].HeaderText = "MissmatchGlassInformationRequest";

                openFileDialog1.InitialDirectory = CIM_Schedule.getSingleton().EQLog.LogFloder;
                dataGridView1.Columns.AddRange(AllColumn);
            }
            else if (szType == CIM_Schedule.getSingleton().LoaderLog.LogName)
            {
                DataGridViewTextBoxColumn[] AllColumn = new DataGridViewTextBoxColumn[9];

                AllColumn[0] = new DataGridViewTextBoxColumn();
                AllColumn[0].HeaderText = "AutoOperationStatus";
                AllColumn[1] = new DataGridViewTextBoxColumn();
                AllColumn[1].HeaderText = "LoadReady";
                AllColumn[2] = new DataGridViewTextBoxColumn();
                AllColumn[2].HeaderText = "LoadComplete";
                AllColumn[3] = new DataGridViewTextBoxColumn();
                AllColumn[3].HeaderText = "LoadCancel";
                AllColumn[4] = new DataGridViewTextBoxColumn();
                AllColumn[4].HeaderText = "Delivering";
                AllColumn[5] = new DataGridViewTextBoxColumn();
                AllColumn[5].HeaderText = "AutoOperationStatus";
                AllColumn[6] = new DataGridViewTextBoxColumn();
                AllColumn[6].HeaderText = "LoadRequest";
                AllColumn[7] = new DataGridViewTextBoxColumn();
                AllColumn[7].HeaderText = "LoadOK";
                AllColumn[8] = new DataGridViewTextBoxColumn();
                AllColumn[8].HeaderText = "DeliveryCancelRequest";

                openFileDialog1.InitialDirectory = CIM_Schedule.getSingleton().LoaderLog.LogFloder;
                dataGridView1.Columns.AddRange(AllColumn);
            }
            else if (szType == CIM_Schedule.getSingleton().UnLoaderLog.LogName)
            {
                DataGridViewTextBoxColumn[] AllColumn = new DataGridViewTextBoxColumn[9];

                AllColumn[0] = new DataGridViewTextBoxColumn();
                AllColumn[0].HeaderText = "AutoOperationStatus";
                AllColumn[1] = new DataGridViewTextBoxColumn();
                AllColumn[1].HeaderText = "UnloadReady";
                AllColumn[2] = new DataGridViewTextBoxColumn();
                AllColumn[2].HeaderText = "UnloadComplete";
                AllColumn[3] = new DataGridViewTextBoxColumn();
                AllColumn[3].HeaderText = "UnloadCancel";
                AllColumn[4] = new DataGridViewTextBoxColumn();
                AllColumn[4].HeaderText = "Delivering";
                AllColumn[5] = new DataGridViewTextBoxColumn();
                AllColumn[5].HeaderText = "AutoOperationStatus";
                AllColumn[6] = new DataGridViewTextBoxColumn();
                AllColumn[6].HeaderText = "UnloadRequest";
                AllColumn[7] = new DataGridViewTextBoxColumn();
                AllColumn[7].HeaderText = "UnloadOK";
                AllColumn[8] = new DataGridViewTextBoxColumn();
                AllColumn[8].HeaderText = "DeliveryCancelRequest";

                openFileDialog1.InitialDirectory = CIM_Schedule.getSingleton().UnLoaderLog.LogFloder;
                dataGridView1.Columns.AddRange(AllColumn);
            }
            else if (szType == CIM_Schedule.getSingleton().ExchangeLog.LogName)
            {
                DataGridViewTextBoxColumn[] AllColumn = new DataGridViewTextBoxColumn[9];

                AllColumn[0] = new DataGridViewTextBoxColumn();
                AllColumn[0].HeaderText = "AutoOperationStatus";
                AllColumn[1] = new DataGridViewTextBoxColumn();
                AllColumn[1].HeaderText = "ExchangeReady";
                AllColumn[2] = new DataGridViewTextBoxColumn();
                AllColumn[2].HeaderText = "ExchangeComplete";
                AllColumn[3] = new DataGridViewTextBoxColumn();
                AllColumn[3].HeaderText = "ExchangeCancel";
                AllColumn[4] = new DataGridViewTextBoxColumn();
                AllColumn[4].HeaderText = "Delivering";
                AllColumn[5] = new DataGridViewTextBoxColumn();
                AllColumn[5].HeaderText = "AutoOperationStatus";
                AllColumn[6] = new DataGridViewTextBoxColumn();
                AllColumn[6].HeaderText = "ExchangeRequest";
                AllColumn[7] = new DataGridViewTextBoxColumn();
                AllColumn[7].HeaderText = "ExchangeOK";
                AllColumn[8] = new DataGridViewTextBoxColumn();
                AllColumn[8].HeaderText = "DeliveryCancelRequest";

                openFileDialog1.InitialDirectory = CIM_Schedule.getSingleton().ExchangeLog.LogFloder;
                dataGridView1.Columns.AddRange(AllColumn);
            }

        }
    }

    public class LogInfo
    {
        public DateTime logTime;
        public Int64 logValue;
    }
}
