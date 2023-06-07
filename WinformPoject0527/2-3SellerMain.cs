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
    public partial class SellerMain : Form
    {
        public int _SellerID;
        public SellerMain()
        {
            InitializeComponent();
            this.Load += SellerMain_Load;
        }

        private void SellerMain_Load(object sender, EventArgs e)
        {
            Display();
        }

        public void Display()
        {
            IQueryable<EFModels.Seller> query = new AppDbContext().Sellers.AsNoTracking();
            txtSellerID.Text = query.Where(c => c.SellerID == _SellerID).Select(a => a.SellerID).FirstOrDefault().ToString();
            txtSellerName.Text = query.Where(c => c.SellerID == _SellerID).Select(a => a.SellerName).FirstOrDefault();
            txtSellerAccount.Text = query.Where(c => c.SellerID == _SellerID).Select(a => a.SellerAccount).FirstOrDefault();
            txtSellerPassword.Text = query.Where(c => c.SellerID == _SellerID).Select(a => a.SellerPassword).FirstOrDefault();
            txtSellerContact.Text = query.Where(c => c.SellerID == _SellerID).Select(a => a.SellerContact).FirstOrDefault();
            txtSellerPhone.Text = query.Where(c => c.SellerID == _SellerID).Select(a => a.SellerPhone).FirstOrDefault();

        }

        private void btnProductMain_Click(object sender, EventArgs e)
        {
            var frm = new SellerProductMain(_SellerID);
            frm.MdiParent = Login.ActiveForm;
            frm.Show();
        }

        private void btnShipments_Click(object sender, EventArgs e)
        {
            var frm = new SellerShipmentsView();
            frm.MdiParent = Login.ActiveForm;
            frm._SellerID = _SellerID;
            frm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var frm = new SellerRegisterEdit();
            frm.MdiParent = Login.ActiveForm;
            frm._SellerID = _SellerID;
            frm.Show();
        }
    }
}
