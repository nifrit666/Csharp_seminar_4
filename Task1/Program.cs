//Задайте одномерный массив, заполненныё случайными числами.
//Определите количество простых чисел в этом массиве. (простые числа это те, которые делятся на 1 и само на себя)
//Примеры: 
//[1 34 193] => 2
//[4 341 9521 13] => 3


// все методы должны быть скомпанованы и вместе. Либо все наверху, либо внизу
int[] GetArrayRndInt(int size, int max)
{
    int[] array = new int[size];

    Random rnd = new Random(); // это какой-то файл, который содержит набор методов для работы со с.ч.
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(max); // вызов метода Next 
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int CountPrimeNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        //bool IsPrimeNumber = IsPrimeNumber(array[i]);
        if (IsPrimeNumber(array[i]))
        {
            count++;
        }
    }

    return count;
}

bool IsPrimeNumber(int num)
{
    for (int i = 2; i < Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}

int size = 5;
int maxVal = 100;

// вызовы методов:
int[] arr = GetArrayRndInt(size, maxVal);
PrintArray(arr); // это метод void, поэтому мы его просто вызываем т.к. он ничего не возвращает 

int countPrimeNumbers = CountPrimeNumbers(arr);
Console.WriteLine($" => {countPrimeNumbers}");