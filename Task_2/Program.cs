// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number;
int result;

while (true)
{
    Console.Write("Введите число: ");
    string stringNumber = Console.ReadLine();
    bool isNumber = int.TryParse(stringNumber, out number);
    if (isNumber)
    {
        Console.WriteLine($"Вы ввели число: {number}.");
        break;
    }
    else Console.WriteLine("Вы ввели не число, а текст!");
}

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    while (number > 999)
    {
        number /=10;
    }
    result = number % 10;
    Console.WriteLine($"Третья цифра: {result}.");
}