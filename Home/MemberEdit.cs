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
    public partial class MemberEdit : Form
    {

        SqlConnectionStringBuilder scsb;
        string strMyDB2ConnectString = "";
        List<int> SearchIDs = new List<int>(); //進階搜尋的結果
        List<string> listPName = new List<string>();
        List<string> listPDesc = new List<string>();//UI跟資料庫互動用list集合
        List<int> listPrice = new List<int>();
        List<int> listID = new List<int>();


        public MemberEdit()
        {
            InitializeComponent();
        }

        private void MemberEdit_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-41UPIVQ\MSSQLSERVER2019"; //伺服器名稱
            scsb.InitialCatalog = "MyDB2"; //資料庫名稱
            scsb.IntegratedSecurity = true; //windows驗證
            strMyDB2ConnectString = scsb.ToString();

            cbox欄位名稱.Items.Add("Name");
            cbox欄位名稱.Items.Add("Phone");
            cbox欄位名稱.Items.Add("Adress");
            cbox欄位名稱.Items.Add("Email");
            cbox欄位名稱.SelectedIndex = 0;

            //radio已婚.Checked = true;  //預設值是全部
            /*  int搜尋婚姻狀態 = 0; *///預設0:全部, 1:已婚, 2:單身

            產生會員資料列表();

        }
        void 產生會員資料列表()
        {
            SqlConnection con = new SqlConnection(strMyDB2ConnectString);
            con.Open();
            //string strSQL = "select * from persons;";
            string strSQL = "select ID , Name, Phone, Email from persons";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgv會員資料列表.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }
        void 清空欄位()
        {
            lblID.Text = "";
            txt姓名.Clear();
            txt電話.Clear();
            txtEmail.Clear();
            txt地址.Clear();
            txt會員點數.Clear();
            txt權限.Clear();
            dtp生日.Value = DateTime.Now;
            //chk婚姻狀態.Checked = false;
        }

        private void btn資料筆數_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strMyDB2ConnectString); //程式化語法物件
            con.Open(); //開啟資料庫
            string strSQL = "select * from persons"; //建立SQL查詢語法
            SqlCommand cmd = new SqlCommand(strSQL, con); //建立SQL命令物件,參數1:SQL語法/參數2:SQL連線(con)
            SqlDataReader reader = cmd.ExecuteReader();  //SQL資料讀取器

            //以上五步驟不能缺少 順序不能更改

            string strMsg = "";
            int count = 0;   //筆數統計

            while (reader.Read() == true)
            {
                string id = reader["ID"].ToString(); //欄位名稱?????
                string 姓名 = reader["Name"].ToString();
                string 電話 = reader["Phone"].ToString();
                string email = reader["Email"].ToString();

                strMsg += $"{id} : {姓名} , {電話} , {email}\n";
                count += 1;
            }

            strMsg += "資料筆數" + count;  //顯示共幾筆資料筆數
            reader.Close();  //記得要關閉否則佔據資源別人無法讀取
            con.Close(); //關閉SQL連線
            MessageBox.Show(strMsg);

        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {//支援模糊搜尋,以先找到的資料為顯示
            if (txt姓名.Text != "")
            {
                SqlConnection con = new SqlConnection(strMyDB2ConnectString);
                con.Open();
                string strSQL = "select * from persons where Name like @SearchName; "; //注意!參數名稱區分大小寫(是C#的部分)
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", "%" + txt姓名.Text + "%");//注入參數
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {//把資料欄位全部讀出來
                    lblID.Text = reader["ID"].ToString();
                    txt姓名.Text = reader["Name"].ToString();
                    txt電話.Text = reader["Phone"].ToString();
                    txt地址.Text = reader["Adress"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txt會員點數.Text = reader["Point"].ToString();
                    txt權限.Text = reader["KeyLevel"].ToString();
                    dtp生日.Value = Convert.ToDateTime(reader["Bday"]);
                    //chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);
                    //Convert強制型別轉換
                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();
                }
                reader.Close();
                con.Close();

            }
            else
            {
                MessageBox.Show("請輸入姓名搜尋關鍵字");
            }

        }

        //private void btn資料修改_Click(object sender, EventArgs e)
        //{
        //    //修改資料以ID為依據
        //    int intID = 0;
        //    Int32.TryParse(lblID.Text, out intID);
        //    int.TryParse(lblID.Text, out intID);//字串轉其他型態用TryParse
        //    //把程式一般化:意思是把程式變成*所有情況*都可用的語法

        //    if ((intID == 0) && (txt姓名.Text != "") && (txt電話.Text != ""))
        //    {
        //        SqlConnection con = new SqlConnection(strDBConnectString);
        //        con.Open();
        //        string strSQL = "update persons set Name=@NewName, Phone=@NewPhone, Adress=@NewAddress, Email=@NewEmail, Bday=@NewBirth/*, 婚姻狀態=@NewMarriage*/, Point=@NewPoints where ID = @SearchID;";
        //        SqlCommand cmd = new SqlCommand(strSQL, con);

        //    }
        //}

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }


        private void listbox搜尋結果_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox搜尋結果.SelectedIndex >= 0) //索引值從0開始
            {
                int intselectedID = SearchIDs[listbox搜尋結果.SelectedIndex];

                SqlConnection con = new SqlConnection(strMyDB2ConnectString);
                con.Open();
                string strSQL = "select * from persons where ID = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", intselectedID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["id"].ToString();
                    txt姓名.Text = reader["Name"].ToString();
                    txt電話.Text = reader["Phone"].ToString();
                    txt地址.Text = reader["Adress"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txt會員點數.Text = reader["Point"].ToString();
                    txt權限.Text = reader["KeyLevel"].ToString();
                    dtp生日.Value = Convert.ToDateTime(reader["Bday"]);
                    //chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);
                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();
                }
                reader.Close();
                con.Close();
            }
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            //進階搜尋
            listbox搜尋結果.Items.Clear();
            SearchIDs.Clear();
            string 欄位名稱 = cbox欄位名稱.SelectedItem.ToString();
            //string sql婚姻狀態查詢語法 = "";

            //if (int搜尋婚姻狀態 == 0)
            //{
            //    sql婚姻狀態查詢語法 = "";
            //}
            //else if (int搜尋婚姻狀態 == 1)
            //{
            //    sql婚姻狀態查詢語法 = "and 婚姻狀態 = 1";
            //}
            //else if (int搜尋婚姻狀態 == 2)
            //{
            //    sql婚姻狀態查詢語法 = "and 婚姻狀態 = 0";
            //}

            if (txt欄位關鍵字.Text != "")
            {
                SqlConnection con = new SqlConnection(strMyDB2ConnectString);
                con.Open();
                string strSQL = "select * from persons where " + 欄位名稱 + " like @SearchKeyword and Bday <= @BirthEnd and Bday >= @BirthStart ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchKeyword", "%" + txt欄位關鍵字.Text + "%");
                cmd.Parameters.AddWithValue("@BirthEnd", dtp結束時間.Value);
                cmd.Parameters.AddWithValue("@BirthStart", dtp開始時間.Value);
                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    SearchIDs.Add((int)reader["ID"]);
                    listbox搜尋結果.Items.Add($"{(int)reader["ID"]} {reader["Name"].ToString()} {reader["Phone"].ToString()}");
                    count += 1;
                    //回去練習: 加入DataGridView
                }

                if (count == 0)
                {
                    MessageBox.Show("查無此人");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入, 欄位查詢關鍵字");
            }
        }


        private void dgv會員資料列表_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dgv會員資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelectedID);

                if (isID == true)
                {
                    SqlConnection con = new SqlConnection(strMyDB2ConnectString);
                    con.Open();
                    string strSQL = "select * from persons where ID = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelectedID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        lblID.Text = reader["ID"].ToString();
                        txt姓名.Text = reader["Name"].ToString();
                        txt電話.Text = reader["Phone"].ToString();
                        txt地址.Text = reader["Adress"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txt會員點數.Text = reader["Point"].ToString();
                        txt權限.Text = reader["KeyLevel"].ToString();
                        dtp生日.Value = Convert.ToDateTime(reader["Bday"]);
                        //chk婚姻狀態.Checked = Convert.ToBoolean(reader["婚姻狀態"]);
                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                        清空欄位();
                    }
                    reader.Close();
                    con.Close();
                }
            }
        }

        private void btn刪除資料_Click_1(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strMyDB2ConnectString);
                con.Open();
                string strSQL = "delete from persons where ID = @DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                清空欄位();
                MessageBox.Show($"({rows}個資料列受到影響)");
                產生會員資料列表();
            }

        }

   


    }

}
