// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.

// БЕЗ ФУНКЦИИ

// System.Console.Write("Введите количество элементов в массиве: ");
// int arraySize = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[arraySize];

// for (int i = 0; i < arraySize; i++)
// {
//     array[i] = new Random().Next(0, 1000);
// }

// array [0] = 91; // Добавили число 91, а то долго ждать совпадения условия

// for (int i = 0; i < arraySize; i++)
// {
//     System.Console.Write(array[i] + " ");
// }

// int countNumbers = 0;

// for (int i = 0; i < arraySize; i++)
// {
//     if (array[i] % 10 == 1 && array[i] % 7 == 0)
//     {
//         countNumbers++;
//     }
// }

// System.Console.WriteLine("\n" + countNumbers);

// С ИСПОЛЬЗОВАНИЕМ ФУНКЦИИ

// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.

void Main()
{
    int arraySize = ReadInt("Bведите количество чисел в массиве: ");
    int[] array = GenerateArray(arraySize, 0, 1000);
    array[0] = 91;
    PrintArray(array);
    System.Console.WriteLine("\n" + CountNumbers(array, 1, 7));
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] myArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        myArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return myArray;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");;
}

int CountNumbers(int[] array, int lastDigit, int divideBy)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == lastDigit && array[i] % divideBy == 0)
        {
            count++;
        }
    }

    return count;
}
Main ();