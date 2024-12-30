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
    public struct Beverage_Property
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Beverage_Property(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }

    public class Beverage
    {
        public Beverage_Property beverage_property { get; set; } 
        public Beverage(string name, int price) 
        {
            beverage_property = new Beverage_Property(name, price);
        }
    }
}

