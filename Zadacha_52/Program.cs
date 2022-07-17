/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
элементов в каждом столбце. */

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (j == 0) System.Console.Write(" | ");
            System.Console.Write($"{mtrx[i, j],4} | ");
        }
        System.Console.WriteLine("");
    }
}

void AverageOfColumns(int[,] matrix)
{
    double count = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            count += matrix[i,j];
        }
        if (j == 0) System.Console.WriteLine("Средне по столбцу равно:");
        System.Console.Write($" |  {Math.Round(count / matrix.GetLength(0), 1)}");
        if (j == matrix.GetLength(1) - 1) System.Console.Write(" |");
        count = 0;
    }
}


int[,] matrix = GetMatrix(5, 5, 1, 10);
System.Console.WriteLine("\nТаблица:");
PrintMatrix(matrix);
AverageOfColumns(matrix);