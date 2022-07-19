/* Задайте прямоугольный двумерный массив. Напишите программу, которая
будет находить строку с наименьшей суммой элемента. */


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

void SearchMinRowAvrg (int[,] mtrx)
{
    int count = 0;
    
    int[] temp = new int[mtrx.GetLength(0)];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            count += mtrx[i, j];
        }
        temp[i] = count;
        count = 0;
    }
    int min = temp[0];
    int minI = 0;
    for (int i = 1; i < temp.Length; i++)
    {
        if (temp[i] <= min) 
        {
            min = temp[i];
            minI = i;
        }
    }
    System.Console.WriteLine($"Строка с наименьшей суммой элементов - № {minI + 1}");
}


int[,] arr = GetMatrix(rowCount, columnCount);
Console.Clear();
PrintMatrix(arr);
System.Console.WriteLine();
SearchMinRowAvrg(arr);