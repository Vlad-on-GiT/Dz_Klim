// Напишите функцию, которая принимает на вход два числа и
// возводит число А в степень Б.

System.Console.WriteLine("Введите через пробел число возводимое в степень и нужную степень: ");
string A = Console.ReadLine()!;
double[] array = A.Split(',').Select(double.Parse).ToArray();

double exponent = Math.Pow(array[0], array[1]);
System.Console.WriteLine(exponent);

