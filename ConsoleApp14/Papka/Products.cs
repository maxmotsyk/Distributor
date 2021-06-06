using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace ConsoleApp14.Papka
{
    class Products : HouseholdChemicals
    {
        protected int[] index1 = new int[2];
        protected long[,] product1 = new long[3, 1] { { 1000 }, { 2000 }, { 3000 } };
        protected long Profit;

        public Products() { }
       
        public void Send1()
        {
            long temp;
            Console.WriteLine("[0][0]-fruit\n[1][0]-vegetables\n[2][0]-milk products\n\n");
            try
            {
                Console.Write("Enter product index-");
                for (int i = 0; i < index1.Length; i++)
                {
                    index1[i] = int.Parse(Console.ReadLine());
                }
               
                if (index1[0] > 3 || index1[1] > 1)
                {
                    throw new Exception("ERROR::there is no product under this index");
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e);
            }

            try
            {
                Console.Write("enter the quantity of goods to order-");
                Profit = long.Parse(Console.ReadLine());
                if (product1[index1[0], index1[1]] < Profit)
                {
                    throw new Exception("ERROR::there is no such quantity of goods in stock");
                }
                 product1[index1[0], index1[1]] -= Profit;
                 temp = Profit * 15;
                 Сheck(index1, Profit,temp, "p");
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e);
            }

        }

        protected long GetMoney
        {
            get { return Profit * 15; }
        }

    }
}
