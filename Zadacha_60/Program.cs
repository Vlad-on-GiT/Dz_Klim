/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента. */

// Блок создания матрицы.
System.Console.WriteLine("===================================================");
System.Console.WriteLine("         Сделал на примере матриц 3х3х3 \n");
int[] sizeMtrx = {3, 3, 3};  // Пришлось сделать пока так, мозги кипят.

int[,,] Get3dMatrix(int row, int column, int page)
{
    Random rnd = new Random();
    int filler = rnd.Next(10, 70);

    int[,,] mtrx = new int[page, row, column];

    for (int i = 0; i < mtrx.GetLength(0); i++)            // Перебираем страницы
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)        // Перебираем строки
        {
            for (int k = 0; k < mtrx.GetLength(2); k++)    // Перебираем столбцы
            {
                mtrx[i, j, k] = filler;
                filler++;
            }
        }
    }
    return mtrx;
}

int[,,] ShufflMatrix(int[,,] mtrx)
{
    int rowSize = mtrx.GetLength(1);
    int columnSize = mtrx.GetLength(2);
    int pageSize = mtrx.GetLength(0);
    int[,,] temp = new int[pageSize, rowSize, columnSize];

    // Перемешивание строк
    int[] row = new int[rowSize];
    for (int i = 0; i < pageSize; i++)              // Page
    {
        for (int j = 0; j < rowSize; j++)           // Row
        {
            for (int k = 0; k < columnSize; k++)    // Column
            {
                row[k] = mtrx[i, j, k];
            }
            Shuffl(row);
            for (int k = 0; k < row.Length; k++)
            {
                temp[i, j, k] = row[k];
            }
        }
    }
    // Перемешивание столбцов
    int[] column = new int[columnSize];
    for (int i = 0; i < pageSize; i++)              // Page
    {
        for (int j = 0; j < rowSize; j++)           // Row
        {
            for (int k = 0; k < columnSize; k++)    // Column
            {
                column[k] = mtrx[i, k, j];
            }
            Shuffl(column);
            for (int k = 0; k < row.Length; k++)
            {
                temp[i, k, j] = column[k];
            }
        }
    }

    // Очередное перемешивание по всем страницам
    for (int i = 0; i < pageSize; i++)              // Page
    {
        for (int j = 0; j < rowSize; j++)           // Row
        {
            for (int k = 0; k < columnSize; k++)    // Column
            {
                column[k] = mtrx[k, i, j];
            }
            Shuffl(column);
            for (int k = 0; k < row.Length; k++)
            {
                temp[k, i, j] = column[k];
            }
        }
    }

    void Shuffl(int[] inArray)
    {
        Random r = new Random();
        for (int i = inArray.Length; i > 0; i--)
        {
            int j = r.Next(i);
            int k = inArray[j];
            inArray[j] = inArray[i - 1];
            inArray[i - 1] = k;
        }
    }
    return temp;
}

void PrintMatrix(int[,,] mtrx, int[,,] mtrx2)
{
    string s = new string('-', sizeMtrx[1] * 5);
    int pages = 1;
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        System.Console.WriteLine($"  Страница № {pages}                  Перемешанная страница № {pages}");
        System.Console.WriteLine($"  " + s + "\b \b" + "                  " + s + "\b \b");
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            for (int k = 0; k < mtrx.GetLength(2); k++)
            {
                if (k == 0) System.Console.Write(" |");
                System.Console.Write($" {mtrx[i, j, k],2} |");
            }
            System.Console.Write("               ");
            for (int k = 0; k < mtrx.GetLength(2); k++)
            {
                if (k == 0) System.Console.Write(" |");
                System.Console.Write($" {mtrx2[i, j, k],2} |");
            }
            System.Console.WriteLine("");
            System.Console.WriteLine($"  " + s + "\b \b" + "                  " + s + "\b \b");
        }
        pages++;
    }
}

int[,,] MtrxThreeD = Get3dMatrix(sizeMtrx[0], sizeMtrx[1], sizeMtrx[2]);
int[,,] MtrxShuffled = ShufflMatrix(MtrxThreeD);

PrintMatrix(MtrxThreeD, MtrxShuffled);

// Блок вывода значения + индекс.
System.Console.WriteLine("===================================================");
System.Console.WriteLine("         Блок вывода значения + индекс \n");
void PrintIdMatrix (int[,,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            for (int k = 0; k < mtrx.GetLength(2); k++)
            {
                System.Console.WriteLine($"Значение {mtrx[i,j,k]} - Индекс[{i},{j},{k}]");
            }
        }
    }
}
PrintIdMatrix(MtrxShuffled);
 