using System;
using System.Collections.Generic;
using System.Text;

namespace Molecula
{
    interface IMove
    {
       void Go_Back();
       void Go_Forward();
       void Go_Left();
       void Go_Right();
    }
}
