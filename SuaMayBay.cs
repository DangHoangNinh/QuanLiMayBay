using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLiMayBay
{
    public partial class SuaMayBay : Form
    {
        private readonly DatabaseConnection dbConnection;
        private int maMB;

        public SuaMayBay(int maMB, string tenMayBay, int namSX, float soGioBay)
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            this.maMB = maMB;

            txtTenMayBay.Text = tenMayBay;
            txtNamSanXuat.Text = namSX.ToString();
            txtSoGioBay.Text = soGioBay.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenMayBay = txtTenMayBay.Text;
            bool isNamSXValid = int.TryParse(txtNamSanXuat.Text, out int namSX);
            bool isSoGioBayValid = float.TryParse(txtSoGioBay.Text, out float soGioBay);

            if (string.IsNullOrWhiteSpace(tenMayBay) || !isNamSXValid || !isSoGioBayValid)
            {
                MessageBox.Show("Vui lòng nhập thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "UPDATE MayBay SET TenMayBay = @tenMayBay, NamSX = @namSX, SoGioBay = @soGioBay WHERE MaMB = @maMB";
            SqlParameter[] parameters = {
                new SqlParameter("@tenMayBay", tenMayBay),
                new SqlParameter("@namSX", namSX),
                new SqlParameter("@soGioBay", soGioBay),
                new SqlParameter("@maMB", maMB)
            };

            bool isSuccess = dbConnection.ThucThiLenh(query, parameters);
            if (isSuccess)
            {
                MessageBox.Show("Cập nhật máy bay thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi khi cập nhật máy bay.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
