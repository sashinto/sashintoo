using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uprajenienineainai
{
    internal class Hero
    {
        //contain all common properties of hero
        private int _health;
        public string Name { get; set; }
        public int Health
        {
            get => _health;
            set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else if (value > 200)
                {
                    _health = 200;
                }
                else
                {
                    _health = value;
                }
            }
        }
        public int Attack { get; set; }
        public int Defence { get; set; }
        //Default constructor
        public Hero()
        {

        }
        public Hero(string name = "No Name", int health = 25, int attack = 5, int defence = 5)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defence = defence;
        }
        public virtual void CelebrateWin()
        {
            Console.WriteLine($"{Name}Uhuuu I won");
        }
    }
}
