using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class SuperHero : Hero
    {
        //PRIVATE PROPERTIES++++++++++++++++++++++

        private string[] superPowers = {"Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control"};



        //CONSTRUCTOR METHOD++++++++++++++++++++++

        public SuperHero(string name):base(name)
        {
            
            generateRandomPowers();
        }

        //PRIVATE METHODS+++++++++++++++++++++++++

        string[] randomSuperPowers = new string[3];
        private void generateRandomPowers()
        {
            Random rnd = new Random();
            int power;           

            int index = 0;
            
            while ( index < randomSuperPowers.Length)
            {

                power = rnd.Next(5);
                //Console.WriteLine("Random super power is {0}", power);//Debugging line
                if (superPowers[power] != "CHOSEN")
                {                    
                    randomSuperPowers[index] = superPowers[power];
                    superPowers[power] = "CHOSEN";
                    index++;
                }
                
            }
            Console.WriteLine("");
            Console.WriteLine("*****************************");
            Console.WriteLine("       Original Powers       ");
            Console.WriteLine("*****************************");
            Console.WriteLine("");
            for (index = 0; index < superPowers.Length; index++)
            {
                Console.WriteLine(superPowers[index]);
            }
            Console.WriteLine("");
            Console.WriteLine("*****************************");
            Console.WriteLine("       Random Powers         ");
            Console.WriteLine("*****************************");
            Console.WriteLine("");
          
             
        }
            
        

        //PUBLIC METHODS++++++++++++++++++++++++++

        public void showPowers()
        {
            int index = 0;


           
            
            for (index = 0; index < randomSuperPowers.Length; index++)
            {
                Console.WriteLine(randomSuperPowers[index]);
                
            }
              

        }
     
  
    }
}
