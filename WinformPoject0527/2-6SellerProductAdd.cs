using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPoject0527.EFModels;

namespace WinformPoject0527
{
    public partial class SellerProductAdd : Form
    {
        private int _ProductID;
        private int _SellerID;
        int open = 1;


        public SellerProductAdd(int productid, int sellerid)
        {
            InitializeComponent();
            _ProductID = productid;
            _SellerID = sellerid;
            this.Load += SellerProductAdd_Load;
        }

        private void SellerProductAdd_Load(object sender, EventArgs e)
        {
            var db = new AppDbContext();
            var result2 = from p in db.Products
                          join q in db.ProductsStocks
                          on p.ProductID equals q.ProductID
                          select new
                          {
                              ProductID = p.ProductID,
                              StockQuantity = q.StockQuantity
                          };

            txtTotal.Text = result2.Where(x => x.ProductID == _ProductID).FirstOrDefault()?.StockQuantity.ToString();

            var result3 = db.Products.Where(x => x.ProductID == _ProductID).Select(x => x.ProductOpen).FirstOrDefault();

            //MessageBox.Show($"{result3}");
            open = Convert.ToInt32(result3);

            if (open == 1)
            {
                open = 1;
                btnOpen.Text = "商品上架";
                btnOpen.BackColor = Color.Green;
                btnOpen.ForeColor = Color.White;
            }
            else
            {
                open = 0;
                btnOpen.Text = "商品下架";
                btnOpen.BackColor = Color.Red;
                btnOpen.ForeColor = Color.Yellow;
            }

            //圖片

            string varImageName = $"{_ProductID}"; // Your variable name
            string extension = ".jpg"; // The extension of your file
            string targetPath = @"C:\Users\sjhja\OneDrive\桌面\WinformProject0607new-master\img";
            string fullPath = Path.Combine(targetPath, varImageName + extension);
            if (File.Exists(fullPath))
            {
                pictureBoxShow.Image = new Bitmap(fullPath);
            }
            else
            {
                string img0 = @"C:\Users\sjhja\OneDrive\桌面\WinformProject0607new-master\img\0.jpg";
                pictureBoxShow.Image = new Bitmap(img0);
            }
            ComboBoxItems();
        }

        public void ComboBoxItems()
        {

            var query1 = new AppDbContext().ProductMainCategories.Select(x => x.CategoryName).ToList();
            foreach (var item in query1)
            {
                comboBoxCategoryMain.Items.Add(item);
            }

        }
        public void ProductAddNew()
        {
            //IQueryable<Product> query = new AppDbContext().Products.AsNoTracking();
            //_ProductID = query.OrderByDescending(c => c.ProductID).Select(c => c.ProductID).FirstOrDefault();
            //_SellerID = (int)query.OrderByDescending(c => c.ProductID).Select(c => c.SellerID).FirstOrDefault();
            txtProductId.Text = _ProductID.ToString();
            btnEdit.Enabled = false;
            btnOpen.Enabled = false;

        }

        public void ProductEdit(int x, int y)
        {
            IQueryable<Product> query = new AppDbContext().Products.AsNoTracking();
            _ProductID = x;
            _SellerID = y;

            txtProductId.Text = _ProductID.ToString();
            var product = new AppDbContext()
                            .Products
                            .AsNoTracking()
                            .Where(c => c.ProductID == _ProductID)
                            .SingleOrDefault();
            txtProductName.Text = product.ProductName;
            txtCategoryId.Text = product.CategoryID;
            txtProductPrice.Text = product.ProductPrice.ToString();
            txtProductDescription.Text = product.ProductDescription;
            btnProductAdd.Enabled = false;

            var db = new AppDbContext();
            var combobox1 = db.ProductCategories.Where(c => c.CategoryID == product.CategoryID).FirstOrDefault();
            if (combobox1 != null)
            {
                var combobox2 = combobox1.ParentCategoryID.ToString();

                var mainCategory = new AppDbContext().ProductMainCategories
                                    .Where(c => c.ParentCategoryID == combobox2)
                                    .Select(c => c.CategoryName)
                                    .FirstOrDefault();

                var category = combobox1.CategoryName;

                if (mainCategory != null)
                {
                    comboBoxCategoryMain.Text = mainCategory;
                }

                if (category != null)
                {
                    comboBoxCategory.Text = category;
                }
            }


        }
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == string.Empty ||
               txtCategoryId.Text == string.Empty ||
               txtProductPrice.Text == string.Empty ||
               txtProductDescription.Text == string.Empty)

            {
                MessageBox.Show("請完整輸入商品內容!");
                return;
            }

            var db = new AppDbContext();
            int ProductId = Convert.ToInt32(txtProductId.Text);
            string name = txtProductName.Text;
            string categoryId = txtCategoryId.Text;
            string description = txtProductDescription.Text;
            bool isInt = int.TryParse(txtProductPrice.Text, out int price);
            string _open = "1";
            if (open == 0)
            {
                _open = "0";
            }

            // 更新記錄
            var product = new Product()
            {
                ProductID = ProductId,
                SellerID = _SellerID,
                ProductName = name,
                CategoryID = categoryId,
                ProductDescription = description,
                ProductPrice = price,
                ProductOpen = _open,
            };
            db.Products.Add(product);
            db.SaveChanges();

            var stock = new ProductsStock();
            stock.ProductID = ProductId;
            stock.PurchaseQuantity = 0;
            stock.OrderQuantity = 0;
            stock.QuantitySold = 0;
            stock.StockQuantity = 0;
            db.ProductsStocks.Add(stock);
            db.SaveChanges();

            //新增進貨
            if (txtProductQuantity.Text != string.Empty&& txtProductQuantity.Text!="0")
            {
                bool Q = int.TryParse(txtProductQuantity.Text, out int quantity);
                if (Q == false)
                {
                    MessageBox.Show("請輸入商品數量(整數)!");
                    return;
                }
                var productinventory = new ProductInventory()
                {
                    ProductID = Convert.ToInt32(txtProductId.Text),
                    SellerID = _SellerID,
                    Quantity = quantity,
                };
                db.ProductInventories.Add(productinventory);
                db.SaveChanges();

                var productStock = db.ProductsStocks.FirstOrDefault(x => x.ProductID == ProductId);

                if (productStock != null)
                {
                    // 更新購買數量
                    productStock.PurchaseQuantity += quantity;
                    productStock.StockQuantity += quantity;

                    // 儲存更改到資料庫
                    db.SaveChanges();
                }

            }

            MessageBox.Show("已更新完成!");
            Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == string.Empty ||
              comboBoxCategory.Text == string.Empty ||
              txtProductPrice.Text == string.Empty ||
              txtProductDescription.Text == string.Empty)
            {
                MessageBox.Show("請完整輸入商品內容!");
                return;
            }

            var db = new AppDbContext();
            var _category=db.ProductCategories.Where(x=>x.CategoryName== comboBoxCategory.Text).Select(x=>x.CategoryID).FirstOrDefault();

            var product = db.Products.Find(_ProductID);
            product.ProductName = txtProductName.Text;
            product.CategoryID = _category;
            product.ProductPrice = Convert.ToDecimal(txtProductPrice.Text);
            product.ProductDescription = txtProductDescription.Text;
            db.SaveChanges();

            //新增進貨
            if (txtProductQuantity.Text != string.Empty&& txtProductQuantity.Text != "0")
            {
                bool Q = int.TryParse(txtProductQuantity.Text, out int quantity);
                if (Q == false)
                {
                    MessageBox.Show("請輸入商品數量(整數)!");
                    txtProductQuantity.Text = "";
                    return;
                }
                var productinventory = new ProductInventory()
                {
                    ProductID = Convert.ToInt32(txtProductId.Text),
                    SellerID = _SellerID,
                    Quantity = quantity,
                };
                db.ProductInventories.Add(productinventory);
                db.SaveChanges();

                var productStock = db.ProductsStocks.FirstOrDefault(x => x.ProductID == _ProductID);

                if (productStock != null)
                {
                    // 更新購買數量
                    productStock.PurchaseQuantity += quantity;
                    productStock.StockQuantity += quantity;

                    // 儲存更改到資料庫
                    db.SaveChanges();
                }

            }
            MessageBox.Show("已更新完成!");
            Close();
        }


        private void btnQuantity_Click_1(object sender, EventArgs e)
        {
            label7.Visible = !label7.Visible;
            txtProductQuantity.Visible = !txtProductQuantity.Visible;
            txtProductName.Enabled = !txtProductName.Enabled;
            txtCategoryId.Enabled = !txtCategoryId.Enabled;
            txtProductPrice.Enabled = !txtProductPrice.Enabled;
            txtProductDescription.Enabled = !txtProductDescription.Enabled;

            if (label7.Visible)
            {
                txtProductQuantity.Focus();
            }
            else
            {
                txtProductName.Focus();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (open == 1)
            {
                btnOpen.Text = "商品下架";
                btnOpen.BackColor = Color.Red;
                btnOpen.ForeColor = Color.Yellow;
                var db = new AppDbContext();
                var data = db.Products.FirstOrDefault(x => x.ProductID == _ProductID);
                data.ProductOpen = "0";
                db.SaveChanges();
                open = 0;
            }
            else
            {
                btnOpen.Text = "商品上架";
                btnOpen.BackColor = Color.Green;
                btnOpen.ForeColor = Color.White;
                var db = new AppDbContext();
                var data = db.Products.FirstOrDefault(x => x.ProductID == _ProductID);
                data.ProductOpen = "1";
                db.SaveChanges();
                open = 1;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string varImageName = $"{_ProductID}"; // Your variable name

                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Get the extension of the selected file
                    string extension = Path.GetExtension(filePath);

                    // 指定要儲存的資料夾路徑
                    string targetPath = @"C:\Users\sjhja\OneDrive\桌面\WinformProject0607new-master\img";

                    // 確保目標路徑存在
                    if (!Directory.Exists(targetPath))
                    {
                        Directory.CreateDirectory(targetPath);
                    }

                    // Build the new file path with your variable name and the original extension
                    string newPath = Path.Combine(targetPath, varImageName + extension);

                    // 複製檔案到指定的資料夾
                    File.Copy(filePath, newPath);

                    // 更新圖片控件以顯示新上傳的圖片
                    pictureBoxShow.Image = new Bitmap(newPath);
                }
            }
        }
        private void btnimgDel_Click(object sender, EventArgs e)
        {
            string varImageName = $"{_ProductID}"; // Your variable name
            string extension = ".jpg"; // The extension of your file
            string targetPath = @"C:\Users\sjhja\OneDrive\桌面\WinformProject0607new-master\img";
            string fullPath = Path.Combine(targetPath, varImageName + extension);

            if (File.Exists(fullPath))
            {
                if (pictureBoxShow.Image != null)
                {
                    pictureBoxShow.Image.Dispose(); // Dispose the current image
                    pictureBoxShow.Image = null;
                }
                File.Delete(fullPath);
                MessageBox.Show("圖片刪除成功!");
            }
            else
            {
                MessageBox.Show("查無圖片內容!");
            }

        }

        private void comboBoxCategoryMain_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxCategory.Items.Clear();
            if (comboBoxCategoryMain.SelectedItem != null)
            {

                string mainCategoryName = comboBoxCategoryMain.Text;

                var mainCategoryID = new AppDbContext().ProductMainCategories
                    .Where(x => x.CategoryName == mainCategoryName)
                    .Select(x => x.ParentCategoryID).FirstOrDefault();


                var query2 = new AppDbContext().ProductCategories
                                            .Where(x => x.ParentCategoryID == mainCategoryID)
                                            .Select(x => x.CategoryName).ToList();
                foreach (var item in query2)
                {
                    comboBoxCategory.Items.Add(item);
                }
            }
        }
    }
}
