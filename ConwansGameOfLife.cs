using System;
using System.Numerics;

namespace Game_Theory
{
    public class ConwansGameOfLife
    {
        private int Heigth;
        private int Width;
        private bool[,] cells;

 
        // Initializes a new Game of Life.

        public ConwansGameOfLife(int Heigth, int Width)
        {
            this.Heigth = Heigth;
            this.Width = Width;
            cells = new bool[Heigth, Width];
            GenerateField();
        }


        // Advances the game by one generation and prints the current state to console.
 
        public void DrawAndGrow()
        {
            DrawGame();
            Grow();
        }


        // Advances the game by one generation.


        private void Grow()
        {
            for (int i = 0; i < Heigth; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    int numOfAliveNeighbors = GetNeighbors(i, j);

                    if (cells[i, j])
                    {
                        if (numOfAliveNeighbors < 2)
                        {
                            cells[i, j] = false;
                        }

                        if (numOfAliveNeighbors > 3)
                        {
                            cells[i, j] = false;
                        }
                    }
                    else
                    {
                        if (numOfAliveNeighbors == 3)
                        {
                            cells[i, j] = true;
                        }
                    }
                }
            }
        }


        // Checks how many alive neighbors.


        private int GetNeighbors(int x, int y)
        {
            int NumOfAliveNeighbors = 0;

            for (int i = x - 1; i < x + 2; i++)
            {
                for (int j = y - 1; j < y + 2; j++)
                {
                    if (!((i < 0 || j < 0) || (i >= Heigth || j >= Width)))
                    {
                        if (cells[i, j] == true) NumOfAliveNeighbors++;
                    }
                }
            }
            return NumOfAliveNeighbors;
        }

      
        // Draws the game to the console.

        private void DrawGame()
        {
            for (int i = 0; i < Heigth; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(cells[i, j] ? "x" : " ");
                    if (j == Width - 1) Console.WriteLine("\r");
                }
            }
            Console.SetCursorPosition(0, Console.WindowTop);
        }
        // Initializes the field.

        private void GenerateField()
        {
            Random generator = new Random();
            int number;
            for (int i = 0; i < Heigth; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    number = generator.Next(2);
                    cells[i, j] = ((number == 0) ? false : true);
                }
            }
        }
    }


    static class OtherFuncts
    {
        public static bool IsNumber(this string aNumber)
        {
            BigInteger temp_big_int;
            var is_number = BigInteger.TryParse(aNumber, out temp_big_int);
            return is_number;
        }
        public static bool IsParsableNumber(this string aNumber)
        {
            string numberStr = "123456";
            int number;

            bool isParsable = Int32.TryParse(numberStr, out number);
            return isParsable;
        }
    }
}