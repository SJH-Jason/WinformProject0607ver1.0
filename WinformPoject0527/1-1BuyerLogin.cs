using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformPoject0527.EFModels;

namespace WinformPoject0527
{
    
    public partial class BuyerLogin : Form
    {
        string _account = "";
        string _pw = "";
        public int _userIdlogin;
        public int _cartIdBuyerLogin;


        public BuyerLogin()
        {
            InitializeComponent();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
       

        private void buttonDemo_Click(object sender, EventArgs e)
        {           
            
            textBoxaccount.Text = "Jason@123.com";
            textBoxPw.Text = "1234";
        }


        public void buttonlogin_Click(object sender, EventArgs e)
        {
            _account= textBoxaccount.Text;
            _pw = textBoxPw.Text;

            try 
            {
                List<int> userID = new List<int>();
                var query1 = new AppDbContext().Users
                                            .Where(x => x.UserAccount == _account && x.UserPassword == _pw)
                                            .Select(x => x.UserID);
                foreach (var item in query1)
                {
                    userID.Add(item);
                }
                _userIdlogin = userID[0];


                if (query1 != null)
                {                                      
                    //取得取的ShoppingCart的CartID
                    var CartIDlog = new AppDbContext().ShoppingCarts
                                                    .Where(x => x.UserID == _userIdlogin)
                                                    .OrderByDescending(x => x.CartID).Select(x => x.CartID)
                                                    .FirstOrDefault();
                    _cartIdBuyerLogin = CartIDlog;


                    //秀出商品主頁
                    var frm = new BuyerMain();
                    frm.MdiParent = Login.ActiveForm;
                    frm._userIdMain = _userIdlogin;
                    frm._cartIdBuyerMain = _cartIdBuyerLogin;
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("請輸入正確帳戶與密碼");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入正確帳戶與密碼");
            }
            
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            var frm = new BuyerRegister();
            frm.MdiParent = Login.ActiveForm;
            frm.Show();
        }

     
    }
}
