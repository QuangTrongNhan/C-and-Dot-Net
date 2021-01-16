using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class ItemManagement
    {
        List<Item> items = new List<Item>();
        MyUtill myUtill = new MyUtill();
        public void addItem()
        {
            string code, name;
            float price;
            int check = 0;
            do
            {
                Console.WriteLine("==========================================");
                code = myUtill.getCode("Enter your code: ");
                check = checkCode(code);
            } while (check == 1);
            name = myUtill.getName("Enter your name: ");
            price = myUtill.getPrice("Enter your price", "Price must be than 0", "Price must be digit");


            Item i = new Item(code, name, price);
            items.Add(i);
            items.Sort();
            Console.WriteLine(i.ToString());
            Console.WriteLine("Add success");
            Console.WriteLine("==========================================");
        }

        public void update()
        {
            int check = 0;
            if (items.Count == 0)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("List items is empty!!!");
                Console.WriteLine("===============================");
            }
            
            
            else
            {
                Console.WriteLine("Enter code you want to update: ");
                showAll();
                string updateCode = Console.ReadLine();
                check = checkCode(updateCode);
                if (check == -1)
                {
                    Console.WriteLine("Item is not found!!!");
                    Console.WriteLine("=================================");
                }
                if(check == 1)
                {
                    for (var i = 0; i < items.Count; i++)
                    {
                        if (items[i].Code.Equals(updateCode))
                        {
                            int index = i;
                            Console.WriteLine("Enter new price: ");
                            float newPrice = float.Parse(Console.ReadLine());
                            Item itemUpdate = new Item(items[i].Code, items[i].Name, items[i].Price = newPrice);
                            items.RemoveAt(index);
                            items.Add(itemUpdate);
                            items.Sort();
                            break;
                        }
                    }
                }
                showAll();
            }
            
        }

        public void delete()
        {
            int check = 0;
            if (items.Count == 0)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("List items is empty!!!");
                Console.WriteLine("===============================");
            }


            else
            {
                Console.WriteLine("Enter code you want to delete: ");
                showAll();
                string deleteCode = Console.ReadLine();
                check = checkCode(deleteCode);
                if (check == -1)
                {
                    Console.WriteLine("Item is not found!!!");
                    Console.WriteLine("=================================");
                }
                if (check == 1)
                {
                    for (var i = 0; i < items.Count; i++)
                    {
                        if (items[i].Code.Equals(deleteCode))
                        {
                            int index = i;
                            items.RemoveAt(index);                            
                            items.Sort();
                            break;
                        }
                    }
                    Console.WriteLine("Delete success!!!");
                }
                showAll();
            }
        }

        public void search()
        {
            int check = 0;
            if (items.Count == 0)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("List items is empty!!!");
                Console.WriteLine("===============================");
            }


            else
            {
                Console.WriteLine("Enter code you want to search: ");
                showAll();
                string searchItem = Console.ReadLine();
                check = checkCode(searchItem);
                if (check == -1)
                {
                    Console.WriteLine("Item is not found!!!");
                    Console.WriteLine("=================================");
                }
                if (check == 1)
                {
                    for (var i = 0; i < items.Count; i++)
                    {
                        if (items[i].Code.Equals(searchItem))
                        {
                            Console.WriteLine("Code: {0}    Name:{1}    Price:{2}",items[i].Code, items[i].Name, items[i].Price);                          
                            break;
                        }
                    }
                    
                }
            }
        }

        public int checkCode (string code)
        {
            for(int i = 0; i < items.Count; i++)
            {
                if (items[i].Code.Equals(code)){
                    Console.WriteLine("Code is existed");
                    return 1;
                }
            }
            return -1;
        }


        public void showAll()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("List items is empty!!!");
                Console.WriteLine("===============================");
            }
            for (var i = 0;i < items.Count;i++)
            {
                items.Sort();
                Console.WriteLine("Code: {0}   Name: {1}   Price: {2}",items[i].Code, items[i].Name, items[i].Price);
                Console.WriteLine("=============================");
            }
        }
    }
}
