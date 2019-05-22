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


namespace QLSV_DEMO
{
    public partial class FormMain : Form
    {
        public  SqlConnection m_Connection;
        public  string m_ConnectionString = @"server ='DESKTOP-OQ444LJ\VTF' ;database ='QLSV2019' ;Integrated Security = true";//;Integrated Security = false ;User ID=sa;password=vtf
        public FormMain()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            UCs.UC_SinhVien ucSinhVien = new UCs.UC_SinhVien();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(ucSinhVien);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCs.UC_Lop ucSinhVien = new UCs.UC_Lop();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(ucSinhVien);
        }
    }
}
