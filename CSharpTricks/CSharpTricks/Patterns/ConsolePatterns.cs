namespace CSharpTricks.Patterns
{
    public class ConsolePatterns
    {
        public static void RunPattern()
        {
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;
            var random = new Random();

            while (true)
            {
                Console.Clear();

                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(0, width);
                    int y = random.Next(0, height);

                    Console.SetCursorPosition(x, y);
                    Console.Write("|");

                    int x1 = random.Next(0, width);
                    int y1 = random.Next(0, height);

                    Console.SetCursorPosition(x1, y1);
                    Console.Write("|");
                    Console.ForegroundColor = (ConsoleColor)random.Next(0, 15);

                    Task.Run(() => Console.Beep());
                }

                Thread.Sleep(60); // Delay for animation effect
            }
        }
    }
}
