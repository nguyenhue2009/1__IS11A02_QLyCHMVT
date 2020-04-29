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
    public partial class frmMaytinh : Form
    {
        public frmMaytinh()
        {
            InitializeComponent();
        }
        private void Hienthi_Luoi()
        {
            string sql;
            DataTable tblMT;
            sql = "SELECT Ma_mayVT,Ten_mayVT,Ma_hang_SX,Ma_loai_may,Ma_RAM,Ma_chip,Ma_MH,Ma_co_MH,Ma_o_Cung,Ma_dungluong,Ma_chuot,Ma_ban_phim,So_luong,Gia_nhap,Gia_ban FROM  dboMay_vi_tinh";
            tblMT = ThucthiSQL.DocBang(sql);
            DataGridView.DataSource = tblMT;
            DataGridView.Columns[0].HeaderText = "Mã Máy Tính";
            DataGridView.Columns[1].HeaderText = "Tên Máy Tính";
            DataGridView.Columns[2].HeaderText = "Hãng Sản Xuất";
            DataGridView.Columns[3].HeaderText = "Mã Loại Máy";
            DataGridView.Columns[4].HeaderText = "RAM";
            DataGridView.Columns[5].HeaderText = "Chip";
            DataGridView.Columns[6].HeaderText = "Màn hình";
            DataGridView.Columns[7].HeaderText = "Kích cỡ";
            DataGridView.Columns[8].HeaderText = "Loại ổ cứng";
            DataGridView.Columns[9].HeaderText = "Dung Lượng";
            DataGridView.Columns[10].HeaderText = "Chuột";
            DataGridView.Columns[11].HeaderText = "Bàn Phím";
            DataGridView.Columns[12].HeaderText = "Số Lượng";
            DataGridView.Columns[13].HeaderText = "Giá Nhập";
            DataGridView.Columns[14].HeaderText = "Giá Bán";
            DataGridView.Columns[0].Width = 50;
            DataGridView.Columns[1].Width = 120;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 50;
            DataGridView.Columns[4].Width = 50;
            DataGridView.Columns[5].Width = 70;
            DataGridView.Columns[6].Width = 60;
            DataGridView.Columns[7].Width = 60;
            DataGridView.Columns[8].Width = 60;
            DataGridView.Columns[9].Width = 60;
            DataGridView.Columns[10].Width = 100;
            DataGridView.Columns[11].Width = 100;
            DataGridView.Columns[12].Width = 40;
            DataGridView.Columns[13].Width = 70;
            DataGridView.Columns[14].Width = 70;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            tblMT.Dispose();
        }

        private void frmMaytinh_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaMT.Enabled = true;
            txtMaMT.Focus();
            txtNSX.Text = "";
            cboLoaimay.Text = "";
            txtGiaNhap.Text = "0";
            txtGiaBan.Text = "0";
            txtSoluong.Text = "0";
            txtMaMT.Text = "";
            cboKichthuoc.Text = "";
            cboLoaimay.Text = "";
            cboLoaiocung.Text = "";
            cboManhinh.Text = "";
            cboRAM.Text = "";
            txtBanphim.Text = "";
            txtChip.Text = "";
            txtChuot.Text = "";
            cboOcung.Text = "";
            txtTenmaytinh.Text = "";
            txtSoluong.Enabled = true;
            txtGiaNhap.Enabled = true;
            txtGiaNhap.Enabled = true;
            btnHuy.Enabled = true;
            btnDong.Enabled = true;
            DataGridView.DataSource = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            if (txtMaMT.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã máy tính", "Thông báo");
                txtMaMT.Focus();
                return;
            }
            
            String sql;
            sql = " SELECT Ma_mayVT FROM dboMay_vi_tinh WHERE Ma_mayVT=N'" + txtMaMT.Text + "'";
            DataTable dt = ThucthiSQL.DocBang(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã này đã có, bạn phải nhập mã khác", "Thông báo");
                txtMaMT.Focus();
                txtMaMT.Text = "";
            }
            sql = "INSERT INTO dboMay_vi_tinh(Ma_mayVT,Ten_mayVT,Ma_hang_SX,Ma_loai_may,Ma_RAM,Ma_chip,Ma_MH,Ma_co_MH,Ma_o_cung,Ma_dungluong,Ma_chuot,Ma_ban_phim,Thoi_han_BH,So_luong,Gia_nhap,Gia_ban) VALUES (N'" +
            txtMaMT.Text + "',N'" + txtTenmaytinh.Text + "',N'" + txtNSX.Text + "',N'" + cboLoaimay.Text + "',N'" + cboRAM.Text + "',N'" + txtChip.Text + "',N'" + cboManhinh.Text + "',N'" + cboKichthuoc.Text + "',N'" + cboLoaiocung.Text + "',N'" + cboOcung.Text + "',N'" + txtChuot.Text + "',N'" + txtBanphim.Text + "'," + txtBaoHanh.Text + "," + txtSoluong.Text + "," + txtGiaNhap.Text + "," + txtGiaBan.Text + ")";
            ThucthiSQL.CapNhatDuLieu(sql);
            Hienthi_Luoi();
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            txtMaMT.Enabled = false;
            if (DataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nào để sửa");
                return;
            }
            txtMaMT.Text = DataGridView.CurrentRow.Cells["Ma_mayVT"].Value.ToString();
            cboLoaimay.Text = DataGridView.CurrentRow.Cells["Ma_loai_may"].Value.ToString();
            txtTenmaytinh.Text = DataGridView.CurrentRow.Cells["Ten_mayVT"].Value.ToString();
            txtChip.Text = DataGridView.CurrentRow.Cells["Ma_chip"].Value.ToString();
            cboManhinh.Text = DataGridView.CurrentRow.Cells["Ma_MH"].Value.ToString();
            cboKichthuoc.Text = DataGridView.CurrentRow.Cells["Ma_co_MH"].Value.ToString();
            cboLoaiocung.Text = DataGridView.CurrentRow.Cells["Ma_o_cung"].Value.ToString();
            cboOcung.Text = DataGridView.CurrentRow.Cells["Ma_dungluong"].Value.ToString();
            txtChuot.Text = DataGridView.CurrentRow.Cells["Ma_chuot"].Value.ToString();
            txtBanphim.Text = DataGridView.CurrentRow.Cells["Ma_ban_phim"].Value.ToString();
            txtNSX.Text = DataGridView.CurrentRow.Cells["Ma_hang_SX"].Value.ToString();
            cboRAM.Text = DataGridView.CurrentRow.Cells["Ma_Ram"].Value.ToString();
            txtSoluong.Text = DataGridView.CurrentRow.Cells["So_luong"].Value.ToString();
            txtGiaNhap.Text = DataGridView.CurrentRow.Cells["Gia_nhap"].Value.ToString();
            txtGiaBan.Text = DataGridView.CurrentRow.Cells["Gia_ban"].Value.ToString();
            StartPosition = FormStartPosition.CenterScreen;
            Show();
        }
        
        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            double gn,gb,sl;
            if (txtSoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoluong.Text);
            if (txtGiaNhap.Text == "")
                gn = 0;
            else
                gn = Convert.ToDouble(txtGiaNhap.Text);
            gb = gn*10/100+gn; 
            txtGiaBan.Text = gb.ToString();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Hienthi_Luoi();
        }

        private void cboLoaimay_TextChanged(object sender, EventArgs e)
        {

            if (cboLoaimay.Text == "Laptop")
            {
                txtBanphim.ReadOnly = true;
                txtChuot.ReadOnly = true;
            }
            else
            {
                txtBanphim.ReadOnly = false;
                txtChuot.ReadOnly = false;
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (DataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa", "Thông báo");
                return;
            }
            string ma = DataGridView.CurrentRow.Cells["Ma_mayVT"].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sql = "DELETE dboMay_vi_tinh WHERE Ma_mayVT=N'" + ma + "'";
                ThucthiSQL.CapNhatDuLieu(sql);
                Hienthi_Luoi();
            }
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtNSX.Text = "";
            cboLoaimay.Text = "";
            txtGiaNhap.Text = "0";
            txtGiaBan.Text = "0";
            txtSoluong.Text = "0";
            txtMaMT.Text = "";
            cboKichthuoc.Text = "";
            cboLoaimay.Text = "";
            cboLoaiocung.Text = "";
            cboManhinh.Text = "";
            cboRAM.Text = "";
            txtBanphim.Text = "";
            txtChip.Text = "";
            txtChuot.Text = "";
            cboOcung.Text = "";
            txtTenmaytinh.Text = "";
            txtSoluong.Text = "";
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
