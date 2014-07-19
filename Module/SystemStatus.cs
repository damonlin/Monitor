using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ContrelModule
{
    public partial class SystemStatus : UserControl
    {
        public SystemStatus()
        {
            InitializeComponent();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void LoadBit(enumBitSource p_BitSource,int p_iBitStatus)
        {
            if (p_BitSource == enumBitSource.EQ)
            {
                LEAutoOperationCheckBox.Checked = (p_iBitStatus & 0x0001) != 0;
                LELoadReqCheckBox.Checked = (p_iBitStatus & 0x0010) != 0;
                LELoadOkCheckBox.Checked = (p_iBitStatus & 0x0100) != 0;
                LEGlassSensorCheckBox.Checked = (p_iBitStatus & 0x1000) != 0;
            }
            else
            {
                LLAutoOperationCheckBox.Checked = (p_iBitStatus & 0x0001) != 0;
                LLLoadReadyCheckBox.Checked = (p_iBitStatus & 0x0010) != 0;
                LLDeliveringCheckBox.Checked = (p_iBitStatus & 0x0100) != 0;
                LLLoadCompCheckBox.Checked = (p_iBitStatus & 0x1000) != 0;
            }
        }

        private void ExchangeBit(enumBitSource p_BitSource, int p_iBitStatus)
        {
            if (p_BitSource == enumBitSource.EQ)
            {
                EEAutoOperationCheckBox.Checked = (p_iBitStatus & 0x0001) != 0;
                EEExchangeReqCheckBox.Checked = (p_iBitStatus & 0x0010) != 0;
                EEExchangeOkCheckBox.Checked = (p_iBitStatus & 0x0100) != 0;
                EEGlassSensorCheckBox.Checked = (p_iBitStatus & 0x1000) != 0;
            }
            else
            {
                ELAutoOperationCheckBox.Checked = (p_iBitStatus & 0x0001) != 0;
                ELExchangeReadyCheckBox.Checked = (p_iBitStatus & 0x0010) != 0;
                ELDeliveringCheckBox.Checked = (p_iBitStatus & 0x0100) != 0;
                ELExchangeCompCheckBox.Checked = (p_iBitStatus & 0x1000) != 0;
            }
        }

        private void UnloadBit(enumBitSource p_BitSource, int p_iBitStatus)
        {
            if (p_BitSource == enumBitSource.EQ)
            {
                UEAutoOperationCheckBox.Checked = (p_iBitStatus & 0x0001) != 0;
                UEUnloadReqCheckBox.Checked = (p_iBitStatus & 0x0010) != 0;
                UEUnloadOkCheckBox.Checked = (p_iBitStatus & 0x0100) != 0;
                UEGlassSensorCheckBox.Checked = (p_iBitStatus & 0x1000) != 0;
            }
            else
            {
                ULAutoOperationCheckBox.Checked = (p_iBitStatus & 0x0001) != 0;
                ULUnloadReadyCheckBox.Checked = (p_iBitStatus & 0x0010) != 0;
                ULDeliveringCheckBox.Checked = (p_iBitStatus & 0x0100) != 0;
                ULUnloadCompCheckBox.Checked = (p_iBitStatus & 0x1000) != 0;
            }
        }
    }

    public enum enumBitSource
    {
        EQ = 0,
        Robot = 1
    }
}
