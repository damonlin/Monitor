using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Common.Template;

namespace Inspect
{
    public partial class InspectPanel : InfoPanelTemplate
    {
        private static InspectPanel singleton = null;

        public InspectPanel()
        {
            InitializeComponent();
        }

        public static InspectPanel getSingleton()
        {
            if (singleton == null)
            {
                singleton = new InspectPanel();
            }
            return singleton;
        }     
    }
}
