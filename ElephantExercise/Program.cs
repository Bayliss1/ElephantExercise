using System;

namespace ElephantExercise
{
    class Elephant
    {
        public string Name;
        public int EarSize;
        public void WhoAmI()
        {
            Console.WriteLine("My name is " + Name + ".");
            Console.WriteLine("My ears are " + EarSize + " inches tall.");
        }
        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(whoSaidIt.Name + " said this: " + message);
        }
        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap, 4 to ruin everything, 5 for Lucinda to speak to Lloyd");
            while (true)
            {
                string UserInput = Console.ReadLine();
                if (int.TryParse(UserInput, out int Choice))
                {
                    Console.WriteLine("You pressed " + Choice);
                    if (Choice == 1)
                    {
                        Console.WriteLine("Calling " + lloyd.Name + ".WhoAmI();");
                        lloyd.WhoAmI();

                    }
                    else if (Choice == 2)
                    {
                        Console.WriteLine("Calling " + lucinda.Name + ".WhoAmI();");
                        lucinda.WhoAmI();

                    }
                    else if (Choice == 3)
                    {
                        Elephant lloydbackup = lloyd;
                        lloyd = lucinda;
                        lucinda = lloydbackup;
                        Console.WriteLine("References have been swapped");
                    }

                    else if (Choice == 4)
                    {
                        lloyd = lucinda;
                        lloyd.EarSize = 4321;
                        lloyd.WhoAmI();
                    }
                    else if (Choice == 5)
                    {
                        lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
