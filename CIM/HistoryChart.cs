using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Common.Template;
using ContrelModule;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace HistoryChart
{
    public partial class HistoryChartPanel : InfoPanelTemplate
    {
        private static HistoryChartPanel singleton = null;
        private List<string> m_LVGData = new List<string>();
        private const int MAX_POINT = 20;
        private int m_iPonitPage = 0;  

        public HistoryChartPanel()
        {
            InitializeComponent();            
        }

        public static HistoryChartPanel getSingleton()
        {
            if (singleton == null)
            {
                singleton = new HistoryChartPanel();
            }
            return singleton;
        }

        private void LoadLVGData()
        {
            string filename = dateTimePickerStart.Value.Year.ToString() + "_" +
                              dateTimePickerStart.Value.Month.ToString("D2") + "_" +
                              dateTimePickerStart.Value.Day.ToString("D2") + ".txt";

            string LVGpath = System.Environment.CurrentDirectory + "\\History\\LVG\\";

            foreach (string line in File.ReadLines(LVGpath + filename))
            {
                string[] arr = line.Split(null);

                DateTime dt = Convert.ToDateTime(arr[0]);
                DateTime startTime = Convert.ToDateTime(numberStartHour.Value.ToString() + ":" + numberStartMin.Value.ToString());
                DateTime endTime = Convert.ToDateTime(numberEndHour.Value.ToString() + ":" + numberEndMin.Value.ToString());

                if (DateTime.Compare(dt, startTime) >= 0 && DateTime.Compare(dt, endTime) <= 0)
                {
                    m_LVGData.Add(line);
                }
            }
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            m_Chart.Series[0].Points.Clear();
            LoadLVGData();

            UpdateChart();
        }

        private void chkScientific_Click(object sender, EventArgs e)
        {
            if (chkScientific.Checked)
            {
                m_Chart.ChartAreas[0].AxisY.LabelStyle.Format = "0.00E+00";                
            }
            else
            {
                m_Chart.ChartAreas[0].AxisY.LabelStyle.Format = "";
            }
        }

        private void UpdateChart()
        {
            m_Chart.Series[0].Points.Clear();

            //if ( m_iPonitPage * MAX_POINT > m_LVGData )
            //{
            //    MessageBox.Show("·j´M¤£¨ì");
            //    return;
            //}                       
            for (int iIdx = m_iPonitPage * MAX_POINT; iIdx < m_iPonitPage * MAX_POINT+MAX_POINT; ++iIdx)
            {
                string[] arr = m_LVGData[iIdx].Split(null);
                m_Chart.Series[0].Points.AddXY(arr[0], arr[1]);
            }
         
            m_Chart.Invalidate();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {           
            m_iPonitPage = 0;
            UpdateChart();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            m_iPonitPage++;
            UpdateChart();
        }

    }
}
