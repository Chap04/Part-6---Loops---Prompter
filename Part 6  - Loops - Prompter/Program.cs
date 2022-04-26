using System;

namespace Part_6____Loops___Prompter
{
    class Program
    {

        static void Main(string[] args)
        {
            //Variables
            int minNum;
            int maxNum;
            int middleVariable;
            //Min Number Input
            Console.WriteLine("Enter A Number");
            while (!Int32.TryParse(Console.ReadLine(), out minNum))
            {
                Console.WriteLine($"Invalid Entry\n Try Again");
            }
            Console.WriteLine($"Minimum Number: {minNum} Recieved");

            //Max Number Input
            Console.WriteLine("Enter A Number Higher Than Your Minimum");
            do
            {
                while (!Int32.TryParse(Console.ReadLine(), out maxNum))
                    Console.WriteLine("Invalid Entry\n Try Again");
                if (maxNum < minNum)
                {
                    Console.WriteLine("Number Too Low");
                }
            }
            while (maxNum < minNum);
            Console.WriteLine($"Maximum Number: {maxNum} Recieved");

            //Final Number Input
            do
            {
                while (!Int32.TryParse(Console.ReadLine(), out middleVariable))

                    Console.WriteLine($"Invalid Entry\n Try Again");

                if (middleVariable > maxNum || middleVariable < minNum)
                {
                    Console.WriteLine("Number Is Not Within The Given Range");
                }
            } while (middleVariable > maxNum || middleVariable < minNum);
            






        }  

    }
}
