/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве. 
Нашел вариант через LINQ, сделал как понял. Оформлять не стал, это уже за малым*/

int[] array = GetArray(20);

int evenValueCount = (
    from value in array
    where IsEven(value)
    select value
).Count();

System.Console.WriteLine(string.Join(',', array));
System.Console.WriteLine("\nКоличество четных чисел в массиве равно {0}", evenValueCount);

int[] GetArray(int size)
{
    int[] array = new int[size];
   for (int i = 0; i < size; i++)
   {
     array[i] = new Random().Next(100);
   }
    return array;
}

bool IsEven(int i)
    {
        return i % 2 == 0;
    }