using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ĐỒÁN_LTUD_QuanLyNVCongTy
{
    public partial class frmXoaBoPhan : Form
    {
        public frmXoaBoPhan()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa bộ phận có mã " + txtMaBoPhan.Text + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRefresh_Click(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaBoPhan.Clear();
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
