namespace WinformPoject0527
{
    partial class BuyerMain
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
            this.comboBoxMain = new System.Windows.Forms.ComboBox();
            this.comboBoxDetail = new System.Windows.Forms.ComboBox();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonmemberdata = new System.Windows.Forms.Button();
            this.buttonSignout = new System.Windows.Forms.Button();
            this.buttonpurchasehistory = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonshoppingcart = new System.Windows.Forms.Button();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSearch2 = new System.Windows.Forms.Button();
            this.buttonalllist = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMain
            // 
            this.comboBoxMain.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMain.FormattingEnabled = true;
            this.comboBoxMain.Location = new System.Drawing.Point(113, 332);
            this.comboBoxMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxMain.Name = "comboBoxMain";
            this.comboBoxMain.Size = new System.Drawing.Size(150, 28);
            this.comboBoxMain.TabIndex = 0;
            this.comboBoxMain.SelectedValueChanged += new System.EventHandler(this.comboBoxMain_SelectedValueChanged);
            // 
            // comboBoxDetail
            // 
            this.comboBoxDetail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDetail.FormattingEnabled = true;
            this.comboBoxDetail.Location = new System.Drawing.Point(113, 374);
            this.comboBoxDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxDetail.Name = "comboBoxDetail";
            this.comboBoxDetail.Size = new System.Drawing.Size(150, 28);
            this.comboBoxDetail.TabIndex = 0;
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(113, 414);
            this.comboBoxBrand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(150, 28);
            this.comboBoxBrand.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(23, 334);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "主分類：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(23, 377);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "細項分類：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(23, 418);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "品牌：";
            // 
            // buttonmemberdata
            // 
            this.buttonmemberdata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonmemberdata.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonmemberdata.Location = new System.Drawing.Point(1136, 10);
            this.buttonmemberdata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonmemberdata.Name = "buttonmemberdata";
            this.buttonmemberdata.Size = new System.Drawing.Size(98, 38);
            this.buttonmemberdata.TabIndex = 13;
            this.buttonmemberdata.Text = "會員資料";
            this.buttonmemberdata.UseVisualStyleBackColor = true;
            this.buttonmemberdata.Click += new System.EventHandler(this.buttonmemberdata_Click);
            // 
            // buttonSignout
            // 
            this.buttonSignout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSignout.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSignout.Location = new System.Drawing.Point(1238, 10);
            this.buttonSignout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSignout.Name = "buttonSignout";
            this.buttonSignout.Size = new System.Drawing.Size(80, 38);
            this.buttonSignout.TabIndex = 13;
            this.buttonSignout.Text = "登出";
            this.buttonSignout.UseVisualStyleBackColor = true;
            this.buttonSignout.Click += new System.EventHandler(this.buttonSignout_Click);
            // 
            // buttonpurchasehistory
            // 
            this.buttonpurchasehistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonpurchasehistory.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonpurchasehistory.Location = new System.Drawing.Point(1033, 10);
            this.buttonpurchasehistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonpurchasehistory.Name = "buttonpurchasehistory";
            this.buttonpurchasehistory.Size = new System.Drawing.Size(98, 38);
            this.buttonpurchasehistory.TabIndex = 13;
            this.buttonpurchasehistory.Text = "購買記錄";
            this.buttonpurchasehistory.UseVisualStyleBackColor = true;
            this.buttonpurchasehistory.Click += new System.EventHandler(this.buttonpurchasehistory_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(283, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 434);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "買家主頁";
            // 
            // buttonshoppingcart
            // 
            this.buttonshoppingcart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonshoppingcart.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonshoppingcart.Location = new System.Drawing.Point(1192, 526);
            this.buttonshoppingcart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonshoppingcart.Name = "buttonshoppingcart";
            this.buttonshoppingcart.Size = new System.Drawing.Size(115, 38);
            this.buttonshoppingcart.TabIndex = 13;
            this.buttonshoppingcart.Text = "進入購物車";
            this.buttonshoppingcart.UseVisualStyleBackColor = true;
            this.buttonshoppingcart.Click += new System.EventHandler(this.buttonshoppingcart_Click);
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxProductID.Location = new System.Drawing.Point(113, 86);
            this.textBoxProductID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(150, 29);
            this.textBoxProductID.TabIndex = 15;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxProductName.Location = new System.Drawing.Point(113, 122);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(150, 29);
            this.textBoxProductName.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(23, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "商品編號：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(23, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "商品名稱：";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSearch.Location = new System.Drawing.Point(164, 162);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(98, 38);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "搜尋";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSearch2
            // 
            this.buttonSearch2.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonSearch2.Location = new System.Drawing.Point(164, 459);
            this.buttonSearch2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearch2.Name = "buttonSearch2";
            this.buttonSearch2.Size = new System.Drawing.Size(98, 38);
            this.buttonSearch2.TabIndex = 13;
            this.buttonSearch2.Text = "搜尋";
            this.buttonSearch2.UseVisualStyleBackColor = true;
            this.buttonSearch2.Click += new System.EventHandler(this.buttonSearch2_Click);
            // 
            // buttonalllist
            // 
            this.buttonalllist.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonalllist.Location = new System.Drawing.Point(283, 22);
            this.buttonalllist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonalllist.Name = "buttonalllist";
            this.buttonalllist.Size = new System.Drawing.Size(98, 38);
            this.buttonalllist.TabIndex = 13;
            this.buttonalllist.Text = "商品總覽";
            this.buttonalllist.UseVisualStyleBackColor = true;
            this.buttonalllist.Click += new System.EventHandler(this.buttonalllist_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttoncancel.Location = new System.Drawing.Point(27, 459);
            this.buttoncancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(98, 38);
            this.buttoncancel.TabIndex = 13;
            this.buttoncancel.Text = "取消";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProductId";
            this.Column1.HeaderText = "商品編號";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SellerID";
            this.Column6.HeaderText = "商家編號";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CategoryId";
            this.Column2.HeaderText = "分類編號";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ProductName";
            this.Column3.HeaderText = "商品名稱";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ProductDescription";
            this.Column4.HeaderText = "商品描述";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ProductPrice";
            this.Column5.HeaderText = "商品價格";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "StockQuantity";
            this.Column7.HeaderText = "庫存數量";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // BuyerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 579);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSignout);
            this.Controls.Add(this.buttonshoppingcart);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonSearch2);
            this.Controls.Add(this.buttonalllist);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonpurchasehistory);
            this.Controls.Add(this.buttonmemberdata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.comboBoxDetail);
            this.Controls.Add(this.comboBoxMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuyerMain";
            this.Text = "BuyerMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMain;
        private System.Windows.Forms.ComboBox comboBoxDetail;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonmemberdata;
        private System.Windows.Forms.Button buttonSignout;
        private System.Windows.Forms.Button buttonpurchasehistory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonshoppingcart;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSearch2;
        private System.Windows.Forms.Button buttonalllist;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}