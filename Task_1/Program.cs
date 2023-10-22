// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number;
int result;

while (true)
{
    Console.Write("Введите трехзначное число: ");
    string stringNumber = Console.ReadLine();
    bool isNumber = int.TryParse(stringNumber, out number);
    if (isNumber)
    {
        if (number < 100 || number > 999)
        {
            Console.WriteLine("Введенное число не трехзначное!");
        }
        else break;
    }
    else
    {
        Console.WriteLine("Вы ввели не число, а текст!");
    }
}

result = number / 10 % 10;

Console.WriteLine($"Вторая цифра в числе {number} это {result}");
