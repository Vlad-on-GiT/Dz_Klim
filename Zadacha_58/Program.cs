/* Задайте две матрицы. Напишите программу, которая будет находить
произведение двух матриц. */

Console.ForegroundColor = ConsoleColor.Red;
System.Console.WriteLine("!!!              Важным условием перемножения матрицы является:              !!!");
System.Console.WriteLine("!!!                совпадение количества строк первой матрицы                !!!");
System.Console.WriteLine("!!!                      с количеством столбцов второй                       !!!");
Console.ForegroundColor = ConsoleColor.White;
System.Console.WriteLine("Введите количество строк первой матрицы:");
int rowCountFirst = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите количество столбцов первой матрицы:");
int columnCountFirst = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите количество строк второй матрицы:");
int rowCountSec = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите количество столбцов второй матрицы:");
int columnCountSec = int.Parse(Console.ReadLine()!);

int[,] GetMatrix(int rows, int columns)
{
    Random rnd = new Random();
    int[,] mtrx = new int[rows, columns];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = rnd.Next(11);
        }
    }
    return mtrx;
}

void PrintMatrix(int[,] mtrx)
{
    string s = new string('-', columnCountFirst * 6);
    System.Console.WriteLine($"  " + s + "\b \b");
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (j == 0) System.Console.Write(" | ");
            System.Console.Write($"{mtrx[i, j],3} | ");
        }
        System.Console.WriteLine("");
    }
    System.Console.WriteLine($"  " + s + "\b \b");
}

void PrintMatrixSec(int[,] mtrx)
{
    string s = new string('-', columnCountSec * 6);
    System.Console.WriteLine($"  " + s + "\b \b");
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (j == 0) System.Console.Write(" | ");
            System.Console.Write($"{mtrx[i, j],3} | ");
        }
        System.Console.WriteLine("");
    }
    System.Console.WriteLine($"  " + s + "\b \b");
}

int[,] MultiMatrix(int[,] FirstMatrix, int[,] SecMatrix)
{
    int[,] resMtrx = new int[rowCountFirst, columnCountSec];

    for (int i = 0; i < rowCountFirst; i++)
    {
        for (int j = 0; j < columnCountSec; j++)
        {
            for (int k = 0; k < rowCountSec; k++)
            {
                resMtrx[i, j] += FirstMatrix[i, k] * SecMatrix[k, j];
            }
        }
    }
    return resMtrx;
}

Console.Clear();
System.Console.WriteLine("Первая матрица:");
int[,] arr = GetMatrix(rowCountFirst, columnCountFirst);
PrintMatrix(arr);
System.Console.WriteLine("Вторая матрица:");
int[,] arr2 = GetMatrix(rowCountSec, columnCountSec);
PrintMatrixSec(arr2);
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("Перемноженная матрица:");

if (columnCountFirst == rowCountSec)
{
    PrintMatrixSec(MultiMatrix(arr, arr2));
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Перемножить матрицы нельзя!");
    Console.ForegroundColor = ConsoleColor.White;
}
