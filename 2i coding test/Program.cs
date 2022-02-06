using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2i_coding_test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //multiply a till x
            //multiply a+1 till 2x 
            //multiply a+2 till 3x

            //establish integer variables

            int a = 5;
            int x = 20;
            int result = 0;


            // increment i by 1 and multiply by a  
            {
                {
                    //create integer value to increment
                    int integer = 1;
                    //loop until a mulitplied by integer equals x then log each result
                    Console.WriteLine("Multiples of a until x");
                while (integer * a < x)
                    {

                        result = integer * a;
                        Console.WriteLine(result.ToString());
                        //increment integer
                        integer++;


                    }
                }


                {
                    //create integer to increment
                    int integer = 1;
                    //loop until a+1 multiplied by integer equals 2x then log each result
                    Console.WriteLine("Multiples of a+1 until 2x");
                    while (integer * (a + 1) < (2 * x))
                    {

                        result = integer * (a + 1);
                        Console.WriteLine(result.ToString());
                        //increment integer
                        integer++;
                    }

                }


                {
                    //create integer to increment
                    int integer = 1;
                    //loop until a+1 multiplied by integer equals 2x then log each result
                    Console.WriteLine("Multiples of a+2 until 3x");
                    while (integer * (a + 2) < (3 * x))
                    {

                        result = integer * (a + 2);
                        Console.WriteLine(result.ToString());
                        //increment integer
                        integer++;
                    }
                }




                }
            }
    }
}
