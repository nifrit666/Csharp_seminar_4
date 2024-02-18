﻿/*
Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
*/

int[] array = { 1, 2, 3, 4, 5, 6, 7 };
int size = array.Length;
int count = 0;
int index = 0;


Console.Write("Исходный массив: ");
foreach (int item in array)
{
    Console.Write(item + " ");
}

while (index < size / 2)
{
    int temp = array[index];
    array[index] = array[size - 1 - count];
    array[size - 1 - count] = temp;
    count += 1;
    index += 1;
}

Console.Write("\nПеревернутый массив: ");
foreach (int item in array)
{
    Console.Write(item + " ");
}
