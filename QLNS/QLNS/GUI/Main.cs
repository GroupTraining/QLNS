﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            contextMenuBar1.Visible = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            GUI.Add ad = new GUI.Add();
            ad.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            GUI.TimKiem tk = new GUI.TimKiem();
            tk.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            GUI.Edit edit = new GUI.Edit();
            edit.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btn_TK_Click(object sender, EventArgs e)
        {
            GUI.ThongKe tk = new GUI.ThongKe();
            tk.Show();
        }
    }
}
