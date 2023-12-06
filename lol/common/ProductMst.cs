using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lol.common
{
    public class ProductMst
    {
        public int pk_ProductId { get; set; }
        public int fk_ProductId { get; set; }
        public string ProductName { get; set; }
        public double oriPrice { get; set; }
        public double sellingupToPrice { get; set; }
        public double ProductQuantity { get; set; }
    }
}