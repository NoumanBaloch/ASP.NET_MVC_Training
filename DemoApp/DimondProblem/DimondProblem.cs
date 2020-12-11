using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimondProblem
{
    public class A
    {
        public virtual void Print()
        {
            Console.WriteLine("Class A Implementation");
        }
    }

    public class B : A
    {
        public override void Print()
        {
            Console.WriteLine("Class B Implementation");
        }
    }
    public class C : A
    {
        public override void Print()
        {
            Console.WriteLine("Class C Implementation");
        }
    }

    public class D : B, C
    {
    }

    public class Test
    {
        public void Tests()
        {
            D d = new D();
            d.Print();
        }
    }
}
