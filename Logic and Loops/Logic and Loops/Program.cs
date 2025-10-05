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

        }
    }
}
