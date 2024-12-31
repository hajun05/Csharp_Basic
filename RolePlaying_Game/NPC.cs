using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlaying_Game
{
    internal class NPC : Character
    {
        private Item[] Sell_Items { get; set; }

        public NPC(Item[] sell_items, string name, int hp, int attackRate) : base(name, hp, attackRate)
        {
            Sell_Items = sell_items;
        }

        public int Sell(string item_name, int owned_money)
        {
            foreach (Item item in Sell_Items)
            {
                if (item.name == item_name && owned_money >= item.price)
                {
                    return item.price;
                }
            }
            return -1;
        }

        public int Buy(Item item)
        {
            return item.price;
        }
    }
}
