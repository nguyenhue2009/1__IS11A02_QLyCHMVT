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
using COMExcel = Microsoft.Office.Interop.Excel;

namespace Ktra2_QuanlyMT.Forms
{
    public partial class frmTheoQuy : Form
    {
        public frmTheoQuy()
        {
            InitializeComponent();
        }
        private void HienthiLuoi()
        {
            dataGridView1.Columns[0].HeaderText = "Mã Nhân Viên";
            dataGridView1.Columns[1].HeaderText = "Tên Nhân Viên";
            dataGridView1.Columns[2].HeaderText = "Tổng tiền";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 130;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            int dau, cuoi;
            dau = 0;
            cuoi = 0;

            if ((cboQuy.Text == "") || (txtNam.Text == ""))
            {
                MessageBox.Show("Hãy nhập đầy đủ quý và năm!!!", "Yeu cau ...",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int nam = Convert.ToInt32(txtNam.Text);
            int namhientai = DateTime.Now.Year;
            if (nam < 2000 || nam > namhientai)
            {
                MessageBox.Show("Năm bạn nhập không hợp lệ!!! (Năm nhập từ 2000 đến " + DateTime.Now.Year + ")", "Yêu cầu nhập lại",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int quy = Convert.ToInt32(cboQuy.Text);
            if (quy == 1)
            {
                dau = 1;
                cuoi = 3;
            }
            else if (quy == 2)
            {
                dau = 4;
                cuoi = 6;
            }
            else if (quy == 3)
            {
                dau = 7;
                cuoi = 9;
            }
            else if (quy == 4)
            {
                dau = 10;
                cuoi = 12;
            }
            string sql;
            sql = "select top 5 tblNhan_vien.MaNV,TenNV,sum(tblHDB.Tong_tien) as tongsotien FROM tblNhan_vien join tblHDB on tblNhan_vien.MaNV=tblHDB.MaNV WHERE (YEAR(tblHDB.NgayBan)=" + txtNam.Text + ") AND (MONTH(tblHDB.NgayBan) BETWEEN  " + dau + " AND " + cuoi + " ) GROUP BY tblNhan_vien.MaNV,TenNV Order by tongsotien desc";
            DataTable tblQuy;
            tblQuy = ThucthiSQL.DocBang(sql);
            if (tblQuy.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Có " + tblQuy.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataGridView1.DataSource = tblQuy;
            HienthiLuoi();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
