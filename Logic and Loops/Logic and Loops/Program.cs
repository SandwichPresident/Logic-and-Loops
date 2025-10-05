namespace Logic_and_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = "adventurer";

            Console.Write("Welcome to the jungle\nWe got fun and games\nWe got everything you want\nHoney, we know the names\n\n");
            Console.WriteLine("Wait... I don't actually know your name.");
            Console.WriteLine("What is your name?");
            Console.WriteLine("[Please enter your name, then press 'ENTER' on the keyboard]");

            playerName = Console.ReadLine();
            Console.WriteLine("Welcome to the jungle " + playerName + "!");
        }
    }
}
