using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market
{
    class Sellinvoce
    {
        private static int BonNumberr = 0;
        public int BonNumber = BonNumberr;

        public Sellinvoce()
        {
            BonNumberr++;
        }

        public Users casherUserName;
        public string NameStore;
        public List<Proudect> Products { get; set; }




        public DateTime dateTime
        {
            get

            {
                return DateTime.Now;
            }
        }


        public double TotalPrice
        {
            get
            {
                double total = 0;
                foreach (var item in Products)
                {
                    total += item.SellingPrice;
                }
                return total;

            }
        }


        public double PaidMoney { get; set; }


        public double RemainingMoney
        {
            get
            {
                return PaidMoney - TotalPrice;
            }
        }
    }
}
