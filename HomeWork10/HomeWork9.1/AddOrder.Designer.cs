namespace HomeWork10
{
    partial class AddOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TelBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户名";
            // 
            // NumBox
            // 
            this.NumBox.Location = new System.Drawing.Point(140, 24);
            this.NumBox.Name = "NumBox";
            this.NumBox.Size = new System.Drawing.Size(100, 25);
            this.NumBox.TabIndex = 2;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(140, 60);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 25);
            this.NameBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "确认添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddInfo
            // 
            this.AddInfo.AutoSize = true;
            this.AddInfo.ForeColor = System.Drawing.Color.Red;
            this.AddInfo.Location = new System.Drawing.Point(94, 132);
            this.AddInfo.Name = "AddInfo";
            this.AddInfo.Size = new System.Drawing.Size(15, 15);
            this.AddInfo.TabIndex = 5;
            this.AddInfo.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "客户电话";
            // 
            // TelBox
            // 
            this.TelBox.Location = new System.Drawing.Point(140, 91);
            this.TelBox.Name = "TelBox";
            this.TelBox.Size = new System.Drawing.Size(100, 25);
            this.TelBox.TabIndex = 7;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.TelBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NumBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumBox;
        private System.Windows.Forms.TextBox NameBox;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label AddInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TelBox;
    }
}