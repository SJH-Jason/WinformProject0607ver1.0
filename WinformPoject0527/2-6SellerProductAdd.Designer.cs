namespace WinformPoject0527
{
    partial class SellerProductAdd
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQuantity = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.btnimgDel = new System.Windows.Forms.Button();
            this.comboBoxCategoryMain = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(625, 431);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 42);
            this.btnEdit.TabIndex = 58;
            this.btnEdit.Text = "商品調整";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(143, 390);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 25);
            this.txtTotal.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 57;
            this.label6.Text = "商品庫存量";
            // 
            // btnQuantity
            // 
            this.btnQuantity.Location = new System.Drawing.Point(277, 431);
            this.btnQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuantity.Name = "btnQuantity";
            this.btnQuantity.Size = new System.Drawing.Size(125, 42);
            this.btnQuantity.TabIndex = 55;
            this.btnQuantity.Text = "商品進貨";
            this.btnQuantity.UseVisualStyleBackColor = true;
            this.btnQuantity.Click += new System.EventHandler(this.btnQuantity_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 54;
            this.label7.Text = "進貨數量";
            this.label7.Visible = false;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(143, 442);
            this.txtProductQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(100, 25);
            this.txtProductQuantity.TabIndex = 45;
            this.txtProductQuantity.Text = "0";
            this.txtProductQuantity.Visible = false;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(625, 372);
            this.btnProductAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(125, 42);
            this.btnProductAdd.TabIndex = 47;
            this.btnProductAdd.Text = "商品新增";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(144, 45);
            this.txtProductId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(100, 25);
            this.txtProductId.TabIndex = 53;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(144, 313);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 25);
            this.txtProductPrice.TabIndex = 44;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(379, 45);
            this.txtProductDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(372, 302);
            this.txtProductDescription.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "商品編號";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "商品價格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "商品說明";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(144, 151);
            this.txtCategoryId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.ReadOnly = true;
            this.txtCategoryId.Size = new System.Drawing.Size(100, 25);
            this.txtCategoryId.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "商品分類";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(144, 99);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 25);
            this.txtProductName.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "商品名稱";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(476, 431);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(125, 42);
            this.btnOpen.TabIndex = 59;
            this.btnOpen.Text = "商品上架";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(1036, 431);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(125, 42);
            this.btnUpload.TabIndex = 60;
            this.btnUpload.Text = "圖片上傳";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.Location = new System.Drawing.Point(786, 45);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(375, 302);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShow.TabIndex = 61;
            this.pictureBoxShow.TabStop = false;
            // 
            // btnimgDel
            // 
            this.btnimgDel.Location = new System.Drawing.Point(887, 431);
            this.btnimgDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnimgDel.Name = "btnimgDel";
            this.btnimgDel.Size = new System.Drawing.Size(125, 42);
            this.btnimgDel.TabIndex = 62;
            this.btnimgDel.Text = "圖片刪除";
            this.btnimgDel.UseVisualStyleBackColor = true;
            this.btnimgDel.Click += new System.EventHandler(this.btnimgDel_Click);
            // 
            // comboBoxCategoryMain
            // 
            this.comboBoxCategoryMain.FormattingEnabled = true;
            this.comboBoxCategoryMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxCategoryMain.Location = new System.Drawing.Point(143, 194);
            this.comboBoxCategoryMain.Name = "comboBoxCategoryMain";
            this.comboBoxCategoryMain.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCategoryMain.TabIndex = 63;
            this.comboBoxCategoryMain.Text = "請選擇";
            this.comboBoxCategoryMain.SelectedValueChanged += new System.EventHandler(this.comboBoxCategoryMain_SelectedValueChanged);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxCategory.IntegralHeight = false;
            this.comboBoxCategory.Location = new System.Drawing.Point(144, 242);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCategory.TabIndex = 64;
            this.comboBoxCategory.Text = "請選擇";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 65;
            this.label8.Text = "商品主分類";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 66;
            this.label9.Text = "商品細分類";
            // 
            // SellerProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 518);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxCategoryMain);
            this.Controls.Add(this.btnimgDel);
            this.Controls.Add(this.pictureBoxShow);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SellerProductAdd";
            this.Text = "SellerProductAdd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.Button btnimgDel;
        private System.Windows.Forms.ComboBox comboBoxCategoryMain;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}