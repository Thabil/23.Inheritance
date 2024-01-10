using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef(); //the chef objects
            chef.MackeChicken();

            ItalianChef chef1 = new ItalianChef(); 
            chef1.MackeChicken();//Italian chef using his inheritance! Chef is superclass, Italian Chef is subclass
            chef1.MakesPasta();//calling his own method, Chef can't call on Make Pasta
            chef1.MakeSpecialDish();
            //freeze
            Console.ReadLine();
        }
    }
}
