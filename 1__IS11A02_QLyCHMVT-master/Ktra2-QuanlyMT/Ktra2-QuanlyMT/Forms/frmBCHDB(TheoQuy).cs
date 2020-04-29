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
    public partial class frmBCHDB_TheoQuy_ : Form
    {
        public frmBCHDB_TheoQuy_()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmBCHDB_TheoQuy__Load(object sender, EventArgs e)
        {

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            int dau, cuoi;
            dau = 0;
            cuoi = 0;
            if ((txtNam.Text == "") || (txtNguoiBC.Text == ""))
            {
                MessageBox.Show("Hãy nhập đầy đủ tên,thời gian !!!", "Yêu cầu ...",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int nam = Convert.ToInt32(txtNam.Text);
            int namhientai = DateTime.Now.Year;
            if (nam < 2000 || nam > namhientai)
            {
                MessageBox.Show("Năm bạn nhập không hợp lệ!!! (Năm nhập từ 2000 đến " + DateTime.Now.Year + ")", "Yeu cau ...",
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
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblHT;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Cửa Hàng Máy Tính NiceT2 ";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Chùa Bộc- Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)310510551";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "Danh sách Hóa Đơn Bán Theo Quy " + quy + " NĂM " + nam + "";

            //Lấy thông tin hóa đơn
            sql = "SELECT a.Ma_HDB,b.Ma_mayVT,b.Ten_mayVT,b.Thoi_han_BH,a.So_luong,a.Thanh_tien FROM tblChitietHDB as a, dboMay_vi_tinh as b,tblHDB as c WHERE a.Ma_mayVT=b.Ma_mayVT and a.Ma_HDB = c.Ma_HDB AND (YEAR(c.NgayBan)=" + txtNam.Text + ") AND (MONTH(c.NgayBan) BETWEEN  " + dau + " AND " + cuoi +" )";
            tblHT = ThucthiSQL.DocBang(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Mã Hóa Đơn";
            exRange.Range["C11:C11"].Value = "Mã Máy";
            exRange.Range["D11:D11"].Value = "Tên Máy";
            exRange.Range["E11:E11"].Value = "Thời Hạn Bảo Hành";
            exRange.Range["F11:F11"].Value = "Số Lương";
            exRange.Range["G11:G11"].Value = "Thành tiền";

            for (hang = 0; hang <= tblHT.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblHT.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblHT.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[cot][hang + 17];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = DateTime.Now;
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Người lập báo cáo";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = txtNguoiBC.Text;
            exSheet.Name = "Hóa Đơn Bán";
            exApp.Visible = true;
        }
    }
}
