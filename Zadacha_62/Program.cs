/* Заполните спирально массив */


int[,] GetSpiralMatrix(int row, int column)
{
    int[,] temp = new int[row, column];
    int fix = 0;
    int count = 1;
    while (fix <= row/2)
    {
    for (int i = 0 + fix; i < 1 + fix; i++)
    {
        for (int j = 0 + fix; j < column - fix; j++)
        {
            temp[i, j] = count;
            count++;
        }
    }
    count--;
    for (int i = 0 + fix; i < column - fix; i++)
    {
        for (int j = row - 1 - fix; j < column - fix; j++)
        {
            temp[i, j] = count;
            count++;
        }
    }
    count--;
    for (int i = column - 1 - fix; i < column - fix; i++)
    {
        for (int j = row - 1 - fix; j >= 0 + fix; j--)
        {
            temp[i, j] = count;
            count++;
        }
    }
    count--;
    for (int i = column - 1 - fix; i > 0 + fix; i--)
    {
        for (int j = 0 + fix; j < 1 + fix; j++)
        {
            temp[i, j] = count;
            count++;
        }
    }
    fix++;
    }
    return temp;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            System.Console.Write($"{mtrx[i, j],2} ");
        }
        System.Console.WriteLine();
    }
}

PrintMatrix(GetSpiralMatrix(7, 7));