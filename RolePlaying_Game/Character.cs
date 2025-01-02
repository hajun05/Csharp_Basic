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

        protected int MaxHP { get; set; }
        protected int AttackRate { get; set; }
        protected bool alive { get; set; }

        public Character(string name, int hp, int attackRate)
        {
            this.name = name;
            HP = hp;
            MaxHP = hp;
            AttackRate = attackRate;
            this.alive = true;
        }

        public int Attack()
        {
            if (alive)
            {
                Console.WriteLine($"{name}의 공격!");
                return AttackRate;
            }
            else
                return -1;
        }

        public virtual void Hit(int attacked_rate)
        {
            if (attacked_rate < 0)
                return;
            if (alive)
            {
                HP -= attacked_rate;
                if (HP < 0)
                    HP = 0;
                Console.WriteLine($"{name}의 남은 HP : {HP}");
                if (HP == 0)
                {
                    Console.WriteLine($"{name}(이)가 죽었습니다.");
                    alive = false;
                }
            }
            else
            {
                Console.WriteLine($"이미 {name}은 죽었습니다.");
            }
        }

        public virtual void Talk()
        {
            Console.WriteLine();
        }

        ~Character()
        {
            Console.WriteLine($"{name}(이)가 사라집니다.");
        }
    }
}
