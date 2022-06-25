class Program {
    static void Main(string[] args) { 
    
        int elementsCount = 3;

        int[] myArray = new int[elementsCount];

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"\nВведите число №{i}:\t");

            myArray[i] = int.Parse(Console.ReadLine()!);
        }

    int j = 0;
    int max = 0;

    while (j < elementsCount)
    {
        if (max < myArray[j])
        {
            max = myArray[j];
        }
        else {}
    j ++;
    }
    Console.WriteLine ($"Максимальное число: " + max);

    }
}