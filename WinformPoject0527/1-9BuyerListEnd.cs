using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPoject0527.EFModels;

namespace WinformPoject0527
{
    public partial class BuyerListEnd : Form
    {
        public int _userIdBuyerListEnd;
        public int _cartIdBuyerListEnd;
        public string _shippingMethodNameBuyerListEnd = "";
        public string _paymenyMethodNameBuyerListEnd = "";


        public int _orderID ;
        List<ListDto> data;



        public BuyerListEnd(int sorderid)
        {
            InitializeComponent();
            _orderID=sorderid;
            this.Load += BuyerListEnd_Load;

        }

        private void BuyerListEnd_Load(object sender, EventArgs e)
        {
            var db = new AppDbContext();

            var item = db.Users.AsNoTracking()
                                        .Where(x => x.UserID == _userIdBuyerListEnd)
                                        .FirstOrDefault();
            //_orderID = db.Orders.Where(x => x.UserID == _userIdBuyerListEnd)
            //                        .OrderByDescending(x => x.OrderID)
            //                        .Select(x => x.OrderID)
            //                        .FirstOrDefault();


            textBoxaccount.Text = item.UserAccount;
            textBoxship.Text = _shippingMethodNameBuyerListEnd;
            textBoxpay.Text = _paymenyMethodNameBuyerListEnd;
            textBoxorderid.Text = _orderID.ToString();


            //datagridview            
            var query = db.Shipments.AsNoTracking()
                            .Where(x => x.OrderID == _orderID)
                            .OrderBy(x => x.ShipmentID)
                            .Join(db.Sellers, x => x.SellerID, y => y.SellerID, (x, y) => new
                            {
                                sShipmentID=x.ShipmentID,
                                sSellerID=x.SellerID,
                                sSellerName=y.SellerName,
                                sShipmentDate= (DateTime)x.ShipmentDate
                            }).ToList();

                                                

            data = query.Select(x => new ListDto()
            {
                ShipmentID = x.sShipmentID,
                SellerID = (int)x.sSellerID,
                SellerName=x.sSellerName,
                ShipmentDate = x.sShipmentDate
            }).ToList();

            this.dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

         
            int _ShipID = this.data[e.RowIndex].ShipmentID;
            int _sellerid = this.data[e.RowIndex].SellerID;

            var frm = new BuyerReceiveStatus(_ShipID,_sellerid);
            frm.Owner = this;
            frm._orderIDBuyerReceiveStatus = _orderID;
            frm._cartIdBuyerReceiveStatus = _cartIdBuyerListEnd;
            frm._userIdBuyerReceiveStatus = _userIdBuyerListEnd;
            frm.ShowDialog();
        }

        private void buttonbackmain_Click(object sender, EventArgs e)
        {
            var frm = new BuyerMain();
            frm.MdiParent = Login.ActiveForm;            
            frm._userIdMain = _userIdBuyerListEnd;
            frm._cartIdBuyerMain = _cartIdBuyerListEnd;
            frm.Show();
        }
    }
}
