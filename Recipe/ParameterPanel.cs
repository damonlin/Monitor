using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Common.Template;
using System.IO.Ports;

namespace Parameter
{
    public partial class ParameterPanel : InfoPanelTemplate
    {
        private static ParameterPanel singleton = null;
              
        public static ParameterPanel getSingleton()
        {
            if (singleton == null)
            {
                singleton = new ParameterPanel();
            }
            return singleton;
        }     

        #region Ctor
        public ParameterPanel()
        {
            InitializeComponent();            
        }
        #endregion
    }
}
