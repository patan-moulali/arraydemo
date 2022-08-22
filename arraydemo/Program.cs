using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraydemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[] { 10, 20, 30, 40 ,50,88,527};
            
            foreach(var item in prices)
            {
                Console.WriteLine(item);

            }
            prices[5] = 1000;
            Array.Sort(prices);
            Array.Reverse(prices);
            Console.WriteLine("After new array element: ");
            foreach (var item in prices)
            {
                Console.Write(item);
            }

            Console.Read();
        }
    }
}
