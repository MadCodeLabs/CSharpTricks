using System.Text;

namespace CSharpTricks.Patterns
{
    public class DiwaliPattern
    {
        private static Random random = new Random();
        public static void RunPattern()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string line1 = "🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫🀫";
            string[] happy = new string[]
            {
                " H     H   A   PPPPP  PPPPP  Y     Y  ",
                " H     H  A A  P    P P    P  Y   Y   ",
                " HHHHHHH AAAAA PPPPP  PPPPP     Y     ",
                " H     H A   A P      P         Y     ",
                " H     H A   A P      P         Y     "
            };

            string[] diwali = new string[]
            {
                " DDDDD   I  W       W   A    L     I  ",
                " D    D  I  W       W  A A   L     I  ",
                " D     D I  W   W   W AAAAA  L     I  ",
                " D    D  I  W   W   W A   A  L     I  ",
                " DDDDD   I   WW W WW  A   A  LLLLL I  "
            };

            // Simulate explosion
            Console.Clear();
            Console.WriteLine("BOOM! 🎇🎇🎇🎇🎇🎇🎇🎇🎇🎇🎇🎇🎇🎇🎇");

            Console.CursorVisible = true;

            foreach (char c in line1)
            {
                ApplyForeGroundColor();
                Console.Write(c);
            }
            Console.WriteLine();

            //Print happy
            foreach (string line in happy)
            {
                foreach (char c in line)
                {
                    ApplyForeGroundColor();
                    Console.Write(c);
                }
                Console.WriteLine();
                Thread.Sleep(400); // Delay to create animation effect
            }

            Console.WriteLine();

            foreach (char c in line1)
            {
                ApplyForeGroundColor();
                Console.Write(c);
            }
            Console.WriteLine();

            //Print Diwali
            foreach (string line in diwali)
            {
                foreach (char c in line)
                {
                    ApplyForeGroundColor();
                    Console.Write(c);
                }
                Console.WriteLine();
                Thread.Sleep(400); // Delay to create animation effect
            }

            foreach (char c in line1)
            {
                ApplyForeGroundColor();
                Console.Write(c);
            }
            Console.WriteLine();

            Thread.Sleep(1000); // Delay to create animation effect
            Console.Read();
            ConsolePatterns.RunPattern();

        }

        private static void ApplyForeGroundColor()
        {
            Console.ForegroundColor = (ConsoleColor)random.Next(9, 14);
        }
    }
}
