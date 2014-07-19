using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Common.Template;

namespace Recipe
{
    public partial class ProductList : SubInfoPanelTemplate
    {
        private static ProductList singleton = null;

        public ProductList()
        {
            InitializeComponent();
        }

        public static ProductList getSingleton()
        {
            if (singleton == null)
            {
                singleton = new ProductList();
            }
            return singleton;
        }
    }
}
