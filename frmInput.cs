using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sidehelp
{
    public partial class frmInput : Form
    {
        public class Variables
        {
            private static string chosen;
            public static string Chosen
            {
                get { return chosen; }
                set { chosen = value; }
            }
        }
        public frmInput()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //flag chosen
            if (rdbtnTexas.Checked)
            {
                Variables.Chosen = "Texas";
            }
            if(rdbtnAmerica.Checked)
            {
                Variables.Chosen = "America";
            }
            if (rdbtnTurkey.Checked)
            {
                Variables.Chosen = "Turkey";
            }
            if(rdbtnUK.Checked)
            {
                Variables.Chosen = "United Kingdom";
            }
            if(rdbtnGreece.Checked)
            {
                Variables.Chosen = "Greece";
            }    

            //closes input form and opens output form
            this.Hide();
            var frmOutput = new frmOutput();
            frmOutput.Closed += (s, args) => this.Close();
            frmOutput.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //terminates program
            this.Close();
        }
    }
}
