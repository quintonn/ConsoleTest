using System;
namespace ConsoleTestForSpoon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter some text");
                var input = Console.ReadLine();
                Console.WriteLine("You entered: " + input);
                Console.WriteLine();
                Console.WriteLine("Press any key to continue, or exit to quit");
                var cmd = Console.ReadLine();
                if (cmd.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }
            }
        }
    }
}
