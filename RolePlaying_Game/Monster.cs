using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlaying_Game
{
    internal class Monster : Character
    {
        protected Item[] Drop_Item_Table { get; set; }
        protected int Drop_Money { get; set; }
        Random drop_rate;

        public Monster(Item[] drop_items, int drop_money, string name, int hp, int attackRate) : base(name, hp, attackRate)
        {
            Console.WriteLine($"몬스터 {name}(이)가 나타났다!");
            Drop_Item_Table = drop_items;
            Drop_Money = drop_money;
            drop_rate = new Random();
        }

        public override void Hit(int attacked_rate)
        {
            base.Hit(attacked_rate);
        }

        public List<Item> DropItem()
        {
            List<Item> drop_items = new List<Item>();
            if (!alive)
            {
                Console.Write("아이템 드랍 : ");
                foreach (var item in Drop_Item_Table)
                {
                    if (drop_rate.Next(0, 10) > 2)
                    {
                        Console.Write($"{item.name} ");
                        drop_items.Add(item);
                    }
                }
                if (drop_items.Count == 0)
                {
                    Console.Write("없음");
                }
                Console.WriteLine();
            }
            return drop_items;
        }

        public int DropMoney()
        {
            if (!alive)
            {
                int drop_money = Drop_Money + drop_rate.Next(0, 10);
                Console.WriteLine($"머니 드랍 : {drop_money}");
                return drop_money;
            }
            else
                return 0;
        }
    }
}
