using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlaying_Game
{
    internal class Player : Character
    {
        public int OwnedMoney { get; private set; }
        private List<Item> owned_items;
        private int Level { get; set; }

        public Player(int owned_money, List<Item> owned_items, string name, int hp, int attackRate) : base(name, hp, attackRate)
        {
            OwnedMoney = owned_money;
            this.owned_items = owned_items;
            Level = 1;
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

        public void LootItem(List<Item> drop_items)
        {
            if (drop_items.Count > 0)
            {
                Console.WriteLine("전리품 획득!");
                owned_items.AddRange(drop_items);
            }
        }

        public void LootMoney(int drop_money)
        {
            if (drop_money > 0)
            {
                OwnedMoney += drop_money;
                Console.WriteLine("머니 획득! 소유 머니 : {0}", OwnedMoney);
            }
        }

        public void LevelUp(int up_HP)
        {
            this.Level++;
            Console.WriteLine("{0} 레벨 업! 현재 레벨 : {1}", this.name, this.Level);
            this.MaxHP += up_HP;
            this.HP = this.MaxHP;
            Console.WriteLine("현재 체력 : {0} - 공격력 {1}", this.HP, this.AttackRate);
        }

        public void LevelUp(int up_HP, int up_attack_rate)
        {
            this.Level++;
            Console.WriteLine("{0} 레벨 업! 현재 레벨 : {1}", this.name, this.Level);
            this.MaxHP += up_HP;
            this.HP = this.MaxHP;
            this.AttackRate += up_attack_rate;
            Console.WriteLine("현재 체력 : {0} - 공격력 {1}", this.HP, this.AttackRate);
        }

        public void LevelUp()
        {
            Console.WriteLine("아직 경험치가 충분하지 않습니다. 현재 레벨 : {0}", this.Level);
        }
    }
}
