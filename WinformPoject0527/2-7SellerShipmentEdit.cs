using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPoject0527.EFModels;

namespace WinformPoject0527
{
    public partial class SellerShipmentEdit : Form
    {

        public int _shipmentid;
        public int _orderid;
        public int _sellerid;


        public SellerShipmentEdit()
        {
            InitializeComponent();
            this.Load += SellerShipmentEdit_Load;
         
        }

        private void SellerShipmentEdit_Load(object sender, EventArgs e)
        {
            Display();
            DisplayView();
        }

        public void Display()
        {
            IQueryable<Shipment> query = new AppDbContext().Shipments.AsQueryable();
            txtShipmentID.Text = query.Where(x => x.ShipmentID == _shipmentid).Select(x => x.ShipmentID).FirstOrDefault().ToString();
            txtOrderId.Text = query.Where(x => x.ShipmentID == _shipmentid).Select(x => x.OrderID).FirstOrDefault().ToString();
            txtSellerId.Text = query.Where(x => x.ShipmentID == _shipmentid).Select(x => x.SellerID).FirstOrDefault().ToString();
            txtTime1.Text = query.Where(x => x.ShipmentID == _shipmentid).Select(x => x.ShipmentDate).FirstOrDefault()?.ToString("yyyy-MM-dd");
            txtAction1.Text = query.Where(x => x.ShipmentID == _shipmentid).Select(x => x.ShipmentStatus).FirstOrDefault();
            txtAction2.Text = query.Where(x => x.ShipmentID == _shipmentid).Select(x => x.CompletionStatus).FirstOrDefault();
            txtAction3.Text = query.Where(x => x.ShipmentID == _shipmentid).Select(x => x.ReceiveStatus).FirstOrDefault();

            if (query.Where(x => x.ShipmentID == _shipmentid).Select(x => x.ShipDate).FirstOrDefault() != null)
            {
                btnShip.Enabled = false;
                btnArrival.Enabled = true;
                txtTime2.Text = query.Where(x => x.ShipmentID == _shipmentid).Select(x => x.ShipDate).FirstOrDefault()?.ToString("yyyy-MM-dd HH:mm");
            }

            if (query.Where(x => x.ShipmentID == _shipmentid).Select(x => x.ArrivalTimeDate).FirstOrDefault() != null)
            {
                btnArrival.Enabled = false;
                btnCompletion.Enabled = true;
                txtTime3.Text = query.Where(x => x.ShipmentID == _shipmentid).Select(x => x.ArrivalTimeDate).FirstOrDefault()?.ToString("yyyy-MM-dd HH:mm");
            }

            if (query.Where(x => x.ShipmentID == _shipmentid).Select(x => x.CompletionDate).FirstOrDefault() != null)
            {
                btnCompletion.Enabled = false;
                txtTime4.Text = query.Where(x => x.ShipmentID == _shipmentid).Select(x => x.CompletionDate).FirstOrDefault()?.ToString("yyyy-MM-dd HH:mm");
            }

            if (query.Where(x => x.ShipmentID == _shipmentid).Select(x => x.ReceiveStatus).FirstOrDefault() == "已領取")
            {
                btnCompletion.Enabled = true;
            }
        }

        public void DisplayView()
        {
            //IQueryable<OrderDetail> query = new AppDbContext().OrderDetails.AsNoTracking();
            //this.dataGridView1.DataSource = query.ToList();

            var db = new AppDbContext();
            var data = from o in db.OrderDetails
                       join p in db.Products
                       on o.ProductID equals p.ProductID
                       select new
                       {
                           o.OrderID,
                           o.ProductID,
                           p.ProductName,
                           p.ProductPrice,
                           o.Quantity,
                           p.SellerID,
                       };
            this.dataGridView1.DataSource = data.Where(c => c.OrderID == _orderid && c.SellerID == _sellerid).ToList();

            //var productQuantities = data
            //                    .Where(c => c.OrderID == _orderid && c.SellerID == _sellerid)
            //                    .GroupBy(x => x.ProductID)
            //                    .ToDictionary(g => g.Key, g => g.Sum(x => x.Quantity));

            //foreach (var item in productQuantities)
            //{
            //    MessageBox.Show($"ProductID: {item.Key}, Total Quantity: {item.Value}");

            //    //var db2 = new AppDbContext();
            //    //var data2 = db2.ProductsStocks.Find(item.Key);
            //    //data2.QuantitySold += item.Value;
            //    //data2.StockQuantity -= item.Value;
            //}

        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            //0=準備中
            //1=已出貨

            btnShip.Enabled = false;
            txtTime2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            btnArrival.Enabled = true;

            //// 更新資料
            var db = new AppDbContext();
            var shipment = db.Shipments.Find(_shipmentid);
            shipment.ShipmentStatus = "已出貨";
            shipment.ReceiveStatus = "已出貨";
            shipment.ShipDate = DateTime.Now;
            db.SaveChanges();
            txtAction1.Text = shipment.ShipmentStatus;
            txtAction3.Text = shipment.ShipmentStatus;
        }

        private void btnArrival_Click(object sender, EventArgs e)
        {
            //1=已出貨
            //2=等候領取

            btnArrival.Enabled = false;
            txtTime3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            // 更新資料
            var db = new AppDbContext();
            var shipment = db.Shipments.Find(_shipmentid);
            shipment.CompletionStatus = "已送達";
            shipment.ReceiveStatus = "等候領取";
            shipment.ArrivalTimeDate = DateTime.Now;
            txtAction2.Text = shipment.CompletionStatus;
            txtAction3.Text = shipment.ReceiveStatus;
            db.SaveChanges();
        }

        private void btnCompletion_Click(object sender, EventArgs e)
        {
            //0=準備中 訂單送出後的初始狀態
            //1=已出貨 
            //2=等候領取 物品領取鈕開啟
            //3=已領取 物品領取鈕按下/完成鈕開啟
            //txtAction3.Text = "已取貨";
            //btnCompletion.Enabled = true;
            //4=已結單 完成鈕按下

            //原本應該為 等候中 物品送達後轉等候領取 確認領取後才會變為已領取 已領取狀態才會開啟按鈕進行確認
            txtAction3.Text = "已結單";
            btnCompletion.Enabled = false;
            txtTime4.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            // 更新資料
            var db = new AppDbContext();
            var shipment = db.Shipments.Find(_shipmentid);
            shipment.ReceiveStatus = "已結單";
            shipment.CompletionDate = DateTime.Now;
            txtAction3.Text = shipment.ReceiveStatus;
            db.SaveChanges();

            var data = from o in db.OrderDetails
                       join p in db.Products
                       on o.ProductID equals p.ProductID
                       select new
                       {
                           o.ProductID,
                           p.ProductName,
                           p.ProductPrice,
                           o.Quantity,
                           p.SellerID,
                           o.OrderID,
                       };

            var productQuantities = data
                                .Where(c => c.OrderID == _orderid && c.SellerID == _sellerid)
                                .GroupBy(x => x.ProductID)
                                .ToDictionary(g => g.Key, g => g.Sum(x => x.Quantity));

            foreach (var item in productQuantities)
            {
                //MessageBox.Show($"ProductID: {item.Key}, Total Quantity: {item.Value}");

                var data2 = db.ProductsStocks.Find(item.Key);
                //訂單數量扣除
                data2.OrderQuantity -=item.Value; 
                data2.QuantitySold += item.Value;
                data2.StockQuantity -= item.Value;
                db.SaveChanges();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var db = new AppDbContext();
            var shipment = db.Shipments.Find(_shipmentid);
            shipment.ShipmentStatus = "準備中";
            shipment.ShipDate = null;
            shipment.CompletionStatus = "準備中";
            shipment.ArrivalTimeDate = null;
            shipment.ReceiveStatus = "準備中";
            shipment.CompletionDate = null;
            db.SaveChanges();

            this.Close();
        }
    }
}
