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
    public partial class frmTKHDN : Form
    {
        DataTable tblHDN;
        public frmTKHDN()
        {
            InitializeComponent();
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMaHoaDonNhap.Focus();
        }
        private void Hienthi_Luoi()
        {
            dataGridView1.Columns[0].HeaderText = "Mã HĐN";
            dataGridView1.Columns[1].HeaderText = "Ngày Bán";
            dataGridView1.Columns[2].HeaderText = "Mã Nhân Viên";
            dataGridView1.Columns[3].HeaderText = "Mã Khách Hàng";
            dataGridView1.Columns[4].HeaderText = "Thành tiền";
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void frmTKHDN_Load(object sender, EventArgs e)
        {
            ResetValues();
            dataGridView1.DataSource = null;
        }

        private void bntTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaHoaDonNhap.Text == "") && (txtMaNhaCungCap.Text == "") && (txtMaNhanVien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện để tìm kiếm !!!");
                return;
            }
            sql = "SELECT * FROM tblHDN WHERE 1=1";
            if (txtMaHoaDonNhap.Text != "")
                sql = sql + " AND Ma_HDN Like N'%" + txtMaHoaDonNhap.Text + "%'";
            tblHDN = ThucthiSQL.DocBang(sql);
            if (txtMaNhanVien.Text != "")
                sql = sql + " AND MaNV Like N'%" + txtMaNhanVien.Text + "%'";
            tblHDN = ThucthiSQL.DocBang(sql);
            if (txtMaNhaCungCap.Text != "")
                sql = sql + " AND MaNCC Like N'%" + txtMaNhaCungCap.Text + "%'";
            tblHDN = ThucthiSQL.DocBang(sql);

            if (tblHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!");
            }
            else
            {
                MessageBox.Show("Có " + tblHDN.Rows.Count + " bản ghi thỏa mãn điều kiện!!!");
            }
            dataGridView1.DataSource = tblHDN;
            Hienthi_Luoi();
        }

        private void bntTimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dataGridView1.DataSource = null;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
