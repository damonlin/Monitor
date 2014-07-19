using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Maintain
{
   public partial class SignalTowerUnitControl : UserControl
   {
      private SignalTower signalTower = new SignalTower();
      private ArrayList signal = new ArrayList();
      private Color[] onColor = { Color.Red, Color.Yellow, Color.Lime, Color.Blue };
      private Color[] offColor = { Color.DarkRed, Color.Olive, Color.DarkGreen, Color.DarkBlue };
      private int[] blinkCounter = new int[4];

      public SignalTowerUnitControl()
      {
         InitializeComponent();

         signal.Add(redPanel);
         signal.Add(yellowPanel);
         signal.Add(greenPanel);
         signal.Add(bluePanel);

         flashTimer.Enabled = true;
      }

      private void flashTimer_Tick(object sender, EventArgs e)
      {

         for (int i = 0; i < signal.Count; i++ )
         {
            switch (signalTower.signalType[i])
            {
            case SignalTower.BlinkMode.ON:
               ((System.Windows.Forms.Panel)signal[i]).BackColor = (Color)onColor[i];
            	break;
            case SignalTower.BlinkMode.OFF:
               ((System.Windows.Forms.Panel)signal[i]).BackColor = (Color)offColor[i];
               break;
            default:
               if (blinkCounter[i] == (int)signalTower.signalType[i])
               {
                  ((System.Windows.Forms.Panel)signal[i]).BackColor = (Color)onColor[i];
               }
               else if (blinkCounter[i] == 2 * (int)signalTower.signalType[i])
               {
                  ((System.Windows.Forms.Panel)signal[i]).BackColor = (Color)offColor[i];
                  blinkCounter[i] = 0;
               }
               blinkCounter[i]++;
               break;
            }  
         }
      }

      /// <summary>
      /// aaaaa
      /// </summary>
      /// <remarks>hggfhgfhg</remarks>
      /// <returns>bbbbb</returns>
      public void SetSignal(SignalTower signalTower)
      {
         for (int i = 0; i < signal.Count; i++)
          blinkCounter[i] = 0; 
         this.signalTower = signalTower;
      }

      public void SetSize(float xRatio, float yRatio)
      {
         this.Size = new Size((int)(this.Size.Width * xRatio), (int)(this.Size.Height * yRatio) + 3);
         int baseHeight = (int)(((System.Windows.Forms.Panel)signal[0]).Size.Height * yRatio);
         for (int i = 0; i < signal.Count; i++ )
         {
            ((System.Windows.Forms.Panel)signal[i]).Size = new Size((int)(((System.Windows.Forms.Panel)signal[i]).Size.Width * xRatio), (int)(((System.Windows.Forms.Panel)signal[i]).Size.Height * yRatio));
            ((System.Windows.Forms.Panel)signal[i]).Location = new Point(0, baseHeight * i - 1*i);
         }
      }
   }

   public class SignalTower : Object
   {
      public enum SignalType { RED = 0, YELLOW, GREEN, BLUE, BUZZER};
      public enum BlinkMode
      {
         // Light
         OFF = 0, ON = 11,
         PER0500ms = 1, PER1000ms, PER1500ms, PER2000ms, PER2500ms,
         PER3000ms,     PER3500ms, PER4000ms, PER4500ms, PER5000ms,
         NoSound=100, LongBeep, ShortIntervalBeep   // Buzzer
      };

      private string status = "";
      private string description = "";

      private BlinkMode redLightType = BlinkMode.OFF;
      private BlinkMode yellowLightType = BlinkMode.OFF;
      private BlinkMode greenLightType = BlinkMode.OFF;
      private BlinkMode blueLightType = BlinkMode.OFF;
      private BlinkMode buzzerType = BlinkMode.NoSound;

      public BlinkMode[] signalType = new BlinkMode[5];

      public string Status
      {
         get
         {
            return status;
         }
         set
         {
            status = value;
         }
      }
      public string Description
      {
         get
         {
            return description;
         }
         set
         {
            description = value;
         }
      }
      public BlinkMode RedLightType
      {
         get
         {
            return redLightType;
         }
         set
         {
            redLightType = value;
            signalType[(int)SignalType.RED] = value;
         }
      }
      public BlinkMode YellowLightType
      {
         get
         {
            return yellowLightType;
         }
         set
         {
            yellowLightType = value;
            signalType[(int)SignalType.YELLOW] = value;
         }
      }
      public BlinkMode GreenLightType
      {
         get
         {
            return greenLightType;
         }
         set
         {
            greenLightType = value;
            signalType[(int)SignalType.GREEN] = value;
         }
      }
      public BlinkMode BlueLightType
      {
         get
         {
            return blueLightType;
         }
         set
         {
            blueLightType = value;
            signalType[(int)SignalType.BLUE] = value;
         }
      }
      public BlinkMode BuzzerType
      {
         get
         {
            return buzzerType;
         }
         set
         {
            buzzerType = value;
            signalType[(int)SignalType.BUZZER] = value;
         }
      }
   }
}
