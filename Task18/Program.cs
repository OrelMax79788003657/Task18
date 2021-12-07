using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task18
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();

            bool finishedByAlgorithm = false;

            string opening = "([{";
            string closing = ")]}";

            Stack<char> stack = new Stack<char>();

            foreach (char ch in text)
            {
                if (opening.Contains(ch))
                {
                    stack.Push(ch);
                }
                if (closing.Contains(ch))
                {
                    int index = closing.IndexOf(ch);
                    if (stack.Peek()== opening[index])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Последовательность ЛОЖНА");
                        finishedByAlgorithm = true;
                        break;
                    }
                }
            }

            if (stack.Count > 0 && !finishedByAlgorithm)
            {
                Console.WriteLine("Последовательность ложна!");
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("Последовательность ВЕРНА!!!");
            }
            
            Console.ReadKey();  

        }
    }
}
