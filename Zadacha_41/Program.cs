/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
System.Console.WriteLine(" ------------------------------------------");
System.Console.WriteLine("|         Вариант через ConvertAll         |");
System.Console.WriteLine("|              и используя LINQ            |");
System.Console.WriteLine(" ------------------------------------------");

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
System.Console.WriteLine("Введите числа через запятую: ");

int[] arr = Array.ConvertAll(Console.ReadLine().Split(','), int.Parse);

int[] arrPositiveInd = arr
    .Where ((item, Index) => item > 0 )
    .ToArray();

System.Console.WriteLine("Чисел больше 0 в массиве: {0}", arrPositiveInd.Length);