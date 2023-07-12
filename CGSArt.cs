using System;
using System.IO;
using System.Windows.Forms;
using CGS;
namespace Art_Gallery_Win
{
    public partial class CGSArt : Form
    {

        public CGSArt()
        {
            InitializeComponent();

        }

        private void UserNametxt_Click(object sender, EventArgs e)
        {

        }

        private void Unametxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void PsWtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void GreetTxt_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (Unametxt.Text == "CGS" && PsWtxt.Text == "admin")
            {
                MessageBox.Show("Hello " + Unametxt.Text);
                mainForm mForm = new mainForm();
                this.Hide();
                mForm.Activate();
                mForm.Show();
            }
            else
            {
                MessageBox.Show("You have entered a wrong username or password.");
            }
            /*

            CGSArt cgsART = new CGSArt();
            cgsART.Visible = true;
             cgsART.Activate();
            MessageBox.Show("Welcome");
            */
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
