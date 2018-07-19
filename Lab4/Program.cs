using System;
 using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Continue = "y";
            while (Continue == "y")
            {

                Console.WriteLine("Please enter an integer.");
                int numEnt = int.Parse(Console.ReadLine());
                Console.WriteLine("    Number     Squared       Cubed");
                Console.WriteLine("    ======     =======       ===== \n");
                for (int i = 1; i <= numEnt; i++)
                {
                    double x = Math.Pow(i, 2);
                    double y = Math.Pow(i, 3);

                    Console.WriteLine(String.Format("{0, 7}     {1, 8}     {2, 7}\n", i, x, y));

                   
                }
                Console.WriteLine("Do you wish to continue? y/n");
                Continue = Console.ReadLine();
                if (Continue != "y")
                {
                    Console.WriteLine("Have a PHENOMENAL Day!!");
                    Console.ReadLine();
                }
            }
        }

    }
}
