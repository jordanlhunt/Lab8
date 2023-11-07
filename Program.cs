internal class Program
{
    private static void Main(string[] args)
    {
        // Problem1();
        // Problem2();
        Problem3();
    }

    private static void Problem1()
    {
        Console.WriteLine("Input a string with the following format: <pyramid slot number>,<block letter>,<whether or not the block should be lit>");
        String userInput = Console.ReadLine();
        String slotNumber = userInput.Substring(0, userInput.IndexOf(","));
        int pyramidSlotNumber = int.Parse(userInput.Substring(0, userInput.IndexOf(",")));
        Console.WriteLine("The integer value is " + pyramidSlotNumber);
    }

    private static void Problem2()
    {
        Console.WriteLine("Input a string with the following format: <pyramid slot number>,<block letter>,<whether or not the block should be lit>");
        String userInput = Console.ReadLine();
        char blockLetter = userInput[userInput.IndexOf(",") + 1];
        Console.WriteLine("The block letter is " + blockLetter);
    }
    private static void Problem3()
    {
        Console.WriteLine("Input a string with the following format: <pyramid slot number>,<block letter>,<whether or not the block should be lit>");
        String userInput = Console.ReadLine();
        userInput = userInput.Substring(userInput.IndexOf(",") + 3);
        bool isLit = false;
        if (userInput == "true")
        {
            isLit = true;
        }
        Console.WriteLine("Block light indicator is " + isLit);
    }
}