// 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение M: ");
//         int M = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение N: ");
//         int N = int.Parse(Console.ReadLine());

//         PrintNumbersInRange(M, N);
//     }

//     static void PrintNumbersInRange(int start, int end)
//     {
//         if (start <= end)
//         {
//             Console.WriteLine(start);
//             PrintNumbersInRange(start + 1, end);
//         }
//     }
// }


// 2. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение m: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение n: ");
//         int n = int.Parse(Console.ReadLine());

//         int result = AckermannFunction(m, n);
//         Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} равен {result}");
//     }

//     static int AckermannFunction(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0)
//         {
//             return AckermannFunction(m - 1, 1);
//         }
//         else
//         {
//             return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//         }
//     }
// }

// 3. Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // Произвольный массив

//         Console.WriteLine("Элементы массива в обратном порядке:");
//         PrintArrayReverse(array, array.Length - 1);
//     }

//     static void PrintArrayReverse(int[] array, int index)
//     {
//         if (index >= 0)
//         {
//             Console.Write(array[index] + " ");
//             PrintArrayReverse(array, index - 1);
//         }
//     }
// }
