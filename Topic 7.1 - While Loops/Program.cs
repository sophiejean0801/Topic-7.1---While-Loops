namespace Topic_7._1___While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pin = 12345, tries = 0;
            int entry, age;
            bool done = false;
            
            Console.WriteLine("WELCOME TO THE BANK OF JEAN");
            while (!done) {
                Console.WriteLine("ENTER YOUR PIN: ");
                while (!int.TryParse(Console.ReadLine(), out entry)) ;
                tries++;
                if (entry == pin)
                {
                    Console.WriteLine("\nPIN ACCEPTED. YOU NOW HAVE ACCESS TO YOUR ACCOUNT.");
                    done = true;
                }
                else if (tries == 5)
                {
                    Console.WriteLine("\nYOU HAVE RUN OUT OF TRIES. ACCOUNT LOCKED.");
                    done = true;
                }
                else
                {
                    Console.WriteLine("\nINCORRECT PIN. TRY AGAIN.");
                }
            while (!done)
            {
                Console.WriteLine("Enter your age: ");
                int.TryParse(Console.ReadLine(), out age);
                if (age < 0)
                {
                    Console.WriteLine("I can tell you're still in the womb. Try again.");
                    continue;
                }
                else
                {
                    done = true;

                }
            } 



        }


    }
    }
}

