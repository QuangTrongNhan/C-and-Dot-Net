using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class MyUtill
    {
        public string getCode(string msg)
        {
            string inputCode = "";
            while (true)
            {
                Console.WriteLine(msg);
                inputCode = Console.ReadLine();
                if (string.IsNullOrEmpty(inputCode))
                {
                    Console.WriteLine("Code is not null");
                }
                else
                {
                    return inputCode;
                }
            }
        }

        public string getName(string msg)
        {
            string inputName = "";
            while (true)
            {
                Console.WriteLine(msg);
                inputName = Console.ReadLine();
                if (string.IsNullOrEmpty(inputName))
                {
                    Console.WriteLine("Name is not null");
                }
                else
                {
                    return inputName;
                }
            }
        }

        public float getPrice(string msg, string warning, string error)
        {
            float inputAmount = 0;
            do
            {
                try
                {
                    Console.WriteLine(msg);
                    inputAmount = float.Parse(Console.ReadLine());
                    if (inputAmount < 0)
                    {
                        Console.WriteLine(warning);
                        continue;
                    }
                    return inputAmount;
                }
                catch (Exception e)
                {
                    Console.WriteLine(error);
                }
            } while (true);
        }
    }
}
