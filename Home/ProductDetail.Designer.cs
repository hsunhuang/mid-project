namespace CafeOrder
{
    partial class ProductDetail
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
            this.groupBox新增 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSelectPic2 = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.groupBox修改 = new System.Windows.Forms.GroupBox();
            this.btnChangeSave = new System.Windows.Forms.Button();
            this.btnSelectPic = new System.Windows.Forms.Button();
            this.pictureBoxPic = new System.Windows.Forms.PictureBox();
            this.txtPDesc = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.lblPID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxPSize = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.groupBox新增.SuspendLayout();
            this.groupBox修改.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox新增
            // 
            this.groupBox新增.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox新增.Controls.Add(this.btnSave);
            this.groupBox新增.Controls.Add(this.btnSelectPic2);
            this.groupBox新增.Controls.Add(this.btClear);
            this.groupBox新增.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox新增.Location = new System.Drawing.Point(490, 487);
            this.groupBox新增.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox新增.Name = "groupBox新增";
            this.groupBox新增.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox新增.Size = new System.Drawing.Size(357, 213);
            this.groupBox新增.TabIndex = 25;
            this.groupBox新增.TabStop = false;
            this.groupBox新增.Text = "新增商品資訊";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(57, 147);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(249, 44);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "儲存商品";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelectPic2
            // 
            this.btnSelectPic2.Location = new System.Drawing.Point(57, 94);
            this.btnSelectPic2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectPic2.Name = "btnSelectPic2";
            this.btnSelectPic2.Size = new System.Drawing.Size(249, 44);
            this.btnSelectPic2.TabIndex = 3;
            this.btnSelectPic2.Text = "選取商品圖片";
            this.btnSelectPic2.UseVisualStyleBackColor = true;
            this.btnSelectPic2.Click += new System.EventHandler(this.btnSelectPic_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(57, 42);
            this.btClear.Margin = new System.Windows.Forms.Padding(4);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(249, 44);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "清空欄位";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // groupBox修改
            // 
            this.groupBox修改.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBox修改.Controls.Add(this.btnChangeSave);
            this.groupBox修改.Controls.Add(this.btnSelectPic);
            this.groupBox修改.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox修改.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox修改.Location = new System.Drawing.Point(490, 725);
            this.groupBox修改.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox修改.Name = "groupBox修改";
            this.groupBox修改.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox修改.Size = new System.Drawing.Size(357, 213);
            this.groupBox修改.TabIndex = 24;
            this.groupBox修改.TabStop = false;
            this.groupBox修改.Text = "修改商品資訊";
            // 
            // btnChangeSave
            // 
            this.btnChangeSave.Location = new System.Drawing.Point(45, 124);
            this.btnChangeSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeSave.Name = "btnChangeSave";
            this.btnChangeSave.Size = new System.Drawing.Size(249, 58);
            this.btnChangeSave.TabIndex = 1;
            this.btnChangeSave.Text = "儲存修改";
            this.btnChangeSave.UseVisualStyleBackColor = true;
            this.btnChangeSave.Click += new System.EventHandler(this.btnChangeSave_Click);
            // 
            // btnSelectPic
            // 
            this.btnSelectPic.Location = new System.Drawing.Point(45, 42);
            this.btnSelectPic.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectPic.Name = "btnSelectPic";
            this.btnSelectPic.Size = new System.Drawing.Size(249, 58);
            this.btnSelectPic.TabIndex = 0;
            this.btnSelectPic.Text = "選取商品圖片";
            this.btnSelectPic.UseVisualStyleBackColor = true;
            this.btnSelectPic.Click += new System.EventHandler(this.btnSelectPic_Click);
            // 
            // pictureBoxPic
            // 
            this.pictureBoxPic.Location = new System.Drawing.Point(183, 86);
            this.pictureBoxPic.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPic.Name = "pictureBoxPic";
            this.pictureBoxPic.Size = new System.Drawing.Size(662, 342);
            this.pictureBoxPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPic.TabIndex = 23;
            this.pictureBoxPic.TabStop = false;
            this.pictureBoxPic.Click += new System.EventHandler(this.pictureBoxPic_Click);
            // 
            // txtPDesc
            // 
            this.txtPDesc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPDesc.Location = new System.Drawing.Point(175, 768);
            this.txtPDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtPDesc.Multiline = true;
            this.txtPDesc.Name = "txtPDesc";
            this.txtPDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPDesc.Size = new System.Drawing.Size(287, 163);
            this.txtPDesc.TabIndex = 22;
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPName.Location = new System.Drawing.Point(175, 556);
            this.txtPName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(289, 39);
            this.txtPName.TabIndex = 20;
            // 
            // lblPID
            // 
            this.lblPID.BackColor = System.Drawing.Color.SandyBrown;
            this.lblPID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPID.Location = new System.Drawing.Point(177, 487);
            this.lblPID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(287, 36);
            this.lblPID.TabIndex = 19;
            this.lblPID.Text = "0000000";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(309, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 36);
            this.label6.TabIndex = 18;
            this.label6.Text = "商品詳細資訊";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(40, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "商品圖檔";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(37, 768);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 36);
            this.label4.TabIndex = 16;
            this.label4.Text = "商品描述";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(40, 695);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "商品價格";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(37, 557);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "商品名稱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(101, 487);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "pID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(37, 621);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 36);
            this.label7.TabIndex = 26;
            this.label7.Text = "商品容量";
            // 
            // cboxPSize
            // 
            this.cboxPSize.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboxPSize.FormattingEnabled = true;
            this.cboxPSize.Location = new System.Drawing.Point(175, 623);
            this.cboxPSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxPSize.Name = "cboxPSize";
            this.cboxPSize.Size = new System.Drawing.Size(132, 38);
            this.cboxPSize.TabIndex = 27;
            this.cboxPSize.SelectedIndexChanged += new System.EventHandler(this.cboxPSize_SelectedIndexChanged_1);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(173, 692);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(182, 39);
            this.txtPrice.TabIndex = 28;
            // 
            // ProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 974);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cboxPSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox新增);
            this.Controls.Add(this.groupBox修改);
            this.Controls.Add(this.pictureBoxPic);
            this.Controls.Add(this.txtPDesc);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductDetail";
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.Detail_Load);
            this.groupBox新增.ResumeLayout(false);
            this.groupBox修改.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox新增;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSelectPic2;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.GroupBox groupBox修改;
        private System.Windows.Forms.Button btnChangeSave;
        private System.Windows.Forms.Button btnSelectPic;
        private System.Windows.Forms.PictureBox pictureBoxPic;
        private System.Windows.Forms.TextBox txtPDesc;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxPSize;
        private System.Windows.Forms.TextBox txtPrice;
    }
}