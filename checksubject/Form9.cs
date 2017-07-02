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
    public partial class Form9 : Form
    {
        public string id;
        public Form9(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        



        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“subjiectSelectionDataSet3.题目表”中。您可以根据需要移动或删除它。
            this.题目表TableAdapter.FillBy(this.subjiectSelectionDataSet3.题目表,id);
            // TODO: 这行代码将数据加载到表“subjiectSelectionDataSet2.题目表”中。您可以根据需要移动或删除它。
            //题目表TableAdapter.Update(this.subjiectSelectionDataSet3.题目表);

        }

       

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 题目表BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
