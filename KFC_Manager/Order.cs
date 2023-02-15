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
using System.Diagnostics;

namespace KFC_Manager
{
    public partial class Order : Form
    {
        string strDB = "";
        SqlConnectionStringBuilder scsb;

        string strShowOrder = "";
        string strSearchID = "";
        string strSearchTime = "";
        bool boolO_OD;

        string strUpdateValue;

        Dictionary<string, string> strOrdersList = new Dictionary<string, string> {
            { "顧客編號", "C_ID" }, { "總價錢", "Price" }, { "Pos機器編號", "Pos_ID" } };
        Dictionary<string, string> strOrderDetailsList = new Dictionary<string, string> {
            { "訂單編號", "O_ID" }, { "產品內容物", "Detail" }, { "食物數量", "Count" } };

        string strClickValue = "";
        string strClickID = "";
        string strclickTitle = "";

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {


        }
        void UpdateOrder()
        {
            try
            {
                DialogResult R = MessageBox.Show("確定要修改編號 " + strClickID + " 的資料嗎?", "修改確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (R == DialogResult.Yes)
                {
                    scsb = new SqlConnectionStringBuilder();
                    scsb.DataSource = @".";
                    scsb.InitialCatalog = "KFCDB";
                    scsb.IntegratedSecurity = true;
                    strDB = scsb.ToString();
                    SqlConnection con = new SqlConnection(strDB);
                    con.Open();

                    string strSQL = strUpdateValue;
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("成功");
                }
            }
            catch
            {
                MessageBox.Show("發生錯誤, 可能為FK資料庫關聯無法變動");
            }

        }
        void ShowOrder()
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "KFCDB";
            scsb.IntegratedSecurity = true;
            strDB = scsb.ToString();
            SqlConnection con = new SqlConnection(strDB);
            con.Open();

            string strSQL = strShowOrder + strSearchID + strSearchTime;

            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridViewOrder.DataSource = dt;
            }
            else
            {
                MessageBox.Show("查無資料");
            }
            //依內容自動換行
            dataGridViewOrder.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //自動調欄寬
            dataGridViewOrder.AutoResizeColumns();
            //自動調欄高
            dataGridViewOrder.AutoResizeRows();

            con.Close();
        }

        private void btnAllOrder_Click(object sender, EventArgs e)
        {
            strShowOrder = "select O.ID as 訂單編號, O.C_ID as 顧客編號, O.Price as 總價錢, O.pos_ID as Pos機器編號, O.建立時間 as 訂單時間 " +
    "from orders as O where O.Validity = 'true' ";

            boolO_OD = true;
            strSearchID = "";
            strSearchTime = "";
            ShowOrder();
        }
        private void btnShowOD_Click(object sender, EventArgs e)
        {
            strShowOrder = "Select OD.ID as ID, O.ID as 訂單編號, O.pos_ID as POS機序號, P.name as 產品名稱, " +
"O.P_Count as 訂單筆數, OD.detail as 產品內容物, OD.Count as 食物數量, O.Price as 訂單總價格 , OD.建立時間 as 銷售時間 " +
"from Order_Details as OD join Orders as O on O.ID = OD.O_ID join Products as P on OD.P_ID = P.ID where OD.Validity = 'true'";

            strSearchID = "";
            boolO_OD = false;
            strSearchTime = "";
            ShowOrder();
            //List<string> list = new List<string> { "O.ID" , "OD.ID" }
        }

        private void btnSearchO_ID_Click(object sender, EventArgs e)
        {
            if (!boolO_OD)
            {
                strSearchID = " and OD.O_ID = " + txtSearchO_ID.Text;
            }
            else
            {
                strSearchID = " and O.ID = " + txtSearchO_ID.Text;
            }
            ShowOrder();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            strShowOrder = "select O.ID as 訂單編號, O.C_ID as 顧客編號, O.Price as 總價錢, O.pos_ID as Pos機器編號, O.建立時間 as 訂單時間 " +
"from orders as O where O.Validity = 'true'";
            strSearchTime = " and O.建立時間 >= \'" + DateTime.Now.ToString("yyyyMMdd") + "\'";
            strSearchID = "";
            boolO_OD = true;
            ShowOrder();
        }
        private void btnTodayOD_Click(object sender, EventArgs e)
        {
            strShowOrder = "Select OD.ID as ID, O.ID as 訂單編號, O.pos_ID as POS機序號, P.name as 產品名稱, " +
"O.P_Count as 訂單筆數, OD.detail as 產品內容物, OD.Count as 食物數量, O.Price as 訂單總價格 , OD.建立時間 as 銷售時間 " +
"from Order_Details as OD join Orders as O on O.ID = OD.O_ID join Products as P on OD.P_ID = P.ID where OD.Validity = 'true' ";
            strSearchTime = " and OD.建立時間 >= \'" + DateTime.Now.ToString("yyyyMMdd") + "\'";
            strSearchID = "";
            boolO_OD = false;
            ShowOrder();
        }

        private void btnSerachTime_Click(object sender, EventArgs e)
        {
            if (!boolO_OD)
            {
                strSearchTime = " and OD.建立時間 <= \'" + dtimeEnd.Value.ToString("yyyyMMdd") + "\' and OD.建立時間 >= \'" + dtimeStart.Value.ToString("yyyyMMdd") + "\'";
            }
            else
            {
                strSearchTime = " and O.建立時間 <= \'" + dtimeEnd.Value.ToString("yyyyMMdd") + "\' and O.建立時間 >= \'" + dtimeStart.Value.ToString("yyyyMMdd") + "\'";
            }

            strSearchID = "";
            ShowOrder();

        }

        private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Console.WriteLine(dataGridViewOrder.Columns[e.ColumnIndex].Index.ToString()); // 取得行index
                //Console.WriteLine(dataGridViewOrder.Rows[e.ColumnIndex].Cells[0].Value.ToString());
                if (e.RowIndex >= 0)
                {
                    strClickValue = dataGridViewOrder.SelectedCells[0].Value.ToString(); //取得目前點選的值
                    strClickID = dataGridViewOrder.Rows[e.RowIndex].Cells[0].Value.ToString();  //取得ID
                    strclickTitle = dataGridViewOrder.Columns[e.ColumnIndex].Name.ToString(); //取得行標題
                    txtEditOrder.Text = strClickValue;
                }
                //Console.WriteLine("目前ID: " + strClickID);
                //Console.WriteLine("目前Value: " + strClickValue);
                //Console.WriteLine("目前Title: " + strclickTitle);
            }
            catch
            {

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!boolO_OD)
            {
                foreach (var item in strOrderDetailsList) 
                { 
                    if (item.Key == strclickTitle)
                    {
                        Console.WriteLine(item.Value);
                        strUpdateValue = "update Order_Details set " + item.Value + " = '" + txtEditOrder.Text + "' where ID = " + strClickID + "; ";
                        UpdateOrder();
                        ShowOrder();
                    }
                    else
                    {
                        //Console.WriteLine("項目不可更改");
                    }
                    Console.WriteLine(item.Key.ToString());
                    Console.WriteLine(item.Value.ToString());
                }
            }
            else
            {
                foreach (var item in strOrdersList)
                {
                    if (item.Key == strclickTitle)
                    {
                        Console.WriteLine(item.Value);
                        strUpdateValue = "update Orders set " + item.Value + " = '" + txtEditOrder.Text + "' where ID = " + strClickID + "; ";
                        UpdateOrder();
                        ShowOrder();
                    }
                    else
                    {
                        //Console.WriteLine("項目不可更改");
                    }
                }
            }
        }

        private void dataGridViewOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            strShowOrder = "Select OD.ID as ID, O.ID as 訂單編號, O.pos_ID as POS機序號, P.name as 產品名稱, " +
"O.P_Count as 訂單筆數, OD.detail as 產品內容物, OD.Count as 食物數量, O.Price as 訂單總價格 , OD.建立時間 as 銷售時間 " +
"from Order_Details as OD join Orders as O on O.ID = OD.O_ID join Products as P on OD.P_ID = P.ID where OD.Validity = 'true'";
            strSearchID = " and OD.O_ID = " + dataGridViewOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine(dataGridViewOrder.Rows[e.RowIndex].Cells[0].Value.ToString());
            ShowOrder();
        }
    }
}
