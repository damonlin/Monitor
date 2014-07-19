using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Common.Template;
using ContrelModule;
using CIM;

namespace Operate
{
    public partial class Operate : InfoPanelTemplate
    {
        private static Operate singleton = null;

        public Operate()
        {
            InitializeComponent();
        }

        public static Operate getSingleton()
        {
            if (singleton == null)
            {
                singleton = new Operate();
            }
            return singleton;
        }     
    }
}
