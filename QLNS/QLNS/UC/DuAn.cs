using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QLNS.UC
{
    public partial class DuAn : UserControl
    {
        Bus bus = new Bus();
        public DuAn()
        {
            InitializeComponent();

            dataGridView1.DataSource = bus.get_duan();
        }
    }
}
