/* Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

void SumNum(int M, int N, int sum = 0)
{
    if (M == N)
    {
        System.Console.WriteLine(sum + M);
        return;
    }
    SumNum(M + 1, N, sum + M);
}

SumNum(1, 15);