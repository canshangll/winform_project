using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace js_ape
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Main_Page main_Page = new Main_Page();
            this.Hide();
            main_Page.ShowDialog();
            Application.ExitThread();
        }
    }
}
