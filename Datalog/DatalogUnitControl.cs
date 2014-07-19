using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NSpring.Logging;
using NSpring.Logging.Loggers;
using System.IO;
using System.Collections;
using Microsoft.VisualBasic.FileIO;
using IniTool;

namespace Datalog
{
    public partial class DatalogUnitControl : Common.Template.SubInfoPanelTemplate
    {
        private Logger logger;
        private const string strINIPath = "INI\\Datalog.ini";
        private string strLogName;
        private string strLogFloder;
        private bool bInit = false;
        private ArrayList strLogRawArray = new ArrayList();

        public DatalogUnitControl(string strLogName)
        {
            InitializeComponent();

            this.strLogName = strLogName;

            LoadFromIniFile(strINIPath);
            CheckLogFileFolder();
            UpdateUIFromINI();

            strLogFloder = logFolderTextBox.Text;

            InitLog(strLogName);

            bInit = true;
        }

        private void InitLog(string strLogName)
        {
            string strLogPath = string.Format("{0}\\{1}-{2}.Log", logFolderTextBox.Text, "{yyyy}-{mm}-{dd}", strLogName);

            logger = Logger.CreateFileLogger(strLogPath, "{TIMESTAMP} {MESSAGE}");
            //logger = Logger.CreateFileLogger(strLogPath);
            //logger.IsBufferingEnabled = false;
            //logger.BufferSize = 1000;

            logger.Encoding = System.Text.Encoding.Default;


        }

        private void LoadFromIniFile(string iniFilePath)
        {
            IniFile iniFile = new IniFile(iniFilePath);

            logFolderTextBox.Text = iniFile.GetString(strLogName, "LogFolder", "");
            autoDeleteLogCheckBox.Checked = iniFile.GetInt16(strLogName, "EnableAutoDeleteLog", 1) >= 1 ? true : false;
            autoDeleteDaysNumeric.Value = iniFile.GetInt16(strLogName, "AutoDeleteLogDays", 90);
            realTimeUpdateCheckBox.Checked = iniFile.GetInt16(strLogName, "EnaleRealTimeUpdate", 1) >= 1 ? true : false;
        }

        private void SaveToIniFile(string iniFilePath)
        {
            IniFile iniFile = new IniFile(iniFilePath);

            iniFile.WriteValue(strLogName, "LogFolder", logFolderTextBox.Text);
            iniFile.WriteValue(strLogName, "EnableAutoDeleteLog", autoDeleteLogCheckBox.Checked == true ? 1 : 0);
            iniFile.WriteValue(strLogName, "AutoDeleteLogDays", (int)autoDeleteDaysNumeric.Value);
            iniFile.WriteValue(strLogName, "EnaleRealTimeUpdate", realTimeUpdateCheckBox.Checked == true ? 1 : 0);
        }

        private void UpdateUIFromINI()
        {
            autoDeleteDaysNumeric.Enabled = autoDeleteLogCheckBox.Checked;
        }

        private void CheckLogFileFolder()
        {
            if (logFolderTextBox.Text.Length == 0)
            {
                do
                {
                    logFolderBrowserDialog.Description = string.Format("Please select \"{0}\" folder...", strLogName);
                    logFolderBrowserDialog.ShowDialog(this);
                } while (logFolderBrowserDialog.SelectedPath.Length == 0);

                logFolderTextBox.Text = logFolderBrowserDialog.SelectedPath;

                SaveToIniFile(strINIPath);
            }
        }

        public void Log(string strLog)
        {
            logger.Encoding = System.Text.Encoding.Default;

            logger.Open();
            logger.Log(strLog + '\r');
            logger.Close();

            if (realTimeUpdateCheckBox.Checked == true)
            {
                todayLogListBox.Items.Add(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fff") + " " + strLog);
                if (showLastLogCheckBox.Checked == true)
                {
                    todayLogListBox.SelectedIndex = todayLogListBox.Items.Count - 1;
                }
            }
        }

        private void selectLogFileFolderButton_Click(object sender, EventArgs e)
        {
            logFolderBrowserDialog.Description = string.Format("Please select \"{0}\" folder...", strLogName);
            if (logFolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                logFolderTextBox.Text = logFolderBrowserDialog.SelectedPath;
                if (bInit == true)
                    SaveToIniFile(strINIPath);
            }
        }

        private void autoDeleteLogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            autoDeleteDaysNumeric.Enabled = autoDeleteLogCheckBox.Checked;
            if (bInit == true)
                SaveToIniFile(strINIPath);
        }

        private void autoDeleteDaysNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (bInit == true)
                SaveToIniFile(strINIPath);
        }

        private void realTimeUpdateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            todayLogListBox.Enabled = realTimeUpdateCheckBox.Checked;
            if (bInit == true)
                SaveToIniFile(strINIPath);
        }

        private void searchLogButton_CheckedChanged(object sender, EventArgs e)
        {
            ArrayList strLogFilePathArray = new ArrayList();

            if (showAllDaysLogButton.Checked == true)
            {
                // 取出資料夾內各個檔案檔名
                DirectoryInfo di = new DirectoryInfo(strLogFloder);
                // Create an array representing the files in the current directory.
                FileInfo[] fi = di.GetFiles();
                // Print out the names of the files in the current directory.
                foreach (FileInfo fiTemp in fi)
                {
                    if (fiTemp.Name.Contains(".Log") == true || fiTemp.Name.Contains(".log") == true)
                    {
                        strLogFilePathArray.Add(string.Format("{0}\\{1}", strLogFloder, fiTemp.Name));
                    }
                }
            }
            else if (showTodayLogButton.Checked == true)
            {
                string strFilaPath;
                strFilaPath = string.Format("{0}\\{1}-{2}.Log", strLogFloder, DateTime.Now.ToString("yyyy-MM-dd"), strLogName);
                if (File.Exists(strFilaPath) == true)
                    strLogFilePathArray.Add(strFilaPath);
            }
            else if (showYesterdayLogButton.Checked == true)
            {
                string strFilaPath;
                strFilaPath = string.Format("{0}\\{1}-{2}.Log", strLogFloder, DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"), strLogName);
                if (File.Exists(strFilaPath) == true)
                    strLogFilePathArray.Add(strFilaPath);
            }
            else if (showLastWeekLogButton.Checked == true)
            {
                string strFilaPath;
                for (int i = -6; i <= 0; i++)
                {
                    strFilaPath = string.Format("{0}\\{1}-{2}.Log", strLogFloder, DateTime.Now.AddDays(i).ToString("yyyy-MM-dd"), strLogName);
                    if (File.Exists(strFilaPath) == true)
                        strLogFilePathArray.Add(strFilaPath);
                }
            }
            else if (showLastMonthLogButton.Checked == true)
            {
                string strFilaPath;
                for (int i = -29; i <= 0; i++)
                {
                    strFilaPath = string.Format("{0}\\{1}-{2}.Log", strLogFloder, DateTime.Now.AddDays(i).ToString("yyyy-MM-dd"), strLogName);
                    if (File.Exists(strFilaPath) == true)
                        strLogFilePathArray.Add(strFilaPath);
                }
            }
            else if (showSearchLogButton.Checked == true)
            {

                DateTime startTime = DateTime.Parse(searchStartDatePicker.Value.ToString("yyyy/MM/dd") + " " + searchStartTimePicker.Value.ToString("HH:mm:ss"));
                DateTime endTime = DateTime.Parse(searchEndDatePicker.Value.ToString("yyyy/MM/dd") + " " + searchEndTimePicker.Value.ToString("HH:mm:ss"));

                if (endTime.Subtract(startTime).Ticks < 0)
                {
                    MessageBox.Show(this, "Invalid Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else
                {
                    int iDaysNum = endTime.Subtract(startTime).Days;

                    string strFilaPath;
                    for (int iDay = 0; iDay < iDaysNum; iDay++)
                    {
                        strFilaPath = string.Format("{0}\\{1}-{2}.Log", strLogFloder, startTime.AddDays(iDay).ToString("yyyy-MM-dd"), strLogName);
                        if (File.Exists(strFilaPath) == true)
                            strLogFilePathArray.Add(strFilaPath);
                    }
                }

            }

            string strText = "";
            for (int i = 0; i < strLogFilePathArray.Count; i++)
            {
                strLogRawArray.AddRange(File.ReadAllLines((string)strLogFilePathArray[i], Encoding.Default));
                strText += File.ReadAllText((string)strLogFilePathArray[i], Encoding.Default);
            }
            historyLogTextBox.Text = strText;
        }

        private void findWhatButton_Click(object sender, EventArgs e)
        {
            if (searchWhatTextBox.Text.Length != 0)
            {
                DataLogSearchForm.GetInstance().searchLogListBox.Items.Clear();
                if (DataLogSearchForm.GetInstance().Visible == false)
                    DataLogSearchForm.GetInstance().Show(this);
                else
                    DataLogSearchForm.GetInstance().Activate();

                List<string> strLogArray = new List<string>();

                foreach (string log in strLogRawArray)
                {
                    if (log.Contains(searchWhatTextBox.Text) == true)
                    {
                        strLogArray.Add(log);
                    }
                }

                DataLogSearchForm.GetInstance().searchLogListBox.Items.AddRange(strLogArray.ToArray());
            }
            else
            {
                MessageBox.Show(this, "The input string is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private System.Text.RegularExpressions.Regex regularExpression;
        private int startSearchIdx = 0;
        private int startSearchTempIdx = 0;
        private bool bMatched = false;
        //private bool bEnableF3Search = false;

        private void historyLogTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (historyLogTextBox.Text.Length > 0)
            {
                if (e.KeyCode == Keys.F3 && e.Modifiers == Keys.None)
                {
                    //historyLogTextBox.Text.
                    regularExpression = null;

                    regularExpression = new System.Text.RegularExpressions.Regex(searchWhatTextBox.Text);

                    System.Text.RegularExpressions.Match match = regularExpression.Match(historyLogTextBox.Text, startSearchIdx);//, historyLogTextBox.Text.Length);
                    if (match.Success)
                    {
                        historyLogTextBox.Select(match.Index, match.Length);
                        startSearchIdx = match.Index + match.Length;
                        startSearchTempIdx = match.Index;
                        try
                        {
                            historyLogTextBox.ScrollToCaret();
                        }
                        catch (System.Exception exception)
                        {
                            MessageBox.Show(exception.Message);
                        }

                        bMatched = true;
                    }
                    else if (bMatched == true)
                    {
                        historyLogTextBox.Select(startSearchTempIdx, searchWhatTextBox.Text.Length);
                        try
                        {
                            historyLogTextBox.ScrollToCaret();
                        }
                        catch (System.Exception exception)
                        {
                            MessageBox.Show(exception.Message);
                        }
                    }
                }
            }
        }

        private void deleteAllLogsButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure to want delete all logs?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // 取出資料夾內各個檔案檔名
                DirectoryInfo di = new DirectoryInfo(strLogFloder);
                // Create an array representing the files in the current directory.
                FileInfo[] fi = di.GetFiles();
                // Print out the names of the files in the current directory.
                foreach (FileInfo fiTemp in fi)
                {
                    if (fiTemp.Name.Contains(".Log") == true || fiTemp.Name.Contains(".log") == true)
                        FileSystem.DeleteFile(string.Format("{0}\\{1}", strLogFloder, fiTemp.Name), UIOption.AllDialogs, RecycleOption.DeletePermanently);
                }
            }
        }

        public string LogName
        {
            get
            {
                return strLogName;
            }
            set
            {
                strLogName = value;
            }
        }

        public string LogFloder
        {
            get
            {
                return strLogFloder;
            }
            set
            {
                strLogFloder = value;
            }
        }
    }
}
