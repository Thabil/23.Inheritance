using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class ItalianChef: Chef //this nakes Italian Chef inherit all there is in Chef, can now call methods in chef!
    {
        public void MakesPasta()
        {
            Console.WriteLine("hakes Pasta");
        }
        public override void MakeSpecialDish() //use keynord Override
        {
            Console.WriteLine("The chef nakes Italianspecials ");
        }


        //this class inherits fron superclass, extends superclas by making new functions and also overrides sone superclass functions
    }
    
}
