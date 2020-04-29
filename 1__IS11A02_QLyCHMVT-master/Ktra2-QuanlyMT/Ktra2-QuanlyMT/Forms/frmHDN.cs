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
    public partial class frmHDN : Form
    {
        public frmHDN()
        {
            InitializeComponent();
        }
        private void Hienthi_Luoi()
        {
            string sql;
            sql = "SELECT Ma_mayVT,So_luong,Don_gia,Thanh_tien FROM tblChitietHDN WHERE Ma_HDN = N'" +
                txtMahoadon.Text + "'";
            dataGridView_HDN.DataSource = ThucthiSQL.DocBang(sql);
            dataGridView_HDN.Columns[0].HeaderText = "Mã máy tính";
            dataGridView_HDN.Columns[1].HeaderText = "Số lượng ";
            dataGridView_HDN.Columns[2].HeaderText = "Đơn giá";
            dataGridView_HDN.Columns[3].HeaderText = "Thành tiền";
            dataGridView_HDN.Columns[0].Width = 80;
            dataGridView_HDN.Columns[1].Width = 130;
            dataGridView_HDN.Columns[2].Width = 80;
            dataGridView_HDN.Columns[3].Width = 90;
            dataGridView_HDN.AllowUserToAddRows = false;
            dataGridView_HDN.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void frmHDB_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            txtTenNV.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            txtTong_tien.ReadOnly = true;
            txtTong_tien.Text = "0";
            dataGridView_HDN.Enabled = false;
            grbChitiet.Enabled = false;
            txtMahoadon.ReadOnly = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMahoadon.Text = "";
            txtMahoadon.Focus();
            cboMaNV.Text = "";
            cboMaNCC.Text = "";
            dtpNgay_nhap.Text = "";
            txtSo_luong.Text = "";
            txtDon_gia.Text = "";
            txtThanh_tien.Text = "";
            txtMahoadon.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnDong.Enabled = true;
            txtMahoadon.ReadOnly = false;
        }

        private void cboMaNV_DropDown(object sender, EventArgs e)
        {
            cboMaNV.DataSource = ThucthiSQL.DocBang("Select MaNV From tblNhan_vien");
            cboMaNV.ValueMember = "MaNV";
            cboMaNV.SelectedIndex = -1;
        }

        private void cboMaNCC_DropDown(object sender, EventArgs e)
        {
            cboMaNCC.DataSource = ThucthiSQL.DocBang("Select MaNCC From tblNCC");
            cboMaNCC.ValueMember = "MaNCC";
            cboMaNCC.SelectedIndex = -1;
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

        private void cboMaNCC_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboMaNCC.Text == "")
            {
                txtTenNCC.Text = "";
                return;

            }
            sql = " SELECT TenNCC FROM tblNCC WHERE MaNCC=N'" + cboMaNCC.Text + "'";
            DataTable table = ThucthiSQL.DocBang(sql);
            if (table.Rows.Count > 0)
            {
                txtTenNCC.Text = table.Rows[0][0].ToString();
            }
        }
        private void ResetValues()
        {
            txtMahoadon.Text = "";
            dtpNgay_nhap.Text = DateTime.Now.ToShortDateString();
            cboMaNV.Text = "";
            cboMaNCC.Text = "";
            txtTong_tien.Text = "0";
            cboMamayvitinh.Text = "";
            txtSo_luong.Text = "";
            txtDon_gia.Text = "";
            txtThanh_tien.Text = "0";
        }
        private void ResetValuesMaytinh()
        {
            cboMamayvitinh.Text = "";
            txtSo_luong.Text = "";
            txtDon_gia.Text = "";
        }
        
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
                if (cboMamayvitinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã máy vi tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMamayvitinh.Focus();
                return;
            }
            if ((txtSo_luong.Text.Trim().Length == 0) || (txtSo_luong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo_luong.Text = "";
                txtSo_luong.Focus();
                return;
            }
            if (txtDon_gia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDon_gia.Text = "";
                txtDon_gia.Focus();
                return;
            }
            string sql = "SELECT Ma_mayVT FROM tblChitietHDN WHERE Ma_mayVT=N'" + cboMamayvitinh.Text +
                "' AND Ma_HDN = N'" + txtMahoadon.Text.Trim() + "'";
            if (ThucthiSQL.DocBang(sql).Rows.Count > 0)
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValuesMaytinh();
                cboMamayvitinh.Focus();
                return;
            }

            sql = "INSERT INTO tblChitietHDN(Ma_HDN,Ma_mayVT,So_luong,Don_gia,Thanh_tien) VALUES(N'" +
                txtMahoadon.Text.Trim() + "','" + cboMamayvitinh.Text.ToString() + "'," + txtSo_luong.Text +
                "," + txtDon_gia.Text + "," + txtThanh_tien.Text + ")";
            ThucthiSQL.CapNhatDuLieu(sql);
            Hienthi_Luoi();
            //
            double tong = Convert.ToDouble(ThucthiSQL.DocBang("SELECT Thanh_tien FROM tblHDN WHERE Ma_HDN=N'" +
                txtMahoadon.Text + "'").Rows[0][0].ToString());
            double tongmoi = tong + Convert.ToDouble(txtThanh_tien.Text);
            sql = "UPDATE tblHDN SET Thanh_tien =" + tongmoi + "WHERE Ma_HDN=N'" + txtMahoadon.Text + "'";
            ThucthiSQL.CapNhatDuLieu(sql);
           //
            double sl = Convert.ToDouble(ThucthiSQL.DocBang("SELECT So_luong FROM dboMay_vi_tinh WHERE Ma_mayVT=N'" +
                cboMamayvitinh.Text + "'").Rows[0][0].ToString());
            double slmoi = sl + Convert.ToDouble(txtSo_luong.Text);
            sql = "UPDATE dboMay_vi_tinh SET So_luong=" + slmoi + "WHERE Ma_mayVT=N'" + cboMamayvitinh.Text + "'";
            ThucthiSQL.CapNhatDuLieu(sql);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtpNgay_nhap.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgay_nhap.Focus();
                return;
            }
            if (cboMaNV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNV.Focus();
                return;
            }
            if (cboMaNCC.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaNCC.Focus();
                return;
            }
            sql = "INSERT INTO tblHDN(Ma_HDN,MaNV,MaNCC,Ngay_nhap,Thanh_tien) VALUES(N'" +
            txtMahoadon.Text.Trim() + "',N'" + cboMaNV.Text + "',N'" +
            cboMaNCC.Text + "',N'" + dtpNgay_nhap.Value.ToShortDateString() + "'," + txtTong_tien.Text + ")";
            ThucthiSQL.CapNhatDuLieu(sql);
            btnLuu.Enabled = false;
            grbChitiet.Enabled = true;
        }

        

        private void txtDon_gia_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboMamayvitinh_DropDown(object sender, EventArgs e)
        {
            cboMamayvitinh.DataSource = ThucthiSQL.DocBang("Select Ma_mayVT From dboMay_vi_tinh");
            cboMamayvitinh.ValueMember = "Ma_mayVT";
            cboMamayvitinh.SelectedIndex = -1;
        }

        private void cboMamayvitinh_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cboMamayvitinh.Text == "")
            {
                txtTenmaytinh.Text = "";
                txtDon_gia.Text = "";
                return;

            }
            sql = " SELECT Ten_mayVT,Gia_nhap FROM dboMay_vi_tinh WHERE Ma_mayVT=N'" + cboMamayvitinh.Text + "'";
            DataTable table = ThucthiSQL.DocBang(sql);
            if (table.Rows.Count > 0)
            {

                txtTenmaytinh.Text = table.Rows[0][0].ToString();
                txtDon_gia.Text = table.Rows[0][1].ToString();
            }
        }

        private void cboMamayvitinh_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            txtThanh_tien.Text = tt.ToString();
        }

        private void txtTong_tien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
