using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printevennumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int a=0;
           
            while(a<num)
            {
                Console.WriteLine(a);
                a = a + 2;
            }
            Console.ReadLine();
        }
    }
}
