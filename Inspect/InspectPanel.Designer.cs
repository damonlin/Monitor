namespace Inspect
{
    partial class InspectPanel
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
            ContrelModule.LightInfo lightInfo1 = new ContrelModule.LightInfo();
            ContrelModule.RS232Info rS232Info1 = new ContrelModule.RS232Info();
            ContrelModule.RS232Info rS232Info2 = new ContrelModule.RS232Info();
            ContrelModule.RS232Info rS232Info3 = new ContrelModule.RS232Info();
            ContrelModule.CCQuickFunction ccQuickFunction1 = new ContrelModule.CCQuickFunction();
            ContrelModule.CCIOFunctionInfo ccioFunctionInfo1 = new ContrelModule.CCIOFunctionInfo();
            ContrelModule.CCQuickFSPString ccQuickFSPString1 = new ContrelModule.CCQuickFSPString();
            ContrelModule.CCQuickFunctionType ccQuickFunctionType1 = new ContrelModule.CCQuickFunctionType();
            ContrelModule.LensInfo lensInfo1 = new ContrelModule.LensInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lightControl1 = new ContrelModule.LightControl();
            this.zMotionControl1 = new ContrelModule.ZMotionControl();
            this.subPixelControl2 = new ContrelModule.SubPixelControl();
            this.subPixelControl1 = new ContrelModule.SubPixelControl();
            this.ccd1 = new Vision.CCD();
            this.otherFunction1 = new ContrelModule.OtherFunction();
            this.systemStatus1 = new ContrelModule.SystemStatus();
            this.patternGenerator1 = new ContrelModule.PatternGenerator();
            this.laserControl1 = new ContrelModule.LaserControl();
            this.lens1 = new ContrelModule.Lens();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lens1);
            this.panel1.Controls.Add(this.lightControl1);
            this.panel1.Controls.Add(this.zMotionControl1);
            this.panel1.Controls.Add(this.subPixelControl2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lightControl1
            // 
            lightInfo1._00_LightCount = 2;
            lightInfo1._01_LightControlType = ContrelModule.enumLightControlType.Rs232;
            rS232Info1.PortBoudrate = 9600;
            rS232Info1.PortDataBits = 8;
            rS232Info1.PortNumber = 2;
            rS232Info1.PortParity = System.IO.Ports.Parity.None;
            rS232Info1.PortStopBits = System.IO.Ports.StopBits.One;
            rS232Info1.ReteyTimes = 3;
            lightInfo1._02_LightRs232PortInfo = rS232Info1;
            lightInfo1._03_LightChannel = new int[] {
        0,
        1};
            lightInfo1._04_LightValue = new int[] {
        0,
        0};
            this.lightControl1.Info = lightInfo1;
            this.lightControl1.LightEnable = true;
            resources.ApplyResources(this.lightControl1, "lightControl1");
            this.lightControl1.Name = "lightControl1";
            // 
            // zMotionControl1
            // 
            rS232Info2.PortBoudrate = 9600;
            rS232Info2.PortDataBits = 8;
            rS232Info2.PortNumber = 7;
            rS232Info2.PortParity = System.IO.Ports.Parity.None;
            rS232Info2.PortStopBits = System.IO.Ports.StopBits.One;
            rS232Info2.ReteyTimes = 3;
            this.zMotionControl1._0_Info = rS232Info2;
            this.zMotionControl1.Enable = true;
            resources.ApplyResources(this.zMotionControl1, "zMotionControl1");
            this.zMotionControl1.Name = "zMotionControl1";
            // 
            // subPixelControl2
            // 
            resources.ApplyResources(this.subPixelControl2, "subPixelControl2");
            this.subPixelControl2.Name = "subPixelControl2";
            // 
            // subPixelControl1
            // 
            resources.ApplyResources(this.subPixelControl1, "subPixelControl1");
            this.subPixelControl1.Name = "subPixelControl1";
            // 
            // ccd1
            // 
            this.ccd1.BackColor = System.Drawing.Color.Black;
            this.ccd1.CCDEnabled = true;
            resources.ApplyResources(this.ccd1, "ccd1");
            this.ccd1.Name = "ccd1";
            // 
            // otherFunction1
            // 
            this.otherFunction1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.otherFunction1, "otherFunction1");
            this.otherFunction1.Name = "otherFunction1";
            // 
            // systemStatus1
            // 
            this.systemStatus1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.systemStatus1.ForeColor = System.Drawing.Color.Cornsilk;
            resources.ApplyResources(this.systemStatus1, "systemStatus1");
            this.systemStatus1.Name = "systemStatus1";
            // 
            // patternGenerator1
            // 
            this.patternGenerator1._0_PatternGeneratorType_ = ContrelModule.enumPGType.Chroma;
            rS232Info3.PortBoudrate = 19200;
            rS232Info3.PortDataBits = 8;
            rS232Info3.PortNumber = 4;
            rS232Info3.PortParity = System.IO.Ports.Parity.None;
            rS232Info3.PortStopBits = System.IO.Ports.StopBits.One;
            rS232Info3.ReteyTimes = 3;
            this.patternGenerator1._1_RS232Protocol_ = rS232Info3;
            ccioFunctionInfo1.ContactIOPoint = 0;
            ccioFunctionInfo1.ContactIOVlaue = false;
            ccioFunctionInfo1.UncontactIOPoint = 0;
            ccioFunctionInfo1.UncontactIOVlaue = false;
            ccQuickFunction1.IOFunctionInfo = ccioFunctionInfo1;
            ccQuickFSPString1.ContactFSP = "";
            ccQuickFSPString1.UncontactFSP = "";
            ccQuickFunction1.QuickFSPString = ccQuickFSPString1;
            ccQuickFunctionType1.ContactFunctionType = ContrelModule.enuFunctionType.VIO;
            ccQuickFunctionType1.UncontactFunctionType = ContrelModule.enuFunctionType.VIO;
            ccQuickFunction1.QuickFunctionType = ccQuickFunctionType1;
            this.patternGenerator1._2_QuickFunction_ = ccQuickFunction1;
            this.patternGenerator1._3_Enable_ = true;
            this.patternGenerator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.patternGenerator1, "patternGenerator1");
            this.patternGenerator1.Name = "patternGenerator1";
            // 
            // laserControl1
            // 
            this.laserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.laserControl1, "laserControl1");
            this.laserControl1.Name = "laserControl1";
            // 
            // lens1
            // 
            lensInfo1._00_LensCount = 4;
            lensInfo1._01_LensName = new string[] {
        "2X",
        "5X",
        "20X",
        "50X"};
            lensInfo1._02_LensType = ContrelModule.enumLensType.LineType;
            lensInfo1._03_LensTriggerType = ContrelModule.enumLensTriggerType.Command;
            lensInfo1._04_LensTriggerDIO = new int[] {
        0,
        0,
        0,
        0};
            lensInfo1._05_LensTriggerVIO = new int[] {
        0,
        0,
        0,
        0};
            lensInfo1._06_LensTriggerIOValue = new bool[] {
        false,
        false,
        false,
        false};
            lensInfo1._07_LensTriggerCmd = new string[] {
        "C101,1",
        "C101,2",
        "C101,3",
        "C101,4"};
            lensInfo1._08_LensEnable = true;
            this.lens1._LensInfo_ = lensInfo1;
            resources.ApplyResources(this.lens1, "lens1");
            this.lens1.Name = "lens1";
            // 
            // InspectPanel
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.laserControl1);
            this.Controls.Add(this.patternGenerator1);
            this.Controls.Add(this.ccd1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.otherFunction1);
            this.Controls.Add(this.systemStatus1);
            this.Name = "InspectPanel";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContrelModule.OtherFunction otherFunction1;
        private ContrelModule.SystemStatus systemStatus1;
        private System.Windows.Forms.Panel panel1;
        private ContrelModule.SubPixelControl subPixelControl1;
        public Vision.CCD ccd1;
        private ContrelModule.ZMotionControl zMotionControl1;
        private ContrelModule.SubPixelControl subPixelControl2;
        private ContrelModule.PatternGenerator patternGenerator1;
        private ContrelModule.LaserControl laserControl1;
        private ContrelModule.LightControl lightControl1;
        private ContrelModule.Lens lens1;
    }
}
