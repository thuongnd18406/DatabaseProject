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
    public partial class FormTeacher : Form 
    {
        bool _isNew = true; // Nếu là true thì thêm mới dữ liệu, false thì cập nhật dữ liệu
        int _idteacher = 0;// Mã dòng helpdesk mà người dùng chọn
        DataTable dtTeacher = new DataTable(); // Dữ liệu lưu vào DataGridView 
        //DataTable dtRequest = new DataTable();  // Dữ liệu lưu vào Combobox //Chưa cần
        
      
        public FormTeacher()
        {
            InitializeComponent();
        }
        private void Teacher_Load(object sender, EventArgs e)
        {
            //tbTimkiem.Focus();
            //cbTinhTrangSeach.SelectedIndex = 0;
            LoadTeacher(); // Nạp trước
            LoadInfoTeacher();// Mới tới lưới dữ liệu
            //AddNewData();  // Mặc định form ban đầu là thêm mới         
        }               
      
        private void LoadTeacher()
        {
            //String id_teacher = "";
            /* SqlParameter[] sqlParams = {
                 new SqlParameter("@ID_Teacher", _idteacher)
             };*/
           
            String sql = "select * from tblStudent";
            //SqlCommand com = new SqlCommand(sql, c);
            dtTeacher.Clear();
            dtTeacher = Libs.Database.Data.ExcuteToDataTable("REQUEST_SELECTALL", CommandType.StoredProcedure);
            dgvDanhSachGiaoVien.DataSource = dtTeacher;
            dgvDanhSachGiaoVien.ClearSelection();
        }

        private void LoadInfoTeacher()
        {
            throw new NotImplementedException();
        }
    }
}
