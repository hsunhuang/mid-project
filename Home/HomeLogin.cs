using CafeOrder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Home
{
    public partial class HomeLogin : Form
    {

        string strMyDB2ConnectionString = "";

        bool isPass = false;


        public HomeLogin()
        {
            InitializeComponent();
        }

        public HomeLogin(string strName) //什麼方式待釐清!!!???
        {
            InitializeComponent();

        }


        private void HomeLogin_Load(object sender, EventArgs e)
        {


            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-41UPIVQ\MSSQLSERVER2019"; //伺服器名稱
            scsb.InitialCatalog = "MyDB2"; //資料庫名稱
            scsb.IntegratedSecurity = true; //windows驗證
            strMyDB2ConnectionString = scsb.ToString();

        } 

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtAccount.Text != "") && (txtPassword.Text != ""))
            {
               Program.strAccount = txtAccount.Text;
                Program.strPassword = txtPassword.Text;


                //bool isPass = false;

                SqlConnection con = new SqlConnection(strMyDB2ConnectionString);
                con.Open(); //開啟資料庫
                string strSQL = "select * from persons where Name = @Account and Phone = @Password;"; //建立SQL查詢語法
                SqlCommand cmd = new SqlCommand(strSQL, con); //建立SQL命令物件,參數1:SQL語法/參數2:SQL連線(con)
                cmd.Parameters.AddWithValue("@Account", Program.strAccount);
                cmd.Parameters.AddWithValue("@Password", Program.strPassword);
                SqlDataReader reader = cmd.ExecuteReader();  //SQL資料讀取器

                if (reader.Read())
                {
                    isPass = true;
                    MessageBox.Show("登入成功");
                    //GlobalVar.memberID = 1; //reader["id"]
                    //GlobalVar.intKeyLevel = 1; //reader["權限"]
                    //GlobalVar.strLoginName = "Joyce Huang";

                    Program.strKeyLevel = reader["KeyLevel"].ToString();

                    this.Visible = false;
                    HomeForm1 menu = new HomeForm1(); //登入後連接menu
                    menu.ShowDialog();

                    //HomeForm1 home = new HomeForm1(strAccount, strPassword);
                    //home.ShowDialog();

                }



                //isPass = true;

                //if (isPass)
                //{
                //    MessageBox.Show("登入成功");
                //    GlobalVar.memberID = 1; //reader["id"]
                //    GlobalVar.intKeyLevel = 1; //reader["權限"]
                //    GlobalVar.strLoginName = "Joyce Huang"; //reader["姓名"]
                //    Close();
                //}
                else
                {
                    MessageBox.Show("登入失敗");
                }
            }
            else
            {
                MessageBox.Show("請輸入帳號密碼");
            }

        }

        private void HomeLogin_FormClosing(object sender, FormClosingEventArgs e)
        {//關閉事件

            if (isPass)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RegisterForm1 menu = new RegisterForm1();
            menu.ShowDialog();

        }
    }
}
