using System;
using System.Linq;
using System.Windows.Forms;
using QLSV.DAL;

namespace QLSV.GUI
{
    public partial class frmKhoaTest : Form
    {
        private readonly Model1 _db = new Model1();

        public frmKhoaTest()
        {
            InitializeComponent();
        }

        private void frmKhoaTest_Load(object sender, EventArgs e)
        {
            try
            {
                var list = _db.Khoa.ToList();

                MessageBox.Show($"Số bản ghi Khoa: {list.Count}");

                dgvKhoa.DataSource = null;
                dgvKhoa.DataSource = list;
                dgvKhoa.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }
    }
}
