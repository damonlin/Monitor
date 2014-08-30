using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Common.Template;
using ContrelModule;

namespace HistoryChart
{
    public partial class HistoryChartPanel : InfoPanelTemplate
    {
        private static HistoryChartPanel singleton = null;

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
    }
}
