using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPoject0527.EFModels;

namespace WinformPoject0527
{
    public partial class BuyerReceiveStatus : Form
    {
        
        public int _shipid;
        public int _sellerid;
        public int _orderIDBuyerReceiveStatus;
        public int _userIdBuyerReceiveStatus;
        public int _cartIdBuyerReceiveStatus;

        List<BuyerShipDto> data;

        public BuyerReceiveStatus(int shipid, int sellerid)
        {
            InitializeComponent();
            _shipid = shipid;
            _sellerid = sellerid;
            this.Load += BuyerReceiveStatus_Load;
           
        }

        private void BuyerReceiveStatus_Load(object sender, EventArgs e)
        {
            textBoxShipmentID.Text = _shipid.ToString();

            //datagridview
            var db = new AppDbContext();


            var query = db.OrderDetails
                            .Where(x => x.OrderID == _orderIDBuyerReceiveStatus)
                            .OrderBy(x => x.ProductID)
                            .Join(db.Products, X => X.ProductID, y => y.ProductID, (x, y) => new
                            {
                                _productID = x.ProductID,
                                _productname = y.ProductName,
                                _productQuantity = x.Quantity,
                                _sellerid=y.SellerID
                            })
                            .Join(db.Shipments, x => x._sellerid, y => y.SellerID, (x, y) => new
                            {
                                _productIDs=x._productID,
                                _productnames=x._productname,
                                _productQuantitys=x._productQuantity,
                                _shipids=y.ShipmentID
                            })
                            .Where(y=>y._shipids==_shipid)
                            .ToList();

            data = query.Select(x => new BuyerShipDto()
            {
                ProductId = x._productIDs,
                ProductName = x._productnames,
                Quantity = x._productQuantitys

            }).ToList();
            this.dataGridView1.DataSource = data;

            var data2 = db.Shipments.Find(_shipid);
            textBoxArrivalTimeDate.Text = data2.ArrivalTimeDate.ToString();
            textBoxReceiveStatus.Text = data2.ReceiveStatus?.ToString();

            if (data2.ReceiveStatus?.ToString() == "等候領取")
            {
                buttoncomplete.Enabled = true;
            }
            else
            {
                buttoncomplete.Enabled = false;
            }
        }

        private void buttoncomplete_Click(object sender, EventArgs e)
        {
            var db = new AppDbContext();
            db.Shipments.Find(_shipid).ReceiveStatus = "已領取";
            db.SaveChanges();

            Close();
            
        }
    }
}
