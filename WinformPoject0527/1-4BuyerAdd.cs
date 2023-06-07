using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPoject0527.EFModels;

namespace WinformPoject0527
{
    public partial class BuyerAdd : Form
    {
        public int _userIdAdd;
        public readonly int _ProductId;
        public int _cartIdBuyerAdd;

        //傳新增商品的ProductName&ProductPrice
        List<ShoppingCartDto> shop ;


        public BuyerAdd(int productId)
        {
            InitializeComponent();
            _ProductId = productId;
            this.Load += BuyerAdd_Load;

        }

        private void BuyerAdd_Load(object sender, EventArgs e)
        {
            var item = new AppDbContext().Products.AsNoTracking()
                                        .Where(x => x.ProductID == _ProductId).FirstOrDefault();

            if (item == null)
            {
                MessageBox.Show("record not found");
                return;
            }

            textBoxProductNameAdd.Text = item.ProductName;
            textBoxProductPriceAdd.Text = (Math.Round((decimal)item.ProductPrice)).ToString();

            string varImageName = $"{_ProductId}"; // Your variable name
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

        }

        private void buttonAddCart_Click(object sender, EventArgs e)
        {
            string name = textBoxProductNameAdd.Text;
            decimal quantity = numericUpDown1.Value;
            decimal price = Decimal.Parse(textBoxProductPriceAdd.Text);
            int roundedPrice = (int)Math.Round(price, MidpointRounding.AwayFromZero);

            var db = new AppDbContext();
            var stockQuantity = db.ProductsStocks
                                .Where(x=>x.ProductID==_ProductId)
                                .Sum(x => x.StockQuantity - x.OrderQuantity);

            //如果購買數量<庫存可加入購物車
            if (quantity< stockQuantity)
            {
                //跳出加入購物車的messagebox之總價
                if (numericUpDown1.Value == 0)
                {
                    MessageBox.Show("請輸入數量");
                }
                else
                {
                    MessageBox.Show($"品名：{name}\r\n共計：{roundedPrice * numericUpDown1.Value}元\r\n已加入購物車");
                    Close();
                }


                //取的新增資料加入table                

                List<int> qua = new List<int>();
                var shopProductID = db.ShoppingCartDetails
                                        .Where(x => x.CartID == _cartIdBuyerAdd && x.ProductID == _ProductId)
                                        .Select(x => x.Quantity);
                foreach (var item in shopProductID)
                {
                    qua.Add((int)item);
                }



                //加入table-ShoppingCartDetail
                //確認是否已在購物車加過同一種商品
                ShoppingCartDetail shoppingCartDetail;

                if (qua.Count == 0)
                {
                    shoppingCartDetail = new ShoppingCartDetail()
                    {

                        CartID = _cartIdBuyerAdd,
                        ProductID = _ProductId,
                        Quantity = (int)quantity
                    };
                    db.ShoppingCartDetails.Add(shoppingCartDetail);
                    db.SaveChanges();
                }
                else
                {
                    int quaend = qua[0];

                    //刪除ProductID的記錄
                    var dbremove = db.ShoppingCartDetails.Where(x => x.ProductID == _ProductId).ToList();
                    db.ShoppingCartDetails.RemoveRange(dbremove);
                    db.SaveChanges();

                    //新增一筆新紀錄
                    shoppingCartDetail = new ShoppingCartDetail()
                    {
                        CartID = _cartIdBuyerAdd,
                        ProductID = _ProductId,
                        Quantity = (int)quantity + quaend
                    };
                    db.ShoppingCartDetails.Add(shoppingCartDetail);
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("庫存不足,待賣家補貨");
            }
            
            
           
        }
    }
}
