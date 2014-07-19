namespace CIM
{
    partial class PLC_Monitor
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {

                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            PLC_Interface.PLCobjEthernetInfo plCobjEthernetInfo2 = new PLC_Interface.PLCobjEthernetInfo();
            this.ccplC_Component1 = new PLC_Interface.CCPLC_Component(this.components);
            this.ccplC_Monitor1 = new PLC_Interface.CCPLC_Monitor();
            this.SuspendLayout();
            // 
            // ccplC_Component1
            // 
            this.ccplC_Component1._0_PLCCpuType_ = PLC_Interface.CpuType.CPU_Q02CPU;
            this.ccplC_Component1._1_Simulate = false;
            this.ccplC_Component1._2_ConnectType_ = PLC_Interface.ConnectType.NetH;
            plCobjEthernetInfo2.ConnectUnitNumber = 0;
            plCobjEthernetInfo2.DidPropertyBit = 0;
            plCobjEthernetInfo2.DsidPropertyBit = 0;
            plCobjEthernetInfo2.HostAddress = "";
            plCobjEthernetInfo2.IONumber = 1023;
            plCobjEthernetInfo2.MultiDropChannelNumber = 0;
            plCobjEthernetInfo2.NetworkNumber = 0;
            plCobjEthernetInfo2.NodeNumber = 0;
            plCobjEthernetInfo2.SourceNetworkNumber = 0;
            plCobjEthernetInfo2.SourceStationNumber = 0;
            plCobjEthernetInfo2.StationNumber = 0;
            plCobjEthernetInfo2.TimeOut = 1000;
            plCobjEthernetInfo2.UnitNumber = 0;
            this.ccplC_Component1._3_EthernetInfo_ = plCobjEthernetInfo2;
            this.ccplC_Component1._4_Title_ = null;
            this.ccplC_Component1._5_NodeNumber_ = 1;
            this.ccplC_Component1._6_Interval_ = 1;
            this.ccplC_Component1._7_Enable_ = false;
            // 
            // ccplC_Monitor1
            // 
            this.ccplC_Monitor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ccplC_Monitor1.Font = new System.Drawing.Font("Verdana", 9F);
            this.ccplC_Monitor1.Location = new System.Drawing.Point(0, 0);
            this.ccplC_Monitor1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ccplC_Monitor1.Name = "ccplC_Monitor1";
            this.ccplC_Monitor1.PLC_Component = this.ccplC_Component1;
            this.ccplC_Monitor1.Size = new System.Drawing.Size(887, 596);
            this.ccplC_Monitor1.TabIndex = 0;
            this.ccplC_Monitor1.WriteFunction = true;
            // 
            // PLC_Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ccplC_Monitor1);
            this.Name = "PLC_Monitor";
            this.ResumeLayout(false);

        }

        #endregion

        public PLC_Interface.CCPLC_Component ccplC_Component1;
        private PLC_Interface.CCPLC_Monitor ccplC_Monitor1;
    }
}
