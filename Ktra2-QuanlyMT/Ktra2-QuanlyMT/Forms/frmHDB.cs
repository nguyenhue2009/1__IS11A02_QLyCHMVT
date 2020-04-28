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
    public partial class frmHDB : Form
    {
        public frmHDB()
        {
            InitializeComponent();
        }

        private void frmHDB_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            cboMaKH.Enabled = true;
            txtTenNV.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            txtTong_tien.ReadOnly = true;
            txtTong_tien.ReadOnly = true;
            txtTong_tien.Text = "0";
            dataGridView_HDB.Enabled = false;
            grbChitiet.Enabled = false;
            txtMa_HDB.ReadOnly = true;
        }
        private void ResetValuesMayVT()
        {
            cboMa_mayVT.Text = "";
            txtSo_luong.Text = "";

        }
        private void frmHNB_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            txtMa_HDB.ReadOnly = false;
            txtTenNV.ReadOnly = false;
            txtTenKH.ReadOnly = false;
            txtTen_mayVT.ReadOnly = false;
            txtDon_gia.ReadOnly = false;
            txtTong_tien.ReadOnly = false;
            txtTong_tien.Text = "0";
            dataGridView_HDB.Enabled = false;
            grbChitiet.Enabled = false;
        }
        private void Hienthi_Luoi()
        {
            string sql;
            sql = "SELECT a.Ma_HDB,b.Ma_mayVT, b.Ten_mayVT, b.Thoi_han_BH, a.So_luong,a.Thanh_tien FROM tblChitietHDB as a, dboMay_vi_tinh as b WHERE a.Ma_HDB = N'" +
                txtMa_HDB.Text + "'AND a.Ma_mayVT=b.Ma_mayVT";
            dataGridView_HDB.DataSource = ThucthiSQL.DocBang(sql);
            dataGridView_HDB.Columns[0].HeaderText = "Mã HDN";
            dataGridView_HDB.Columns[1].HeaderText = "Mã MVT";
            dataGridView_HDB.Columns[2].HeaderText = "Tên MVT";
            dataGridView_HDB.Columns[3].HeaderText = "Bảo Hành";
            dataGridView_HDB.Columns[4].HeaderText = "Số Lượng";
            dataGridView_HDB.Columns[5].HeaderText = "Thành tiền";
            dataGridView_HDB.Columns[0].Width = 70;
            dataGridView_HDB.Columns[1].Width = 70;
            dataGridView_HDB.Columns[2].Width = 150;
            dataGridView_HDB.Columns[3].Width = 70;
            dataGridView_HDB.Columns[4].Width = 100;
            dataGridView_HDB.Columns[5].Width = 100;
            dataGridView_HDB.AllowUserToAddRows = false;
            dataGridView_HDB.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMa_HDB.Text = "";
            dtpNgayban.Text = DateTime.Now.ToShortDateString();
            cboMaNV.Text = "";
            cboMaKH.Text = "";
            cboMa_mayVT.Text = "";
            txtTong_tien.Text = "0";
            txtSo_luong.Text = "";
            txtDon_gia.Text = "";
            txtTen_mayVT.Text = "";
            txtTenNV.Text = "";
            txtTenKH.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboMa_mayVT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã máy vi tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMa_mayVT.Focus();
                return;
            }
            if ((txtSo_luong.Text.Trim().Length == 0) || (txtSo_luong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo_luong.Text = "";
                txtSo_luong.Focus();
                return;
            }
            string sql = "SELECT Ma_mayVT FROM tblChitietHDB WHERE Ma_mayVT=N'" + cboMa_mayVT.Text +
                "' AND Ma_HDB = N'" + txtMa_HDB.Text.Trim() + "'";
            if (ThucthiSQL.DocBang(sql).Rows.Count > 0)
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValuesMayVT();
                cboMa_mayVT.Focus();
                return;
            }

            sql = "INSERT INTO tblChitietHDB(Ma_HDB,Ma_mayVT,So_luong,Thanh_tien) VALUES(N'" +
                txtMa_HDB.Text.Trim() + "',N'" + cboMa_mayVT.Text.ToString() + "',N'" + txtSo_luong.Text +
                "',N'" + txtTong_tien.Text + "')";
            ThucthiSQL.CapNhatDuLieu(sql);
            Hienthi_Luoi();
            //
            double tong = Convert.ToDouble(ThucthiSQL.DocBang("SELECT Tong_tien FROM tblHDB WHERE Ma_HDB = N'" +
                txtMa_HDB.Text + "'").Rows[0][0].ToString());
            double tongmoi = tong + Convert.ToDouble(txtTong_tien.Text);
            sql = "UPDATE tblHDB SET Tong_tien =" + tongmoi + "WHERE Ma_HDB = N'" + txtMa_HDB.Text + "'";
            ThucthiSQL.CapNhatDuLieu(sql);
            txtTongtien.Text = tongmoi.ToString();
            //
            double sl = Convert.ToDouble(ThucthiSQL.DocBang("SELECT So_luong FROM dboMay_vi_tinh WHERE Ma_mayVT=N'" +
               cboMa_mayVT.Text + "'").Rows[0][0].ToString());
            double slmoi = sl - Convert.ToDouble(txtSo_luong.Text);
            sql = "UPDATE dboMay_vi_tinh SET So_luong=" + slmoi + "WHERE Ma_mayVT=N'" + cboMa_mayVT.Text + "'";
            ThucthiSQL.CapNhatDuLieu(sql);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMa_HDB.Text = "";
            txtMa_HDB.Focus();
            cboMaNV.Text = "";
            cboMaKH.Text = "";
            dtpNgayban.Text = "";
            txtSo_luong.Text = "";
            txtDon_gia.Text = "";
            txtMa_HDB.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnDong.Enabled = true;
            txtMa_HDB.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtMa_HDB.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Hóa Đơn nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa_HDB.Focus();
                return;
            }
            if (dtpNgayban.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayban.Focus();
                return;
            }
            if (cboMaKH.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaKH.Focus();
                return;
            }
            if (cboMaNV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNV.Focus();
                return;
            }

            sql = "INSERT INTO tblHDB(Ma_HDB,Ngayban,MaNV,MaKH,Tong_tien) VALUES(N'" + txtMa_HDB.Text.Trim() + "'," +
                "N'" + dtpNgayban.Value.ToShortDateString() + "',N'" + cboMaNV.Text.Trim() + "',N'" + cboMaKH.Text.Trim() + "',N'" + txtTong_tien.Text + "')";
            ThucthiSQL.CapNhatDuLieu(sql);
            btnLuu.Enabled = false;
            grbChitiet.Enabled = true;


        }

        private void txtSo_luong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg;
            if (txtSo_luong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSo_luong.Text);
            if (txtDon_gia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDon_gia.Text);
            tt = sl * dg;
            txtTong_tien.Text = tt.ToString();
        }

        private void dataGridView_HDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa_HDB.Text = dataGridView_HDB.CurrentRow.Cells["MaHDN"].Value.ToString();
            cboMa_mayVT.Text = dataGridView_HDB.CurrentRow.Cells["MaMayVT"].Value.ToString();
            txtSo_luong.Text = dataGridView_HDB.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtTen_mayVT.Text = dataGridView_HDB.CurrentRow.Cells["TenMayVT"].Value.ToString();
            txtDon_gia.Text = dataGridView_HDB.CurrentRow.Cells["ThanhTien"].Value.ToString();

            txtMa_HDB.Enabled = false;
            cboMa_mayVT.Enabled = false;
        }

        private void cboMa_mayVT_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboMa_mayVT.Text == "")
            {
                txtTen_mayVT.Text = "";
                txtBaohanh.Text = "";
                return;

            }
            sql = " SELECT Ten_mayVT,Gia_ban,Thoi_han_BH FROM dboMay_vi_tinh WHERE Ma_mayVT=N'" + cboMa_mayVT.Text + "'";
            DataTable table = ThucthiSQL.DocBang(sql);
            if (table.Rows.Count > 0)
            {

                txtTen_mayVT.Text = table.Rows[0][0].ToString();
                txtDon_gia.Text = table.Rows[0][1].ToString();
                txtBaohanh.Text = table.Rows[0][2].ToString();
            }

        }

        private void cboMaKH_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboMaKH.Text == "")
            {
                txtTenKH.Text = "";
                return;

            }
            sql = " SELECT TenKH FROM tblKhach_hang WHERE MaKH=N'" + cboMaKH.Text + "'";
            DataTable table = ThucthiSQL.DocBang(sql);
            if (table.Rows.Count > 0)
            {
                txtTenKH.Text = table.Rows[0][0].ToString();
            }
        }

        private void cboMaNV_TextUpdate(object sender, EventArgs e)
        {

        }

        private void cboMa_mayVT_DropDown(object sender, EventArgs e)
        {
            cboMa_mayVT.DataSource = ThucthiSQL.DocBang("Select Ma_mayVT From dboMay_vi_tinh");
            cboMa_mayVT.ValueMember = "Ma_mayVT";
            cboMa_mayVT.SelectedIndex = -1;
        }

        private void cboMaNV_DropDown(object sender, EventArgs e)
        {
            cboMaNV.DataSource = ThucthiSQL.DocBang("Select MaNV From tblNhan_vien");
            cboMaNV.ValueMember = "MaNV";
            cboMaNV.SelectedIndex = -1;
        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaKH_DropDown(object sender, EventArgs e)
        {
            cboMaKH.DataSource = ThucthiSQL.DocBang("Select MaKH From tblKhach_hang");
            cboMaKH.ValueMember = "MaKH";
            cboMaKH.SelectedIndex = -1;
        }
        private void DelUpdateSo_luongMVT(string ma_mayVTxoa, double slxoa, double giabanxoa)
        {
            //Cập nhập số lượng máy tính vào bảng máy vi tính  theo công thức
            //Slmoi= slg trong bảng máy vi tính - slg đã bị xóa
            double sl = Convert.ToDouble(ThucthiSQL.DocBang("SELECT So_luong FROM dboMay_vi_tinh WHERE Ma_mayVT=N'" + ma_mayVTxoa + "'").Rows[0][0].ToString());
            double slmoi = sl - slxoa;
            string sql = "UPDATE dboMay_vi_tinh SET So_luong=" + slmoi + "WHERE Ma_mayVT=N'" + ma_mayVTxoa + "'";
            ThucthiSQL.CapNhatDuLieu(sql);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT Ma_HDB, So_luong, Ma_mayVT FROM tblChitietHDB WHERE Ma_HDB = N'" + txtMa_HDB.Text + "'";
                DataTable tbl = ThucthiSQL.DocBang(sql);
                sql = "DELETE tblHDB WHERE Ma_HDB = N'" + txtMa_HDB.Text + "'";
                ThucthiSQL.CapNhatDuLieu(sql);
                ResetValues();
                Hienthi_Luoi();
                // cập nhật lại số lượng máy tính 
                for (int i = 0; i < tbl.Rows.Count; i++)
                    DelUpdateSo_luongMVT(tbl.Rows[i][0].ToString(),
                    Convert.ToDouble(tbl.Rows[0][1]),
                    Convert.ToDouble(tbl.Rows[0][2]));
                btnHuy.Enabled = false;
            }

        }

        private void grbChitiet_Enter(object sender, EventArgs e)
        {

        }

        private void cboMaNV_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboMaNV.Text == "")
            {
                txtTenNV.Text = "";
                return;

            }
            sql = " SELECT TenNV FROM tblNhan_vien WHERE MaNV=N'" + cboMaNV.Text + "'";
            DataTable table = ThucthiSQL.DocBang(sql);
            if (table.Rows.Count > 0)
            {
                txtTenNV.Text = table.Rows[0][0].ToString();
            }
        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
