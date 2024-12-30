using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_VendingMachine
{
    public partial class VendingMachine : Form
    {
        // 음료, 사용자, 관리자, 저장 현금, 재고, 잔액
        Beverage beverage;
        User user;
        Manager manager;
        int storge_cash;
        int stock;
        int balance;

        // 음료 자판기를 구성하는 음료, 사용자, 관리인 객체 생성
        public VendingMachine()
        {
            InitializeComponent();

            beverage = new Beverage("코카콜라", 1200);
            user = new User(10000, true, 10000);
            manager = new Manager(50);
            storge_cash = 100000;
            stock = 5;
            balance = 0;
            
            // 음료 정보를 자판기 화면에 출력
            Beverage_name.Text = beverage.beverage_property.Name;
            Beverage_price.Text = string.Format($"{beverage.beverage_property.Price}원");
        }

        // 카드 결제 실행
        private void Card_pay_Click(object sender, EventArgs e)
        {
            if (stock <= 0)
            {
                Beverage_output.Text = "품절되었습니다.";
            }
            else if(user.InputCard(beverage.beverage_property.Price) > 0)
            {
                Beverage_output.Text = beverage.beverage_property.Name;
                stock--;
            }
            else
            {
                Beverage_output.Text = "카드 한도 초과";
            }
        }

        // 현금 결재 실행
        private void Cash_pay_Click(object sender, EventArgs e)
        {
            if (stock <= 0)
            {
                Beverage_output.Text = "품절되었습니다.";
                return;
            }
            else if (storge_cash < beverage.beverage_property.Price)
            {
                Beverage_output.Text = "잔액이 부족합니다";
                return;
            }
            int input_cash = user.InputCash(beverage.beverage_property.Price);
            if (input_cash > 0)
            {
                Beverage_output.Text = beverage.beverage_property.Name;
                storge_cash += beverage.beverage_property.Price;
                balance += input_cash - beverage.beverage_property.Price;
                Balance.Text = string.Format($"잔액 {balance}원");
                stock--;
            }
            else
            {
                Beverage_output.Text = "금액이 부족합니다";
            }
        }

        // 사용자가 잔액 회수
        private void Balance_Click(object sender, EventArgs e)
        {
            user.TakeBalance(balance);
            balance = 0;
            Balance.Text = "";
        }

        // 사용자가 나온 음료를 회수
        private void Beverage_output_Click(object sender, EventArgs e)
        {
            Beverage_output.Text = "";
        }

        // 관리자가 음료 재고 채우기, 현금 회수
        private void VendingMachineBack_Click(object sender, EventArgs e)
        {
            manager.Replenishment(ref beverage, ref stock);
            storge_cash = manager.RecoverCash(storge_cash);

            // 관리자가 채운 음료 정보를 자판기 화면에 출력
            Beverage_name.Text = beverage.beverage_property.Name;
            Beverage_price.Text = string.Format($"{beverage.beverage_property.Price}원");
        }
    }
}
