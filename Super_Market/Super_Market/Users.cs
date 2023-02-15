using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market
{
    public enum position
    {
        Casher,
        Admin,
    }
    class Users
    {
        public string UserName { get; set; }
        public int Password { get; set; }
        public float Salary { get; set; }
        public position Pos { get; set; }
    }
}
