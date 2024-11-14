using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLiMayBay
{
    public partial class ThemMayBay : Form
    {
        private readonly DatabaseConnection dbConnection;

        public ThemMayBay()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
        }

        // Sự kiện nhấp vào nút "Thêm Máy Bay"
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các ô nhập liệu
            string tenMayBay = txtTenMayBay.Text;
            bool isNamSXValid = int.TryParse(txtNamSanXuat.Text, out int namSX);
            bool isSoGioBayValid = float.TryParse(txtSoGioBay.Text, out float soGioBay);

            // Kiểm tra các giá trị nhập vào
            if (string.IsNullOrWhiteSpace(tenMayBay) || !isNamSXValid || !isSoGioBayValid)
            {
                MessageBox.Show("Vui lòng nhập thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Câu lệnh SQL thêm máy bay mới
            string query = "INSERT INTO MayBay (TenMayBay, NamSX, SoGioBay) VALUES (@tenMayBay, @namSX, @soGioBay)";
            SqlParameter[] parameters = {
                new SqlParameter("@tenMayBay", tenMayBay),
                new SqlParameter("@namSX", namSX),
                new SqlParameter("@soGioBay", soGioBay)
            };

            // Thực thi lệnh thêm máy bay
            bool isSuccess = dbConnection.ThucThiLenh(query, parameters);
            if (isSuccess)
            {
                MessageBox.Show("Thêm máy bay thành công!");
                this.Close(); // Đóng form sau khi thêm thành công
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm máy bay.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
