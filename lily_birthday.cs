using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            calculation();
        }

        static void calculation()
        {
            int age; // age of lily
            int toys; // price of toys
            int machine; // price of washing machine
            int money = 0; // money for the birthday
            int price = 0; // money for the toys
            int total; // total money saved


            Console.Write("Enter the age of Lily: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter the price of toys: ");
            toys = int.Parse(Console.ReadLine());

            Console.Write("Enter the price of washing machine: ");
            machine = int.Parse(Console.ReadLine());


            for (int i = 1; i < age; i = i + 2)
            {
                if (age % 2 == 0)
                {
                    money = (money + 10) - 1;
                }
                else
                {
                    price = price + toys;
                }
            }

            total = price + money;

            if (total > machine)
            {
                Console.WriteLine("Yes! Lily can buy the washing machine and will have " + (total - machine) + " dollars left.");

            }
            else
            {
                Console.WriteLine("No! Lily cannot buy the washing machine and needs " + (machine - total) + " dollars more.");
            }
        }
    }
}