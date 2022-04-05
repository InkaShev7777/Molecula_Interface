using System;

namespace Molecula
{
    class Program
    {
        internal static void Info(Base_Moleckula m)
        {
            m.Move();
            m.Eat();
            m.Behavior();
        }
        static void Main(string[] args)
        {

            Moleckula_Good moleckula_Good = new Moleckula_Good(12);
            Info(moleckula_Good);
            Moleckula_Bad moleckula_Bad = new Moleckula_Bad(44);
            Info(moleckula_Bad);

        }
    }
}
