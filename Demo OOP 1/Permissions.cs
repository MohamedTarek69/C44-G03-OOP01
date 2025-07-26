using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_1
{
    [Flags]
    internal enum Permissions : byte 
    {
        Delete = 1,   // 0001
        Execute = 2,  // 0010
        Read = 4,     // 0100
        Write = 8     // 1000
    }
}
