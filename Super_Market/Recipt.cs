using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market
{
    class Recipt
    {
        private static int bon = 0;
        public int BonNumber = bon;
        public Recipt()
        {
            bon++;
        }
        public Suppliers supplier;
        public List<Proudect> products;
        public string StoreName;
        public int Quantity;
        public int Discount;

        public DateTime dateTime
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
