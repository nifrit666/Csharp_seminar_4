/*
Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
*/


while (true)
{
    Console.Write("Введите целое число или q для выхода: ");
    string input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }

    int number;
    if (int.TryParse(input, out number))
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        if (sum % 2 == 0)
        {
            Console.WriteLine("[STOP]");
            break;
        }
    }

    else
    {
        Console.WriteLine("Неккоретный ввод. Пожалуйста, введите целое число или 'q'. ");
    }

}