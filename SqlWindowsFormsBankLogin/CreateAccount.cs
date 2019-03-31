using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlWindowsFormsBankLogin
{
    public partial class CreateAccount : Form
    {
        Form1 form = new Form1();

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void isThisCreateScreenClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
