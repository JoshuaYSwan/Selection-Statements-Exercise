using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Guess a number between 1 and 1000");

            bool run = true;
            string yesno = "yes";
            while (run)
            {
                var userInput = int.Parse(Console.ReadLine());
                if (userInput > favNumber)
                {
                    Console.WriteLine("too high!");
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("too low!");
                }
                else if (userInput == favNumber)
                {
                    bool cont = true;
                    while (cont)
                    {

                        Console.WriteLine("you win! play again? (yes/no)");
                        yesno = Console.ReadLine();
                        switch (yesno)
                        {
                            case "yes":
                                r = new Random();
                                favNumber = r.Next(1, 1000);
                                Console.WriteLine("Guess a number between 1 and 1000");
                                cont = false;
                                break;
                            case "no":
                                run = false;
                                cont = false;
                                break;
                            default:
                                Console.WriteLine("not valid");
                                cont = true;
                                break;

                        }
                    }
                }
                else
                {
                    Console.WriteLine("not valid");


                }
                
                
            }
        }
    }
}
