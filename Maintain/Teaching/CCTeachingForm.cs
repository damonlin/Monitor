using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Maintain.Teaching
{
    public partial class CCTeachingForm : Common.Wizard.CCWizardForm
    {
        public CCTeachingForm()
        {
            InitializeComponent();

            Controls.AddRange(new Control[] {		  
                new CCLaserPathTeachControl(),
                new CCMarkTeachControl(),                
                new CCClampTeachControl(),
                new CCSupportBarControl(),
                new CCTurnUnitClampControl(),
                new CCPanelParaControl(),
                new CCVcrTeachControl()
		        });
        }
    }
    

}
