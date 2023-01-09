using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class RegisterForm1 : Form
    {

        SqlConnectionStringBuilder scsb;
        string strMyDB2ConnectString = "";
        public RegisterForm1()
        {
            InitializeComponent();
        }
        private void RegisterForm1_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-41UPIVQ\MSSQLSERVER2019"; //伺服器名稱
            scsb.InitialCatalog = "MyDB2"; //資料庫名稱
            scsb.IntegratedSecurity = true; //windows驗證
            strMyDB2ConnectString = scsb.ToString();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (txtTel.Text != ""))
            {
                SqlConnection con = new SqlConnection(strMyDB2ConnectString);
                con.Open();
                string strSQL = "insert into persons values (@NewName,@NewPhone,@NewAddress,@NewEmail,@NewBirth,@NewPassword,@NewPoint,@KeyLevel);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txtTel.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtAdress.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtpBday.Value);
                cmd.Parameters.AddWithValue("@NewPassword", txtPassword.Text);
                cmd.Parameters.AddWithValue("@KeyLevel", txtKeyLevel.Text);
                int intPoints = 0;
                Int32.TryParse(txtPoint.Text, out intPoints);
                cmd.Parameters.AddWithValue("@NewPoint", intPoints);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"({rows}個資料列受到影響)");
            }
        }

        private void btnRelogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomeLogin login = new HomeLogin(); //登入後連接menu
            login.ShowDialog();
        }
    }
}
