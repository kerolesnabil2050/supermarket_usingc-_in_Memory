using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market
{
    class Stor
    {
        private static int StorNumber = 10;
        public Stor()

        {
            StorNumber+=10;
        }
        
        private int x = StorNumber;
        public int Id {
            get
            { return x; } }
                
                  
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Categorys> Categories { get; set; }
    }
}
