using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlaying_Game
{
    internal struct Item
    {
        public string name { get; set; }
        public int price { get; set; }

        public Item(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
    }
    internal class Character
    {
        protected string name;
        protected int HP { get; set; }
        protected int AttackRate { get; set; }
        protected bool alive { get; set; }

        public Character(string name, int hP, int attackRate)
        {
            this.name = name;
            HP = hP;
            AttackRate = attackRate;
            this.alive = true;
        }

        public int Attack()
        {
            Console.WriteLine($"{name}의 공격!");
            return AttackRate;
        }

        public void Hit(int attacked_rate)
        {
            HP -= attacked_rate;
            if (HP <= 0)
            {
                Console.WriteLine($"{name}가 죽었습니다.");
                alive = false;
            }
        }
    }
}
