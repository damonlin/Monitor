using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Common.Template;

namespace Recipe
{
    public partial class MappingTable : SubInfoPanelTemplate
    {
        private static MappingTable singleton = null;

        public MappingTable()
        {
            InitializeComponent();
        }

        public static MappingTable getSingleton()
        {
            if (singleton == null)
            {
                singleton = new MappingTable();
            }
            return singleton;
        }
    }
}
