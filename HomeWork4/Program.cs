using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы");
            int rowMatrix = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов матрицы");
            int colMatrix = int.Parse(Console.ReadLine());

            int[,] a = new int[rowMatrix,colMatrix];
            Random randomNumber = new Random();

            //Задание 1
            Console.WriteLine("Полученная матрица А: ");
            int sum = 0;
            for (int i = 0; i < rowMatrix; i++)
            {
                for (int j = 0; j < colMatrix; j++)
                {
                    a[i, j] = randomNumber.Next(1,10);
                    sum += a[i, j];
                    Console.Write($" {a[i, j]} ");
                }
                Console.WriteLine(); //Для читабельности матрицы в консоли
            }
            Console.WriteLine($"Сумма чисел в матрице {sum}");
            Console.WriteLine();

            //Задание 2
            int[,] b = new int[rowMatrix, colMatrix];

            Console.WriteLine("Полученная матрица B: ");
            for (int i = 0; i < rowMatrix; i++)
            {
                for (int j = 0; j < colMatrix; j++)
                {
                    b[i, j] = randomNumber.Next(1, 10);
                    sum += b[i, j];
                    Console.Write($" {b[i, j]} ");
                }
                Console.WriteLine(); //Для читабельности матрицы в консоли
            }
            Console.WriteLine("Сумма матриц A и B: ");

            int[,] c = new int [rowMatrix, colMatrix];

            for (int i = 0; i < rowMatrix; i++)
            {
                for (int j = 0; j < colMatrix; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    Console.WriteLine($" {c[i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
