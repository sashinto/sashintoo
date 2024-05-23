using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace uprajenienineainai
{
    internal class Battle
    {
        private static readonly Random rnd = new Random();
        //method -- > start fight 
        // loop  -- >till one of the heroes get 0 health
        //encapsulation
        // calculate damage
        public Battle() 
        {
            Console.WriteLine("Battle started");
        } 

        public void StartBattle(Hero hero1, Hero hero2)
        {
            while (hero1.Health > 0 && hero2.Health > 0)
            {
                int whoIsfirst = GetWhoIsFirst();
                if (whoIsfirst < 5)
                {
                    //first will be hero 1 
                    PerformAttack(hero1, hero2);
                    if (hero2.Health <= 0)
                    {
                        break;
                    }

                    PerformAttack(hero2, hero1);
                }
                else
                {
                    //first will be hero2
                    PerformAttack(hero2, hero1);
                    if (hero1.Health <= 0)
                    {
                        break;
                    }
                    PerformAttack(hero1, hero2);
                }
            }
            if (hero1.Health <= 0 && hero2.Health > hero1.Health)
            {
                hero2.CelebrateWin();
                Console.WriteLine($"{hero2.Name} wins!");
            }
            else if(hero2.Health<=0 && hero1.Health > hero2.Health)    
            {
                hero1.CelebrateWin();
            }
        }
        

        //perform of the attack
        private void PerformAttack(Hero attacker, Hero defender)
        {
            int demage = 0;
            demage = GetAttackResult(attacker.Attack, defender.Defence);
            if (demage > 0)
            {
                //take health from the defender
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{attacker.Name}attacks with {demage}");
                defender.Health = defender.Health - demage;
                Console.WriteLine($"{defender.Name}'s remaning health is {defender.Health}");
            }
            else
            {
                //defender blocked the attack 
                Console.ForegroundColor = ConsoleColor.Red;
                
                Console.WriteLine($"{defender.Name} blocked successfully the attacker");
            }
        }

        //calculate dmg
        private int GetAttackResult(int attack, int defence)
        {
            Thread.Sleep(2500);
            int additionalMomentumAttack = GetRandomMomentum();
            int realAttack = attack + additionalMomentumAttack;
            return realAttack;
        }
        //who will start first 
        private int GetWhoIsFirst()
        {
            return rnd.Next(0, 10);
        }
        // add random momentum to the attack of attacking hero
        private int GetRandomMomentum()
        {
            return rnd.Next(-7, 7);
        }

    }
}
