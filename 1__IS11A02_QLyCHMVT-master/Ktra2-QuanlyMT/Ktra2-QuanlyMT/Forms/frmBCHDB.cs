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
    public partial class frmBCHDB : Form
    {
        public frmBCHDB()
        {
            InitializeComponent();
        }

        private void frmBCHDB_Load(object sender, EventArgs e)
        {

        }

        private void btnTheonam_Click(object sender, EventArgs e)
        {
            Forms.frmBCHDB_TheoNam_ f = new Forms.frmBCHDB_TheoNam_();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void btnTheoQuy_Click(object sender, EventArgs e)
        {
            Forms.frmBCHDB_TheoQuy_ f = new Forms.frmBCHDB_TheoQuy_();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void btnTheothang_Click(object sender, EventArgs e)
        {
            Forms.frmBCHDB_TheoThang_ f = new Forms.frmBCHDB_TheoThang_();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
