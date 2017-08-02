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

namespace checksubject
{
    public partial class Form3 : Form
    {
        public string id;
        public Form3(string id)
        {
            InitializeComponent();
            this.id = id; 
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //MainForm f = new MainForm();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "server=.\\SQLExpress;uid=sa;pwd=a3252016;database=select-the-topic";
            con.Open();
            string sql = string.Format("select tname from T where tno='{0}'", id);
            SqlCommand cmd = new SqlCommand(sql, con);
            // cmd.Connection = con;
            // SqlDataReader dr = cmd.ExecuteReader();
            textBox1.Text = (string)cmd.ExecuteScalar();
            //if (dr.Read())
           // {

               // textBox1.Text = dr.ToString();
              
                con.Close();
                con.Dispose();  //释放连接

            // }
            
        }
       
        

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

      /*  private void button4_Click(object sender, EventArgs e)
        {

            this.panel1.Controls.Clear();
            Form8 f8 = new Form8(id);
            f8.button1.Visible = false;
            f8.TopLevel = false;    //设置为非顶级窗体
            f8.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
            f8.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel
            panel1.Controls.Add(f8);      //添加窗体
            f8.Show();					  //窗体运行
            
            

        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form7 f7 = new Form7(id);
            f7.TopLevel = false;    //设置为非顶级窗体
            f7.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
            f7.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel
            panel1.Controls.Add(f7);      //添加窗体
            f7.Show();					  //窗体运行

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form9 f9 = new Form9(id);
            f9.TopLevel = false;    //设置为非顶级窗体
            f9.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
            f9.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel
            panel1.Controls.Add(f9);      //添加窗体
            f9.Show();					  //窗体运行

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.panel1.Controls.Clear();
            Form10 f8 = new Form10(id);
            //f8.button1.Visible = false;
            f8.TopLevel = false;    //设置为非顶级窗体
            f8.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
            f8.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel
            panel1.Controls.Add(f8);      //添加窗体
            f8.Show();                    //窗体运行

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form11 f11 = new Form11(id);
            f11.TopLevel = false;    //设置为非顶级窗体
            f11.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
            f11.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel
            panel1.Controls.Add(f11);      //添加窗体
            f11.Show();					  //窗体运行

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Form8 f8 = new Form8(id);
            //f8.button1.Visible = false;
            f8.TopLevel = false;    //设置为非顶级窗体
            f8.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
            f8.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel
            panel1.Controls.Add(f8);      //添加窗体
            f8.Show();					  //窗体运行
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm f1 = new MainForm();
            f1.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            this.panel1.Controls.Clear();
            Form16 f8 = new Form16(id);
            //f8.button1.Visible = false;
            f8.TopLevel = false;    //设置为非顶级窗体
            f8.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //设置窗体为非边框样式
            f8.Dock = System.Windows.Forms.DockStyle.Fill;                  //设置样式是否填充整个panel
            panel1.Controls.Add(f8);      //添加窗体
            f8.Show();
        }
    }
}

