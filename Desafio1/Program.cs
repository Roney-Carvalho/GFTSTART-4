using System;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string groupNumber1 = "15485448";
            string groupNumber2 = "2195498";
            string groupNumber3 = "12";
            string groupNumber4 = "98716549";
            string groupNumber5 = "9999998999";
            string groupNumber6 = "1654891";

            InvertAndPrint(groupNumber1);
            InvertAndPrint(groupNumber2);
            InvertAndPrint(groupNumber3);
            InvertAndPrint(groupNumber4);
            InvertAndPrint(groupNumber5);
            InvertAndPrint(groupNumber6);
        }

        static void InvertAndPrint(string group)
        {
            string invertedNumbers = new string(group.Reverse().ToArray());
            Console.WriteLine($"Posição normal: {group} - Posição invertida: {invertedNumbers}");
        }
    }
}

