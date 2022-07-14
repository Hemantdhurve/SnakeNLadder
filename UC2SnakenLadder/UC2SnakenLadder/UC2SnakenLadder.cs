using System;

namespace UC2SnakeNladder
{
    class Program
    {
        public static void Main(string[] args)
        {
            //define constants
            //Player 1 = P1 and Position 1 = Pos1
            const int P1 = 1;
            int Pos1 = 0;
            Console.WriteLine("Initial position of P1 is :" + "" + Pos1);

            Random random = new Random();
            //dice roll in between 1 to 6
            int diceroll = random.Next(1,7);
            Console.WriteLine("Dice Roll :" + diceroll);
            Console.ReadLine();


        }
    }
}
