using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cs = new Customer();

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            cs.SetName(name);

            Console.Write("Enter units consumed: ");
            int units = Convert.ToInt32(Console.ReadLine());
            cs.Units = units;

            cs.CalculateBill();

            Tuple<string, int, float, float> result = cs.GetData();

            Console.WriteLine("\nGenarated Bill::--");
            Console.WriteLine("Name: " + result.Item1);
            Console.WriteLine("Units: " + result.Item2);
            Console.WriteLine("Charges: " + result.Item3);
            Console.WriteLine("Total Bill: " + result.Item4);

            Console.ReadKey();
        }
    }
}
