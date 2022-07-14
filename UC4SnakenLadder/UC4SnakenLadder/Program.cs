using System;

namespace UC3SnakeNladder
{
    class Program
    {
        public static void Main(string[] args)
        {
            //define constants
            //Player 1 = P1 and Position 1 = Pos1
            const int optionNoPlay = 0;
            const int optionLadder = 1;
            const int optionSnake = 2;
            const int P1 = 1;

            //define Variables
            int Pos1 = 0;
           //use while loop to iterate 100 positions
            while(Pos1 < 100)
            {

                    //use Random check to check options
                    Random random = new Random();
                    int diceroll = random.Next(1, 7);
                    int options = random.Next(0, 3);

                switch (options)
                {
                    case optionNoPlay:
                        Pos1 = Pos1 + 0;
                        Console.WriteLine("STAYED IN THAT POSITION :" + Pos1);
                        break;
                    case optionLadder:
                        Pos1 = Pos1 + diceroll;
                        Console.WriteLine("PLAYER MOVED ON LADDER :" + Pos1);
                        break;
                    case optionSnake:
                        // when snake bites it decrements to so put -ve sign
                        Pos1 = Pos1 - diceroll;
                        if (Pos1 < 0)
                        {
                            Pos1 = 0;
                        }
                          Console.WriteLine("PLAYER MOVES BACKWARDS : " + Pos1);
                        break;
                }

            }
            Console.WriteLine("Player P1 wins :" + Pos1);
        }
    }
}
