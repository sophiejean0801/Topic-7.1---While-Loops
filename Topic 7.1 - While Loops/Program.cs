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
            while (!done)
            {
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
                    tries++;
                }

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
                int count = 0; // Will count number of times we have looped
                Console.WriteLine("Type out a message and I will repeat it five times");
                Console.Write("Message: ");
                string message = Console.ReadLine();
                while (count < 5)
                {
                    Console.WriteLine((count + 1) + ". " + message);
                    count++; //Adds 1 to our counter
                }
                Console.ForegroundColor = ConsoleColor.Red;
                int count2= 0; // Will count number of times we have looped
                Console.WriteLine("Type out a message and I will repeat it");
                Console.Write("Message: ");
                string message2= Console.ReadLine();
                Console.Write("How many times would you like me to repeat it? ");
                int repeat = int.Parse(Console.ReadLine());
                while (count2< repeat)
                {
                    Console.WriteLine((count2 + 1) + ". " + message2);
                    count2++; //Adds to our counter
                }
                int total = 0;
                int count3 = 0;
                Console.WriteLine("I will add up the numbers you give me.");
                Console.WriteLine("How many numbers would you like to add?");
                int numbers = int.Parse(Console.ReadLine());
                while (numbers > 0)
                {
                    int number = int.Parse(Console.ReadLine());
                    total += number;

                }




            }
        }
    }
}
