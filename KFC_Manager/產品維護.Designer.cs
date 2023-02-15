namespace KFC_Manager
{
    partial class 產品維護
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn刪除資料 = new System.Windows.Forms.Button();
            this.btn新增資料 = new System.Windows.Forms.Button();
            this.btn修改資料 = new System.Windows.Forms.Button();
            this.btn資料搜尋 = new System.Windows.Forms.Button();
            this.btn所有產品 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btn關鍵字搜尋 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.btn清空欄位);
            this.groupBox1.Controls.Add(this.btn刪除資料);
            this.groupBox1.Controls.Add(this.btn新增資料);
            this.groupBox1.Controls.Add(this.btn修改資料);
            this.groupBox1.Controls.Add(this.btn資料搜尋);
            this.groupBox1.Controls.Add(this.btn所有產品);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(152, 573);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能按鈕";
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.Location = new System.Drawing.Point(12, 327);
            this.btn清空欄位.Margin = new System.Windows.Forms.Padding(6);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(101, 37);
            this.btn清空欄位.TabIndex = 5;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = true;
            // 
            // btn刪除資料
            // 
            this.btn刪除資料.Location = new System.Drawing.Point(13, 278);
            this.btn刪除資料.Margin = new System.Windows.Forms.Padding(6);
            this.btn刪除資料.Name = "btn刪除資料";
            this.btn刪除資料.Size = new System.Drawing.Size(101, 37);
            this.btn刪除資料.TabIndex = 4;
            this.btn刪除資料.Text = "刪除資料";
            this.btn刪除資料.UseVisualStyleBackColor = true;
            // 
            // btn新增資料
            // 
            this.btn新增資料.Location = new System.Drawing.Point(12, 227);
            this.btn新增資料.Margin = new System.Windows.Forms.Padding(6);
            this.btn新增資料.Name = "btn新增資料";
            this.btn新增資料.Size = new System.Drawing.Size(101, 37);
            this.btn新增資料.TabIndex = 3;
            this.btn新增資料.Text = "新增資料";
            this.btn新增資料.UseVisualStyleBackColor = true;
            // 
            // btn修改資料
            // 
            this.btn修改資料.Location = new System.Drawing.Point(13, 178);
            this.btn修改資料.Margin = new System.Windows.Forms.Padding(6);
            this.btn修改資料.Name = "btn修改資料";
            this.btn修改資料.Size = new System.Drawing.Size(101, 37);
            this.btn修改資料.TabIndex = 2;
            this.btn修改資料.Text = "修改資料";
            this.btn修改資料.UseVisualStyleBackColor = true;
            // 
            // btn資料搜尋
            // 
            this.btn資料搜尋.Location = new System.Drawing.Point(13, 129);
            this.btn資料搜尋.Margin = new System.Windows.Forms.Padding(6);
            this.btn資料搜尋.Name = "btn資料搜尋";
            this.btn資料搜尋.Size = new System.Drawing.Size(101, 37);
            this.btn資料搜尋.TabIndex = 1;
            this.btn資料搜尋.Text = "資料搜尋";
            this.btn資料搜尋.UseVisualStyleBackColor = true;
            // 
            // btn所有產品
            // 
            this.btn所有產品.Location = new System.Drawing.Point(13, 80);
            this.btn所有產品.Margin = new System.Windows.Forms.Padding(6);
            this.btn所有產品.Name = "btn所有產品";
            this.btn所有產品.Size = new System.Drawing.Size(101, 37);
            this.btn所有產品.TabIndex = 0;
            this.btn所有產品.Text = "所有產品";
            this.btn所有產品.UseVisualStyleBackColor = true;
            this.btn所有產品.Click += new System.EventHandler(this.btn所有產品_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btn關鍵字搜尋);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cBoxCategory);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(167, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(345, 572);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "功能按鈕";
            // 
            // cBoxCategory
            // 
            this.cBoxCategory.FormattingEnabled = true;
            this.cBoxCategory.Location = new System.Drawing.Point(173, 72);
            this.cBoxCategory.Name = "cBoxCategory";
            this.cBoxCategory.Size = new System.Drawing.Size(60, 29);
            this.cBoxCategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "產品類別 :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox3.Controls.Add(this.dgvProducts);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(535, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(740, 572);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "產品列表";
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(22, 31);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(492, 527);
            this.dgvProducts.TabIndex = 0;
            // 
            // btn關鍵字搜尋
            // 
            this.btn關鍵字搜尋.Location = new System.Drawing.Point(173, 119);
            this.btn關鍵字搜尋.Name = "btn關鍵字搜尋";
            this.btn關鍵字搜尋.Size = new System.Drawing.Size(75, 29);
            this.btn關鍵字搜尋.TabIndex = 2;
            this.btn關鍵字搜尋.Text = "搜尋";
            this.btn關鍵字搜尋.UseVisualStyleBackColor = true;
            this.btn關鍵字搜尋.Click += new System.EventHandler(this.btn關鍵字搜尋_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "關鍵字搜尋 :";
            // 
            // 產品維護
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 744);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "產品維護";
            this.Text = "產品維護";
            this.Load += new System.EventHandler(this.產品維護_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn刪除資料;
        private System.Windows.Forms.Button btn新增資料;
        private System.Windows.Forms.Button btn修改資料;
        private System.Windows.Forms.Button btn資料搜尋;
        private System.Windows.Forms.Button btn所有產品;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxCategory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn關鍵字搜尋;
    }
}