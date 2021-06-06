using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14.Papka
{
    class HouseholdChemicals :WrittenOff
    {
        protected int[] index2 = new int[2];
        protected long[,] product2 = new long[3, 1] { { 1000 }, { 2000 }, { 3000 } };
        protected long profit2;
        public HouseholdChemicals() { }

        public void Send2()
        {
            long temp;
            Console.WriteLine("[0][0]-detergent\n[1][0]-bathroom detergent\n[2][0]-air freshener\n\n");
            try
            {
                Console.Write("Enter chemicals product index-");
                for (int i = 0; i < index2.Length; i++)
                {
                    index2[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                if (index2[0] > 3 || index2[1] > 1)
                {
                    throw new Exception("there is no product under this index");
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
                profit2 = long.Parse(Console.ReadLine());
                if (product2[index2[0], index2[1]] < profit2)
                {
                    throw new Exception("there is no such quantity of goods in stock");
                }
                product2[index2[0], index2[1]] -= profit2;
                temp = profit2 * 7;
                Сheck(index2, profit2,temp, "h");
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e);
            }
        }

        protected long GetMoney2
        {
            get { return profit2 * 7; }
        }

    }
}
