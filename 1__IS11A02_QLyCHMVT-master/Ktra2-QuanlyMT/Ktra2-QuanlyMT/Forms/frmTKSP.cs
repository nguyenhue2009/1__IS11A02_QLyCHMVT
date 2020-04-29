using QlyCHVT;
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
    public partial class frmTKSP : Form
    {
        public frmTKSP()
        {
            InitializeComponent();
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMaMayTinh.Focus();
        }

        private void Hienthi_Luoi()
        {
            
            DataGridView.Columns[0].HeaderText = "Mã máy ";
            DataGridView.Columns[1].HeaderText = "Tên máy";
            DataGridView.Columns[2].HeaderText = "Loại máy";
            DataGridView.Columns[3].HeaderText = "Hãng sản xuất";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 100;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[2].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void frmTKSP_Load(object sender, EventArgs e)
        {
            ResetValues();
            DataGridView.DataSource = null;
        }

        private void bntTimKiem_Click(object sender, EventArgs e)
        {
            DataTable tblTimKiemSanPham;
            string sql;
            if ((txtMaMayTinh.Text == "") && (txtTenLoaiMay.Text == "") && (txtTenHangSanXuat.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm !!!");
                return;
            }
            sql = "SELECT Ma_mayVT,Ten_mayVT,Ma_loai_may,Ma_hang_SX FROM dboMay_vi_tinh WHERE 1=1";
            if (txtMaMayTinh.Text != "")
                sql = sql + " AND Ma_mayVT Like N'%" + txtMaMayTinh.Text + "%'";
            if (txtTenHangSanXuat.Text != "")
                sql = sql + " AND Ma_hang_SX Like N'%" + txtTenHangSanXuat.Text + "%'";
            if (txtTenLoaiMay.Text != "")
                sql = sql + " AND Ma_loai_may Like N'%" + txtTenLoaiMay.Text + "%'";
            tblTimKiemSanPham = ThucthiSQL.DocBang(sql);
            if (tblTimKiemSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblTimKiemSanPham.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DataGridView.DataSource = tblTimKiemSanPham;
            Hienthi_Luoi();

        }

        private void bntTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            DataGridView.DataSource = null;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string chitiet;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                chitiet = DataGridView.CurrentRow.Cells["Ma_mayVT"].Value.ToString();
                frmMaytinh frm = new frmMaytinh();
                frm.txtMaMT.Text = chitiet;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
        }
    }
}
