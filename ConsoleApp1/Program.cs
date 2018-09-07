using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubtype c = new ConcreteSubtype();
            c.Alpha();
            c.Bravo();
            c.Charlie();
            c.Hello();
            Console.ReadLine();
        }
    }


    public class BaseD
    {
        public virtual void DoWork(int i)
        {
            // Original implementation.
            Console.WriteLine($"From Base class D:");
            Console.WriteLine($"Hello winner number {i}.");
        }
    }

    public abstract class AbstractSupertype : BaseD
    {
        public void Alpha()
        {
            Console.WriteLine("AbstractSupertype.Alpha()");
        }
        public abstract void Bravo();

        public override void DoWork(int i)
        {
            base.DoWork(i);
        }

        public virtual void Charlie()
        {
            Console.WriteLine("AbstractSupertype.Charlie()");
        }
    }

    public class ConcreteSubtype : AbstractSupertype
    {

        public new void Alpha()
        {
            base.Alpha(); //call the abstract method

            Console.WriteLine("ConcreteSubtype.Alpha()"); //new Alpha method it's own content
        }


        public override void Bravo()
        {
            Console.WriteLine("ConcreteSubtype.Bravo()");
        }

        public override void Charlie()
        {
            Console.WriteLine("ConcreteSubtype.Charlie()");
        }

        public void Hello()
        {
            DoWork(1);
        }
    }
}
