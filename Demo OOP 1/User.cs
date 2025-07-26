using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_1
{
    //   1       1       1        1
    // Write , Read , Execute , Delete
    internal class User
    {
        public int Id { get; set; } // 4 bytes

        //public bool[] Permisions { get; set; } = new bool[4]; // 4 bytes
        public Permissions Permissions { get; set; }
    }
}
