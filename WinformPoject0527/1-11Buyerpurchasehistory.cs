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
    public partial class Buyerpurchasehistory : Form
    {
        public int _userIdBuyerpurchasehistory;
        public int _cartIdBuyerpurchasehistory;

        List<ListAllDto> data;

        public string _shippingMethodNameBuyerpurchasehistory = "";
        public string _paymenyMethodNameBuyerpurchasehistory = "";


        public Buyerpurchasehistory()
        {
            InitializeComponent();
            this.Load += Buyerpurchasehistory_Load;
        }

        private void Buyerpurchasehistory_Load(object sender, EventArgs e)
        {
            var db=new AppDbContext();
            var acc=db.Users.Where(x=>x.UserID==_userIdBuyerpurchasehistory)
                                .Select(x=>x.UserAccount).FirstOrDefault();

            textBoxaccount.Text = acc;

            //datagridview
            var query =db.Orders.Where(x=>x.UserID== _userIdBuyerpurchasehistory)                                
                                .ToList();

            data=query.Select(x=>new ListAllDto()
            {
                OrderID=x.OrderID,
                ShipmentDate= (DateTime)x.OrderDate

            }).ToList();

            dataGridView1.DataSource= data;
           
        }

        private void buttonbackmain_Click(object sender, EventArgs e)
        {
            var frm = new BuyerMain();
            frm.MdiParent = Login.ActiveForm;
            frm._userIdMain = _userIdBuyerpurchasehistory;
            frm._cartIdBuyerMain = _cartIdBuyerpurchasehistory;
            frm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var db = new AppDbContext();

            //ShippingMethods取的combobox其id的name
            var query12 = db.Users.Where(x => x.UserID == _userIdBuyerpurchasehistory)
                                    .Join(db.ShippingMethods
                                            .AsNoTracking(), x => x.ShippingMethodId, y => y.ShippingMethodId, (x, y) => new
                                            {
                                                _shippingMethodName = y.ShippingMethodName
                                            });

            List<string> _shippingMethodNamelist = query12.Select(x => x._shippingMethodName).ToList();
            _shippingMethodNameBuyerpurchasehistory = _shippingMethodNamelist[0];

            //PaymenyMethods取的combobox其id的name
            var query22 = db.Users.Where(x => x.UserID == _userIdBuyerpurchasehistory)
                                    .Join(db.PaymentMethods
                                            .AsNoTracking(), x => x.PaymenyMethodId, y => y.PaymentMethodId, (x, y) => new
                                            {
                                                _paymenyMethodName = y.PaymentMethodName
                                            });

            List<string> _paymenyMethodNamelist = query22.Select(x => x._paymenyMethodName).ToList();
            _paymenyMethodNameBuyerpurchasehistory = _paymenyMethodNamelist[0];




            if (e.RowIndex<0) return;

            int _orderid = this.data[e.RowIndex].OrderID;

            var frm = new BuyerListEnd(_orderid);
            frm.MdiParent = Login.ActiveForm;
            //frm._orderID= _orderid;
            frm._userIdBuyerListEnd= _userIdBuyerpurchasehistory;
            frm._cartIdBuyerListEnd = _cartIdBuyerpurchasehistory;
            frm._shippingMethodNameBuyerListEnd = _shippingMethodNameBuyerpurchasehistory;
            frm._paymenyMethodNameBuyerListEnd =_paymenyMethodNameBuyerpurchasehistory;
            frm.Show();
        }

       
    }
}
