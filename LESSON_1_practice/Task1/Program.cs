﻿// // ****************************************************************************************************

// // Задание 1. 
// // Напишите программу, которая на вход
// // принимает два целых числа и проверяет,
// // является ли первое число квадратом второго.
// // a = 25, b = 5 => да
// // a = 2, b = 10 => нет
// // a = 9, b = -3 => да
// // a = -3, b = 9 => нет

// int first = 9;
// int second = -3;

// if (second * second == first)
// {
//     Console.Write("yes");
// }
// else
// {
//     Console.Write("no");
// }
// // ****************************************************************************************************


// // Задание 2. 
// // Напишите программу, которая на вход принимает
// // целое число N, а на выходе показывает все целые
// // числа в промежутке от -N до N.
// // Примеры
// // 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// // 2 => -2, -1, 0, 1, 2

// int n = 4;

// for (int i = -n; i <= n; i++)
// {
//     Console.Write($"  {i}");
// }
// // ****************************************************************************************************


// // Задание 3*. 
// // Напишите программу, которая принимает на вход
// // трёхзначное целое число и на выходе показывает сумму
// // первой и последней цифры этого числа.
// // 456 => 10
// // 782 => 9
// // 918 => 17

// int n = 918;
// int a = n/100;
// int b = n%10;

// Console.Write(a+b);
// ****************************************************************************************************