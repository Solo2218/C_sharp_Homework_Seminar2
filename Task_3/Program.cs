// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int number;

while (true)
{
    Console.Write("Введите цифру дня недели: ");
    string stringNumber = Console.ReadLine();
    bool isNumber = int.TryParse(stringNumber, out number);
    if (isNumber)
    {
        if ( number >= 1 && number <= 7)
        {
            Console.WriteLine($"Вы ввели цифру: {number}.");
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели цифру не соответствующую дню недели! Дни недели от 1 до 7");
        }
    }
    else Console.WriteLine("Вы ввели не цифру, а текст!");
}

if (number == 6 || number == 7)
{
    Console.WriteLine("Это выходной день!");
}
else 
{
    Console.WriteLine("Нужно идти на работу.");
}