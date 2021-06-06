using System;
using System.Numerics;

namespace Game_Theory
{

    
    class Program
    {

   

        private static void Main(string[] args)
        {

            Console.Write("Please enter preferred height of board:");
            var HeigthS = Console.ReadLine();

            if (!OtherFuncts.IsNumber(HeigthS))
            {
                Console.Write("Please enter preferred height of board:");
                HeigthS = Console.ReadLine();
            }

            Console.Write("Please enter preferred Width of board:");
            var Widths = Console.ReadLine();

            if (!OtherFuncts.IsNumber(Widths))
            {
                Console.Write("Please enter preferred height of board:");
                Widths = Console.ReadLine();
            }

            Console.Write("Please enter preferred No. of generations:");
            var MaxRunsS = Console.ReadLine();

            if (!OtherFuncts.IsNumber(MaxRunsS))
            {
                Console.Write("Please enter preferred height of board:");
                MaxRunsS = Console.ReadLine();
            }


            if(OtherFuncts.IsParsableNumber(HeigthS) || OtherFuncts.IsParsableNumber(Widths) || OtherFuncts.IsParsableNumber(MaxRunsS))
            {

            }

            try
            {

                var Heigth = Int16.Parse(HeigthS);
                var Width = Int16.Parse(Widths);
                var MaxRuns = Int16.Parse(HeigthS);

                int runs = 0;
                var res = new ConwansGameOfLife(Heigth, Width);

                while (runs++ < MaxRuns)
                {
                    res.DrawAndGrow();

                    // Give the user a chance to view the game in a more reasonable speed.
                    System.Threading.Thread.Sleep(200);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Please make sure you enter correct parameters,");
                //throw;
            }
           


        }
    }
    
}