using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14.Papka
{
    class WrittenOff : Sent1
    {
        public WrittenOff() { }
        protected void Сheck(int [] index,long product,long m, string px)
        {
            try
            {
                if (product == 0)
                {
                    throw new Exception("ERROR::you have not sent anything");
                }
                Console.WriteLine("Written off the warehouse-" + product + "index-" + index);
                Сheck2( index, product,m, px);
            }
            catch( Exception e)
            {
                Console.Clear();
                Console.WriteLine(e);
            }
        }

    }
}
