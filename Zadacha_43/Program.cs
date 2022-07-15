/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


Console.WriteLine("Введите координаты A, B через запятую для первой прямой:");
double[] firstArr = StrToArray();
Console.WriteLine("Введите координаты A, B через запятую для второй прямой:");
double[] secondArr = StrToArray();

FindIntersection(firstArr, secondArr);

void FindIntersection(double[] firstArr, double[] secondArr)
{
    if (firstArr[0] == secondArr[0])
    {
        if (firstArr[0] == secondArr[0] && firstArr[1] == secondArr[1]) Console.WriteLine("Прямые совпадают");
        if (firstArr[0] != secondArr[0] && firstArr[1] == secondArr[1]) Console.WriteLine("Прямые совпадают");
        else Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double x = (firstArr[0] - secondArr[0]) / (secondArr[1] - firstArr[1]);
        double y = firstArr[1] * x + firstArr[0];
        System.Console.WriteLine($"Точка пересечения прямых  ({x};{y}).");
    }


}

double[] StrToArray()
{
    return Console.ReadLine()
        .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(Double.Parse).ToArray();
}

