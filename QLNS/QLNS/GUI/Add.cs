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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Bus bus = new Bus();
        private void Add_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = bus.getData1();

        }

        private void btnThêm_Click(object sender, EventArgs e)
        {
             DataDiagramDataContext data = new DataDiagramDataContext();

            NhanVien NV = new NhanVien();
            PhanCong PC = new PhanCong();
            try
            {
                NV.MaNV = txtMaNV.Text;
                PC.MaNV = txtMaNV.Text;
                PC.MaDA = txtDuAn.Text;
                NV.HoTen = txtHoTen.Text;
                NV.Luong = Convert.ToInt32(txtLuong.Text);
                NV.MaNGS = txtMaNGS.Text;
                NV.MaPB = txtMaPB.Text;
                if (rabtn_nam.Checked == true)
                {
                    NV.GT = false;
                }
                if (rabtn_nu.Checked == true)
                {
                    NV.GT = true;
                }
                //NV.NS = Convert.ToDateTime(txtNS.Text);
                NV.NS = Convert.ToDateTime(dtpBirtday.Value.ToShortDateString());
                data.NhanViens.InsertOnSubmit(NV);
                data.PhanCongs.InsertOnSubmit(PC);
                data.SubmitChanges();

                txtMaNV.Text = "";
                txtHoTen.Text = "";
               // txtNS.Text = "";
                txtLuong.Text = "";
                txtMaNGS.Text = "";
                txtMaPB.Text = "";
                txtDuAn.Text = "";
                dgvNhanVien.DataSource = bus.getData1();
                dgvNhanVien.Refresh();
                MessageBox.Show("Đã thêm thành công");
            }catch(Exception )
            {
                MessageBox.Show("Lỗi dữ thêm dữ liệu!!!!");
            }

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
