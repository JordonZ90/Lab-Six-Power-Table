using System;

namespace LabSixPowerTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            string userNumber; //user entry

            int validInt = 0;  //int confirmer

            char loopBreaker = ' ';

            string loopBreakerTest = " ";

            //Asking user to enter an integer
            do
            {
                bool isInValidInput = true;
                while (isInValidInput)
                {
                    Console.WriteLine("Please enter an integer: ");
                    userNumber = Console.ReadLine();
                    if (int.TryParse(userNumber, out validInt))
                    {
                        isInValidInput = false;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: invalid entry, please enter again");
                    }
                }
                //table
                Console.WriteLine("Number       Squared        Cubed");
                Console.WriteLine("------       -------        -----");
                for (int i = 1; i <= validInt; i++) // 1 not 0, cannot square a zero
                {
                    Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", i, i * i, i * i * i));
                }

                bool isInValidInput2 = true;
                Console.WriteLine();
                while (isInValidInput2)
                {
                    Console.WriteLine("Do you wish to continue? (enter y or n)");
                    loopBreakerTest = Console.ReadLine();
                    if (char.TryParse(loopBreakerTest, out loopBreaker))
                    {
                        if (loopBreaker != 'y' && loopBreaker != 'n')
                        {
                            isInValidInput2 = true;
                        }
                        else
                        {
                            isInValidInput2 = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERROR: invalid entry, please enter again");
                    }
                }
            } while (loopBreaker == 'y');

            Console.WriteLine();

            Console.WriteLine("End of application!");

            Console.ReadLine();
        }
    }
}