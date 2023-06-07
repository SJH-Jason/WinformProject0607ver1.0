using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformPoject0527
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public int SellerID { get; set; }
        public string CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }

        public int StockQuantity { get; set; }
    }
}
