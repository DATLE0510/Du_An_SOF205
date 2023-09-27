namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailAddress = txtEmail.Text.Trim();
            int atIndex = emailAddress.IndexOf("@"); // Tìm vị trí của ký tự "@"

            if (atIndex != -1)
            {
                string username = emailAddress.Substring(0, atIndex); // Cắt từ đầu chuỗi đến vị trí của "@"
                MessageBox.Show("Tên người dùng là: " + username, "Kết Quả");
            }
            else
            {
                MessageBox.Show("Địa chỉ email không hợp lệ.", "Lỗi");
            }
        }   
    }
}