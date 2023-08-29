using LibMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con10
{
    public class ConsoleUserInterface : IUserInterface
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadLine()
        {
            return Console.ReadLine() ?? string.Empty;
        }

        public int ReadInt()
        {
            string input = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(input, out int choice))
            {
                return choice;
            }
            return -1; // Indicate failure
        }
    }
}
