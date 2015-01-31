using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Hero myHero = new Hero("Girl");
            myHero.show();
            myHero.fight();
           

            // Wait for output before closing console.           

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
            
        }
        


    }
}
