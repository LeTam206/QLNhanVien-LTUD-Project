using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ĐỒÁN_LTUD_QuanLyNVCongTy
{
    public partial class frmThemBoPhan : Form
    {
        public frmThemBoPhan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm bộ phận có mã " + txtMaBoPhan.Text + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRefresh_Click(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaBoPhan.Clear();
            txtTenBoPhan.Clear();
            txtMaTruongBP.Clear();
            txtSoLuongNV.Clear();
            txtMaBoPhan.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new frmChuongTrinhChinh();
            form.Show();
        }
    }
}
