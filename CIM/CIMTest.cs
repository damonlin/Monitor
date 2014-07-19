using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CIM
{
    public partial class CIMTest : Common.Template.SubInfoPanelTemplate
    {
        public CIMTest()
        {
            InitializeComponent();

            propertyGrid1.SelectedObject = Common.GlobalValue.GlassData1;
            propertyGrid2.SelectedObject = Common.GlobalValue.GlassData2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CIM_Schedule.getSingleton().ExchangeHandshakeIdx = int.Parse(textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CIM_Schedule.getSingleton().UnloadHandshakeIdx = int.Parse(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CIM_Schedule.getSingleton().LoadHandshakeIdx = int.Parse(textBox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = CIM_Schedule.getSingleton().LoadHandshakeIdx.ToString();
            label2.Text = CIM_Schedule.getSingleton().UnloadHandshakeIdx.ToString();
            label3.Text = CIM_Schedule.getSingleton().ExchangeHandshakeIdx.ToString();
            label4.Text = Common.GlobalValue.UnloadGlass.ToString();
            label5.Text = Common.GlobalValue.VCRGlassData;
            label6.Text = Common.GlobalValue.RecipeData.ToString();
            label8.Text = CIM.PatternFind.PatternFindIdx.ToString();
            propertyGrid1.SelectedObject = Common.GlobalValue.GlassData1;
            propertyGrid2.SelectedObject = Common.GlobalValue.GlassData2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Common.GlobalValue.UnloadGlass = int.Parse(textBox4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Common.GlobalValue.VCRGlassData = textBox5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Common.GlobalValue.RecipeData = int.Parse(textBox6.Text);
            //CIM_Schedule.getSingleton().RecipeChangeOK = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Common.GlobalValue.GlassProcessStatus[1])
            {
                CIM_Schedule.getSingleton().RemoveData(1);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Common.GlobalValue.GlassProcessStatus[2])
            {
                CIM_Schedule.getSingleton().RemoveData(2);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CIM_Schedule.getSingleton().InitHandshakeBit();
        }

        private void m_StartToLoad_Click(object sender, EventArgs e)
        {
            Scenario.StartToLoad();
        }

        private void m_btnUnload_Click(object sender, EventArgs e)
        {
            Scenario.StartToUnload();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label7.Text = Scenario.LULIndex.ToString();
            label9.Text = Scenario.StageIndex.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Scenario.ScenarioIndex = int.Parse(textBox8.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            CIM_Schedule.getSingleton().AbnormalFlag = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CIM.PatternFind.PatternFindIdx = int.Parse(textBox7.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            CIM.PatternFind.StartPatternFind();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //CIM_Schedule.getSingleton(). = int.Parse(textBox8.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Scenario.ScenarioIndex = 0;
        }

        private void m_SendCCommand_Click(object sender, EventArgs e)
        {
            //SDDE.GetSingleton().SendMessageToTK(textBox9.Text); 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Scenario.SupplyEnd = !checkBox1.Checked;
        }
    }
}
