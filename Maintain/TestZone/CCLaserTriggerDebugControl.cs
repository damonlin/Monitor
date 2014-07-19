using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Maintain.TestZone
{
    public partial class CCLaserTriggerDebugControl : Common.Template.SubInfoPanelTemplate
    {
        #region Private Member
        private CCLaserTriggerInterface m_TriggerInterface = CCLaserTriggerInterface.getSingleton();
        #endregion

        #region Ctor
        public CCLaserTriggerDebugControl()
        {
            InitializeComponent();
        }
        #endregion
    }
}
