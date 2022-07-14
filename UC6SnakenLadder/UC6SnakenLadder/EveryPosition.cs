using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC6SnakenLadder
{
    public class EveryPosition
    {
        private static string diceroll;

        public static void everyPosition()
        {
            //define constants
            //Player 1 = P1 and Position 1 = Pos1
            const int optionNoPlay = 0;
            const int optionLadder = 1;
            const int optionSnake = 2;
            const int P1 = 1;

            //define Variables
            int Pos1 = 0;
            int dicecount = 0;
            //use while loop to iterate 100 positions
            while (Pos1 < 100)
            {

                //use Random check to check options
                Random random = new Random();
                int diceroll = random.Next(1, 7);
                //here dicearoll incremented 
                dicecount++;
                int options = random.Next(0, 3);
                Console.WriteLine("Position :" + Pos1);

                switch (options)
                {
                    //for noplay it stays 
                    case optionNoPlay:
                        Console.WriteLine("Position :" + Pos1);
                        break;
                    case optionLadder:
                        //
                        if (Pos1 + diceroll <= 100)
                        {
                            Pos1 = Pos1 + diceroll;
                        }
                        Console.WriteLine("Position :" + Pos1);
                        break;

                    case optionSnake:
                        // when snake bites it decrements to so put -ve sign
                        Pos1 = Pos1 - diceroll;
                        if (Pos1 < 0)
                        {
                            Pos1 = 0;
                        }
                        Console.WriteLine("Position :" + Pos1);
                        break;
                }

            }
            Console.WriteLine("Player P1 wins on dice roll :" + dicecount );

        }
    }
}

