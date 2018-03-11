using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace QLNS.GUI
{
    public partial class Edit : Form
    {
        Bus tk = new Bus();
        public Edit()
        {
            InitializeComponent();
            dataGridView1.DataSource = tk.getData1();
        }
        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//đẩy dữ liệu từ gridview sang panel
        {
            txtManv.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            txtHoten.Text = dataGridView1.CurrentRow.Cells["Hoten"].Value.ToString();
            dateNgaysinh.Text = dataGridView1.CurrentRow.Cells["NS"].Value.ToString();
            txtMapb.Text = dataGridView1.CurrentRow.Cells["MaPB"].Value.ToString();
            txtMada.Text = dataGridView1.CurrentRow.Cells["MaDA"].Value.ToString();

            string Gender = "";
            Gender = dataGridView1.CurrentRow.Cells["GT"].Value.ToString();
                if (Gender == "False")
                {
                    radioNam.Checked = true;
                }
                else
                {
                    radioNu.Checked = true;
                }
            
        }

        private void button3_Click(object sender, EventArgs e)//Xóa nhân viên
        {
            tk.Delete(txtManv.Text);
            dataGridView1.DataSource = tk.getData1();
        }

        private void Edit_Load(object sender, EventArgs e)
        {  
        }
    }
}
