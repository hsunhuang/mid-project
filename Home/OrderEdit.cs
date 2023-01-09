using CafeOrder;
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
    public partial class OrderEdit : Form
    {
        string strMyDB2ConnectionString = "";
        List<string> listPName = new List<string>();
        List<string> listPDesc = new List<string>();//UI跟資料庫互動用list集合
        List<int> listPrice = new List<int>();
        List<int> listID = new List<int>();

        public OrderEdit()
        {
            InitializeComponent();
        }

        private void OrderEdit_Load(object sender, EventArgs e)
        {
            //Login mylogin = new Login();
            //mylogin.ShowDialog();
     

            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"DESKTOP-41UPIVQ\MSSQLSERVER2019"; //伺服器名稱
            scsb.InitialCatalog = "MyDB2"; //資料庫名稱
            scsb.IntegratedSecurity = true; //windows驗證
            strMyDB2ConnectionString = scsb.ToString();

            readDB();
            OpenPicCafeMenu(); //開啟圖片

            lbllogininfo.Text = $"姓名:{Program.strAccount} 權限:{Program.strKeyLevel}";
           
        }

        void readDB()
        {
            SqlConnection con = new SqlConnection(strMyDB2ConnectionString);
            con.Open(); //開啟資料庫
            string strSQL = "select * from products;"; //建立SQL查詢語法
            SqlCommand cmd = new SqlCommand(strSQL, con); //建立SQL命令物件,參數1:SQL語法/參數2:SQL連線(con)
            SqlDataReader reader = cmd.ExecuteReader();  //SQL資料讀取器

            string image_dir = @"images\";//圖檔目錄:@不處理特殊符號
            //images\=>相對路徑;C:\mydata\images\=>絕對路徑
            string image_name = ""; //圖檔名稱
            int i = 0;


            while (reader.Read()) //Form顯示的內容
            {
                listID.Add((int)reader["ID"]);
                listPName.Add(reader["pName"].ToString());
                listPDesc.Add(reader["pDesc"].ToString());
                listPrice.Add((int)reader["Price"]);
                image_name = reader["pImage"].ToString();
                Image myProductImage = Image.FromFile(image_dir + image_name);
                //加上路徑(完整路徑:路徑+完整名稱)
                imageListPic.Images.Add(myProductImage); //圖檔加入imagelist
                i += 1;
            }
            Console.WriteLine($"讀取{i}筆資料");
            reader.Close();
            con.Close();
        }




        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenPicCafeMenu();
        }
        void OpenPicCafeMenu()  //=>寫一個方法可以隨時呼叫 //開啟圖片
        {
            listViewCafeMenu.Clear(); //內容先清空
            listViewCafeMenu.View = View.LargeIcon;  //列舉??? LargeIcon,SmallIcon,List,Tile
            imageListPic.ImageSize = new Size(120, 120); //指定圖檔大小
            listViewCafeMenu.LargeImageList = imageListPic;  //LargeIcon,Tile
            listViewCafeMenu.SmallImageList = imageListPic; //SmallIcon,List?????


            for (int i = 0; i < imageListPic.Images.Count; i += 1) //用for迴圈加入圖片
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;  //索引值對應???
                item.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listPName[i] + "";/*+ listPrice[i] + "元";*/
                item.Tag = listID[i]; //tag是隱藏欄位!!!
                listViewCafeMenu.Items.Add(item);

            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            OpenListCafeMenu();
        }
        void OpenListCafeMenu()  //開啟列表
        {
            listViewCafeMenu.Clear(); //內容先清空
            listViewCafeMenu.LargeImageList = null;
            listViewCafeMenu.SmallImageList = null;
            listViewCafeMenu.View = View.Details;
            listViewCafeMenu.Columns.Add("pID", 100); //(欄位名稱,欄位寬度)
            listViewCafeMenu.Columns.Add("pName", 200);
            listViewCafeMenu.Columns.Add("price", 80);
            listViewCafeMenu.FullRowSelect = true;
            listViewCafeMenu.GridLines = true; //格線

            for (int i = 0; i < listID.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                listViewCafeMenu.Font = new Font("微軟正黑體", 10, FontStyle.Regular);
                item.Text = listID[i].ToString(); //第1欄
                item.SubItems.Add(listPName[i]); //第2欄(2之後屬於subitem的集合)
                item.SubItems.Add(listPrice[i].ToString()); //第3欄
                item.Tag = listID[i]; //tag是隱藏欄位!!!

                listViewCafeMenu.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductDetail myformDetail = new ProductDetail();
            myformDetail.ShowDialog();  //ShowDialog獨佔顯示(用show會每開一次有
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            listID.Clear();
            listPName.Clear();
            listPrice.Clear();
            imageListPic.Images.Clear();
            readDB();

            if (listViewCafeMenu.View == View.Details)
            {
                OpenListCafeMenu();
            }
            else
            {
                OpenPicCafeMenu();
            }
        }

        private void listViewCafeMenu_ItemActivate(object sender, EventArgs e)
        {//此方法不是預設,要從listview的屬性去點兩下觸發


            ProductDetail myformDetail = new ProductDetail();
            myformDetail.pID = (int)listViewCafeMenu.SelectedItems[0].Tag;//所選項目的第一個元素[0],ID存在tag裡
            myformDetail.pName = listViewCafeMenu.SelectedItems[0].Text;//所選項目的第一個元素[0],ID存在tag裡
            myformDetail.ShowDialog();



        }

        private void btn會員資料查詢_Click(object sender, EventArgs e)
        {

            MemberEdit member = new MemberEdit();
            member.ShowDialog();

        }

    }
}
