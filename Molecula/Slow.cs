using System;
using System.Collections.Generic;
using System.Text;

namespace Molecula
{
    class Slow:IMove
    {
        public Slow(){}
        public void Go_Back()
        {
            Console.WriteLine("I go back slow");
        }
        public void Go_Forward()
        {
            Console.WriteLine("I go forward slow");
        }
        public void Go_Left()
        {
            Console.WriteLine("I go left slow");
        }
        public void Go_Right()
        {
            Console.WriteLine("I go right slow");
        }
    }
}
