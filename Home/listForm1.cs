using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class listForm1 : Form
    {
        int ID = 1;
        public listForm1()
        {
            InitializeComponent();
        }
        void 單獨顯示()
        {
            if (panel會員.Visible == true)
            { panel會員.Visible = false; }
            if (panel訂單.Visible == true)
            { panel訂單.Visible = false; }
        }

        void 顯示Panel資訊(Panel 訂單)
        {
            if(訂單.Visible== false)
            {
                單獨顯示();
                訂單.Visible = true;
            }else
            {
                訂單.Visible = false;
            }
        }

       
        private void listForm1_Load(object sender, EventArgs e)
        {

        }

        private void btn訂單_Click(object sender, EventArgs e)
        {
            顯示Panel資訊(panel訂單);
        }

        private void btn商品訂購_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MenuForm1());
            單獨顯示();
        }

        private void btn會員_Click(object sender, EventArgs e)
        {
            顯示Panel資訊(panel會員);
        }

        private void btn註冊_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterForm1());
            單獨顯示();
        }

        private void btn會員修改_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MemberForm1());
            單獨顯示();
        }

        private void btn維護_Click(object sender, EventArgs e)
        {
            顯示Panel資訊(panel維護);
        }

        private void btn訂單維護_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrderEdit());
            單獨顯示();
        }

        private void btn會員維護_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MemberEdit());
            單獨顯示();
        }

        private void btn離開_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        private Form activeForm = null;
        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel主要頁面.Controls.Add(ChildForm);
            panel主要頁面.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();


        }
    }
}
