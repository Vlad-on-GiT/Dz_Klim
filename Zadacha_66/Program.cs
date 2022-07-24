/* Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9 */

int Akkerman(int m, int n)
{
    int temp = 0;
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        temp = Akkerman(m - 1, 1);
        return temp;
    }
    else if (m > 0 && n > 0)
    {
        temp = Akkerman(m - 1, Akkerman(m, n - 1));
        return temp;
    }
    return 0;
}

System.Console.WriteLine(Akkerman(2, 3));