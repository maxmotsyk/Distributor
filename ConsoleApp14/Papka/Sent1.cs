using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14.Papka
{
    class Sent1 : Distributor
    {
        public void Сheck2( int[] index, long product,long m,string px)
        {
            Console.WriteLine("The product came to the distribution");
            DistributionToWarehouses( index, product,m,px);
            Menu();
        }

    }
}
