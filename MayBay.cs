using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiMayBay
{
    public partial class MayBay : Form
    {
        private readonly DatabaseConnection dbConnection;

        public MayBay()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            LoadMayBayData();
        }

        private void LoadMayBayData()
        {
            string query = "SELECT * FROM MayBay ORDER BY TenMayBay ASC";
            DataTable mayBayTable = dbConnection.LayDuLieu(query);

            if (mayBayTable != null)
            {
                dataGridViewMayBay.DataSource = mayBayTable;
            }
            else
            {
                MessageBox.Show("Lỗi khi tải dữ liệu máy bay.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMayBay_Click(object sender, EventArgs e)
        {
            using (ThemMayBay themMayBayForm = new ThemMayBay())
            {
                themMayBayForm.ShowDialog();
                LoadMayBayData();
            }
        }

        private void btnSuaMayBay_Click(object sender, EventArgs e)
        {
            if (dataGridViewMayBay.SelectedRows.Count > 0)
            {
                int maMB = Convert.ToInt32(dataGridViewMayBay.SelectedRows[0].Cells["MaMB"].Value);
                string tenMayBay = dataGridViewMayBay.SelectedRows[0].Cells["TenMayBay"].Value.ToString();
                int namSX = Convert.ToInt32(dataGridViewMayBay.SelectedRows[0].Cells["NamSX"].Value);
                float soGioBay = Convert.ToSingle(dataGridViewMayBay.SelectedRows[0].Cells["SoGioBay"].Value);

                using (SuaMayBay suaMayBayForm = new SuaMayBay(maMB, tenMayBay, namSX, soGioBay))
                {
                    suaMayBayForm.ShowDialog();
                    LoadMayBayData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một máy bay để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 
    } 
}
