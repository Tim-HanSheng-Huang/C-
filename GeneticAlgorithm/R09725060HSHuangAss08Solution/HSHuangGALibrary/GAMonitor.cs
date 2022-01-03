using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSHuangGALibrary
{
    public partial class GAMonitor<S> : UserControl
    {
        GenericGASolver<S> theGASolver;
        public GAMonitor(GenericGASolver<S> theGASolver)
        {
            this.theGASolver = theGASolver;
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            theGASolver.Reset();
            btnRunOneIteration.Enabled = true;
            btnRunToEnd.Enabled = true;
        }

        private void btnRunOneIteration_Click(object sender, EventArgs e)
        {
            theGASolver.RunOneIteration();
        }

        private void btnRunToEnd_Click(object sender, EventArgs e)
        {
            theGASolver.RunToEnd();
        }
    }
}
