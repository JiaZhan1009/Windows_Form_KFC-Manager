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
    public partial class Form1 : Form
    {
        string strDBConnectionString;
        string strSelectedProductPrice;
        string strSelectedProductName;

        int intSelectedIndex;
        int intSelectedFoodID;
        string strSelectedFoodName;
        string strSelectedFoodCategory;

        List<string> listSelectedFoodCategory = new List<string>();

        SqlConnectionStringBuilder scsb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewProducts.DefaultCellStyle.WrapMode = DataGridViewTriState.True; 
            dataGridViewProducts.AutoResizeColumns(); dataGridViewProducts.AutoResizeRows();
            dataGridViewFood.DefaultCellStyle.WrapMode = DataGridViewTriState.True; 
            dataGridViewFood.AutoResizeColumns(); dataGridViewFood.AutoResizeRows();


            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "KFCDB";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ToString();

            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select ID, Name, Category, Price from Products order by Category";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridViewProducts.DataSource = dt;
            }
            strSQL = "select ID, Name, Category from Food order by Category";
            SqlCommand cmd2 = new SqlCommand(strSQL, con);
            reader = cmd2.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridViewFood.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }
        //  Step 2
        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strSelectedProductCategory;
            if (e.RowIndex >= 0)
            {
                G.intProductID = (int)dataGridViewProducts.Rows[e.RowIndex].Cells[0].Value;
                strSelectedProductName = dataGridViewProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                strSelectedProductCategory = dataGridViewProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                strSelectedProductPrice = dataGridViewProducts.Rows[e.RowIndex].Cells[3].Value.ToString();

                lblProductName.Text = strSelectedProductName;
                txtProductPrice.Text = strSelectedProductPrice;
                lblFoodName.Text = strSelectedProductName;// + "  |  " + strSelectedProductCategory + "  |  " + strSelectedProductPrice + "元";
                lblStep4ProductName.Text = strSelectedProductName;// + "  |  " + strSelectedProductCategory + "  |  " + strSelectedProductPrice + "元";
            }
        }
        private void dataGridViewFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                intSelectedFoodID = (int)dataGridViewFood.Rows[e.RowIndex].Cells[0].Value;
                strSelectedFoodName = dataGridViewFood.Rows[e.RowIndex].Cells[1].Value.ToString();
                strSelectedFoodCategory = dataGridViewFood.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnNextStep1_Click(object sender, EventArgs e)
        {
            if (strSelectedProductPrice != txtProductPrice.Text)
            {
                DialogResult R = MessageBox.Show("您目前輸入的金額與資料表金額不同, 是否要變更價錢 ? ", "變更確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (R == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "update Products set Price = @Price where ID = @ID";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Price", txtProductPrice.Text);
                    cmd.Parameters.AddWithValue("@ID", G.intProductID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(string.Format("成功修改產品名稱 :  " + strSelectedProductName + " 的資料"));
                    panStep1.Visible = false;
                }
            }
            else
            {
                panStep1.Visible = false;
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            listBoxSelected.Items.Add(strSelectedFoodName + "  |  " + strSelectedFoodCategory);
            Console.WriteLine(strSelectedFoodName);
            G.listFoodID.Add(intSelectedFoodID);
            G.listFoodName.Add(strSelectedFoodName);
            listSelectedFoodCategory.Add(strSelectedFoodCategory);
            Console.WriteLine(strSelectedFoodName);
            if (listBoxSelected.Items != null)
            {
                this.listBoxSelected.SetSelected(0, true);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxSelected.Items != null)
                {
                    this.listBoxSelected.SetSelected(0, true);
                }
                if (listBoxSelected.SelectedIndex > -1)
                {
                    intSelectedIndex = listBoxSelected.SelectedIndex;
                    Console.WriteLine(intSelectedIndex);
                    listBoxSelected.Items.RemoveAt(intSelectedIndex);
                    G.listFoodID.RemoveAt(intSelectedIndex);
                    G.listFoodName.RemoveAt(intSelectedIndex);
                    listSelectedFoodCategory.RemoveAt(intSelectedIndex);
                }
            }
            catch
            {

            }
            
        }
        private void btnNextStep2_Click(object sender, EventArgs e)
        {
            G.i = 0;
            for (int i = 0; i < G.listFoodName.Count; i++)
            {
                Combo c = new Combo();
                c.ShowDialog();
            }

            for(int i = 0; i < G.listFoodCount.Count; i += 1)
            {
                Console.WriteLine(G.listFoodName[i] + " 數量是 : " + G.listFoodCount[i]);
            }

            for (int i = 0; i < G.listFoodCount.Count; i++)
            {
                Console.WriteLine(i + " : " + G.listFoodID[i] + " Name:" + G.listFoodName[i] + "類別: " + listSelectedFoodCategory[i] + ", 數量: " + G.listFoodCount[i]);

                Label lblName = new Label();
                Label lblCategory = new Label();
                lblName.Dock = DockStyle.Top;
                lblCategory.Dock = DockStyle.Top;

                panFoodName.Controls.Add(lblName);
                panFoodCategory.Controls.Add(lblCategory);
                lblName.Text = G.listFoodName[i] + " x" + G.listFoodCount[i];
                lblName.TextAlign = ContentAlignment.MiddleLeft;
                lblCategory.Text = listSelectedFoodCategory[i];
                lblCategory.TextAlign = ContentAlignment.MiddleRight;
            }
            panStep1.Visible = false;
            panStep2.Visible = false;
            panStep3.Visible = true;

        }
        private void btnbackStep2_Click(object sender, EventArgs e)
        {
            panStep1.Visible = true;
        }

        private void btnBackStep4_Click(object sender, EventArgs e)
        {
            G.listFoodCount.Clear();
            panFoodName.Controls.Clear();
            panFoodCategory.Controls.Clear();
            panStep3.Visible = false;
            panStep1.Visible = false;
            panStep2.Visible = true;
        }

        private void btnStop4Done_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("是否要新增套餐 " + strSelectedProductName + " 的組合設定嗎?", "新增確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (R == DialogResult.Yes)
            {
                for (int i = 0; i < G.listFoodCount.Count; i++)
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "insert into Combo (P_ID, F_ID, Count) Values (@P_ID, @F_ID, @Count);";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@P_ID", G.intProductID);
                    cmd.Parameters.AddWithValue("@F_ID", G.listFoodID[i]);
                    cmd.Parameters.AddWithValue("@Count", G.listFoodCount[i]);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show(string.Format("成功新增套餐 : " + strSelectedProductName + " 的資料"));
                Close();
            }
        }
    }
}
