using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_1.User_Defined_Data_Type
{
    internal interface IMyInterface
    {
        //----------------------------------- Video 02 -----------------------------------
        int Id { get; set; }

        void Print();

        private void MyFun()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
