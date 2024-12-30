using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_VendingMachine
{
    internal class User
    {
        private int CashInHand { get; set; }
        private bool CardInHand { get; set; }
        private int CardLimit { get; set; }
        public User(int cash, bool card, int limit)
        {
            CashInHand = cash;
            CardInHand = card;
            CardLimit = limit;
        }

        public int InputCash(int price)
        {
            // 1000원 단위로 현금 결재
            int cash1000 = price / 1000 * 1000 + 1000;

            if (CashInHand >= cash1000)
            {
                CashInHand -= cash1000;
                return cash1000;
            }
            else
            {
                return 0;
            }
        }

        public int InputCard(int price)
        {
            if (CardInHand && CardLimit >= price)
            {
                CardLimit -= price;
                return price;
            }
            else
            {
                return 0;
            }
        }

        public void TakeBalance(int balance)
        {
            if (balance > 0)
            {
                CashInHand += balance;
            }
        }
    }
}
