using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;
using QlyCHVT;

namespace Ktra2_QuanlyMT.Forms
{
    public partial class frmBaoCaoHDB : Form
    {
        private readonly object txtMa_HDB;
        private readonly object txtMaHDBan;

        public frmBaoCaoHDB()
        {
            InitializeComponent();
        }

        private void frmBaoCaoHDB_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {

            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaoCao_Click_1(object sender, EventArgs e)
        {
            int dau, cuoi;
            dau = 0;
            cuoi = 0;

            if ((cboQuy.Text == "") || (txtNam.Text == "") || (txtNguoiBC.Text == ""))
            {
                MessageBox.Show("Hãy nhập đầy đủ tên, quý và năm!!!", "Yeu cau ...",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nam = Convert.ToInt32(txtNam.Text);
            int namhientai = DateTime.Now.Year;
            if (nam < 2000 || nam > namhientai)
            {
                MessageBox.Show("Năm bạn nhập không hợp lệ!!! (Năm nhập từ 2000 đến " + DateTime.Now.Year + ")", "Yeu cau nhap lai",
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
            

            DataTable tblH;
            
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;

            int hang = 0, cot = 0;

            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];

            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5;

            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

            exRange.Range["A1:B1"].Value = "Cửa hàng máy tính";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Cầu Giấy - Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)38272525";

            exRange.Range["B6:F7"].Font.Size = 16;
            exRange.Range["B6:F7"].Font.Name = "Times new roman";
            exRange.Range["B6:F7"].Font.Bold = true;
            exRange.Range["B6:F7"].Font.ColorIndex = 3;

            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["B7:F7"].MergeCells = true;

            exRange.Range["B6:F7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;

            exRange.Range["C6:E6"].Value = "DANH SÁCH HÓA ĐƠN ";
            exRange.Range["B7:F7"].Value = "CÓ TỔNG TIỀN MUA HÀNG TRONG QUÝ " + quy + " NĂM " + nam + "";
            // Biểu diễn thông tin của hóa đơn bán
            string sql;
            sql = "SELECT * FROM tblHDB JOIN tblChitietHDB ON tblChitietHDB.Ma_HDB=tblHDB.Ma_HDB WHERE (YEAR(tblHDB.NgayBan)=" + txtNam.Text + ")  AND (MONTH(tblHDB.NgayBan) BETWEEN  " + dau + " AND " + cuoi + ")";
            tblH = ThucthiSQL.DocBang(sql);
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";

            for (hang = 0; hang <= tblH.Rows.Count - 1; hang++)
            {
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= 4; cot++)
                    exSheet.Cells[cot + 2][hang + 12] = tblH.Rows[hang][cot].ToString();
            }

            exRange = exSheet.Cells[4][hang + 17];
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

            exSheet.Name = "Hóa đơn";
            exApp.Visible = true;
        }

        private void frmBaoCaoHDB_Load_1(object sender, EventArgs e)
        {

        }
    }
}


