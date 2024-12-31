using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlaying_Game
{
    internal class Player : Character
    {
        private int OwnedMoney { get; set; }
        private List<Item> owned_items;

        public Player(int owned_money, List<Item> owned_items, string name, int hp, int attackRate) : base(name, hp, attackRate)
        {
            OwnedMoney = owned_money;
            this.owned_items = owned_items;
        }

        public void Buy(string item_name_want_buy, int item_price_want_buy)
        {
            if (item_price_want_buy >= 0)
            {
                owned_items.Add(new Item(item_name_want_buy, item_price_want_buy));
                OwnedMoney -= item_price_want_buy;
                Console.WriteLine($"{item_name_want_buy} 구매 성공!. 잔액 : {OwnedMoney}");
            }
            else
                Console.WriteLine($"{item_name_want_buy} 구매 실패...");
        }
        public void Sell(Item item_want_sell, int price)
        {
            owned_items.Remove(item_want_sell);
            OwnedMoney += price;
            Console.WriteLine($"{item_want_sell} 판매. 잔액 : {OwnedMoney}");
        }


    }
}
