using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ktra2_QuanlyMT.Forms
{
    public partial class BaoCaoNVXS : Form
    {
        public BaoCaoNVXS()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnTheothang.Enabled = true;
            btnTheoQuy.Enabled = true;
            btnTheonam.Enabled = true;
        }

        private void BaoCaoNVXS_Load(object sender, EventArgs e)
        {
            btnTheothang.Enabled = false;
            btnTheoQuy.Enabled = false;
            btnTheonam.Enabled = false;
        }

        private void btnTheothang_Click(object sender, EventArgs e)
        {
            Forms.frmTheoThang f = new Forms.frmTheoThang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void btnTheoQuy_Click(object sender, EventArgs e)
        {
            Forms.frmTheoQuy f = new Forms.frmTheoQuy();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void btnTheonam_Click(object sender, EventArgs e)
        {
            Forms.frmTheoNam f = new Forms.frmTheoNam();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
