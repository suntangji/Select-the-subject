﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checksubject
{
    public partial class Form8 : Form
    {
        public string id;
        public Form8(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection("server =.\\SQLEXPRESS; database=select-the-topic; uid = sa; Pwd = a3252016"))
            {
                conn.Open();
                string sql = string.Format("select S.sno,sname,sdept,sclass,TP.tpname from S,XT,CT,TP where tno = {0}and CT.tpno =XT.tpno and XT.sno =S.sno and CT.tpno = TP.tpno", id); // select rpname,grade from UP,PY where sno = {0} and UP.rpname=PY.rpname",
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //MessageBox.Show(da.ToString());
                DataTable dt = new DataTable();
                // MessageBox.Show(dt.ToString());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }

        }


    
   

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

     
    

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
