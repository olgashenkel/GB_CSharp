﻿// 5.3. Поиск четных элементов
// Пусть дан массив на некоторое количество целых чисел, например, 10 штук.
// Требуется найти в массиве четные числа и вывести их на экран.
// ***************
// РЕШЕНИЕ:
// ***************

// int N = 10;
int[] array = { 2, 11, 7, 8, 10, 15, 16, 5, 7, 12 };
int i = 0;

while (i < array.Length)
{
    if(array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i++;
}

Cons