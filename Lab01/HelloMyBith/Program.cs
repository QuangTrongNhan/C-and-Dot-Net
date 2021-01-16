using Lab1;
using System;
using System.Collections;

namespace HelloMyBith
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            ItemManagement itemManagement = new ItemManagement();
            do
            {
                item.display();
                Console.WriteLine("Enter your choice:");
                string yourChoice = Console.ReadLine();
                switch (yourChoice)
                {
                    case "1":
                        itemManagement.addItem();
                        break;
                    case "2":
                        itemManagement.update();
                        break;
                    case "3":
                        itemManagement.delete();
                        break;
                    case "4":
                        //search item by code
                        itemManagement.search();
                        break;
                    case "5":
                        //display item
                        itemManagement.showAll();
                        break;
                    case "6":
                        //quit
                        System.Environment.Exit(1);
                        Console.WriteLine("GoodBye!!!!");
                        break;
                    
                }
            } while (true);
        }
        }
    } 
