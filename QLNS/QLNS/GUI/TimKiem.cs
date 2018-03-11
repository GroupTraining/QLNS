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
    public partial class TimKiem : Form
    {
        Bus bus = new Bus();
        public TimKiem()
        {
            InitializeComponent();

            dataGridView1.DataSource = bus.get_nhanvien();
        }

        private void btnCapnhat_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.get_nhanvien();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtManv.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            txtHoten.Text = dataGridView1.CurrentRow.Cells["Hoten"].Value.ToString();
            txtNs.Text = dataGridView1.CurrentRow.Cells["NS"].Value.ToString();
            txtPb.Text = dataGridView1.CurrentRow.Cells["TenPB"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["GT"].Value.ToString() == "False")
            {
                txtGt.Text = "Nam";
            }
            else
            {
                txtGt.Text = "Nữ";
            }

            txtDa.Text = dataGridView1.CurrentRow.Cells["TenDA"].Value.ToString();
        }

        private void btnTimkiem_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.get_nhanvien(txtGiatri.Text);
        }
    }
}
