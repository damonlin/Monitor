using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Datalog
{
   public partial class DataLogSearchForm : Form
   {
      private static DataLogSearchForm singlaton;

      protected DataLogSearchForm()
      {
         InitializeComponent();
      }

      public static DataLogSearchForm GetInstance()
      {
         if (singlaton==null)
         {
            singlaton = new DataLogSearchForm();
         }
         return singlaton;
      }

      private void closeButton_Click(object sender, EventArgs e)
      {
         this.Close();
         this.Dispose();
         singlaton = null;
      }

      private void DataLogSearchForm_FormClosed(object sender, FormClosedEventArgs e)
      {
         singlaton = null;
      }
   }
}