namespace RolePlaying_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item[] sell_items = new Item[]
            {
                new Item("빨간 포션", 500),
                new Item("파란 포션", 600)
            };

            Item[] drop_items_orc = new Item[]
            {
                new Item("오크의 엄니", 52),
                new Item("빨간 포션", 500)
            };

            Item[] drop_items_slime = new Item[]
            {
                new Item("이상한 액체", 43),
                new Item("파란 포션", 600)
            };

            List<Item> player_items = new List<Item>()
            {
                new Item("목검", 1000),
                new Item("가죽 갑옷", 800)
            };


            NPC goods_merchant = new NPC(sell_items, "잡화 상인", 100, 1);
            Player player = new Player(2000, player_items, "초보자", 500, 15);

            player.Buy("빨간 포션", goods_merchant.Sell("빨간 포션", player.OwnedMoney));
            player.Buy("파란 포션", goods_merchant.Sell("파란 포션", player.OwnedMoney));
            player.Buy("강철 검", goods_merchant.Sell("강철 검", player.OwnedMoney));

            Console.WriteLine();
            player.LevelUp();
            Console.WriteLine();

            Orc orc1 = new Orc(6, drop_items_orc, 60, "오크 잡졸", 40, 10);
            orc1.Hit(player.Attack());
            orc1.Hit(player.Attack());
            player.Hit(orc1.Attack());
            orc1.Hit(player.Attack());
            player.LootItem(orc1.DropItem());
            player.LootMoney(orc1.DropMoney());

            Console.WriteLine();
            player.LevelUp(50);
            Console.WriteLine();

            Slime slime1 = new Slime(10, drop_items_slime, 40, "초록 슬라임", 30, 7);
            slime1.Hit(player.Attack());
            player.Hit(slime1.Attack());
            slime1.Hit(player.Attack());
            slime1.Hit(player.Attack());
            player.LootItem(slime1.DropItem());
            player.LootMoney(slime1.DropMoney());

            Console.WriteLine();
            player.LevelUp(40, 5);
            Console.WriteLine();

            player.Sell(drop_items_orc[0], goods_merchant.Buy(drop_items_orc[0]));
            player.Sell(sell_items[1], goods_merchant.Buy(sell_items[1]));
        }
    }
}
