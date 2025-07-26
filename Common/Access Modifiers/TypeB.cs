using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Access_Modifiers
{
    internal class TypeB
    {
        //----------------------------------- Video 03 -----------------------------------
        public TypeB()
        {
            TypeA typeA = new TypeA();
            //typeA.x = 10;
            typeA.y = 20;
            typeA.z = 30;
        }

    }
}
