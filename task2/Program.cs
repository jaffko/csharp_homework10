// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumBetween(int M, int N)
{
    if (N == M) return M;
    return N + SumBetween(M, N-1);
}

System.Console.WriteLine(SumBetween(1,15));