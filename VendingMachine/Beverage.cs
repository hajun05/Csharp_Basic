using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Using_VendingMachine
{
    public struct Beverage_status
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Beverage_status(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }

    public class Beverage
    {
        public Beverage_status beverage_status { get; set; } 
        public Beverage(string name, int price) 
        {
            beverage_status = new Beverage_status(name, price);
        }
    }
}

