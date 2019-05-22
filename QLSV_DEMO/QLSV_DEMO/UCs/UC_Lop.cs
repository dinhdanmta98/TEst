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
    public partial class UC_Lop : UserControl
    {
        
        public UC_Lop()
        {
            InitializeComponent();
        }
       
        private void UC_Lop_Load(object sender, EventArgs e)
        {
            Global_DAL truyVanTT = new Global_DAL();
            if(truyVanTT.isConnected())
            {
                DataTable ketqua = truyVanTT.Get_table("SELECT * FROM Lop");
                dataGridView1.DataSource = ketqua;
            }
            else
            {
                MessageBox.Show("CHƯA KẾT NỐI ĐÂU");
            }
        }
    }
}
