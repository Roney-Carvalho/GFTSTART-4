using System;

namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<---  Análise de Números  --->\n");

            string phrase1 = "55 2 1 854 963 520 1 0 98 8";
            string phrase2 = "";
            string phrase3 = "2 3 5 44 8 99 6 55 72 3 01 25";
            string phrase4 = "98 99 100 101 102 103 105 105";
            string phrase5 = "1";
            
            SetArray(phrase1);
            SetArray(phrase2);
            SetArray(phrase3);
            SetArray(phrase4);
            SetArray(phrase5);
        }

        static async void SetArray(string sequence)
        {
            string[] numbers = sequence.Split(' ');
            int[] arrayInt = numbers.Select(int.Parse).ToArray();
            
            int greatest = arrayInt[0];
            int sum = 0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                sum += arrayInt[i];
                if (arrayInt[i] > greatest)
                    greatest = arrayInt[i];

                Console.Write($" {arrayInt[i]}");

                
            }
            Console.WriteLine($"\n O maior número: {greatest}. Soma: {sum}.\n");
            if (arrayInt.Count() == 0)
                    Console.WriteLine("\nNão nenhum número nesse grupo");
        }
    }
}