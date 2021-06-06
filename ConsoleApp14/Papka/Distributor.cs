using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14.Papka
{
    class Distributor
    {
        protected long Money2 { get; set; }
        protected long[,] productP = new long[3, 1];
        protected long[,] productH = new long[3, 1];

        public Distributor()
        { 
            this.Money2 = 10000000;
        }

        protected void  DistributionToWarehouses( int[] index, long product,long m, string px)
        {
            if (px =="p")
            {
                this.productP[index[0], index[1]] += product;
            }
            else
            {
                this.productH[index[0], index[1]] += product;
            }

            this.Money2 = this.Money2 - m;
        }

        protected void Show2()
        {
            Console.WriteLine("Firm money" + Money2 + "\n");
            Console.WriteLine("food:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine(productP[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("chemistry:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine(productH[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }

        protected void Menu()
        {
            bool work = true;
            int choise;
            while (work)
            {
                Console.WriteLine("[1]-All info\n[2]-Show\n[0]-Exit");
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Console.Clear();
                        Show2();
                        break;
                    case 2:
                        Console.Clear();
                        Show2();
                        break;
                    case 0:
                        work = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("[1]-send products\n[2]-send chemicals\n[0]-Exit");
                        choise = int.Parse(Console.ReadLine());
                        break;
                }

            }
        }

    }
}
