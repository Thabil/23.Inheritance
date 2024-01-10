using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class Chef
    {
        public void MackeChicken()
        {
            Console.WriteLine("The chef makes Chicken");
        }

        public void MakeSalad()
        {
           
            Console.WriteLine("The chef makes salad");
        }

        public virtual void MakeSpecialDish() //virtual allows subclasses to override
        {
            Console.WriteLine("The chef makes Special dish");
        }
    }
}
