using Microsoft.SqlServer.Server;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Linq;

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

            // controllo se la frase si inizia con la lettera
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

