using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;


namespace QLNS.GUI
{
    public partial class Login : Form
    {
        Bus bus = new Bus();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(bus.check_login(txt_username.Text, txt_password.Text) == 1)
            {
                GUI.Main main = new GUI.Main();
                main.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!");
            }
        }
    }
}
