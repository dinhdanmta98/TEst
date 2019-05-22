using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSV_DEMO.UCs
{
    public partial class UC_SinhVien : UserControl
    {
       // public SqlConnection m_Connection;
       // public string m_ConnectionString = @"server ='DESKTOP-OQ444LJ\VTF' ;database ='QLSV2019' ;Integrated Security = true";//;Integrated Security = false ;User ID=sa;password=vtf
        public UC_SinhVien()
        {
            InitializeComponent();
        }
        
        private void UC_SinhVien_Load(object sender, EventArgs e)
        {
            Global_DAL truyVanTT = new Global_DAL();
            if (truyVanTT.isConnected())
            {
                DataTable ketqua = truyVanTT.Get_table("SELECT * FROM SinhVien");
                dataGridView1.DataSource = ketqua;
            }
            else
            {
                MessageBox.Show("CHƯA KẾT NỐI ĐÂU");
            }
            //// Bước 1: Đầu tiên mình phải thử xem có kết nối được không??
            ////sqlQuery_DAL LamViecVoiDB = new sqlQuery_DAL();
            //try
            //{
            //    if (m_Connection != null && m_Connection.State != ConnectionState.Open)
            //    {

            //        m_Connection.Open();
            //        MessageBox.Show("KẾT NỐI THÀNH CÔNG");
            //    }
            //    else if (m_Connection == null)
            //    {

            //        m_Connection = new SqlConnection();
            //        m_Connection.ConnectionString = m_ConnectionString;// DataAccessLayer.Properties.Settings.Default.ConnectionString; //st.ConnectionString
            //        m_Connection.Open();
            //        MessageBox.Show("KẾT NỐI THÀNH CÔNG");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Lỗi " + ex.Message);
            //}
            //// Bước 2: Thực thi truy vấn
            //string query = "SELECT * FROM SinhVien";
            //DataTable ketQua = Get_table(query);
            //dataGridView1.DataSource = ketQua;
        }
    }
}
