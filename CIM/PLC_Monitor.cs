using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CIM
{
    public partial class PLC_Monitor : Common.Template.SubInfoPanelTemplate
    {
        private static PLC_Monitor singleton = null;

        public PLC_Monitor()
        {
            InitializeComponent();
        }

        public static PLC_Monitor getSingleton()
        {
            if (singleton == null)
            {
                singleton = new PLC_Monitor();
            }
            return singleton;
        }
    }
}
