using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐỒÁN_LTUD_QuanLyNVCongTy
{
    public partial class frmChuongTrinhChinh : Form
    {
        public frmChuongTrinhChinh()
        {
            InitializeComponent();
        }

        //ĐĂNG XUÁT
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //THÊM
        private void thêmNhânViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
            Form form = new frmThemNV();
            form.Show();
        }

        private void thêmBộPhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new frmThemBoPhan();
            form.Show();
        }

        //XÓA
        private void xóaNhânViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new frmXoaNV();
            form.Show();
        }

        private void xóaBộPhậnToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new frmXoaBoPhan();
            form.Show();
        }

        //SỬA
        private void sửaNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new frmSuaNV();
            form.Show();
        }

        private void sửaBộPhậnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new frmSuaBoPhan();
            form.Show();
        }
    }
}
