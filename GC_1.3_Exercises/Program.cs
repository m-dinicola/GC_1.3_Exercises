using System;

namespace GC_1._3_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // these initializations default to counting up.
            int power = 1;
            int sign = 0;           //0 is normal counting to ease start/end offset at expense of increment
            bool tryAgain = true;   //controls input validation and, later, retry tracking
            while (tryAgain)
            {
                tryAgain = false;
                Console.Write("Choose the exercise you would like to run (13 / 14 / 15) ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 13:        //countdown preset
                        sign = -1;  //exercise 13 counts down, power remains 1
                        break;
                    case 14:        //squaring preset
                        power = 2;  //exercise 14 uses squares, counting remains normal
                        break;
                    case 15:        //cubing preset
                        power = 3;  //exercise 15 uses cubes, counting is normal
                        break;
                    default:        //catches all other integer inputs
                        Console.Write("Bad Input. ");
                        tryAgain = true;
                        break;
                }

            }
            tryAgain = true;        //to exit above loop, must have been false
            while (tryAgain)
            {
                Console.Write("Enter an integer: ");
                int inputNum = int.Parse(Console.ReadLine());
                /* the for loop below is a bit complex.
                        * Only the countdown includes 0, so it has to start one earlier or
                        * end one later. Adding "sign" to initialization starts 1 earlier.
                        * Math.Abs(i) allows us to decrement on the countdown and still have an endpoint.
                        * by using the assignment operator on (1 + 2*sign) we can add 1 when sign=0 and
                        * -1 when sign=-1.                                                          */
                for (int i = 1+sign ; Math.Abs(i) <= inputNum ; i += (1 + 2 * sign))
                {
                    Console.WriteLine(inputNum*-1*sign + Math.Pow(i, power));
                }   // using the Math.Pow() method means we can use this for all three exercises
                    // the inputNum*-sign allows us to start counting at max for assignment 13 and
                    // since sign=0 for the others we can have an offset of 0 for those.
                Console.Write("Would you like to continue (y/n) ");
                tryAgain = Console.ReadLine().StartsWith("y", StringComparison.OrdinalIgnoreCase);
            }       //even if the user types "yes" or "YEs" this will catch it. It also catches "Yra5dl7seu"
        }           //but thems the breaks.
    }
}
