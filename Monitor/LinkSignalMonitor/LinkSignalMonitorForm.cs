using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

using ChartDirector;

namespace Monitor
{
   public partial class LinkSignalMonitorForm : Form
   {
      #region Global Variables

      string[] valueLabels;
      float[] values;
      string xLabel;     // Label displayed on x axis
      string yLabel;     // Label displayed on y axis
      string fontFormat = "Courier"; // format for labels
      int alpha = 255;      // alpha for graph

      #endregion

      public LinkSignalMonitorForm()
      {
         InitializeComponent();

         dataGridView2.Rows.Add(25);



      }

      public Bitmap DrawLineGraph()
      {
         Bitmap objgraph = new Bitmap(200, 200);             // Canvas for graph

         Graphics graphicGraph = Graphics.FromImage(objgraph);

         //Paint the graph canvas white
         // SolidBrush whiteBrush = new SolidBrush(Color.White);
         //graphicGraph.FillRectangle(whiteBrush, 0, 0, 200, 200);

         int highestValue; //Highest value in the values array

         //Get the highest value 
         int[] tempValue = new int[values.Length];
         for (int j = 0; j < values.Length; j++)
         {
            tempValue[j] = (int)values[j];
         }
         Array.Sort<int>(tempValue);
         highestValue = tempValue[values.Length - 1];
         int[,] points = new int[values.Length, 2];

         for (int i = 0; i <= values.Length; i++)
         {
            Point startPoint = new Point(10, i*10);
            Point endPoint = new Point(100, i * 10);
            SolidBrush brush = new SolidBrush(Color.LightGray);
            Pen colorPen = new Pen(brush, 1);

            graphicGraph.DrawLine(colorPen, startPoint, endPoint);
         }

         //objgraph = EmbedAxis(objgraph, true);
         //objgraph = EmbedXLinePanel(objgraph);
         return (objgraph);

      }

		private void exitButton_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
   }
}