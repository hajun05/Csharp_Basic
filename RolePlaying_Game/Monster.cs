using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlaying_Game
{
    internal class Monster : Character
    {
        protected Item[] Drop_Items { get; set; }
        protected int Drop_Money { get; set; }
        //Random drop_rate;

        public Monster(Item[] drop_items, int drop_money, string name, int hp, int attackRate) : base(name, hp, attackRate)
        {
            Drop_Items = drop_items;
            Drop_Money = drop_money;
        }

        public override void Hit(int attacked_rate)
        {
            base.Hit(attacked_rate);
            if (!alive)
            {
                Drop();
            }
        }

        public void Drop()
        {
            Console.Write("아이템 드랍 : ");
            foreach(var item in Drop_Items)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"- 머니 드랍 : {Drop_Money}");
        }
    }
}
