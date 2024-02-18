/*
Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
*/

int[] GetArrayRndInt(int size, int max)
{
    int[] array = new int[size];

    Random rnd = new Random(); // что-то что содержит набор методов для работы со с.ч.
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(max); // вызов метода Next 
    }
    return array;
}

int FindNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] array = GetArrayRndInt(5, 1000);
int count = FindNumber(array);
PrintArray(array);
Console.WriteLine($"=> {count}");