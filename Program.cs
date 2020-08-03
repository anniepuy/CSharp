using System;

namespace Section3
{

    class Program
    {
        static void Main(string[] args)
        {
        //Create the empty string

           string input = "0";
           int count = 0;
           int total = 0;
           int currentNumber = 0;



        

           //Take the all of teh scores and average them
        while(input != "-1") 
        {
            Console.WriteLine("Last number was {0}", currentNumber);
            Console.WriteLine("Please enter the next score");
            Console.WriteLine("Current about mof entries {0}", count);
            Console.WriteLine("Please enter -1 when  you are ready to calculate the average score.");

            input = Console.ReadLine();


            if(input.Equals("-1"))
            {
                Console.WriteLine("---------");
                //Calculate average
                double average = (double)currentNumber / (double)count;
                Console.WriteLine("The average score of your studnets is {0}", average);
            }

            if(int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
            {
                total = total + currentNumber;
            }
            else
            {
                if(!(input.Equals("-1")))
                {
                    Console.WriteLine("Please enter the value between 1 and twenty.");
                }
                continue;
            }
            count++;
            
        }
        Console.ReadLine();

        }

    }
}
