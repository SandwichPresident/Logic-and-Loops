namespace Logic_and_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = "adventurer";
            string userChoice = "none";

            Console.Write("Welcome to the jungle\nWe got fun and games\nWe got everything you want\nHoney, we know the names\n\n");
            Console.WriteLine("Wait... I don't actually know your name.");
            Console.WriteLine("What is your name?");
            Console.WriteLine("[Please enter your name, then press 'ENTER' on the keyboard]");
            playerName = Console.ReadLine();
            Console.WriteLine("Welcome to the jungle " + playerName + "!");
            Console.WriteLine("Which path do you chose?");
            Console.WriteLine("Type 'left' to choose the path and go left or type 'right' to choose the cave and go right.");
            userChoice = Console.ReadLine();
            Console.WriteLine("\nYou chose: " + userChoice + "\n");
            if (userChoice == "left")
            {
                Console.WriteLine("You take the path to the left. It leads you out of the jungle. You are safe to adventure another day!");

            }
            else if (userChoice == "right")
            {
                Console.WriteLine("You take the path to the right. It leads you into a cave. There is a spider and you evaporate out of fear!");
            }
            else
            {
                userChoice = "none";

                while (userChoice != "left" && userChoice != "right" && userChoice != "up")
                {
                    Console.WriteLine("Please enter either 'left', 'right', or our now super secret answer of 'up'.");
                    userChoice = Console.ReadLine();
                    Console.WriteLine("\nYou chose: " + userChoice + "\n");
                }

                if (userChoice == "left")
                {
                    Console.WriteLine("You take the path to the left. It leads you out of the jungle. You are safe to adventure another day!");
                }
                else if (userChoice == "right")
                {
                    Console.WriteLine("You take the path to the right. It leads you into a cave. There is a spider and you evaporate out of fear!");
                }
                else if (userChoice == "up")
                {
                    Console.WriteLine("You take the path up and start climbing a tree and get a beautiful view from atop the cannopy");
                }
                else
                {
                    Console.WriteLine("dead :(");
                }
            }
        }
    }
}
