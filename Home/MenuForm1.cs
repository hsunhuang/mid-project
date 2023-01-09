using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class MenuForm1 : Form
    {
        SqlConnectionStringBuilder scsb; //資料庫連線字串!!!!!
        string strDBConnectString = "";

        List<string> listProductName = new List<string>();
        List<int> listUnitPrice = new List<int>();
        List<int> listTotalPrice = new List<int>();
        List<string> listSize = new List<string>();
        List<string> listSweet = new List<string>();
        List<string> listIce = new List<string>();
        List<string> listAdd = new List<string>();  //加價購

        int SelectedCupCount = 0;     //可量化的東西 給整數
        int SelectedUnitPrice = 0;
        int SelectedTotalPrice = 0;
        string OrderPerson = "";      //不是量化的東西 做字串
        string SelectedItem = "";  //insert到資料庫
        string SelectedSize = "";
        string SelectedSweet = "";
        string SelectedIce = "";
        bool isToGO = false;
        bool isBuyBag = false;

        public MenuForm1()
        {
            InitializeComponent();
            txtName.Text = Program.strAccount;
            txtPhone.Text = Program.strPassword;
        }
        //public MenuForm1(string strAccount, string strPassword)
        //{
        //    InitializeComponent();
        //   
        //   
        //}

        String[] path = Directory.GetFiles(@"images2\");

        private void MenuForm1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            //定義連接SQL
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-41UPIVQ\MSSQLSERVER2019";        //伺服器名稱  @:忽略特殊符號
            scsb.InitialCatalog = "MyDB2";  //資料庫名稱
            scsb.IntegratedSecurity = true;  //windows驗證
            strDBConnectString = scsb.ToString();

            for (int i = 0; i < path.Length; i++)
            {
                string fileName = Path.GetFileNameWithoutExtension(path[i]);
                listBoxMenu.Items.Add(fileName);
            }

            //listProductName.Add("Caffè Americano 美式");
            //listProductName.Add("Espresso 濃縮");
            //listProductName.Add("Latte 拿鐵");
            //listProductName.Add("Cold Brew 冷萃咖啡");
            //listProductName.Add("Matcha Latte 抹茶拿鐵");
            //listProductName.Add("Cappuccino 卡布奇諾");
            //listProductName.Add("Black Milk Tea紅茶拿鐵");
            //listProductName.Add("Lemon Black Tea 檸檬紅");

            listUnitPrice.Add(100);
            listUnitPrice.Add(110);
            listUnitPrice.Add(140);
            listUnitPrice.Add(155);
            listUnitPrice.Add(120);
            listUnitPrice.Add(135);
            listUnitPrice.Add(120);
            listUnitPrice.Add(110);

            listTotalPrice.Add(100);
            listTotalPrice.Add(110);
            listTotalPrice.Add(140);
            listTotalPrice.Add(155);
            listTotalPrice.Add(120);
            listTotalPrice.Add(135);
            listTotalPrice.Add(120);
            listTotalPrice.Add(110);


            listSize.Add("S");
            listSize.Add("M");
            listSize.Add("L");

            listSweet.Add("正常");
            listSweet.Add("少糖");
            listSweet.Add("半糖");
            listSweet.Add("無糖");

            listIce.Add("正常冰");
            listIce.Add("少冰");
            listIce.Add("去冰");

            for (int i = 0; i < listProductName.Count; i += 1)
            {
                listBoxMenu.Items.Add(listProductName[i]);
            }
            foreach (string item in listSweet)
            {
                cboxSweet.Items.Add(item);
            }
            foreach (string item in listIce)
            {
                cboxIce.Items.Add(item);
            }
            foreach (string item in listSize)
            {
                cboxSize.Items.Add(item);
            }




            txtCupCount.Text = "1";  //設定預設值!!!!!
            SelectedCupCount = 1;

            cboxSize.SelectedIndex = 0;
            SelectedSize = cboxSize.SelectedItem.ToString();

            cboxSweet.SelectedIndex = 0;
            SelectedSweet = cboxSweet.SelectedItem.ToString();

            cboxIce.SelectedIndex = 0;
            SelectedIce = cboxIce.SelectedItem.ToString();

            radioInside.Checked = true;
            isToGO = false;
            chkBag.Checked = false;
            isBuyBag = false;
        }
        //void CountUnitPrice()
        //{


        //    if (cboxSize.SelectedIndex == 0)
        //    {

        //        SelectedUnitPrice += 0;

        //    }
        //    else if (cboxSize.SelectedIndex == 1)
        //    {
        //        SelectedUnitPrice += 10;
        //    }
        //    else
        //    {
        //        SelectedUnitPrice += 15;
        //    }

        //    lblUnitPrice.Text = $"{SelectedUnitPrice}";

        //}

        void CountTotalPrice()
        {
            if (SelectedCupCount > 0)
            {

                if (listBoxMenu.SelectedIndex > -1)
                {

                    if (cboxSize.SelectedIndex == 0)
                    {
                        SelectedUnitPrice = listUnitPrice[listBoxMenu.SelectedIndex];
                        //SelectedUnitPrice += 0;

                    }
                    else if (cboxSize.SelectedIndex == 1)
                    {
                        SelectedUnitPrice = listUnitPrice[listBoxMenu.SelectedIndex] + 10;
                        //SelectedUnitPrice += 10;

                    }
                    else
                    {
                        SelectedUnitPrice = listUnitPrice[listBoxMenu.SelectedIndex] + 15;
                        //SelectedUnitPrice += 15;
                    }
                }
                lblUnitPrice.Text = $"{SelectedUnitPrice}";
                SelectedTotalPrice = SelectedUnitPrice * SelectedCupCount;

                if (listAdd.Count > 0)
                {

                    SelectedTotalPrice = SelectedTotalPrice + listAdd.Count * 40;
                }
                if (isBuyBag == true)
                {

                    SelectedTotalPrice += 2;

                }
                lblTotalPrice.Text = $"{SelectedTotalPrice}";


            }

            //if (cboxSize.SelectedIndex == 0)
            //{

            //    SelectedUnitPrice += 0;

            //}
            //else if (cboxSize.SelectedIndex == 1)
            //{
            //    SelectedUnitPrice += 10;
            //}
            //else
            //{
            //    SelectedUnitPrice += 15;
            //}

            //lblUnitPrice.Text = $"{SelectedUnitPrice}";
        }

        private void txtCupCount_TextChanged(object sender, EventArgs e)
        {
            if (txtCupCount.Text.Length > 0)  //Int32 字串轉數字(.ToString 數字轉字串 )

            {
                bool is數字 = Int32.TryParse(txtCupCount.Text, out SelectedCupCount);
                if (is數字)
                {
                    CountTotalPrice();

                    //if (cboxSize.SelectedIndex == 0)
                    //{

                    //    SelectedTotalPrice += 0;

                    //}
                    //else if (cboxSize.SelectedIndex == 1)
                    //{
                    //    SelectedTotalPrice += 10;
                    //}
                    //else
                    //{
                    //    SelectedTotalPrice += 15;
                    //}
                    //lblTotalPrice.Text = $"{SelectedTotalPrice}";
                }
                else
                {
                    MessageBox.Show("杯數輸入錯誤!!!");
                }

            }

        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxMenu.Image = Image.FromFile(path[listBoxMenu.SelectedIndex]);
            SelectedUnitPrice = listUnitPrice[listBoxMenu.SelectedIndex];
            SelectedTotalPrice = listTotalPrice[listBoxMenu.SelectedIndex];
            //lblUnitPrice.Text = $"{SelectedUnitPrice}";
            cboxSize.SelectedIndex = 0; //讓combo box索引值都是0(第一個值)
            //CountUnitPrice();
            CountTotalPrice();

            //if(listBoxMenu.SelectedIndex==0)
            //{
            //    cboxSize.Text = cboxSize.Text;

            //}else if (listBoxMenu.SelectedIndex == 1)
            //{
            //    cboxSize.Text = cboxSize.Text;
            //}

            //if (listBoxMenu.SelectedIndex >= 0)
            //{
            //    SelectedItem = listProductName[listBoxMenu.SelectedIndex];
            //    SelectedUnitPrice = listUnitPrice[listBoxMenu.SelectedIndex];

            //    lblUnitPrice.Text = $"{SelectedUnitPrice}";
            //    CountTotalPrice();
            //}
        }



        private void cboxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SelectedSize = cboxSize.SelectedItem.ToString();

            //SelectedUnitPrice = listUnitPrice[listBoxMenu.SelectedIndex];
            //lblUnitPrice.Text = $"{SelectedUnitPrice}";


            //int selectedIndex = cboxSize.SelectedIndex;

            //string PSize = cboxSize.SelectedItem.ToString();

            //if (cboxSize.SelectedIndex == 0)
            //{
            //    lblUnitPrice.Text = "100";//$"{Price}";
            //    //lblTotalPrice.Text = lblUnitPrice.Text;
            //}
            //else if (cboxSize.SelectedIndex == 1)
            //{
            //    lblUnitPrice.Text = "135";//$"{Price}";
            //    //lblTotalPrice.Text = lblUnitPrice.Text;

            //}
            //else
            //{
            //    lblUnitPrice.Text = "150";//$"{Price}";
            //    //lblTotalPrice.Text = lblUnitPrice.Text;

            //}
            //CountUnitPrice();
            CountTotalPrice();
        }

        private void cboxSweet_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSweet = cboxSweet.SelectedItem.ToString();
        }

        private void cboxIce_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIce = cboxIce.SelectedItem.ToString();
        }

        private void chkCanele_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCanele.Checked == true)
            {
                listAdd.Add("Canele");
            }
            else
            {
                listAdd.Remove("Canele");
            }
            CountTotalPrice();

        }

        private void chkCookie_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCookie.Checked == true)
            {
                listAdd.Add("Cookie");
            }
            else
            {
                listAdd.Remove("Cookie");
            }
            CountTotalPrice();

        }

        private void chkScone_CheckedChanged(object sender, EventArgs e)
        {
            if (chkScone.Checked == true)
            {
                listAdd.Add("Scone");
            }
            else
            {
                listAdd.Remove("Scone");
            }
            CountTotalPrice();
        }

        private void chkBag_CheckedChanged(object sender, EventArgs e)
        {
            isBuyBag = chkBag.Checked;
            CountTotalPrice();
        }

        private void radioInside_CheckedChanged(object sender, EventArgs e)
        {
            isToGO = false;
        }

        private void radioToGo_CheckedChanged(object sender, EventArgs e)
        {
            isToGO = true;
        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            pictureBoxMenu.Image = Image.FromFile(@"C:\Users\Joyce\OneDrive\桌面\全端班\ADO\@期中專題\CafeOrder\Home\bin\Debug\images2");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (SelectedCupCount > 0))
            {
                OrderPerson = txtName.Text;
                SqlConnection con = new SqlConnection(strDBConnectString);
                con.Open();
                string strSQL = "insert into orderlist values(@NewName,@NewPrice,@NewTotalPrice,@NewCups,@NewSugar,@NewIce,@NewCustomerName,@NewToGo,@NewBuyBag,@NewAdd)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", SelectedItem);
                cmd.Parameters.AddWithValue("@NewPrice", SelectedUnitPrice);
                cmd.Parameters.AddWithValue("@NewTotalPrice", SelectedTotalPrice);
                cmd.Parameters.AddWithValue("@NewCups", SelectedCupCount);
                cmd.Parameters.AddWithValue("@NewSugar", SelectedSweet);
                cmd.Parameters.AddWithValue("@NewIce", SelectedIce);
                cmd.Parameters.AddWithValue("@NewCustomerName", OrderPerson);
                cmd.Parameters.AddWithValue("@NewToGo", isToGO);
                cmd.Parameters.AddWithValue("@NewBuyBag", isBuyBag);
                string strAddDessert = "";  //因為配料是list 要先給字串!!!
                foreach (string item in listAdd)
                {
                    strAddDessert = strAddDessert + "," + item;
                }
                cmd.Parameters.AddWithValue("@NewAdd", strAddDessert.Trim(','));
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"訂購成功,共{rows}筆");
            }
            else
            {
                MessageBox.Show("訂購人必填 至少購買1杯!!!");
            }
        }

        private void lblUnitPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
