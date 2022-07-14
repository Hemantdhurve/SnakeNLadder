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
            Random random = new Random();

            //dice roll in between 1 to 6
            int diceroll = random.Next(1, 7);
            Console.WriteLine("Dice Roll :" + diceroll);
            Console.ReadLine();
            
            //use Random check to check options
            Random random1 = new Random();
            int options = random1.Next(0, 3);
            switch (options)
            {
                case optionNoPlay:
                    Pos1 = Pos1 + 0;
                    Console.WriteLine("STAYED IN THAT POSITION");
                    break;
                case optionLadder:
                    Pos1 = Pos1 + diceroll ;
                    Console.WriteLine("PLAYER MOVED ON LADDER");
                    break;
                case optionSnake:
                    // when snake bites it decrements to so put -ve sign
                    Pos1= Pos1 - diceroll ;
                    if (Pos1 < 0)
                    {
                        Pos1 = 0;
                    }
                    Console.WriteLine("PLAYER MOVES BACKWARDS");
                    break;
                   
            }

        }
    }
}
