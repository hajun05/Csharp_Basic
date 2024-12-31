using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlaying_Game
{
    internal class Monster : Character
    {
        private Item[] Drop_Items { get; set; }
        private int Drop_Money { get; set; }
        //Random drop_rate;
        public Monster(Item[] drop_items, int drop_money, string name, int hp, int attackRate) : base(name, hp, attackRate)
        {
            Drop_Items = drop_items;
            Drop_Money = drop_money;
        }
    }
}
