using Microsoft.SqlServer.Server;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Linq;

// папка с различными файлами
namespace ConsolApp1
{
    class Program
    {

        static void Main()
        {

            Console.Write("Inserire la frase: ");
            string inputFrase = Console.ReadLine();
            int WordCount = 0;
            int spacePosition = inputFrase.IndexOf(" ");

            if (inputFrase.Substring(0, 1) != " ")
            {
                WordCount++;
            }

            for (int i = 1; i<inputFrase.Length; i++)
            {

                if (inputFrase.Substring(i, 1) != " " && inputFrase.Substring(i-1, 1) == " ")
                {
                    WordCount++;
                }
            }

            Console.WriteLine($"le parole presenti nella frase: <{inputFrase}> sono {WordCount}");




        }

    }
}


// uint только положительные числа
// byte только до 255 
// short только до 32000 
// int все остальные до 2 милиардов
// long для огромных чисел
// string "text";
// char 'symbol';
// bool variable = true/false;
// для float в конце нужно ставить f (float a = 3.14f; )
// Double это тот же float но без f в конце