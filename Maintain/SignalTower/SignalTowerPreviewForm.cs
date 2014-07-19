using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Maintain
{
   public partial class SignalTowerPreviewForm : Form
   {
      private static SignalTowerPreviewForm singleton;

      protected SignalTowerPreviewForm()
      {
         InitializeComponent();

         signalTowerUnitControl.SetSize(5, 3);
      }

      public static SignalTowerPreviewForm GetSingleton()
      {
         if (singleton==null)
         {
            singleton = new SignalTowerPreviewForm();
         }
         return singleton;
      }

      public void SetSignal(SignalTower signalTower)
      {
         this.signalTowerUnitControl.SetSignal(signalTower);
      }

      private void SignalTowerPreviewForm_FormClosed(object sender, FormClosedEventArgs e)
      {
         singleton = null;
      }
   }
}