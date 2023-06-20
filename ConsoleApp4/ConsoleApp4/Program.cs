using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p = "pineapple\ngggggggggggggggggggg";
            p.ToBox();
            p.WordToggle();
            DateTime date= DateTime.Now;
            date.ToCustomFormat();
            Console.WriteLine(p.WordFill());
            Console.ReadLine();
        }
    }
    static class utils
    {
        public static int count(this string p, char c)
        {
            int counter = 0;
            foreach (var item in p)
            {
                if (item == c)
                {
                    counter++;
                }
            }
            return counter;
        }
        public static string WordFill(this string n)
        {
            int counter = 7;
            string word = "";
            for (int i = 0; i < counter; i++)
            {
                word += n[i];
            }
            for (int i = word.Length; i < 10; i++)
            {
                word += ".";
            }
            return word;
        }
        public static void ToBox(this string toBox)
        {
            char underscore = '_';
            int boxwidth = Console.WindowWidth;
            ConsoleColor textColor = ConsoleColor.White;
            ConsoleColor borderColor = ConsoleColor.Green;

            Console.ForegroundColor = borderColor;
            for (int i = 0; i < boxwidth; i++)
            {
                Console.Write(underscore);
            }
            // wrapping
            for (int i = 1; i <= boxwidth - 2; i++)
            {
                if (toBox.Length >= boxwidth)
                {
                    toBox = toBox.Insert(i*(boxwidth - 2-i),"\n");
                }
            }

            string[] sentence = toBox.Split('\n');

            int Row1 = Console.CursorLeft;
            int Col1 = Console.CursorTop;
            Console.SetCursorPosition(0, Col1 + 2);

            Console.ForegroundColor = textColor;
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(" " + sentence[i]);
            }

            Console.ForegroundColor = borderColor;
            for (int i = 1; i <= boxwidth; i++)
            {
                Console.Write(underscore);
            }


            int Row2 = Console.CursorLeft;
            int Col2 = Console.CursorTop;

            for (int i = 1; i <= Col2; i++)
            {
                Console.SetCursorPosition(Row2, i);
                Console.WriteLine('|');
                Console.SetCursorPosition(0, i);
                Console.WriteLine('|');
            }

            Console.ReadLine();
        }
        public static void ToBox(this string toBox,ConsoleColor bColor)
        {
            char underscore = '_';
            int boxwidth = 20;
            ConsoleColor textColor = ConsoleColor.White;
            ConsoleColor borderColor = bColor;

            Console.ForegroundColor = borderColor;
            for (int i = 0; i < boxwidth; i++)
            {
                Console.Write(underscore);
            }
            // wrapping
            for (int i = 1; i <= boxwidth - 2; i++)
            {
                if (toBox.Length >= boxwidth)
                {
                    toBox = toBox.Insert(i * (boxwidth - 2 - i), "\n");
                }
            }

            string[] sentence = toBox.Split('\n');

            int Row1 = Console.CursorLeft;
            int Col1 = Console.CursorTop;
            Console.SetCursorPosition(0, Col1 + 2);

            Console.ForegroundColor = textColor;
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(" " + sentence[i]);
            }

            Console.ForegroundColor = borderColor;
            for (int i = 1; i <= boxwidth; i++)
            {
                Console.Write(underscore);
            }


            int Row2 = Console.CursorLeft;
            int Col2 = Console.CursorTop;

            for (int i = 1; i <= Col2; i++)
            {
                Console.SetCursorPosition(Row2, i);
                Console.WriteLine('|');
                Console.SetCursorPosition(0, i);
                Console.WriteLine('|');
            }

            Console.ReadLine();
        }
        public static void ToBox(this string toBox, ConsoleColor bColor, ConsoleColor tColor)
        {
            char underscore = '_';
            int boxwidth = 20;
            ConsoleColor textColor = tColor;
            ConsoleColor borderColor = bColor;

            Console.ForegroundColor = borderColor;
            for (int i = 0; i < boxwidth; i++)
            {
                Console.Write(underscore);
            }
            // wrapping
            for (int i = 1; i <= boxwidth - 2; i++)
            {
                if (toBox.Length >= boxwidth)
                {
                    toBox = toBox.Insert(i * (boxwidth - 2 - i), "\n");
                }
            }

            string[] sentence = toBox.Split('\n');

            int Row1 = Console.CursorLeft;
            int Col1 = Console.CursorTop;
            Console.SetCursorPosition(0, Col1 + 2);

            Console.ForegroundColor = textColor;
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(" " + sentence[i]);
            }

            Console.ForegroundColor = borderColor;
            for (int i = 1; i <= boxwidth; i++)
            {
                Console.Write(underscore);
            }


            int Row2 = Console.CursorLeft;
            int Col2 = Console.CursorTop;

            for (int i = 1; i <= Col2; i++)
            {
                Console.SetCursorPosition(Row2, i);
                Console.WriteLine('|');
                Console.SetCursorPosition(0, i);
                Console.WriteLine('|');
            }

            Console.ReadLine();
        }
        public static void WordToggle(this string toggle)
        {
            int iterator = 3;
            int time = 1000;
            for (int i = 0; i < iterator; i++)
            {
                Console.Clear();
                Thread.Sleep(time);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(toggle);
                Thread.Sleep(time);
            }
        }
        public static void WordToggle(this string toggle, int timeInMiliSec)
        {
            int iterator = 3;
            int time = timeInMiliSec;
            for (int i = 0; i < iterator; i++)
            {
                Console.Clear();
                Thread.Sleep(time);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(toggle);
                Thread.Sleep(time);
            }
        }
        public static void WordToggle(this string toggle, int timeInMiliSec, int NoOfTime)
        {
            int iterator = NoOfTime;
            int time = timeInMiliSec;
            for (int i = 0; i < iterator; i++)
            {
                Console.Clear();
                Thread.Sleep(time);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(toggle);
                Thread.Sleep(time);
            }
        }
        public static void ToCustomFormat(this DateTime date)
        {
            Console.WriteLine(date.ToString("dd MMM yyyy"));
        }
        public static void ToCustomFormat(this DateTime date, string type)
        {
            if (type == "US" || type == "us")
                Console.WriteLine(date.ToString("MMM dd, yyyy"));
            else
                Console.WriteLine(date.ToString("MMM dd, yyyy"));
        }
    }
}
