namespace HomeWork9
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ImportButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchType = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FlushTable = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Label();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.typeOfProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOfProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToHTML = new System.Windows.Forms.Button();
            this.CreateDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(HomeWork6.Order);
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataSource = typeof(HomeWork6.OrderDetails);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "搜索依据";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 51);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 27);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "AllOrder.txt";
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(318, 51);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(72, 25);
            this.ExportButton.TabIndex = 6;
            this.ExportButton.Text = "导出";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "导出位置";
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(318, 21);
            this.ImportButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(70, 25);
            this.ImportButton.TabIndex = 3;
            this.ImportButton.Text = "导入";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "initOrder.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "导入位置";
            // 
            // SearchType
            // 
            this.SearchType.FormattingEnabled = true;
            this.SearchType.Items.AddRange(new object[] {
            "总金额",
            "订单号",
            "客户名",
            "产品种类"});
            this.SearchType.Location = new System.Drawing.Point(520, 21);
            this.SearchType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SearchType.Name = "SearchType";
            this.SearchType.Size = new System.Drawing.Size(137, 25);
            this.SearchType.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(667, 21);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 27);
            this.textBox3.TabIndex = 13;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(805, 18);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(81, 26);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "搜索";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SearchInfo
            // 
            this.SearchInfo.AutoSize = true;
            this.SearchInfo.ForeColor = System.Drawing.Color.Red;
            this.SearchInfo.Location = new System.Drawing.Point(1015, 54);
            this.SearchInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchInfo.Name = "SearchInfo";
            this.SearchInfo.Size = new System.Drawing.Size(0, 17);
            this.SearchInfo.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(77, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Log:";
            // 
            // FlushTable
            // 
            this.FlushTable.Location = new System.Drawing.Point(407, 91);
            this.FlushTable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FlushTable.Name = "FlushTable";
            this.FlushTable.Size = new System.Drawing.Size(109, 26);
            this.FlushTable.TabIndex = 9;
            this.FlushTable.Text = "刷新";
            this.FlushTable.UseVisualStyleBackColor = true;
            this.FlushTable.Click += new System.EventHandler(this.FlushTable_Click);
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Font = new System.Drawing.Font("宋体", 15F);
            this.Log.ForeColor = System.Drawing.Color.Red;
            this.Log.Location = new System.Drawing.Point(136, 93);
            this.Log.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(103, 25);
            this.Log.TabIndex = 20;
            this.Log.Text = "nothing";
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(407, 59);
            this.AddOrderButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(109, 26);
            this.AddOrderButton.TabIndex = 18;
            this.AddOrderButton.Text = "添加订单";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeOfProductDataGridViewTextBoxColumn,
            this.priceOfProductDataGridViewTextBoxColumn,
            this.amountOfProductDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.orderDetailsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(492, 149);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(443, 264);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // typeOfProductDataGridViewTextBoxColumn
            // 
            this.typeOfProductDataGridViewTextBoxColumn.DataPropertyName = "TypeOfProduct";
            this.typeOfProductDataGridViewTextBoxColumn.HeaderText = "TypeOfProduct";
            this.typeOfProductDataGridViewTextBoxColumn.Name = "typeOfProductDataGridViewTextBoxColumn";
            // 
            // priceOfProductDataGridViewTextBoxColumn
            // 
            this.priceOfProductDataGridViewTextBoxColumn.DataPropertyName = "PriceOfProduct";
            this.priceOfProductDataGridViewTextBoxColumn.HeaderText = "PriceOfProduct";
            this.priceOfProductDataGridViewTextBoxColumn.Name = "priceOfProductDataGridViewTextBoxColumn";
            // 
            // amountOfProductDataGridViewTextBoxColumn
            // 
            this.amountOfProductDataGridViewTextBoxColumn.DataPropertyName = "AmountOfProduct";
            this.amountOfProductDataGridViewTextBoxColumn.HeaderText = "AmountOfProduct";
            this.amountOfProductDataGridViewTextBoxColumn.Name = "amountOfProductDataGridViewTextBoxColumn";
            // 
            // moneyDataGridViewTextBoxColumn1
            // 
            this.moneyDataGridViewTextBoxColumn1.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn1.HeaderText = "Money";
            this.moneyDataGridViewTextBoxColumn1.Name = "moneyDataGridViewTextBoxColumn1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.telNumDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(448, 264);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // orderNumDataGridViewTextBoxColumn
            // 
            this.orderNumDataGridViewTextBoxColumn.DataPropertyName = "OrderNum";
            this.orderNumDataGridViewTextBoxColumn.HeaderText = "OrderNum";
            this.orderNumDataGridViewTextBoxColumn.Name = "orderNumDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // telNumDataGridViewTextBoxColumn
            // 
            this.telNumDataGridViewTextBoxColumn.DataPropertyName = "TelNum";
            this.telNumDataGridViewTextBoxColumn.HeaderText = "TelNum";
            this.telNumDataGridViewTextBoxColumn.Name = "telNumDataGridViewTextBoxColumn";
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Money";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            // 
            // AddProButton
            // 
            this.AddProButton.Location = new System.Drawing.Point(520, 59);
            this.AddProButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddProButton.Name = "AddProButton";
            this.AddProButton.Size = new System.Drawing.Size(129, 26);
            this.AddProButton.TabIndex = 17;
            this.AddProButton.Text = "添加产品条目";
            this.AddProButton.UseVisualStyleBackColor = true;
            this.AddProButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.Font = new System.Drawing.Font("仿宋", 13F);
            this.label4.Location = new System.Drawing.Point(175, 416);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 34);
            this.label4.TabIndex = 14;
            this.label4.Text = " 订单信息";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(520, 91);
            this.deleteOrderButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(129, 27);
            this.deleteOrderButton.TabIndex = 16;
            this.deleteOrderButton.Text = "删除当前行";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("仿宋", 13F);
            this.label5.Location = new System.Drawing.Point(667, 416);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 27);
            this.label5.TabIndex = 15;
            this.label5.Text = "订单详细";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CreateDatabase);
            this.panel1.Controls.Add(this.ToHTML);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.deleteOrderButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AddProButton);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.AddOrderButton);
            this.panel1.Controls.Add(this.Log);
            this.panel1.Controls.Add(this.FlushTable);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SearchInfo);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.SearchType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.ImportButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ExportButton);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("仿宋", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 489);
            this.panel1.TabIndex = 11;
            // 
            // ToHTML
            // 
            this.ToHTML.Location = new System.Drawing.Point(654, 59);
            this.ToHTML.Name = "ToHTML";
            this.ToHTML.Size = new System.Drawing.Size(92, 26);
            this.ToHTML.TabIndex = 21;
            this.ToHTML.Text = "转为HTML";
            this.ToHTML.UseVisualStyleBackColor = true;
            this.ToHTML.Click += new System.EventHandler(this.ToHTML_Click);
            // 
            // CreateDatabase
            // 
            this.CreateDatabase.Location = new System.Drawing.Point(654, 93);
            this.CreateDatabase.Name = "CreateDatabase";
            this.CreateDatabase.Size = new System.Drawing.Size(106, 24);
            this.CreateDatabase.TabIndex = 12;
            this.CreateDatabase.Text = "创建数据库";
            this.CreateDatabase.UseVisualStyleBackColor = true;
            this.CreateDatabase.Click += new System.EventHandler(this.CreateDatabase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 501);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("仿宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SearchType;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label SearchInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button FlushTable;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOfProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddProButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ToHTML;
        private System.Windows.Forms.Button CreateDatabase;
    }
}

