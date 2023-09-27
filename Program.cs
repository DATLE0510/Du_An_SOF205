
//// Thêm thư viện Microsoft.Office.Interop.Excel vào dự án
//using System;
//using System.Windows.Forms;
//using Microsoft.Office.Interop.Excel;

//// Tạo một đối tượng ExcelApplication và mở file Excel
//private void openExcel()
//{
//    // Tạo đối tượng ExcelApplication
//    ExcelApplication objXL = new ExcelApplication();

//    // Mở file Excel
//    objXL.Workbooks.Open("data.xlsx");

//    // Lấy đối tượng Worksheet
//    Worksheet objSHT = objXL.ActiveSheet;
//}

//// Truy cập vào các ô dữ liệu
//private void fillData()
//{
//    // Lấy số dòng và số cột của trang tính
//    int rowCount = objSHT.Rows.Count;
//    int columnCount = objSHT.Columns.Count;

//    // Duyệt qua tất cả các ô dữ liệu
//    for (int i = 1; i <= rowCount; i++)
//    {
//        for (int j = 0; j < columnCount; j++)
//        {
//            // Lấy giá trị của ô dữ liệu
//            string value = objSHT.Cells[i, j].Value2.ToString();

//            // Hiển thị giá trị của ô dữ liệu
//            TextBox txtData = new TextBox();
//            txtData.Text = value;
//            txtData.Location = new Point(100, 100 * i + 20 * j);
//            txtData.Size = new Size(200, 20);
//            Controls.Add(txtData);
//        }
//    }
//}