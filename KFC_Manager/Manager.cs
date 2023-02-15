using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Collections;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace KFC_Manager
{
    public partial class Manager : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString;

        string imageDir;
        string imageName;
        int 新增資料解說 = 0;
        string strChangeP_F = "Food";
        //string 新增修改 = "";
        int height = 0;
        int intButton = 0;
        int 開關 = 0;
        string whereCategory;
        string strFunction;
        Order o = new Order();

        public Manager()
        {
            InitializeComponent();
        }

        private void 產品維護_Load(object sender, EventArgs e)
        {
            dgvProducts.DefaultCellStyle.BackColor = Color.FromArgb(225, 225, 228);
            whereCategory = "";
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";  //DataSource 代表伺服器名稱, @不處理特殊符號如/
            scsb.InitialCatalog = "KFCDB";  //資料庫的名稱 = database名稱
            scsb.IntegratedSecurity = true;  //設為 true 才可以存取
            strDBConnectionString = scsb.ToString();
            UpdateItems();
            ChangeFoodProduct();

            //cBoxSetCategory.SelectedIndex = 0; cBoxCategory.SelectedIndex = 0;
        }
        void UpdateItems()
        {
            cBoxCategory.Items.Clear();
            cBoxSetCategory.Items.Clear();
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "Select * from " + strChangeP_F + ";";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string category = reader["Category"].ToString();
                if (!cBoxCategory.Items.Contains(category))
                {
                    cBoxCategory.Items.Add(category);
                    cBoxSetCategory.Items.Add(category);
                }
            }
            reader.Close();
            con.Close();
        }
        void ChangeFoodProduct()
        {
            try
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "Select ID as 編號, Name as 食物名稱, Category as 產品類別, Image as 圖檔位置 from " + strChangeP_F + whereCategory + " order by Category;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvProducts.DataSource = dt;
                }
                reader.Close();
                con.Close();
                //依內容自動換行
                dgvProducts.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                //自動調欄寬
                dgvProducts.AutoResizeColumns();
                //自動調欄高
                dgvProducts.AutoResizeRows();
            }
            catch
            {

            }
        
        }

        private void btn關鍵字搜尋_Click(object sender, EventArgs e)
        {
            try
            {
                if (tBox關鍵字搜尋.Text != "" && cBoxCategory.Text != "")
                {
                    string str欄位搜尋 = cBoxCategory.SelectedItem.ToString();
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "select * from " + strChangeP_F + " where Category = @Category and Name like @Search;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Category", str欄位搜尋);
                    cmd.Parameters.AddWithValue("@Search", "%" + tBox關鍵字搜尋.Text + "%");
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable d = new DataTable();
                        d.Load(reader);
                        dgvProducts.DataSource = d;
                    }
                    else
                    {
                        MessageBox.Show("查無資料");
                    }
                    //依內容自動換行
                    dgvProducts.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    //自動調欄寬
                    dgvProducts.AutoResizeColumns();
                    //自動調欄高
                    dgvProducts.AutoResizeRows();
                    con.Close();
                }
                else if (tBox關鍵字搜尋.Text != "" && cBoxCategory.Text == "")
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "select * from " + strChangeP_F + " where Name like @Search;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Search", "%" + tBox關鍵字搜尋.Text + "%");
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable d = new DataTable();
                        d.Load(reader);
                        dgvProducts.DataSource = d;
                    }
                    else
                    {
                        MessageBox.Show("查無資料");
                    }
                    //依內容自動換行
                    dgvProducts.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    //自動調欄寬
                    dgvProducts.AutoResizeColumns();
                    //自動調欄高
                    dgvProducts.AutoResizeRows();
                    con.Close();
                }
                else if (tBox關鍵字搜尋.Text == "" && cBoxCategory.Text != "")
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "select * from " + strChangeP_F + " where Category = @Search;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Search", cBoxCategory.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable d = new DataTable();
                        d.Load(reader);
                        dgvProducts.DataSource = d;
                    }
                    else
                    {
                        MessageBox.Show("查無資料");
                    }
                    //依內容自動換行
                    dgvProducts.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    //自動調欄寬
                    dgvProducts.AutoResizeColumns();
                    //自動調欄高
                    dgvProducts.AutoResizeRows();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("請輸入搜尋關鍵字 ~");
                }
            }
            catch
            {

            }        
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pBoxImage.Visible = true;
                if (e.RowIndex >= 0)
                {
                    string strSelectedID = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int intID = 0;
                    bool isID = Int32.TryParse(strSelectedID, out intID);
                    if (isID)
                    {
                        SqlConnection con = new SqlConnection(strDBConnectionString);
                        con.Open();

                        string strSQL = "select * from " + strChangeP_F + " where ID = @Search;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@Search", intID);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            lblID.Text = reader["ID"].ToString();
                            tBoxProductName.Text = reader["Name"].ToString();
                            cBoxSetCategory.Text = reader["Category"].ToString();
                            lblImage.Text = reader["Image"].ToString();
                            pBoxImage.Image = Image.FromFile(Application.StartupPath + lblImage.Text);
                            try
                            {
                                tBoxPrice.Text = reader["price"].ToString();
                            }
                            catch { }
                        }
                        reader.Close();
                        con.Close();
                    }
                }
            }
            catch
            {

            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                //清空欄位();
                OpenFileDialog f = new OpenFileDialog();
                f.Filter = "圖檔類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";
                DialogResult S = f.ShowDialog();
                string[] sArray = new string[2];
                int i = 0;
                if (S == DialogResult.OK)
                {
                    Console.WriteLine("f.FileName : " + f.FileName);
                    // 處理路徑
                    string Image = f.FileName;
                    sArray = Regex.Split(Image, @"\Debug");
                    i = 1;
                }
                if (i == 1)
                {
                    pBoxImage.Image = Image.FromFile(Application.StartupPath + sArray[1]);
                    lblImage.Text = sArray[1];
                    imageDir = sArray[1];
                    Console.WriteLine("image_name : " + imageDir);
                    // 留下檔名
                    string[] tArray = imageDir.Split(new string[] { @"\", "." }, StringSplitOptions.RemoveEmptyEntries);
                    //foreach (string t in tArray)
                    //{
                    //    Console.WriteLine("tArray裡面有 : " + t);
                    //}
                    imageName = tArray[sArray.Length];
                    tBoxProductName.Text = imageName;
                    Console.WriteLine(imageName);
                }
                //Console.WriteLine("最後: " + imageDir);
            }
            catch
            {

            }
        }

        private void btn修改資料_Click(object sender, EventArgs e)
        {   //修改資料會找不到圖片 , 因為還沒點選選擇圖片
            try
            {
                int intID = 0;
                Int32.TryParse(lblID.Text, out intID);
                if (lblID.Text != "" && tBoxProductName.Text != "" && cBoxSetCategory.Text != "")
                {
                    DialogResult R = MessageBox.Show("確定要修改 :" + lblID.Text + " 的資料嗎?", "修改確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (R == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection(strDBConnectionString);
                        con.Open();
                        string strSQL = "update " + strChangeP_F + " set Name = @NewName, Category = @NewCategory, " +
                            "Image = @NewImage, UpdateTime = @NewDate where ID = @SearchID";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@NewName", tBoxProductName.Text);
                        cmd.Parameters.AddWithValue("@NewCategory", cBoxSetCategory.Text);
                        cmd.Parameters.AddWithValue("@NewImage", lblImage.Text);
                        cmd.Parameters.AddWithValue("@SearchID", lblID.Text);
                        //cmd.Parameters.AddWithValue("@Price", tBoxPrice.Text);
                        cmd.Parameters.AddWithValue("@NewDate", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show(string.Format("成功修改 ID : " + lblID.Text + ", 產品名稱 :  " + tBoxProductName.Text + " 的資料"));
                        清空欄位();
                        ChangeFoodProduct();
                    }
                }
                else
                {
                    MessageBox.Show("有欄位資料不正確, 請重新檢查");
                }
            }
            catch
            {

            }
            
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            try
            {
                if (tBoxProductName.Text != "" && cBoxSetCategory.Text != "" && lblImage.Text != "")
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "select top 1 ID from " + strChangeP_F + " order by ID desc";
                    //SqlCommand cmd = new SqlCommand(strSQL, con);
                    //SqlDataReader reader = cmd.ExecuteReader();
                    //if (reader.Read())
                    //{
                    //    lblID.Text = ((int)reader["ID"] + 1).ToString();
                    //}
                    //reader.Close();

                    DialogResult R = MessageBox.Show("是否要新增 " + tBoxProductName.Text + " 資料嗎?", "新增確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (R == DialogResult.Yes)
                    {
                        if (cBoxSetCategory.Text != "")
                        {
                            strSQL = "insert into " + strChangeP_F + " (Name, Category, Image, UpdateTime)Values (@NewName, @NewCategory, @NewImage, @NewDate);";
                            SqlCommand cmd2 = new SqlCommand(strSQL, con);
                            cmd2.Parameters.AddWithValue("@NewImage", imageDir);
                            cmd2.Parameters.AddWithValue("@NewName", tBoxProductName.Text);
                            cmd2.Parameters.AddWithValue("@NewCategory", cBoxSetCategory.Text);
                            cmd2.Parameters.AddWithValue("@NewDate", DateTime.Now);

                            cmd2.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show(string.Format("成功新增 ID : " + lblID.Text + ", 產品名稱 :  " + tBoxProductName.Text + " 的資料"));
                            ChangeFoodProduct();
                        }
                        else
                        {
                            MessageBox.Show("類別還沒選擇,請重新檢查");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("請輸入完整需要新增的資料");
                }
            }
            catch
            {

            }
          
        }

        private void btn刪除資料_Click(object sender, EventArgs e)
        {
            try
            {
                int intID = 0;
                Int32.TryParse(lblID.Text, out intID);
                if (lblID.Text != "" && tBoxProductName.Text != "" && cBoxSetCategory.Text != "")
                {
                    DialogResult R = MessageBox.Show("確定要刪除ID: " + intID + " 的資料嗎?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (R == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection(strDBConnectionString);
                        con.Open();
                        string strSQL = "delete from " + strChangeP_F + " where ID = @DeleteId;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@DeleteId", intID);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show(string.Format("成功刪除 ID : " + lblID.Text + ", 產品名稱 :  " + tBoxProductName.Text + " 的資料"));
                        清空欄位();
                        ChangeFoodProduct();
                    }
                }
                else
                {
                    MessageBox.Show("沒有選取需要刪除的項目 ~");
                }
            }
            catch
            {
                MessageBox.Show("發生錯誤, 可能為FK關聯導致無法刪除");
            }

        }
        void 清空欄位()
        {
            cBoxCategory.Text = "";
            cBoxSetCategory.Text = "";
            whereCategory = "";
            tBoxProductName.Clear();
            tBox關鍵字搜尋.Clear();
            lblImage.Text = "";

            lblID.Text = "";
            pBoxImage.Image = Image.FromFile(Application.StartupPath + "\\Image\\無法顯示.png");
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn套餐組合設定_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
        void showMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }
        void hideMenu()
        {
            if (pan查看商品.Visible == true)
            {
                pan查看商品.Visible = false;
            }
            if (pan功能列表.Visible == true)
            {
                pan功能列表.Visible = false;
            }
            if (pan套餐組合設定.Visible == true)
            {
                pan套餐組合設定.Visible = false;
            }
            if (panOrder.Visible == true)
            {
                panOrder.Visible = false;
            }
        }

        private void btnShowProduct_Click(object sender, EventArgs e)
        {
            showMenu(pan查看商品);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (intButton == 1 && 開關 == 1)
            {
                pan查看商品.Size = new Size(140, Height + height);
                if(pan查看商品.Size.Height > 125)
                {
                    //timer.Enabled = false;
                    timer.Stop();
                    Console.WriteLine("計時器停止");
                }
                height = 10;
            }
            else
            {
                pan查看商品.Size = new Size(140, Height - height);
                if (pan查看商品.Size.Height < 47)
                {
                    //timer.Enabled = false;
                    timer.Stop();
                    Console.WriteLine("計時器停止");
                }
                height = 10;
            }
        }

        private void btn顯示套餐_Click(object sender, EventArgs e)
        {
            panOrder區.Controls.Remove(o);
            pan功能區.Visible = true;
            groupBox修改功能.Text = "套餐 功能按鈕";
            groupBox產品列表.Text = "套餐 列表";
            //panelPrice.Visible = true;
            strFunction = "套餐";
            清空欄位();
            strChangeP_F = "Products";
            ChangeFoodProduct();
            UpdateItems();
        }

        private void cBoxCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cBoxSetCategory.Text = "";
            whereCategory = "";
            tBoxProductName.Clear();
            tBox關鍵字搜尋.Clear();
            lblImage.Text = "";

            Console.WriteLine("whereCategory" + whereCategory);

        }

        private void btn顯示產品_Click(object sender, EventArgs e)
        {
            panOrder區.Controls.Remove(o);
            pan功能區.Visible = true;
            panelPrice.Visible = false;
            groupBox修改功能.Text = "產品 功能按鈕";
            groupBox產品列表.Text = "產品 列表";
            清空欄位();
            strFunction = "產品";
            strChangeP_F = "Food";
            ChangeFoodProduct();
            UpdateItems();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

        }

        private void btn功能列表_Click(object sender, EventArgs e)
        {
            showMenu(pan功能列表);
        }

        private void btn套餐組合設定_Click_1(object sender, EventArgs e)
        {
            showMenu(pan套餐組合設定);
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            showMenu(panOrder);
        }

        private void btnShowOrder_Click(object sender, EventArgs e)
        {
            pan功能區.Visible = false;


            o.TopLevel = false;
            o.Dock = DockStyle.Left;
            this.panOrder區.Controls.Add(o);

            o.Show();
        }
    }
}
