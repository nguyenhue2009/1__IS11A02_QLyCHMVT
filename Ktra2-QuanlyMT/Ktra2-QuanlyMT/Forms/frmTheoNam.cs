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
    public partial class frmTheoNam : Form
    {
        public frmTheoNam()
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
            
            if ((txtNam.Text == ""))
            {
                MessageBox.Show("Hãy nhập đầy đủ năm!!!", "Yeu cau ...",
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
            
            string sql;
            sql = "select top 5 tblNhan_vien.MaNV,TenNV,sum(tblHDB.Tong_tien) as tongsotien FROM tblNhan_vien join tblHDB on tblNhan_vien.MaNV=tblHDB.MaNV WHERE (YEAR(tblHDB.NgayBan)=" + txtNam.Text + ") GROUP BY tblNhan_vien.MaNV,TenNV Order by tongsotien desc";
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

        private void frmTheoNam_Load(object sender, EventArgs e)
        {

        }
    }
}
