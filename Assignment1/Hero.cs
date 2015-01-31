using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Hero
    {
        //PRIVATE PROPERTIES++++++++++++++
        private int strength;
        private int speed;
        private int health;

        //PUBLIC PROPERTIES+++++++++++++++
        public string name = "SuperGirl";
        

        //CONSTRUCTOR++++++++++++++++++++++++
        public Hero(string name)
        {
            this.name = name;
            generateAbilities();
            
           
        }

       

        //PRIVATE METHODS+++++++++++++++++++++++
        Random r = new Random();  //Create random variable
        private void generateAbilities()
        {
            
            
            strength = r.Next(1, 100);
            
            speed = r.Next(1, 100);
            
            health = r.Next(1, 100);
            
                      
            
	    }

        private bool hitAttempt()
        {
            int prob = r.Next(100);
            if (prob < 20)
            {
                hitDamage();  
                return true;
            }
            else
            {
                return false;
            }
        }
        private int hitDamage()             
        {
            int damage = (strength * r.Next(1, 6));
            Console.WriteLine("The damage caused to the target is {0}", damage);
            return damage;
        }
       
        //PUBLIC METHODS++++++++++++++++++++++++
        public void fight()
        {
            hitAttempt();
        }
        
        public void show()
        {
            Console.WriteLine("The strength is {0}", strength);
            Console.WriteLine("The speed is {0}", speed);
            Console.WriteLine("The health is {0}", health);
        }
    }
}
