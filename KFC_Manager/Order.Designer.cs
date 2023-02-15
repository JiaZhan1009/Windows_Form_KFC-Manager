namespace KFC_Manager
{
    partial class Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtimeEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTodayOD = new System.Windows.Forms.Button();
            this.btnShowOD = new System.Windows.Forms.Button();
            this.btnShowO = new System.Windows.Forms.Button();
            this.btnTodayO = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dtimeStart = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSerachTime = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEditOrder = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchO_ID = new System.Windows.Forms.TextBox();
            this.btnSearchO_ID = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtimeEnd
            // 
            this.dtimeEnd.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.dtimeEnd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtimeEnd.Location = new System.Drawing.Point(36, 61);
            this.dtimeEnd.Margin = new System.Windows.Forms.Padding(6);
            this.dtimeEnd.Name = "dtimeEnd";
            this.dtimeEnd.Size = new System.Drawing.Size(141, 25);
            this.dtimeEnd.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.groupBox1.Controls.Add(this.btnTodayOD);
            this.groupBox1.Controls.Add(this.btnShowOD);
            this.groupBox1.Controls.Add(this.btnShowO);
            this.groupBox1.Controls.Add(this.btnTodayO);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 201);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查看訂單";
            // 
            // btnTodayOD
            // 
            this.btnTodayOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(197)))));
            this.btnTodayOD.FlatAppearance.BorderSize = 0;
            this.btnTodayOD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodayOD.Location = new System.Drawing.Point(36, 151);
            this.btnTodayOD.Name = "btnTodayOD";
            this.btnTodayOD.Size = new System.Drawing.Size(129, 34);
            this.btnTodayOD.TabIndex = 8;
            this.btnTodayOD.Text = "今日訂單細節";
            this.btnTodayOD.UseVisualStyleBackColor = false;
            this.btnTodayOD.Click += new System.EventHandler(this.btnTodayOD_Click);
            // 
            // btnShowOD
            // 
            this.btnShowOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(197)))));
            this.btnShowOD.FlatAppearance.BorderSize = 0;
            this.btnShowOD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOD.Location = new System.Drawing.Point(36, 111);
            this.btnShowOD.Name = "btnShowOD";
            this.btnShowOD.Size = new System.Drawing.Size(129, 34);
            this.btnShowOD.TabIndex = 7;
            this.btnShowOD.Text = "所有訂單細節";
            this.btnShowOD.UseVisualStyleBackColor = false;
            this.btnShowOD.Click += new System.EventHandler(this.btnShowOD_Click);
            // 
            // btnShowO
            // 
            this.btnShowO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(197)))));
            this.btnShowO.FlatAppearance.BorderSize = 0;
            this.btnShowO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowO.Location = new System.Drawing.Point(36, 35);
            this.btnShowO.Name = "btnShowO";
            this.btnShowO.Size = new System.Drawing.Size(129, 30);
            this.btnShowO.TabIndex = 5;
            this.btnShowO.Text = "所有訂單";
            this.btnShowO.UseVisualStyleBackColor = false;
            this.btnShowO.Click += new System.EventHandler(this.btnAllOrder_Click);
            // 
            // btnTodayO
            // 
            this.btnTodayO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(197)))));
            this.btnTodayO.FlatAppearance.BorderSize = 0;
            this.btnTodayO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodayO.Location = new System.Drawing.Point(36, 71);
            this.btnTodayO.Name = "btnTodayO";
            this.btnTodayO.Size = new System.Drawing.Size(129, 34);
            this.btnTodayO.TabIndex = 6;
            this.btnTodayO.Text = "今日訂單";
            this.btnTodayO.UseVisualStyleBackColor = false;
            this.btnTodayO.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label14.Location = new System.Drawing.Point(9, 27);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 21);
            this.label14.TabIndex = 44;
            this.label14.Text = "從";
            // 
            // dtimeStart
            // 
            this.dtimeStart.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.dtimeStart.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtimeStart.Location = new System.Drawing.Point(36, 24);
            this.dtimeStart.Margin = new System.Windows.Forms.Padding(6);
            this.dtimeStart.Name = "dtimeStart";
            this.dtimeStart.Size = new System.Drawing.Size(141, 25);
            this.dtimeStart.TabIndex = 43;
            this.dtimeStart.Value = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label15.Location = new System.Drawing.Point(9, 63);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 21);
            this.label15.TabIndex = 45;
            this.label15.Text = "到";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.groupBox2.Controls.Add(this.btnSerachTime);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dtimeEnd);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.dtimeStart);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(0, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 133);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "時間篩選";
            // 
            // btnSerachTime
            // 
            this.btnSerachTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(197)))));
            this.btnSerachTime.FlatAppearance.BorderSize = 0;
            this.btnSerachTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerachTime.Location = new System.Drawing.Point(131, 95);
            this.btnSerachTime.Name = "btnSerachTime";
            this.btnSerachTime.Size = new System.Drawing.Size(60, 24);
            this.btnSerachTime.TabIndex = 7;
            this.btnSerachTime.Text = "搜尋";
            this.btnSerachTime.UseVisualStyleBackColor = false;
            this.btnSerachTime.Click += new System.EventHandler(this.btnSerachTime_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.groupBox3.Controls.Add(this.txtEditOrder);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(0, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 218);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "修改訂單";
            // 
            // txtEditOrder
            // 
            this.txtEditOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.txtEditOrder.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEditOrder.Location = new System.Drawing.Point(36, 41);
            this.txtEditOrder.Name = "txtEditOrder";
            this.txtEditOrder.Size = new System.Drawing.Size(115, 27);
            this.txtEditOrder.TabIndex = 11;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(197)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(131, 74);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 30);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.dataGridViewOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(211, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 651);
            this.panel1.TabIndex = 49;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewOrder.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(884, 651);
            this.dataGridViewOrder.TabIndex = 0;
            this.dataGridViewOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellClick);
            this.dataGridViewOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 651);
            this.panel2.TabIndex = 50;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtSearchO_ID);
            this.groupBox5.Controls.Add(this.btnSearchO_ID);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox5.Location = new System.Drawing.Point(0, 201);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(211, 99);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "搜尋編號";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "編號";
            // 
            // txtSearchO_ID
            // 
            this.txtSearchO_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.txtSearchO_ID.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSearchO_ID.Location = new System.Drawing.Point(57, 38);
            this.txtSearchO_ID.Name = "txtSearchO_ID";
            this.txtSearchO_ID.Size = new System.Drawing.Size(68, 27);
            this.txtSearchO_ID.TabIndex = 11;
            // 
            // btnSearchO_ID
            // 
            this.btnSearchO_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(197)))));
            this.btnSearchO_ID.FlatAppearance.BorderSize = 0;
            this.btnSearchO_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchO_ID.Location = new System.Drawing.Point(131, 38);
            this.btnSearchO_ID.Name = "btnSearchO_ID";
            this.btnSearchO_ID.Size = new System.Drawing.Size(60, 25);
            this.btnSearchO_ID.TabIndex = 8;
            this.btnSearchO_ID.Text = "搜尋";
            this.btnSearchO_ID.UseVisualStyleBackColor = false;
            this.btnSearchO_ID.Click += new System.EventHandler(this.btnSearchO_ID_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1116, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtimeEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowOD;
        private System.Windows.Forms.Button btnShowO;
        private System.Windows.Forms.Button btnTodayO;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtimeStart;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSerachTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEditOrder;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchO_ID;
        private System.Windows.Forms.Button btnSearchO_ID;
        private System.Windows.Forms.Button btnTodayOD;
    }
}