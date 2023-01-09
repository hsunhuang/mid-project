namespace Home
{
    partial class MenuForm1
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
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.cboxSize = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.chkBag = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioToGo = new System.Windows.Forms.RadioButton();
            this.radioInside = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkScone = new System.Windows.Forms.CheckBox();
            this.chkCookie = new System.Windows.Forms.CheckBox();
            this.chkCanele = new System.Windows.Forms.CheckBox();
            this.cboxIce = new System.Windows.Forms.ComboBox();
            this.cboxSweet = new System.Windows.Forms.ComboBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCupCount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Location = new System.Drawing.Point(80, 596);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(317, 281);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 116;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.pictureBoxMenu_Click);
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 30;
            this.listBoxMenu.Location = new System.Drawing.Point(80, 270);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(317, 304);
            this.listBoxMenu.TabIndex = 115;
            this.listBoxMenu.SelectedIndexChanged += new System.EventHandler(this.listBoxMenu_SelectedIndexChanged);
            // 
            // cboxSize
            // 
            this.cboxSize.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxSize.FormattingEnabled = true;
            this.cboxSize.Location = new System.Drawing.Point(583, 233);
            this.cboxSize.Margin = new System.Windows.Forms.Padding(4);
            this.cboxSize.Name = "cboxSize";
            this.cboxSize.Size = new System.Drawing.Size(122, 38);
            this.cboxSize.TabIndex = 114;
            this.cboxSize.SelectedIndexChanged += new System.EventHandler(this.cboxSize_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(487, 237);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 30);
            this.label11.TabIndex = 113;
            this.label11.Text = "容量";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Chocolate;
            this.btnOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOrder.Location = new System.Drawing.Point(395, 939);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(201, 75);
            this.btnOrder.TabIndex = 112;
            this.btnOrder.Text = "訂購";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // chkBag
            // 
            this.chkBag.AutoSize = true;
            this.chkBag.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkBag.Location = new System.Drawing.Point(716, 687);
            this.chkBag.Margin = new System.Windows.Forms.Padding(4);
            this.chkBag.Name = "chkBag";
            this.chkBag.Size = new System.Drawing.Size(135, 34);
            this.chkBag.TabIndex = 111;
            this.chkBag.Text = "買購物袋";
            this.chkBag.UseVisualStyleBackColor = true;
            this.chkBag.CheckedChanged += new System.EventHandler(this.chkBag_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.radioToGo);
            this.groupBox2.Controls.Add(this.radioInside);
            this.groupBox2.Location = new System.Drawing.Point(506, 118);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(256, 68);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            // 
            // radioToGo
            // 
            this.radioToGo.AutoSize = true;
            this.radioToGo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioToGo.Location = new System.Drawing.Point(135, 16);
            this.radioToGo.Margin = new System.Windows.Forms.Padding(4);
            this.radioToGo.Name = "radioToGo";
            this.radioToGo.Size = new System.Drawing.Size(86, 34);
            this.radioToGo.TabIndex = 1;
            this.radioToGo.TabStop = true;
            this.radioToGo.Text = "外帶";
            this.radioToGo.UseVisualStyleBackColor = true;
            this.radioToGo.CheckedChanged += new System.EventHandler(this.radioToGo_CheckedChanged);
            // 
            // radioInside
            // 
            this.radioInside.AutoSize = true;
            this.radioInside.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioInside.Location = new System.Drawing.Point(38, 15);
            this.radioInside.Margin = new System.Windows.Forms.Padding(4);
            this.radioInside.Name = "radioInside";
            this.radioInside.Size = new System.Drawing.Size(86, 34);
            this.radioInside.TabIndex = 0;
            this.radioInside.TabStop = true;
            this.radioInside.Text = "內用";
            this.radioInside.UseVisualStyleBackColor = true;
            this.radioInside.CheckedChanged += new System.EventHandler(this.radioInside_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.chkScone);
            this.groupBox1.Controls.Add(this.chkCookie);
            this.groupBox1.Controls.Add(this.chkCanele);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(583, 461);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(322, 133);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "買飲料加價購 $40/個";
            // 
            // chkScone
            // 
            this.chkScone.AutoSize = true;
            this.chkScone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkScone.Location = new System.Drawing.Point(217, 64);
            this.chkScone.Margin = new System.Windows.Forms.Padding(4);
            this.chkScone.Name = "chkScone";
            this.chkScone.Size = new System.Drawing.Size(87, 34);
            this.chkScone.TabIndex = 2;
            this.chkScone.Text = "司康";
            this.chkScone.UseVisualStyleBackColor = true;
            this.chkScone.CheckedChanged += new System.EventHandler(this.chkScone_CheckedChanged);
            // 
            // chkCookie
            // 
            this.chkCookie.AutoSize = true;
            this.chkCookie.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkCookie.Location = new System.Drawing.Point(122, 64);
            this.chkCookie.Margin = new System.Windows.Forms.Padding(4);
            this.chkCookie.Name = "chkCookie";
            this.chkCookie.Size = new System.Drawing.Size(87, 34);
            this.chkCookie.TabIndex = 1;
            this.chkCookie.Text = "餅乾";
            this.chkCookie.UseVisualStyleBackColor = true;
            this.chkCookie.CheckedChanged += new System.EventHandler(this.chkCookie_CheckedChanged);
            // 
            // chkCanele
            // 
            this.chkCanele.AutoSize = true;
            this.chkCanele.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkCanele.Location = new System.Drawing.Point(11, 64);
            this.chkCanele.Margin = new System.Windows.Forms.Padding(4);
            this.chkCanele.Name = "chkCanele";
            this.chkCanele.Size = new System.Drawing.Size(111, 34);
            this.chkCanele.TabIndex = 0;
            this.chkCanele.Text = "可麗露";
            this.chkCanele.UseVisualStyleBackColor = true;
            this.chkCanele.CheckedChanged += new System.EventHandler(this.chkCanele_CheckedChanged);
            // 
            // cboxIce
            // 
            this.cboxIce.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxIce.FormattingEnabled = true;
            this.cboxIce.Location = new System.Drawing.Point(583, 375);
            this.cboxIce.Margin = new System.Windows.Forms.Padding(4);
            this.cboxIce.Name = "cboxIce";
            this.cboxIce.Size = new System.Drawing.Size(122, 38);
            this.cboxIce.TabIndex = 108;
            this.cboxIce.SelectedIndexChanged += new System.EventHandler(this.cboxIce_SelectedIndexChanged);
            // 
            // cboxSweet
            // 
            this.cboxSweet.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxSweet.FormattingEnabled = true;
            this.cboxSweet.Location = new System.Drawing.Point(583, 303);
            this.cboxSweet.Margin = new System.Windows.Forms.Padding(4);
            this.cboxSweet.Name = "cboxSweet";
            this.cboxSweet.Size = new System.Drawing.Size(122, 38);
            this.cboxSweet.TabIndex = 107;
            this.cboxSweet.SelectedIndexChanged += new System.EventHandler(this.cboxSweet_SelectedIndexChanged);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPrice.Location = new System.Drawing.Point(681, 839);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(120, 38);
            this.lblTotalPrice.TabIndex = 106;
            this.lblTotalPrice.Text = "0000元";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblUnitPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUnitPrice.Location = new System.Drawing.Point(519, 839);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(120, 38);
            this.lblUnitPrice.TabIndex = 105;
            this.lblUnitPrice.Text = "0000元";
            this.lblUnitPrice.Click += new System.EventHandler(this.lblUnitPrice_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(625, 695);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 30);
            this.label10.TabIndex = 104;
            this.label10.Text = "杯";
            // 
            // txtCupCount
            // 
            this.txtCupCount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCupCount.Location = new System.Drawing.Point(477, 685);
            this.txtCupCount.Margin = new System.Windows.Forms.Padding(4);
            this.txtCupCount.Name = "txtCupCount";
            this.txtCupCount.Size = new System.Drawing.Size(138, 39);
            this.txtCupCount.TabIndex = 103;
            this.txtCupCount.TextChanged += new System.EventHandler(this.txtCupCount_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(80, 118);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 39);
            this.txtName.TabIndex = 102;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(483, 461);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 30);
            this.label9.TabIndex = 101;
            this.label9.Text = "加價購";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(487, 380);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 30);
            this.label8.TabIndex = 100;
            this.label8.Text = "冰塊";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(487, 307);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 30);
            this.label7.TabIndex = 99;
            this.label7.Text = "甜度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(688, 791);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 30);
            this.label6.TabIndex = 98;
            this.label6.Text = "品項總價";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(541, 791);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 30);
            this.label5.TabIndex = 97;
            this.label5.Text = "單價";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(487, 643);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 30);
            this.label4.TabIndex = 96;
            this.label4.Text = "數量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(84, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 95;
            this.label3.Text = "飲料品項";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(84, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 30);
            this.label2.TabIndex = 94;
            this.label2.Text = "訂購人/電話";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(356, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 50);
            this.label1.TabIndex = 93;
            this.label1.Text = "Café MENU";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone.Location = new System.Drawing.Point(80, 174);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(224, 39);
            this.txtPhone.TabIndex = 117;
            // 
            // MenuForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 1089);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.pictureBoxMenu);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.cboxSize);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.chkBag);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboxIce);
            this.Controls.Add(this.cboxSweet);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCupCount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm1";
            this.Text = "MenuForm1";
            this.Load += new System.EventHandler(this.MenuForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.ComboBox cboxSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.CheckBox chkBag;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioToGo;
        private System.Windows.Forms.RadioButton radioInside;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkScone;
        private System.Windows.Forms.CheckBox chkCookie;
        private System.Windows.Forms.CheckBox chkCanele;
        private System.Windows.Forms.ComboBox cboxIce;
        private System.Windows.Forms.ComboBox cboxSweet;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCupCount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
    }
}