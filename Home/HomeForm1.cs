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
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Home
{
    public partial class HomeForm1 : Form
    {
        SqlConnectionStringBuilder scsb; //資料庫連線字串!!!!!
        string strDBConnectString = "";

        List<string> listMemberName = new List<string>();
        //string sPassword = "";
        //string sAccount = "";
        
        public HomeForm1()
        {
            InitializeComponent();
           
            lblTitle.Text = $"Welcome {Program.strAccount} !";
        }

        //public HomeForm1(string strAccount, string strPassword)
        //{
        //    InitializeComponent();
         

        //    //sAccount = strAccount;

        //    //sPassword = strPassword;

            
        //}


            //}
            private void HomeForm1_Load(object sender, EventArgs e)
        {
            

            this.FormBorderStyle = FormBorderStyle.Sizable;
            //定義連接SQL
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-41UPIVQ\MSSQLSERVER2019";        //伺服器名稱  @:忽略特殊符號
            scsb.InitialCatalog = "MyDB2";  //資料庫名稱
            scsb.IntegratedSecurity = true;  //windows驗證
            strDBConnectString = scsb.ToString();

            if (Program.strKeyLevel == "店長" || Program.strKeyLevel == "店員")
            {
                btnStaffOnly.Visible = true;
            }
            else
            {
                btnStaffOnly.Visible = false; 
            }


            //lblTitle.Text="Welcome! Joyce";
        } 

        private void btnMember_Click(object sender, EventArgs e)
        {
            MemberForm1 member = new MemberForm1();
            //home.Show();
            member.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MenuForm1 menu = new MenuForm1();
            menu.ShowDialog();

        }


        private void btnStaffOnly_Click(object sender, EventArgs e)
        {
            OrderEdit order = new OrderEdit();
            order.ShowDialog();
   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomeLogin order = new HomeLogin();
            order.ShowDialog();
        }
    }
}
