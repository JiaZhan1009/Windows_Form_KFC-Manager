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

namespace KFC_Manager
{
    public partial class 產品維護 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBConnectionString;
        public 產品維護()
        {
            InitializeComponent();
        }

        private void 產品維護_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";  //DataSource 代表伺服器名稱, @不處理特殊符號如/
            scsb.InitialCatalog = "KFCDB";  //資料庫的名稱 = database名稱
            scsb.IntegratedSecurity = true;  //設為 true 才可以存取
            strDBConnectionString = scsb.ToString();

            cBoxCategory.Items.Add("主餐");
            cBoxCategory.Items.Add("副餐");
            cBoxCategory.Items.Add("飲料");
            cBoxCategory.SelectedIndex = 0;

            GetFoodItem();
        }
        void GetFoodItem()
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "Select ID as 產品編號, Name as 食物名稱, Category as 產品類別, Image as 圖檔位置 from FoodItem order by Category;";
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


        }

        private void btn所有產品_Click(object sender, EventArgs e)
        {

        }

        private void btn關鍵字搜尋_Click(object sender, EventArgs e)
        {

        }
    }
}
