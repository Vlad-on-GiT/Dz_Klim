//Напишите программу которая принимает на вход птятизначное число
// и проверяет является ли оно палиндромом.

// Способ №1

/* Console.WriteLine("Введите пятизначное число:");
string chislo = Console.ReadLine();
if (chislo[0] == chislo[4] && chislo[1] == chislo[3])
{
    System.Console.WriteLine("Является полиндромом.");
}
else
{
    System.Console.WriteLine("Не является полиндромом.");
} */



//Способ №2 подслушал вариант решения в чате
// Мешанина конечно получилась, но это я баловался, пробовал разные функции и методы
// главное работает

/* Console.WriteLine("Введите пятизначное число:");
int inputNumber = int.Parse(Console.ReadLine()!);

int Reversal(int number)
{
    int reverseNumber = 0;
    int tempNumber = number;
    while (number > 0)
    {
        int remainder = number % 10;
        reverseNumber = reverseNumber * 10 + remainder;
        number /= 10;
    }
    return reverseNumber;
}

int invertedNumber = Reversal(inputNumber);
int lenght = Convert.ToString(inputNumber).Length;

if (lenght == 5)
{
    if (Convert.ToString(inputNumber).SequenceEqual(Convert.ToString(invertedNumber)))
    {
        System.Console.WriteLine($"Число {inputNumber} - палиндром");
    }
    else
    {
        System.Console.WriteLine($"Число {inputNumber} - не палиндром");
    }
}
else
{
    System.Console.WriteLine($"Введено не пятизначное число");
}
 */


// Способ №3... Кто-то в чате заикнулся что можно сделать проверку на вводимое число
// является ли оно числом, и сколько в нем цифр... блин это было не просто... 

Console.Clear();
System.Console.WriteLine("Введите пятизначное число:");
string input = Console.ReadLine()!;
Int32 number;
bool result = int.TryParse(input, out number);

while (result == false)
{
    Console.WriteLine("ОШИБКА! ВЫ ВВЕЛИ НЕ ЦЕЛОЧИСЛЕННОЕ ЗНАЧЕНИЕ\n");
    Console.Write("Введите целое число: ");
    result = int.TryParse(Console.ReadLine()!, out number);
}

int length = Convert.ToString(number).Length;
if (length == 5)
{
    if (Convert.ToString(number).Reverse().SequenceEqual(Convert.ToString(number))) Console.WriteLine($"Число {number} является палиндромом");
    // реверс переворачивает число,секьенсеквал сравнивает
    else System.Console.WriteLine($"Число {number} не является палиндромом ");
}
else
{
    System.Console.WriteLine($"Error. Введите пятизначное число");
}