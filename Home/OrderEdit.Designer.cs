namespace Home
{
    partial class OrderEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewCafeMenu = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.imageListPic = new System.Windows.Forms.ImageList(this.components);
            this.btn會員資料查詢 = new System.Windows.Forms.Button();
            this.lbllogininfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewCafeMenu
            // 
            this.listViewCafeMenu.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewCafeMenu.HideSelection = false;
            this.listViewCafeMenu.Location = new System.Drawing.Point(105, 178);
            this.listViewCafeMenu.Name = "listViewCafeMenu";
            this.listViewCafeMenu.Size = new System.Drawing.Size(1043, 513);
            this.listViewCafeMenu.TabIndex = 18;
            this.listViewCafeMenu.UseCompatibleStateImageBehavior = false;
            this.listViewCafeMenu.ItemActivate += new System.EventHandler(this.listViewCafeMenu_ItemActivate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(527, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 52);
            this.label1.TabIndex = 17;
            this.label1.Text = "商品展示";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReload.Location = new System.Drawing.Point(743, 747);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(183, 75);
            this.btnReload.TabIndex = 16;
            this.btnReload.Text = "重新載入";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(519, 747);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 75);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "新增商品";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnList.Location = new System.Drawing.Point(281, 747);
            this.btnList.Margin = new System.Windows.Forms.Padding(4);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(183, 75);
            this.btnList.TabIndex = 14;
            this.btnList.Text = "列表模式";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnPic
            // 
            this.btnPic.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPic.Location = new System.Drawing.Point(57, 747);
            this.btnPic.Margin = new System.Windows.Forms.Padding(4);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(183, 75);
            this.btnPic.TabIndex = 13;
            this.btnPic.Text = "圖片模式";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // imageListPic
            // 
            this.imageListPic.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListPic.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListPic.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn會員資料查詢
            // 
            this.btn會員資料查詢.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員資料查詢.Location = new System.Drawing.Point(965, 747);
            this.btn會員資料查詢.Margin = new System.Windows.Forms.Padding(4);
            this.btn會員資料查詢.Name = "btn會員資料查詢";
            this.btn會員資料查詢.Size = new System.Drawing.Size(183, 75);
            this.btn會員資料查詢.TabIndex = 20;
            this.btn會員資料查詢.Text = "會員資料查詢";
            this.btn會員資料查詢.UseVisualStyleBackColor = true;
            this.btn會員資料查詢.Click += new System.EventHandler(this.btn會員資料查詢_Click);
            // 
            // lbllogininfo
            // 
            this.lbllogininfo.AutoSize = true;
            this.lbllogininfo.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbllogininfo.Location = new System.Drawing.Point(882, 71);
            this.lbllogininfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllogininfo.Name = "lbllogininfo";
            this.lbllogininfo.Size = new System.Drawing.Size(145, 40);
            this.lbllogininfo.TabIndex = 21;
            this.lbllogininfo.Text = "登入資訊";
            // 
            // OrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 915);
            this.Controls.Add(this.lbllogininfo);
            this.Controls.Add(this.btn會員資料查詢);
            this.Controls.Add(this.listViewCafeMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnPic);
            this.Name = "OrderEdit";
            this.Text = "OrderEdit";
            this.Load += new System.EventHandler(this.OrderEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewCafeMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.ImageList imageListPic;
        private System.Windows.Forms.Button btn會員資料查詢;
        private System.Windows.Forms.Label lbllogininfo;
    }
}