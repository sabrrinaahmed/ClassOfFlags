using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace sidehelp
{
    public partial class frmOutput : Form
    {
        public frmOutput()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //calls event for that type of flag
            frmInput frmInput = new frmInput();
            Flags flags = new Flags();
            if (frmInput.Variables.Chosen == "Texas")
            {
                flags.TexasFlag(pictureBox1, ClientRectangle);
            }
            if(frmInput.Variables.Chosen == "America")
            {
                flags.AmericaFlag(pictureBox1, ClientRectangle);
            }
            if (frmInput.Variables.Chosen == "Turkey")
            {
                flags.TurkeyFlag(pictureBox1, ClientRectangle);
            }
            if(frmInput.Variables.Chosen == "United Kingdom")
            {
                flags.UKFlag(pictureBox1, ClientRectangle);
            }
            if(frmInput.Variables.Chosen == "Greece")
            {
                flags.GreeceFlag(pictureBox1, ClientRectangle);
            }
            btnShow.Visible = false;
            btnBack.Visible = true;
            btnBack.Focus();

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            //terminates program
            this.Close();
        }

        private void frmOutput_Load(object sender, EventArgs e)
        {
            //form text specific to flag chosen
            this.Text = frmInput.Variables.Chosen + " Flag";
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {

            //closes output form and opens input form
            this.Hide();
            var frmInput = new frmInput();
            frmInput.Closed += (s, args) => this.Close();
            frmInput.Show();
        }
    }
}
