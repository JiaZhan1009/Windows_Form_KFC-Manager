namespace KFC_Manager
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBoxSelected = new System.Windows.Forms.ListBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnNextStep2 = new System.Windows.Forms.Button();
            this.btnStep2Back = new System.Windows.Forms.Button();
            this.panStep2 = new System.Windows.Forms.Panel();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.dataGridViewFood = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panStep1 = new System.Windows.Forms.Panel();
            this.btnNextStep1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.panStep3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelStep4Done = new System.Windows.Forms.Panel();
            this.panFoodName = new System.Windows.Forms.Panel();
            this.panFoodCategory = new System.Windows.Forms.Panel();
            this.lblStep4ProductName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBackStep4 = new System.Windows.Forms.Button();
            this.btnStop4Done = new System.Windows.Forms.Button();
            this.panStep2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).BeginInit();
            this.panStep1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.panStep3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelStep4Done.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.listBoxSelected.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxSelected.FormattingEnabled = true;
            this.listBoxSelected.ItemHeight = 19;
            this.listBoxSelected.Location = new System.Drawing.Point(514, 69);
            this.listBoxSelected.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.Size = new System.Drawing.Size(236, 194);
            this.listBoxSelected.TabIndex = 2;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReturn.Location = new System.Drawing.Point(445, 185);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(56, 33);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "←";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.btnChoose.FlatAppearance.BorderSize = 0;
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChoose.Location = new System.Drawing.Point(445, 117);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(2);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(56, 33);
            this.btnChoose.TabIndex = 4;
            this.btnChoose.Text = "→";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnNextStep2
            // 
            this.btnNextStep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.btnNextStep2.FlatAppearance.BorderSize = 0;
            this.btnNextStep2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextStep2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNextStep2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNextStep2.Location = new System.Drawing.Point(652, 308);
            this.btnNextStep2.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextStep2.Name = "btnNextStep2";
            this.btnNextStep2.Size = new System.Drawing.Size(75, 32);
            this.btnNextStep2.TabIndex = 5;
            this.btnNextStep2.Text = "下一步";
            this.btnNextStep2.UseVisualStyleBackColor = false;
            this.btnNextStep2.Click += new System.EventHandler(this.btnNextStep2_Click);
            // 
            // btnStep2Back
            // 
            this.btnStep2Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.btnStep2Back.FlatAppearance.BorderSize = 0;
            this.btnStep2Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStep2Back.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStep2Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStep2Back.Location = new System.Drawing.Point(525, 308);
            this.btnStep2Back.Margin = new System.Windows.Forms.Padding(2);
            this.btnStep2Back.Name = "btnStep2Back";
            this.btnStep2Back.Size = new System.Drawing.Size(75, 32);
            this.btnStep2Back.TabIndex = 6;
            this.btnStep2Back.Text = "上一步";
            this.btnStep2Back.UseVisualStyleBackColor = false;
            this.btnStep2Back.Click += new System.EventHandler(this.btnbackStep2_Click);
            // 
            // panStep2
            // 
            this.panStep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.panStep2.Controls.Add(this.lblFoodName);
            this.panStep2.Controls.Add(this.dataGridViewFood);
            this.panStep2.Controls.Add(this.label2);
            this.panStep2.Controls.Add(this.btnStep2Back);
            this.panStep2.Controls.Add(this.listBoxSelected);
            this.panStep2.Controls.Add(this.btnNextStep2);
            this.panStep2.Controls.Add(this.btnReturn);
            this.panStep2.Controls.Add(this.btnChoose);
            this.panStep2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panStep2.Location = new System.Drawing.Point(801, 0);
            this.panStep2.Margin = new System.Windows.Forms.Padding(2);
            this.panStep2.Name = "panStep2";
            this.panStep2.Size = new System.Drawing.Size(772, 370);
            this.panStep2.TabIndex = 7;
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFoodName.Location = new System.Drawing.Point(337, 32);
            this.lblFoodName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(65, 24);
            this.lblFoodName.TabIndex = 9;
            this.lblFoodName.Text = "label8";
            this.lblFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewFood
            // 
            this.dataGridViewFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewFood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.dataGridViewFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFood.Location = new System.Drawing.Point(2, 69);
            this.dataGridViewFood.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewFood.MultiSelect = false;
            this.dataGridViewFood.Name = "dataGridViewFood";
            this.dataGridViewFood.ReadOnly = true;
            this.dataGridViewFood.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataGridViewFood.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFood.RowTemplate.Height = 27;
            this.dataGridViewFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFood.ShowEditingIcon = false;
            this.dataGridViewFood.Size = new System.Drawing.Size(428, 299);
            this.dataGridViewFood.TabIndex = 7;
            this.dataGridViewFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFood_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. 選擇套餐內容";
            // 
            // panStep1
            // 
            this.panStep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.panStep1.Controls.Add(this.btnNextStep1);
            this.panStep1.Controls.Add(this.label6);
            this.panStep1.Controls.Add(this.txtProductPrice);
            this.panStep1.Controls.Add(this.label5);
            this.panStep1.Controls.Add(this.lblProductName);
            this.panStep1.Controls.Add(this.label3);
            this.panStep1.Controls.Add(this.label1);
            this.panStep1.Controls.Add(this.dataGridViewProducts);
            this.panStep1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panStep1.Location = new System.Drawing.Point(0, 0);
            this.panStep1.Margin = new System.Windows.Forms.Padding(2);
            this.panStep1.Name = "panStep1";
            this.panStep1.Size = new System.Drawing.Size(801, 370);
            this.panStep1.TabIndex = 8;
            // 
            // btnNextStep1
            // 
            this.btnNextStep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.btnNextStep1.FlatAppearance.BorderSize = 0;
            this.btnNextStep1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextStep1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNextStep1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNextStep1.Location = new System.Drawing.Point(118, 329);
            this.btnNextStep1.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextStep1.Name = "btnNextStep1";
            this.btnNextStep1.Size = new System.Drawing.Size(76, 28);
            this.btnNextStep1.TabIndex = 7;
            this.btnNextStep1.Text = "下一步";
            this.btnNextStep1.UseVisualStyleBackColor = false;
            this.btnNextStep1.Click += new System.EventHandler(this.btnNextStep1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(85, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "元";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.txtProductPrice.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProductPrice.Location = new System.Drawing.Point(40, 187);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(41, 27);
            this.txtProductPrice.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(2, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "套餐金額 :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProductName.Location = new System.Drawing.Point(13, 119);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(79, 19);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "XXXXXXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(0, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "所選套餐 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. 選擇需設定的套餐";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(228)))));
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProducts.Location = new System.Drawing.Point(220, 2);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersWidth = 82;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataGridViewProducts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProducts.RowTemplate.Height = 27;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(579, 370);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
            // 
            // panStep3
            // 
            this.panStep3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.panStep3.Controls.Add(this.panel1);
            this.panStep3.Controls.Add(this.label9);
            this.panStep3.Controls.Add(this.btnBackStep4);
            this.panStep3.Controls.Add(this.btnStop4Done);
            this.panStep3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panStep3.Location = new System.Drawing.Point(1573, 0);
            this.panStep3.Margin = new System.Windows.Forms.Padding(2);
            this.panStep3.Name = "panStep3";
            this.panStep3.Size = new System.Drawing.Size(0, 376);
            this.panStep3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelStep4Done);
            this.panel1.Controls.Add(this.lblStep4ProductName);
            this.panel1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.Location = new System.Drawing.Point(35, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 241);
            this.panel1.TabIndex = 13;
            // 
            // panelStep4Done
            // 
            this.panelStep4Done.Controls.Add(this.panFoodName);
            this.panelStep4Done.Controls.Add(this.panFoodCategory);
            this.panelStep4Done.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStep4Done.Location = new System.Drawing.Point(0, 37);
            this.panelStep4Done.Name = "panelStep4Done";
            this.panelStep4Done.Size = new System.Drawing.Size(488, 202);
            this.panelStep4Done.TabIndex = 12;
            // 
            // panFoodName
            // 
            this.panFoodName.Dock = System.Windows.Forms.DockStyle.Left;
            this.panFoodName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panFoodName.Location = new System.Drawing.Point(208, 0);
            this.panFoodName.Name = "panFoodName";
            this.panFoodName.Size = new System.Drawing.Size(280, 202);
            this.panFoodName.TabIndex = 1;
            // 
            // panFoodCategory
            // 
            this.panFoodCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.panFoodCategory.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panFoodCategory.Location = new System.Drawing.Point(0, 0);
            this.panFoodCategory.Name = "panFoodCategory";
            this.panFoodCategory.Size = new System.Drawing.Size(208, 202);
            this.panFoodCategory.TabIndex = 2;
            // 
            // lblStep4ProductName
            // 
            this.lblStep4ProductName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStep4ProductName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStep4ProductName.Location = new System.Drawing.Point(0, 0);
            this.lblStep4ProductName.Name = "lblStep4ProductName";
            this.lblStep4ProductName.Size = new System.Drawing.Size(488, 37);
            this.lblStep4ProductName.TabIndex = 0;
            this.lblStep4ProductName.Text = "label4";
            this.lblStep4ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(16, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "3. 確認設定的套餐內容";
            // 
            // btnBackStep4
            // 
            this.btnBackStep4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.btnBackStep4.FlatAppearance.BorderSize = 0;
            this.btnBackStep4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackStep4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBackStep4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBackStep4.Location = new System.Drawing.Point(89, 327);
            this.btnBackStep4.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackStep4.Name = "btnBackStep4";
            this.btnBackStep4.Size = new System.Drawing.Size(76, 29);
            this.btnBackStep4.TabIndex = 6;
            this.btnBackStep4.Text = "上一步";
            this.btnBackStep4.UseVisualStyleBackColor = false;
            this.btnBackStep4.Click += new System.EventHandler(this.btnBackStep4_Click);
            // 
            // btnStop4Done
            // 
            this.btnStop4Done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.btnStop4Done.FlatAppearance.BorderSize = 0;
            this.btnStop4Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop4Done.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStop4Done.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStop4Done.Location = new System.Drawing.Point(390, 327);
            this.btnStop4Done.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop4Done.Name = "btnStop4Done";
            this.btnStop4Done.Size = new System.Drawing.Size(76, 29);
            this.btnStop4Done.TabIndex = 5;
            this.btnStop4Done.Text = "完成";
            this.btnStop4Done.UseVisualStyleBackColor = false;
            this.btnStop4Done.Click += new System.EventHandler(this.btnStop4Done_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(158)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(799, 370);
            this.Controls.Add(this.panStep3);
            this.Controls.Add(this.panStep2);
            this.Controls.Add(this.panStep1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "套餐設定精靈";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panStep2.ResumeLayout(false);
            this.panStep2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).EndInit();
            this.panStep1.ResumeLayout(false);
            this.panStep1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.panStep3.ResumeLayout(false);
            this.panStep3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelStep4Done.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxSelected;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnNextStep2;
        private System.Windows.Forms.Button btnStep2Back;
        private System.Windows.Forms.Panel panStep2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panStep1;
        private System.Windows.Forms.Button btnNextStep1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.DataGridView dataGridViewFood;
        private System.Windows.Forms.Panel panStep3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBackStep4;
        private System.Windows.Forms.Button btnStop4Done;
        private System.Windows.Forms.Panel panelStep4Done;
        private System.Windows.Forms.Panel panFoodCategory;
        private System.Windows.Forms.Panel panFoodName;
        private System.Windows.Forms.Label lblStep4ProductName;
        private System.Windows.Forms.Panel panel1;
    }
}

