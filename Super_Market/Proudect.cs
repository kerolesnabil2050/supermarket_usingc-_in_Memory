using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market
{
    class Proudect
    {
        public int Id { get; set; } // id must be uique
        public string Name { get; set; }
        public double SellingPrice { get; set; }
        public double PurchasingPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        //public Category category { get; set; }
        public int category_id { get; set; }
    }
}
