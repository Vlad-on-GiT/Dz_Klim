/* Задайте двумерный массив размером m x n,
заполненный случайными вещественными числами. */

System.Console.Write("Введите число строк:   ");
int rows = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число столбцов:   ");
int columns = int.Parse(Console.ReadLine()!);

double[,] CreateAndFillMAtrix(int rows, int column)
{
    double[,] mtrx = new double[rows, column];
    Random rnd = new Random();
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = rnd.NextDouble() * 10;
        }
    }
    return mtrx;
}

void PrintMatrix(double[,] arr)
{
    string s = new string('-', 6 * columns);
    System.Console.WriteLine("  " + s);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) System.Console.Write(" | ");
            // не понял как таким образом сделать ровную таблицу
            System.Console.Write($"{Math.Round(arr[i, j],1), 3} | ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("  " + s);
}


double[,] arr = CreateAndFillMAtrix(rows, columns);
System.Console.WriteLine("\nТаблица:");
PrintMatrix(arr);
