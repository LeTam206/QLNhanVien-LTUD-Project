using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ĐỒÁN_LTUD_QuanLyNVCongTy
{
    public partial class frmXoaNV : Form
    {
        public frmXoaNV()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa nhân viên có mã " + txtMaNV.Text + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtMaNV.Focus();
        }
    }
}
