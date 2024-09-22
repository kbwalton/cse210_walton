using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();
        int magicNumber = randomgenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your magic number guess?");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Correct! ");
            }
        }



        
    }
}