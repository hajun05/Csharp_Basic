using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlaying_Game
{
    internal class Slime : Monster
    {
        private int Self_Heal_Rate { get; set; }
        private bool Heal_Sign { get; set; }

        public Slime(int heal_rate, Item[] drop_items, int drop_money, string name, int hp, int attackRate) : base(drop_items, drop_money, name, hp, attackRate)
        {
            Self_Heal_Rate = heal_rate;
            Heal_Sign = false;
        }

        public override void Hit(int attacked_rate)
        {
            base.Hit(attacked_rate);

            if (alive && HP <= 10 && !Heal_Sign)
                SelfHeal();
        }

        public void SelfHeal()
        {
            HP += Self_Heal_Rate;
            Heal_Sign = true;
            Console.WriteLine($"{name}가 스스로를 치유합니다. HP {Self_Heal_Rate} 회복!");
        }
    }
}
