using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Common.Template;
using ContrelModule;
using CIM;

namespace Operate
{
    public partial class Operate : InfoPanelTemplate
    {
        private static Operate singleton = null;

        public Operate()
        {
            InitializeComponent();
        }

        public static Operate getSingleton()
        {
            if (singleton == null)
            {
                singleton = new Operate();
            }
            return singleton;
        }

        private void InlineStatusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ModeChangeRadioButton_Click(object sender, EventArgs e)
        {
            RadioButton tmpSender = (RadioButton)sender;

            if (tmpSender == AutoRadioButton)
            {
                CIM_Schedule.getSingleton().EQStatus = enumEqStatus.Idle;
                CIM_Schedule.getSingleton().AutoOperation = AutoRadioButton.Checked;
            }
            else if (tmpSender == ManualRadioButton)
            {
            }
            else if (tmpSender == StopRadioButton)
            {
                CIM_Schedule.getSingleton().EQStatus = enumEqStatus.Stop;
                CIM_Schedule.getSingleton().AutoOperation = AutoRadioButton.Checked;
            }
        }

        private void InlineStatusCheckBox_Click(object sender, EventArgs e)
        {
            if (CIM.CIM_Schedule.getSingleton().LoadHandshakeIdx != 0 || CIM.CIM_Schedule.getSingleton().UnloadHandshakeIdx != 0 || CIM.CIM_Schedule.getSingleton().ExchangeHandshakeIdx != 0)
            {
                MessageBox.Show("Handshaking");
                InlineStatusCheckBox.Checked = true;
            }
            else
            {
                CIM_Schedule.getSingleton().InlineStatus = InlineStatusCheckBox.Checked;

                if (InlineStatusCheckBox.Checked)
                {
                    InlineStatusCheckBox.Text = "LUL Inline";
                }
                else
                {
                    InlineStatusCheckBox.Text = "LUL Offline";
                }
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            SDDEMsg.SDDE.GetSingleton().SendMessageToTK("C100");
            SDDEMsg.SDDE.GetSingleton().SendMessageToTK("C300");            
        }
    }
}
