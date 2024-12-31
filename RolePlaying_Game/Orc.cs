using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlaying_Game
{
    internal class Orc : Monster
    {
        private int Rage_Rate { get; set; }
        private bool Rage_Sign { get; set; }

        public Orc(int rage_rate, Item[] drop_items, int drop_money, string name, int hp, int attackRate) : base(drop_items, drop_money, name, hp, attackRate)
        {
            Rage_Rate = rage_rate;
            Rage_Sign = false;
        }

        public override void Hit(int attacked_rate)
        {
            base.Hit(attacked_rate);

            if (alive && HP <= 10 && !Rage_Sign)
                Rage();
        }

        public void Rage()
        {
            AttackRate += Rage_Rate;
            Rage_Sign = true;
            Console.WriteLine($"{name}가 분노했습니다! 공격력이 더욱 강력해집니다.");
        }
    }
}
