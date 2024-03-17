// Задание 1. Совместная работа
// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// string s = "";
// char[] chars = { 'a', 'b', 'c' };

// foreach (char c in chars)
// {
//     s += c;
// }
// Console.Write(s);

// ****************************************************************************************************

// Задание 2. 
// На основе символов строки (тип string) сформировать массив 
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.

// ***************
// РЕШЕНИЕ:
// ***************

// char[] ToCharArray(string input)
// {
//     char[] array = new char[input.Length];
//     for(int i=0; i<array.Length; i++)
//     {
//         array[i] = input[i];
//     }
//     return array;
// }

// void PrintArray(char[] array)
// {
//     Console.Write("["); 
//     foreach (char c in array)
//     {
//         Console.Write($"{c} ");
//     }
//     Console.WriteLine("]");
// }


// Console.Clear();
// Console.WriteLine("Введите строку:");
// string input = Console.ReadLine()!;

// char[] array = ToCharArray(input);

// Console.WriteLine("\nСформированный массив:");

// PrintArray(array);


// ****************************************************************************************************
// Задание 3. Совместная работа
// Считать строку с консоли, состоящую из латинских букв в 
// нижнем регистре. Выяснить, сколько среди введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

// ***************
// РЕШЕНИЕ:
// ***************

// using System.Runtime.CompilerServices;

// char[] ToCharArray(string input)
// {
//     char[] array = new char[input.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = input[i];
//     }
//     return array;
// }

// // int CountGlasnyeIsArray(string array)
// // {
// //     int count = 0;
// //     for (int i = 0; i < array.Length; i++)
// //         if (array[i] == 'e' || array[i] == 'u' || array[i] == 'i' || array[i] == 'o' || array[i] == 'a' || array[i] == 'y')
// //         {
// //             count++;
// //         }
// //     return count;
// // }

// // Альтернативная функция:

// bool IsLetsVowels(char vowel)
// {
//     char[] vowels = { 'e', 'y', 'u', 'i', 'o', 'a' };
//     foreach (char item in vowels)
//     {
//         if (vowel == item)
//         {
//             return true;
//         }
//     }
//     return false;
// }


// int CountGlasnyeIsArray(string array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (IsLetsVowels(array[i]))
//         {
//             count++;
//         }
//     return count;
// }

// void PrintArray(char[] array)
// {
//     Console.Write("[");
//     foreach (char c in array)
//     {
//         Console.Write($"{c} ");
//     }
//     Console.WriteLine("]");
// }


// Console.Clear();
// Console.WriteLine("Введите строку:");
// string input = Console.ReadLine()!;

// Console.WriteLine($"\nКоличество гласных в строке = {CountGlasnyeIsArray(input)}");


// ****************************************************************************************************
// Задание 4. Совместная работа
// Считать строку с консоли и развернуть её.
// Пример
// “hello” => “olleh”
// “world” => “dlrow”

// ***************
// РЕШЕНИЕ:
// ***************


// string ReversIsString(string input)
// {
//     string result = "";
//     for (int i = input.Length - 1; i > -1; i--)
//     {
//         result += input[i];
//     }
//     return result;
// }

// Console.Clear();
// Console.WriteLine("Введите строку:");
// string input = Console.ReadLine()!;

// Console.WriteLine($"\nПеревернутая строка - {ReversIsString(input)}");


// ****************************************************************************************************

// ***************
// РЕШЕНИЕ:
// ***************



// ****************************************************************************************************

// ***************
// РЕШЕНИЕ:
// ***************




// ****************************************************************************************************

// ***************
// РЕШЕНИЕ:
// ***************
