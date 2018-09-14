using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQuot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rnd = new Random();
                decimal num1, num2, prod, quot = 0;

                for (int counter = 0; counter <= 10; counter++)
                {

                    num1 = rnd.Next(0, 11);
                    num2 = rnd.Next(0, 11);
                    prod = num1 * num2;
                    quot = num1 / num2;
                    Console.WriteLine("The product of " + num1 + "," + num2 + " = " + prod);
                    Console.WriteLine("The quotient of " + num1 + "," + num2 + " = " + Math.Round(quot, 2));
                    Console.WriteLine();
                }

            }


            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide By Zero Exception caught!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception Thrown " + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
