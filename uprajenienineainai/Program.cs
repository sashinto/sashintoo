using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uprajenienineainai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //classBattle( contain all the logic for battle between heroes)
            //class Hero
            //several class derivate(proizvodni)  of Hero---> / Sorcer/Warrior/Paladin/
            //
            Hero batman = new Hero("batman", 120, 17, 13);
            Hero superman = new Hero("superman", 150, 20, 14);
            Battle firstBattle=new Battle();
            firstBattle.StartBattle(superman, batman);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Battle ends");
        }
    }
}
