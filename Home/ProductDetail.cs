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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeOrder
{
    public partial class ProductDetail : Form
    {
        public int pID = 0; //用ID帶資料過來
        public string pName = "";  //用Name帶資料過來
        string strMyDB2ConnectionString = "";
        string image_dir = @"images\";
        string image_name = "";
        bool is已修改圖檔 = false; //用bool判斷是有修改圖檔
        int Price = 0;

        //List<int> listPrice = new List<int>();
        //List<string> listPSize = new List<string>();

        public ProductDetail()
        {
            InitializeComponent();
        }
        
        private void Detail_Load(object sender, EventArgs e)
        {

            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-41UPIVQ\MSSQLSERVER2019"; //伺服器名稱
            scsb.InitialCatalog = "MyDB2"; //資料庫名稱
            
            scsb.IntegratedSecurity = true; //windows驗證
            strMyDB2ConnectionString = scsb.ToString();

            cboxPSize.Items.Add("S");
            cboxPSize.Items.Add("M");
            cboxPSize.Items.Add("L");
            cboxPSize.SelectedIndex = 0;


            if (pID > 0)
            {//修改模式

                groupBox新增.Visible = false;
                groupBox修改.Visible = true;
                OpenProductDetail(); //判斷此顯示需在修改模式執行

            }
            else
            {//新增模式(空的)

                groupBox新增.Visible = true;
                groupBox修改.Visible = false;

            }

        }

        void OpenProductDetail()  //商品展示中圖片點下出現詳細資訊的表格!!!
        {
            SqlConnection con = new SqlConnection(strMyDB2ConnectionString);
            con.Open(); //開啟資料庫
            //string strSQL = "select * from pDetail where pID= @SearchID;"; //建立SQL查詢語法
            string strSQL = "select top(1) * from pDetail where pName like @SearchName ;"; //建立SQL查詢語法
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", pName);
            SqlDataReader reader = cmd.ExecuteReader();  //SQL資料讀取器

            int i = 0;
            while (reader.Read())
            {//reader出來的型式是物件....??沒聽到
                lblPID.Text = reader["pID"].ToString();
                txtPName.Text = reader["pName"].ToString();
                //lblPrice.Text = reader["Price"].ToString();
                txtPDesc.Text = reader["pDesc"].ToString();
                image_name = reader["pImage"].ToString();
                pictureBoxPic.Image = Image.FromFile(image_dir + image_name);
                i += 1;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"查詢{i}筆資料");

        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog(); //檔案開啟對話框
            f.Filter = "檔案類型(*.jpg, *.jepg , *.png)|*.jpg; *.jepg ; *.png";
            // 左邊描述欄位,無標準格式 |(or) 右邊是要過濾的檔案,使用;隔開
            DialogResult R = f.ShowDialog(); //user的選擇存在R

            if (R == DialogResult.OK)
            {
                pictureBoxPic.Image = Image.FromFile(f.FileName);
                //系統化命名!!!
                string fileExtension = System.IO.Path.GetExtension(f.SafeFileName);
                //SafeFileName=>不包含目錄
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyyymmddhhmmss") + myRand.Next(1000, 10000).ToString() + fileExtension; //fileExtension副檔名
                is已修改圖檔 = true;
                Console.WriteLine(image_name);

            }

        }

        private void btnChangeSave_Click(object sender, EventArgs e)
        {

            if ((txtPName.Text != "") && (txtPrice.Text != "") && (txtPDesc.Text != "") && (pictureBoxPic.Image != null))
            {
                if (is已修改圖檔 == true)
                {
                    pictureBoxPic.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                SqlConnection con = new SqlConnection(strMyDB2ConnectionString);
                con.Open();
                string strSQL = "update products set PName=@NewPname, Price=@NewPrice ,PDesc=@NewPdesc ,PImage=@NewPimage where ID=@SearchID ; "; //抓Products資料
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", pID);
                cmd.Parameters.AddWithValue("@NewPName", txtPName.Text);
                int intPrice = 0;
                Int32.TryParse(txtPrice.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPdesc", txtPDesc.Text);
                cmd.Parameters.AddWithValue("@NewPimage", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料儲存成功, 影響{rows}筆資料");

            }
            else
            {
                MessageBox.Show("所有欄位必填!!!");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if ((txtPName.Text != "") && (txtPrice.Text != "") && (txtPDesc.Text != "") && (pictureBoxPic.Image != null))
            {
                if (is已修改圖檔 == true)
                {
                    pictureBoxPic.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                }

                //練習請insert進products

                SqlConnection con = new SqlConnection(strMyDB2ConnectionString);
                con.Open();
                string strSQL = "insert into products values (@NewPName , @NewPrice ,@NewPdesc,   @NewPimage) ; ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewPName", txtPName.Text);
                int intPrice = 0;
                Int32.TryParse(txtPrice.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewPdesc", txtPDesc.Text);
                cmd.Parameters.AddWithValue("@NewPimage", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料儲存成功, 影響{rows}筆資料");

            }
            else
            {
                MessageBox.Show("所有欄位必填!!!");
            }


        }


        private void cboxPSize_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string PSize = cboxPSize.SelectedItem.ToString();

            //if (cboxPSize.SelectedIndex == 0)
            //{
            //    lblPrice.Text = "100";//$"{Price}";
            //}
            //else if (cboxPSize.SelectedIndex == 1)
            //{
            //    lblPrice.Text = "115";//$"{Price}";
            //}
            //else
            //{
            //    lblPrice.Text = "120";//$"{Price}";
            //}

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            lblPID.Text = "";
            txtPName.Clear();
            //cboxPrice.Clear();
            txtPDesc.Clear();
            pictureBoxPic.Image = null;
        }

        private void pictureBoxPic_Click(object sender, EventArgs e)
        {

        }
    }
}
