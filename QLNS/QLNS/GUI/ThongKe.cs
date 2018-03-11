using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.UC;

namespace QLNS.GUI
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            NhanVien ucnv = new NhanVien();
            ucnv.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ucnv);
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            PhongBan ucpb = new PhongBan();
            ucpb.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ucpb);
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            DuAn ucda = new DuAn();
            ucda.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ucda);
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            TimKiem tk = new TimKiem();
            tk.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
