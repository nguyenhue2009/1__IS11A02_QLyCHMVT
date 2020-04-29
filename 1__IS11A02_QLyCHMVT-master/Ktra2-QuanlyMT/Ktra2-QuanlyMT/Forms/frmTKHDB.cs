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
    public partial class frmTKHDB : Form
    {
     
        public frmTKHDB()
        {
            InitializeComponent();
        }
        private void HienthiLuoi()
        {
            dataGridView1.Columns[0].HeaderText = "Mã hóa đơn bán";
            dataGridView1.Columns[1].HeaderText = "Ngày bán";
            dataGridView1.Columns[2].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[3].HeaderText = "Mã khách hàng";
            dataGridView1.Columns[4].HeaderText = "Tổng tiền";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 130;
            dataGridView1.Columns[3].Width = 130;
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMaHoaDonBan.Focus();
        }

        private void bntTimkiem_Click(object sender, EventArgs e)
        {
            DataTable tblHDB;
            string sql;
            if ((txtMaHoaDonBan.Text == "") && (txtMaKhachHang.Text == "") &&
               (txtMaNhanVien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yeu cau ...",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblHDB WHERE 1=1";
            if (txtMaHoaDonBan.Text != "")
                sql = sql + " AND Ma_HDB Like N'%" + txtMaHoaDonBan.Text + "%'";
            tblHDB = ThucthiSQL.DocBang(sql);
            if (txtMaNhanVien.Text != "")
                sql = sql + " AND MaNV Like N'%" + txtMaNhanVien.Text + "%'";
            tblHDB = ThucthiSQL.DocBang(sql);
            if (txtMaKhachHang.Text != "")
                sql = sql + " AND MaKH Like N'%" + txtMaKhachHang.Text + "%'";
            tblHDB = ThucthiSQL.DocBang(sql);
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblHDB.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataGridView1.DataSource = tblHDB;
            HienthiLuoi();
        }
        

        private void frmTKHDB_Load(object sender, EventArgs e)
        {
            ResetValues();
            dataGridView1.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaHoaDonBan.Text = "";
            txtMaKhachHang.Text = "";
            txtMaMayViTinh.Text = "";
            txtMaNhanVien.Text = "";
            ResetValues();
            dataGridView1.DataSource = null;
        }
    }
}
