using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Monitor
{
   public partial class IOMonitorForm : Form
   {
      static private IOMonitorForm singleton;
      //private object triggerObject;

      protected IOMonitorForm()
      { 
      }
      
      private IOMonitorForm(ref object triggerObject)
      {
         InitializeComponent();

         //this.triggerObject = triggerObject;

         diMonitorUnitControl.LoadUI("INI\\DIOName.INI", IOMonitorUnitControl.IOType.DI_TYPE);
         doMonitorUnitControl.LoadUI("INI\\DIOName.INI", IOMonitorUnitControl.IOType.DO_TYPE);
      }

      ~IOMonitorForm()
      {
      }

      public static IOMonitorForm getSingleton(ref object triggerObject)
      {
         if (singleton==null)
            singleton = new IOMonitorForm(ref triggerObject);
         return singleton;
      }

      private void exitButton_Click(object sender, EventArgs e)
      {
         this.Hide();
         /*if (triggerObject!=null)
         {
            if(this.triggerObject.GetType().FullName == "System.Windows.Forms.ToolStripMenuItem")
               ((System.Windows.Forms.ToolStripMenuItem)triggerObject).Checked = false;
            else if (this.triggerObject.GetType().FullName == "System.Windows.Forms.Button")
               ((System.Windows.Forms.Button)triggerObject).BackColor = Color.FromArgb(229, 230, 250);
         }*/
      }
   }
}