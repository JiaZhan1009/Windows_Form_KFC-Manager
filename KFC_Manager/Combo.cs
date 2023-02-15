using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFC_Manager
{
    public partial class Combo : Form
    {
        public Combo()
        {
            InitializeComponent();
        }

        private void Combo_Load(object sender, EventArgs e)
        {
            lblFoodName.Text = G.listFoodName[G.i];
            G.i += 1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool checkCount = Regex.IsMatch(txtCount.Text, @"[0-9]");

            try
            {
                if (checkCount && Convert.ToInt32(txtCount.Text) > 0)
                {
                    G.listFoodCount.Add(Convert.ToInt32(txtCount.Text));
                    Close();
                }
                else
                {
                    MessageBox.Show("還沒輸入產品數量");
                }
            }
            catch
            {
                MessageBox.Show("輸入的資料不正確");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            G.listFoodCount.Clear();
            Close();
        }
    }
}
