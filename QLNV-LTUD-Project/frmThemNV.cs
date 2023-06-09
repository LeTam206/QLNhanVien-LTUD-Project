using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ĐỒÁN_LTUD_QuanLyNVCongTy
{
    public partial class frmThemNV : Form
    {
        public frmThemNV()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm nhân viên có mã " + txtMaNV.Text + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMaNV.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new frmChuongTrinhChinh();
            form.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtHoTenNV.Clear();
            txtNgaySinh.Clear();
            txtGioiTinh.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            cboBoPhan.SelectedIndex = -1;
            txtMaNV.Focus();
        }
    }
}
