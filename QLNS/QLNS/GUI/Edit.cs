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
        public Edit()
        {
            InitializeComponent();
            DataDiagramDataContext dt = new DataDiagramDataContext();
            dataGridView1.DataSource = from u in dt.NhanViens
                                       from t in dt.PhongBans
                                       from v in dt.PhanCongs
                                       from z in dt.DuAns
                                       where u.MaNV == v.MaNV
                                       where v.MaDA == z.MaDA
                                       where u.MaPB == t.MaPB
                                       select new
                                       {
                                           MaNV = u.MaNV,
                                           HoTen = u.HoTen,
                                           NS = u.NS,
                                           GT = u.GT,
                                           MaPB = t.MaPB,
                                           MaDA = v.MaDA
                                       };
        }
        
        private void Edit_Load(object sender, EventArgs e)
        {

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
    }
}
