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

namespace Home
{
    public partial class MemberForm1 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strMyDB2ConnectString = "";
        //string sPassword = "";
        //string sAccount = "";

        public MemberForm1()
        {
            InitializeComponent();
        }
        //public MemberForm1      (string strAccount, string strPassword)
        //{
        //    InitializeComponent();
        //    sAccount = strAccount;
        //    sPassword = strPassword;
        //}
  
        private void personsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDB2DataSet1);

        }

        private void MemberForm1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'myDB2DataSet1.persons' 資料表。您可以視需要進行移動或移除。
            this.personsTableAdapter.Fill(this.myDB2DataSet1.persons);
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-41UPIVQ\MSSQLSERVER2019"; //伺服器名稱
            scsb.InitialCatalog = "MyDB2"; //資料庫名稱
            scsb.IntegratedSecurity = true; //windows驗證
            strMyDB2ConnectString = scsb.ToString();
            HomeLogin strLogin = new HomeLogin();

            if (Program.strAccount != "")
            {
                //string strSelectedID = dgv會員資料列表.Rows[e.txtAccount].Cells[0].Value.ToString();
                int intSelectedID = 0;
                bool isName = true;

                if (isName == true)
                {
                    SqlConnection con = new SqlConnection(strMyDB2ConnectString);
                    con.Open();
                    string strSQL = "select * from persons where Name = @SearchName;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchName", Program.strAccount);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        lblID.Text = reader["ID"].ToString();
                        txtName.Text = reader["Name"].ToString();
                        txtTel.Text = reader["Phone"].ToString();
                        txtAdress.Text = reader["Adress"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtPoint.Text = reader["Point"].ToString();
                        dtpBday.Value = Convert.ToDateTime(reader["Bday"]);
                       
                    }
                    else
                    {
                        MessageBox.Show("請先加入會員");
                        
                    }
                    reader.Close();
                    con.Close();
                }
            }

        }

        private void btnChangeSave_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if ((intID > 0) && (txtName.Text != "") && (txtTel.Text != ""))
            {
                SqlConnection con = new SqlConnection(strMyDB2ConnectString);
                con.Open();
                string strSQL = "update persons set Name=@NewName, Phone=@NewPhone, Adress=@NewAddress, Email=@NewEmail, Bday=@NewBirth where ID = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txtTel.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtAdress.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtpBday.Value);
                //int intPoints = 0;
                //Int32.TryParse(txt會員點數.Text, out intPoints);
                //cmd.Parameters.AddWithValue("@NewPoints", intPoints);
                cmd.Parameters.AddWithValue("@SearchID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"({rows}個資料列受到影響)");
            }
        }

       

    }
}
