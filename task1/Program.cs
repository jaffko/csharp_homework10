﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumStringReverse(int N)
{
    if (N == 1) return "1";
    return Convert.ToString(N) + ", " + NumStringReverse(N - 1);
}

System.Console.WriteLine(NumStringReverse(7));