using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPoject0527.EFModels;

namespace WinformPoject0527
{
    public partial class SellerLogin : Form
    {
        string account = " ";
        string password = " ";
        public int SellerIdlogin;

        public SellerLogin()
        {
            InitializeComponent();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            //變數值 等於txtbox 內的值 
            account = textBoxaccount.Text;
            password = textBoxPw.Text;
            try
            {
                //List<int> SellerID = new List<int>();
                var query1 = new AppDbContext().Sellers
                                            .Where(x => x.SellerAccount == account && x.SellerPassword == password)
                                            .Select(x => x.SellerID).FirstOrDefault();
                //foreach (var item in query1)
                //{
                //    SellerID.Add(item);
                //}
                SellerIdlogin = query1;

                //不用繞一圈 直接確認有沒有值 有值 等於SellerID 沒值等於default
                if (query1 != default)
                {
                    var frm = new SellerMain();
                    frm.MdiParent = Login.ActiveForm;
                    frm._SellerID = SellerIdlogin;
                    frm.Show();

                    textBoxPw.Text = "";
                }
                else
                {
                    MessageBox.Show("請輸入正確帳號或密碼");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入正確帳號或密碼");
            }


        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDemo_Click(object sender, EventArgs e)
        {
            //這裡僅有帶入值 不能設定變數值
            textBoxaccount.Text = "Apple@123.com";
            textBoxPw.Text = "1234";
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            var frm = new SellerRegister();
            frm.MdiParent = Login.ActiveForm;
            frm.Show();
        }
    }
}
