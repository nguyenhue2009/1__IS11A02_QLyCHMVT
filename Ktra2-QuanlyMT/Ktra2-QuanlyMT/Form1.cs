using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ktra2_QuanlyMT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmHDB f = new Forms.frmHDB();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmHDN f = new Forms.frmHDN();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void danhSáchMáyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmMaytinh f = new Forms.frmMaytinh();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void hóaĐơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.frmTKHDN f = new Forms.frmTKHDN();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void hàngTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmBaocaohangtoncs f = new Forms.frmBaocaohangtoncs();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmTKSP f = new Forms.frmTKSP();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void hoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmTKHDB f = new Forms.frmTKHDB();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void danhSáchĐểThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.BaoCaoNVXS f = new Forms.BaoCaoNVXS();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void báoCáoHóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmBCHDB f = new Forms.frmBCHDB();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmBaoCaoHDN f = new Forms.frmBaoCaoHDN();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
