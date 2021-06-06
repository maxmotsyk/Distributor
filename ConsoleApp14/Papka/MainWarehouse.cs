using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14.Papka
{
    class MainWarehouse : Products
    {
        protected long FirmMoney { get; set; }

        public MainWarehouse()
        {
            this.FirmMoney = 10000000;
        }

        public void MainMenu()
        {
            bool work = true;
            int choise;
            while(work)
            {
                Console.WriteLine("[1]-send products\n[2]-send chemicals\n[3]-Show all info\n[4]-Take profit \n[0]-Exit");
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Console.Clear();
                        Send1();
                        break;
                    case 2:
                        Console.Clear();
                        Send2();
                        break;
                    case 3:
                        Console.Clear();
                        Show();
                        break;
                    case 4:
                        FirmMoney += GetMoney;
                        FirmMoney += GetMoney2;
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

        protected void Show()
        {
            Console.WriteLine("Firm money" + FirmMoney + "\n");
            Console.WriteLine("food:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine(product1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("chemistry:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine(product2[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
