using System;
using System.Collections.Generic;
using System.Text;

namespace Molecula
{
    class Fast:IMove
    {
        public Fast(){}
        public void Go_Back()
        {
            Console.WriteLine("I go back fast");
        }
        public void Go_Forward()
        {
            Console.WriteLine("I go forward fast");
        }
        public void Go_Left()
        {
            Console.WriteLine("I go left fast");
        }
        public void Go_Right()
        {
            Console.WriteLine("I go right fast");
        }
    }
}
