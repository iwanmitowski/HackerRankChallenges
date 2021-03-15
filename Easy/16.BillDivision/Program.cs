using System;
using System.Linq;

namespace _16.BillDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nk[0];
            int k = nk[1];

            int[] bill = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int money = int.Parse(Console.ReadLine());

            int foodCostAtK = bill[k];

            int totalBill = bill.Sum()-foodCostAtK;
            int splitBill = totalBill / 2;

            if (money-splitBill==0)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(money-splitBill);
            }
        }
    }
}
