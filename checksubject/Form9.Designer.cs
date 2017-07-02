namespace checksubject
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.题目名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.要求DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.题目表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjiectSelectionDataSet3 = new checksubject.SubjiectSelectionDataSet3();
            this.题目表TableAdapter = new checksubject.SubjiectSelectionDataSet3TableAdapters.题目表TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.题目表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjiectSelectionDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.题目名DataGridViewTextBoxColumn,
            this.要求DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.题目表BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(206, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(443, 357);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // 题目名DataGridViewTextBoxColumn
            // 
            this.题目名DataGridViewTextBoxColumn.DataPropertyName = "题目名";
            this.题目名DataGridViewTextBoxColumn.HeaderText = "题目名";
            this.题目名DataGridViewTextBoxColumn.Name = "题目名DataGridViewTextBoxColumn";
            this.题目名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 要求DataGridViewTextBoxColumn
            // 
            this.要求DataGridViewTextBoxColumn.DataPropertyName = "要求";
            this.要求DataGridViewTextBoxColumn.HeaderText = "要求";
            this.要求DataGridViewTextBoxColumn.Name = "要求DataGridViewTextBoxColumn";
            this.要求DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 题目表BindingSource
            // 
            this.题目表BindingSource.DataMember = "题目表";
            this.题目表BindingSource.DataSource = this.subjiectSelectionDataSet3;
            this.题目表BindingSource.CurrentChanged += new System.EventHandler(this.题目表BindingSource_CurrentChanged);
            // 
            // subjiectSelectionDataSet3
            // 
            this.subjiectSelectionDataSet3.DataSetName = "SubjiectSelectionDataSet3";
            this.subjiectSelectionDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 题目表TableAdapter
            // 
            this.题目表TableAdapter.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 462);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.题目表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjiectSelectionDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SubjiectSelectionDataSet3 subjiectSelectionDataSet3;
        private System.Windows.Forms.BindingSource 题目表BindingSource;
        private SubjiectSelectionDataSet3TableAdapters.题目表TableAdapter 题目表TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 题目名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 要求DataGridViewTextBoxColumn;
    }
}