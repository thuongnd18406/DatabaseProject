using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoneDoneDone
{
    public partial class FormStudents : Form
    {

        DataTable dtStudent = new DataTable();
        public FormStudents()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=THE_J4;Initial Catalog=HELPDESK;Integrated Security=True");
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from REQUEST";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void frmStudent_Load(object sender, EventArgs e)
        {
            //LoadPhongBan();
            //LoadRequest();
        }
        private void LoadRequest()
        {
            dtStudent.Clear();
            dtStudent = Libs.Database.Data.ExcuteToDataTable("REQUEST_SELECTALL", CommandType.StoredProcedure);
            dataGridView1.DataSource = dtStudent;

            // Không Select bất cứ dòng nào
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            //AddNewData();
        }
    }
}
