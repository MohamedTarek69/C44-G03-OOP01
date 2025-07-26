using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Access_Modifiers
{
    public class TypeA
    {
        //----------------------------------- Video 03 -----------------------------------
        private int x;
        internal int y;
        public int z;

        public void print()
        {
            x = 10; // Accessable withen its Scope only
            y = 20; // Accessable withen its Scope and in Class in intrenal Project
            z = 30; // Accessable withen its Scope and in Class in intrenal Project and in Class in External Project
        }
    }
}
