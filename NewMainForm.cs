using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGS;
namespace Art_Gallery_Win
{
    public partial class NewMainForm : Form
    {
        Gallery gal;
        public NewMainForm()
        {
            InitializeComponent();
        }

        private void NewMainForm_Load(object sender, EventArgs e)
        {
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            gal.addCurator(curIDTexBox.Text, curFirstNameTexbox.Text, curLastnameTexBox.Text);
        }
    }
}
