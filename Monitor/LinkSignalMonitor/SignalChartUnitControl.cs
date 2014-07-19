using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Monitor
{
   public partial class SignalChartUnitControl : UserControl
   {
      private ArrayList signalHistoryList = new ArrayList();
      private ArrayList monitorSignalList = new ArrayList();
      //private ArrayList monitorSignalList = new ArrayList();
      private ArrayList labelList = new ArrayList();

      private Bitmap bitmap = null;
      
      public SignalChartUnitControl()
      {
         InitializeComponent();

         //this.Size = new Size(870, 400);
         AddLoadingMonitorSignal(new LinkSignalItem("Upstream Equipment", LinkSignalItem.SignalType.Title, 1));

         AddLoadingMonitorSignal(new LinkSignalItem("Send Ready", LinkSignalItem.SignalType.X, 1));
         AddLoadingMonitorSignal(new LinkSignalItem("Sending", LinkSignalItem.SignalType.X, 2));
         AddLoadingMonitorSignal(new LinkSignalItem("Transfer", LinkSignalItem.SignalType.X, 3));

         AddLoadingMonitorSignal(new LinkSignalItem("Downstream Equipment", LinkSignalItem.SignalType.Title, 1));

         AddLoadingMonitorSignal(new LinkSignalItem("Rcvd Ready", LinkSignalItem.SignalType.X, 1));
         AddLoadingMonitorSignal(new LinkSignalItem("Receiving", LinkSignalItem.SignalType.X, 2));
         AddLoadingMonitorSignal(new LinkSignalItem("Receiving WIP Sensor", LinkSignalItem.SignalType.DI, 3));
         AddLoadingMonitorSignal(new LinkSignalItem("Receiving Verify Sensor", LinkSignalItem.SignalType.DI, 3));

         int yTemp = 0;
         bool bFirstTtle = true;
         bool titleFlag = false;
         for (int i = 0; i < monitorSignalList.Count; i++)
         {
            Label label = new Label();
            switch (((LinkSignalItem)monitorSignalList[i]).Type)
            {
               case LinkSignalItem.SignalType.Title:
                  label.AutoSize = true;
                  label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                  label.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  label.Location = new System.Drawing.Point(8, (bFirstTtle == true) ? (yTemp + 10) : (yTemp + 40));

                  yTemp = label.Location.Y;
                  titleFlag = true;
                  bFirstTtle = false;
            	   break;
               default:
                  label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                  label.Location = new System.Drawing.Point(10, (titleFlag == true) ? (yTemp + 20) : (yTemp + 40));
                  label.Size = new System.Drawing.Size(140, 20);

                  yTemp = label.Location.Y;
                  titleFlag = false;
                  break;
            }
            label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label.Name = ((LinkSignalItem)monitorSignalList[i]).SignalName + "label";
            label.TabIndex = 2;
            label.Text = ((LinkSignalItem)monitorSignalList[i]).SignalName;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(label);

            labelList.Add(label);
         }

         //this.Size = new Size(this.Size.Width, 25 + monitorSignalList.Count*50);

         this.Invalidate();

      }

      private Rectangle rectPlot = new Rectangle();

      private void test()
      {
         bitmap = new Bitmap(600, 50, graphicsObject);

         Graphics newGraphics = Graphics.FromImage(bitmap);
         
      }

      private Graphics graphicsObject = null;

      private void SignalChartUnitControl_Paint(object sender, PaintEventArgs e)
      {
         //if (graphicsObject==null)
           // graphicsObject = e.Graphics;

         Graphics graphicsObject = e.Graphics;

         //graphicsObject.DrawRectangle(new Pen(new SolidBrush(Color.Black), 1), 10, 10, 700,700);
         //graphicsObject.FillRectangle(new SolidBrush(Color.White), 10, 10, 250, 150);

         //graphicsObject.DrawImage();

         Pen pen = new Pen(new SolidBrush(Color.LightGray), 1);

         int countX = 0;
         int baseX = 10;
         while (true)
         {
            if ((countX * 20) > this.Size.Width)
            {
               break;
            }
            graphicsObject.DrawLine(pen, baseX + countX * 20, 0, baseX + countX * 20, this.Size.Height);
            countX++;
         }

         int countY = 0;
         int baseY = 10;
         while (true)
         {
            if ((countY * 20) > this.Size.Height)
            {
               break;
            }
            graphicsObject.DrawLine(pen, 0, baseY + countY * 20, this.Size.Width, baseY + countY * 20);
            countY++;
         }
         
      }

      private void DrawBase(PaintEventArgs e)
      {
         Graphics graphicsObject = e.Graphics;

      }

      public void AddLoadingMonitorSignal(LinkSignalItem linkSignal)
      {
         monitorSignalList.Add(linkSignal);
      }

      public bool SetSignalStatus(SingleLinkSignalRecord singleLinkSignalRecord)
      {
         signalHistoryList.Add(singleLinkSignalRecord);
         return true;
      }

      private void updateSignalTimer_Tick(object sender, EventArgs e)
      {
         //for (int i = 0; signalHistoryList.Count; i++ )
         {
            //((SingleLinkSignalRecord)signalHistoryList[i]).Status;
         }

         this.Invalidate();
      }
   }

   public class LinkSignalItem : Object
   {
      public enum SignalType { Title = 0, DI, DO, X, Y };
      private string strSignalName = "";
      private SignalType signalType = SignalType.DI;
      private int iAddress = 0;

      public LinkSignalItem(string strSignalName, SignalType signalType, int iAddress)
      {
         this.strSignalName = strSignalName;
         this.signalType = signalType;
         this.iAddress = iAddress;
      }

      public string SignalName
      {
         get
         {
            return strSignalName;
         }
      }

      public SignalType Type
      {
         get
         {
            return signalType;
         }
      }

      public int Address
      {
         get
         {
            return iAddress;
         }
      }
   }

   public class SingleLinkSignalRecord : Object
   {
      private string strSignalName = "";
      private Boolean bStatus = false;
      private DateTime dateTime = new DateTime();

      public SingleLinkSignalRecord(string strSignalName, bool bStatus)
      {
         this.strSignalName = strSignalName;
         this.bStatus = bStatus;
         dateTime = DateTime.Now;
      }

      public string SignalName
      {
         get
         {
            return strSignalName;
         }
      }

      public Boolean Status
      {
         get
         {
            return bStatus;
         }
      }

      public DateTime RecordDateTime
      {
         get
         {
            return dateTime;
         }
      }
   }


}
