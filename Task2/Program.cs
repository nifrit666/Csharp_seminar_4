// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.

// БЕЗ ФУНКЦИИ

System.Console.Write("Введите количество элементов в массиве: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arraySize];

for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(0, 1000);
}

array [0] = 91; // Добавили число 91, а то долго ждать совпадения условия

for (int i = 0; i < arraySize; i++)
{
    System.Console.Write(array[i] + " ");
}

int countNumbers = 0;

for (int i = 0; i < arraySize; i++)
{
    if (array[i] % 10 == 1 && array[i] % 7 == 0)
    {
        countNumbers++;
    }
}

System.Console.WriteLine("\n" + countNumbers);