using System;
    class PingPong 
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();
            int variable = int.Parse(userInput);
            Check(variable);
        }

        static void Check (int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i%3 == 0 && i%5 == 0)
                {
                    Console.WriteLine("ping-pong");
                }
                else if (i%3 == 0)
                {
                   Console.WriteLine("ping");
                }
                else if (i%5 == 0)
                {
                    Console.WriteLine("pong");
                }
                else
                {
                    string converter = i.ToString();
                    Console.WriteLine(converter);
                }
            }
        }
    }