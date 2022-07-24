/* Задайте двумерный массив. Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива. */

System.Console.WriteLine("Введите количество строк:");
int rowCount = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите количество столбцов:");
int columnCount = int.Parse(Console.ReadLine()!);

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
    string s = new string('-', columnCount * 5);
    System.Console.WriteLine($"  " + s + "\b \b");
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (j == 0) System.Console.Write(" | ");
            System.Console.Write($"{mtrx[i, j],2} | ");
        }
        System.Console.WriteLine("");
    }
    System.Console.WriteLine($"  " + s + "\b \b");
}

void SortMatrix(int[,] mtrx)
{
    int rowSize = mtrx.GetLength(0);
    int columnSize = mtrx.GetLength(1);
    
    int[] row = new int[columnCount];
    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)
        {
            row[j] = mtrx[i, j];
        }
        BubbleInvertSort(row);
        for (int k = 0; k < row.Length; k++)
        {
            mtrx[i, k] = row[k];
        }
    }

    int[] col = new int[rowCount];
    for (int i = 0; i < columnSize; i++)
    {
        for (int j = 0; j < rowSize; j++)
        {
            col[j] = mtrx[j, i];
        }
        BubbleInvertSort(col);
        for (int k = 0; k < col.Length; k++)
        {
            mtrx[k, i] = col[k];
        }
    }

    void BubbleInvertSort(int[] inArray)
    {
        for (int i = 0; i < inArray.Length; i++)
            for (int j = 0; j < inArray.Length - i - 1; j++)
            {
                if (inArray[j] < inArray[j + 1])
                {
                    int temp = inArray[j];
                    inArray[j] = inArray[j + 1];
                    inArray[j + 1] = temp;
                }
            }
    }
}

int[,] arr = GetMatrix(rowCount, columnCount);
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
System.Console.WriteLine("Изначальная матрица:");
PrintMatrix(arr);
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("Отсортированная матрица:");
SortMatrix(arr);
PrintMatrix(arr);
Console.ForegroundColor = ConsoleColor.White;
