using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloApp
{
    class Program
    {
        /* Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные
пробелом.Знаки препинания не используются. Найти самое длинное слово в строке */
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");

            
            string startString = Console.ReadLine();

            
            string[] stringArray = startString.Split();

            int l = 0;

            
            foreach (string str in stringArray)
            {
                if (str.Length > l)
                    l = str.Length;
            }

            Console.WriteLine();
           
            Console.Write("Длина самого длинного слова равна {0}", l);
            Console.ReadKey();
        }

    }
}

