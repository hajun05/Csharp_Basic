using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Using_VendingMachine
{
    // 자판기 관리자
    public class Manager
    {
        // 관리자가 가져온 새 음료, 현금, 재고
        Beverage beverage = new Beverage("칠성 사이다", 1300);
        private int CashToRecover { get; set; }
        private int ReplenishmentStock { get; set; }
        public Manager(int stock)
        {
            CashToRecover = 0;
            ReplenishmentStock = stock;
        }

        // 새 음료 재고 채우기
        public void Replenishment(ref Beverage existing_beverage, ref int stock)
        {
            // 관리자가 가져온 음료가 기존 음료와 동일
            if (existing_beverage.beverage_status.Name == beverage.beverage_status.Name)
            {
                stock += ReplenishmentStock;
            }
            //  관리자가 가져온 음료가 기존 음료와 상이
            else
            {
                existing_beverage = beverage;
                stock = ReplenishmentStock;
            }
            ReplenishmentStock = 0;
        }

        // 자판기에 저장된 현금 회수
        public int RecoverCash(int storage_cash)
        {
            CashToRecover += (storage_cash - 100000);
            storage_cash = 100000;
            return storage_cash;
        }
    }
}
