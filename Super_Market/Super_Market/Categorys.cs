using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market
{
    class Categorys
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Proudect> Products { get; set; }
        public string storeName { get; set; }

    }
}
