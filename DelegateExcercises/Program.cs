using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExcercises
{
    public class DelegateExcercises
    {
        public delegate void MyDelegate();
        void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();


        }


    }
}
namespace DelegateAndEvents
{
    class program
    {
        static void Main(string[] args)
        {
            // TO DO: Call Method2 from the DelegateExcercises class
        }
    }
}


