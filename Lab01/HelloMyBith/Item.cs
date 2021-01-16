using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab1
{
    class Item : IEquatable<Item>, IComparable<Item>
    {
        private string code;
        private string name;
        private float price;

        //create constructor
        public Item(string code, string name, float price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }

        public Item()
        {            
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return "Code: " + code + "\t" + "Name: " + name + "\t" + "Price: " + price;
        }

        public void display()
        {
            Console.WriteLine("1.Add new item");
            Console.WriteLine("2.Update the price of a item");
            Console.WriteLine("3.Delete a item");
            Console.WriteLine("4.Search item");
            Console.WriteLine("5.Display item");
            Console.WriteLine("6.Quit");
        }

        public int CompareTo(Item compareItem)
        {
            if (compareItem == null)
            {
                return 1;
            }
            else
            {
                return this.Price.CompareTo(compareItem.price);
            }
        }

        public bool Equals([AllowNull] Item other)
        {
            throw new NotImplementedException();
        }
    }
}
