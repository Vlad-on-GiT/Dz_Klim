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

void SortMatrix(int[,] mtrx)
{
    int[] row = new int[columnCount];
    int rowSize = mtrx.GetLength(0);
    int columnSize = mtrx.GetLength(1);
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
PrintMatrix(arr);
System.Console.WriteLine();
SortMatrix(arr);
PrintMatrix(arr);
