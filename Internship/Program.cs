using System;
using System.Linq;

namespace Internship
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Change the value of two variables
            // Don't change it implicitly, use logic to do

            var one = 54;
            var two = 23;

            one += two; // 77
            two = one - two; // 54
            one -= two; // 23

            Console.WriteLine($"The final value of the variable one is: {one}");
            Console.WriteLine($"The final value of the variable two is: {two}");

            // 2 Change the value of two variables
            // Don't use a third one, don't change it implicitly

            var three = "Brasil";
            var four = "Santa Catarina";           
            
            three = (four + three); // Santa CatarinaBrasil
            four = three.Substring(four.Length, 6); // Brasil 
            three = three.Substring(0, three.Length - 6); // Santa Catarina


            Console.WriteLine($"The final value of the variable three is: {three}");
            Console.WriteLine($"The final value of the variable four is: {four}");

            // 3 Ask for a string and return it backwards
            // Replace the empty spaces " " for underline _

            // frase de exemplo: this test is easy
            // resultado esperado: ysae_si_tset_siht

            Console.WriteLine("Informe uma frase curta");
            var input = Console.ReadLine();

            var answer = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                answer += input[i].ToString() != " " ? input[i].ToString() : "_"; 
            }

            Console.WriteLine(answer);

            // 4 array multidimensional 5 x 5
            // Replace the repeated even numbers for 0, odds for -1

            /* int[,] numbers = new int[5,5]
            {
                { 42, 20, 55, 19, 15 },
                { 42, 21, 55, 18, 14 },
                { 80, 20, 53, 19, 15 },
                { 61, 20, 55, 19, 13 },
                { 42, 22, 54, 17, 15 }
            };

            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if (numbers[linha, coluna] % 2 == 0) numbers[linha, coluna] = 0;
                    else numbers[linha, coluna] = -1;
                }
            } */

            // 5 Ask the size of the array, than ask the int numbers           
            // If the numbers are divisible for 3 write "Fizz"
            // If the numbers are divisible for 5 write "Buzz"
            // If the numbers are divisible for 3 and 5 write "FizzBuzz"
       
            Console.WriteLine("Informe o tamanho do array: ");
            var arraySize = Int32.Parse(Console.ReadLine());
            
            var array = new int[arraySize];

            Console.WriteLine("\n");

            for (var index = 0; index < arraySize; index++)
            {
                Console.WriteLine($"Informe o {index + 1}º número do array");
                var numberInformed = Int32.Parse(Console.ReadLine());
                array[index] = numberInformed;
            }

            Console.WriteLine("\n");
            
            for (var index = 1; index < arraySize; index++)
            {
                if (array[index] % 3 == 0) Console.WriteLine("Fizz");
                if (array[index] % 5 == 0) Console.WriteLine("Buzz");
                if ((array[index] % 3 == 0) & (array[index] % 5 == 0)) Console.WriteLine("FizzBuzz");
            }

        }
    }
}
