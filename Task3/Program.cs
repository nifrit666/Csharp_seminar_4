//простой метод

// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231
void Main()
{
    int arraySize = ReadInt("Bведите количество чисел в массиве: ");
    int[] array = GenerateArray(7, 0, 9);
    PrintArray(array);
    int result = Convert.ToInt32(string.Concat(array));
    System.Console.WriteLine(result);
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
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");; // {1, 2, 8, 9} -> join "1, 2, 8, 9" -> concat "1289"
}

Main();