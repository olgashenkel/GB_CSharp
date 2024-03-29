﻿// ****************************************************************************************************
// ****************************************************************************************************
// РАЗДЕЛ S. Ввод и вывод числовых данных. Оператор присваивания
// ****************************************************************************************************
// ****************************************************************************************************

// РАЗДЕЛ S1. Простейшие программы. Арифметические выражения

// ****************************************************************************************************
// ****************************************************************************************************


// S1.1. Вывести на экран число с точностью до сотых.

// double a = 12345.1275789;
// Console.WriteLine("\nЗадача 1: " + "{0:#.00}", a);

// ****************************************************************************************************

// S1.2. Вывести на экран число e (основание натурального логарифма) 
// с точностью до десятых.

// double e = Math.E;
// Console.WriteLine("\nЗадача 2: " + "{0:#.0}", e);

// ****************************************************************************************************

// S1.3. Составить программу вывода на экран числа, вводимого с клавиатуры. 
// Выводимому числу должно предшествовать сообщение «Вы ввели число».

// Console.WriteLine("Введите число");
// string num = Console.ReadLine()!;
// Console.WriteLine("\nЗадача 3: Вы ввели число " + num);
// Console.WriteLine($"\nЗадача 3: Вы ввели число {num}");


// ****************************************************************************************************

// S1.4. Составить программу вывода на экран числа, вводимого с клавиатуры. 
// После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».

// Console.WriteLine("Введите число");
// string num = Console.ReadLine()!; // Знак ! - дает избежать вывода ошибки NULL
// Console.WriteLine($"{num} - вот такое число вы ввели");

// ****************************************************************************************************

// S1.5. Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.

// Console.WriteLine("Способ 1: 1 13 49\n");
// int num1 = 1;
// int num2 = 13;
// int num3 = 49;
// Console.WriteLine($"Способ 2: {num1} {num2} {num3}\n");
// Console.WriteLine("Способ 3: " + num1 +" "+ num2 +" "+ num3);

// ****************************************************************************************************

// S1.6. Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.

// Console.WriteLine("Способ 1: 7  15  100\n");
// int num1 = 7;
// int num2 = 15;
// int num3 = 100;
// Console.WriteLine($"Способ 2: {num1}  {num2}  {num3}\n");
// Console.WriteLine("Способ 3: " + num1 +"  "+ num2 +"  "+ num3);


// ****************************************************************************************************

// S1.7. Составить программу вывода на экран 
// в одну строку трех любых чисел с двумя пробелами между ними.

// Console.WriteLine("Введите через <Enter> три любых числа");
// string num1 = Console.ReadLine()!; // Знак ! - дает избежать вывода ошибки NULL
// string num2 = Console.ReadLine()!; // Знак ! - дает избежать вывода ошибки NULL
// string num3 = Console.ReadLine()!; // Знак ! - дает избежать вывода ошибки NULL
// Console.WriteLine($"Вы ввели такие числа: {num1}  {num2}  {num3}");

// ****************************************************************************************************

// S1.8. Составить программу вывода на экран 
// в одну строку четырех любых чисел с одним пробелом между ними.

// Console.WriteLine("Введите через <Enter> четыре любых числа");
// Console.WriteLine($"Вы ввели такие числа: {Console.ReadLine()} {Console.ReadLine()} {Console.ReadLine()} {Console.ReadLine()}");


// ****************************************************************************************************

//S1.9.Вывести на экран числа 50 и 10 одно под другим.

// Console.Write("Способ 1:\n50\n10\n");
// Console.Write($"Способ 2:\n{50}\n{10}\n");
// Console.Write("Способ 3:\n{0}\n{1}", 50,10);

// ****************************************************************************************************

//S1.10.Вывести на экран числа 5, 10 и 21 одно под другим.

// Console.WriteLine($"{5}\n{10}\n{21}");

// ****************************************************************************************************

//S1.11.Составить программу вывода на экран «столбиком» четырех любых чисел.

// Random random = new Random();
// Console.WriteLine($"Вывод на экран четыре случайных числа:\n{random.Next(1, 10)}\n{random.Next(10, 20)}\n{random.Next(20, 30)}\n{random.Next(30, 40)}");


// ****************************************************************************************************

// S1.12. Составить программу вывода на экран следующей информации:
// 5 10
// 7 см

// Console.WriteLine($"Вывод на экран следующей информации:\n5 10\n7 см");

// ****************************************************************************************************

// S1.13. Составить программу вывода на экран следующей информации:
// 2 кг
// 13 17

// Console.WriteLine($"Вывод на экран следующей информации:\n2 кг\n13 17");




// ****************************************************************************************************
// ****************************************************************************************************

// РАЗДЕЛ S2. Вычисления по известным формулам

// ****************************************************************************************************
// ****************************************************************************************************


// S2.1. Составить программу:
// а) вычисления значения функции y=7x^2+3x+6 при любом значении x;
// б) вычисления значения функции x=12a^2+7a+12 при любом значении а.

// Console.WriteLine("Введите значение X для функции y=7x^2+3x+6 (дробная часть вводится через запятую)");
// double x1 = double.Parse(Console.ReadLine()!);
// double y = 7 * x1 * x1 + 3 * x1 + 6;
// Console.WriteLine($"Значение функции 7x^2+3x+6 = {y}, при Х равном {x1}\n");

// Console.WriteLine("Введите значение А для функции x=12a^2+7a+12 (дробная часть вводится через запятую)");
// double a = double.Parse(Console.ReadLine()!);
// double x2 = 12 * a * a + 7 * a + 12;
// Console.WriteLine($"Значение функции 12a^2+7a+12 = {x2}, при А равной {a}");

// ****************************************************************************************************

// S2.2. Дана сторона квадрата. Найти его периметр.

// Console.WriteLine("Введите сторону квадрата");
// double storona = double.Parse(Console.ReadLine()!);
// Console.WriteLine($"Периметр квадрата: P=4*a={4 * storona}");

// ****************************************************************************************************

// S2.24. Возраст Тани — X лет, а возраст Мити — Y лет. Найти их средний возраст, 
// а также определить, на сколько отличается возраст каждого ребенка от среднего значения.

// Console.WriteLine("Введите возраст Тани:");
// int year_tanya = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите возраст Мити:");
// int year_tima = int.Parse(Console.ReadLine()!);

// int average = (year_tanya + year_tima)/2;

// Console.WriteLine($"Средний возраст составит - {average} лет");

// if(average > year_tanya)
// {
//     Console.WriteLine($"Таня моложе, чем средний возраст на {average - year_tanya} лет");
// }
// else if (average < year_tanya)
// {
//     Console.WriteLine($"Таня старше, чем средний возраст на {year_tanya - average} лет");
// }
// else
// {
//     Console.WriteLine($"Средний возраст и возраст Тани совпадают: {average} лет");
// }

// if(average > year_tima)
// {
//     Console.WriteLine($"Тима моложе, чем средний возраст на {average - year_tima} лет");
// }
// else if (average < year_tima)
// {
//     Console.WriteLine($"Тима старше, чем средний возраст на {year_tima - average} лет");
// }
// else
// {
//     Console.WriteLine($"Средний возраст и возраст Тимы совпадают: {average} лет");
// }




// ****************************************************************************************************
// ****************************************************************************************************

// РАЗДЕЛ S3. Часто используемые эффективные алгоритмы

// ****************************************************************************************************
// ****************************************************************************************************

// S3.1 Составить программу обмена значениями двух переменных величин.

// Console.WriteLine("Введите значение первой переменной - a:");
// string a = Console.ReadLine()!;
// Console.WriteLine("Введите значение второй переменной - b:");
// string b = Console.ReadLine()!;
// Console.WriteLine($"Меняем местами значения переменных: a = {b}, b = {a}");


// Console.WriteLine($"\nМеняем местами значения переменных программно:");
// Console.WriteLine("Введите значения a и b они поменяются местами");
// int a = int.Parse(Console.ReadLine()!);
// int b = int.Parse(Console.ReadLine()!);
// (a, b) = (b, a);
// Console.WriteLine($"a = {a}, b = {b}");
// Console.ReadKey();


// ****************************************************************************************************

// S3.2. Cоставить программу обмена значениями трех переменных величин а, b, c по
// следующим двум схемам: 
// а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
// б) b присвоить значение а, с присвоить значение b, а присвоить значение с.

// Console.WriteLine("Введите значение первой переменной - a:");
// string a = Console.ReadLine()!;
// Console.WriteLine("Введите значение второй переменной - b:");
// string b = Console.ReadLine()!;
// Console.WriteLine("Введите значение третьей переменной - c:");
// string c = Console.ReadLine()!;
// Console.WriteLine($"а) Меняем местами значения переменных:\nb => с => {c}, a => b => {b}, c => a => {a}\n");
// Console.WriteLine($"б) Меняем местами значения переменных:\nb => a => {a}, c => b => {b}, a => c => {c}");

// Console.WriteLine($"\nМеняем местами значения переменных программно - 1 способ:");
// string a1 = b;
// Console.WriteLine($"a = {a1}");
// string b1 = c;
// Console.WriteLine($"b = {b1}");
// string c1 = a;
// Console.WriteLine($"c = {c1}");

// Console.WriteLine($"\nМеняем местами значения переменных программно - 2 способ:");
// Console.WriteLine("Введите значение первой переменной - a:");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите значение второй переменной - b:");
// int b = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите значение третьей переменной - c:");
// int c = int.Parse(Console.ReadLine()!);
// (b, c, a) = (a, b, c);
// Console.WriteLine($"б) Меняем местами значения переменных:\nb => a => {b}, c => b => {c}, a => c => {a}");


// ****************************************************************************************************

// S3.3. Дано вещественное число а. Пользуясь только операцией умножения, получить:
// а) a^4 за две операции;
// б) a^6  за три операции;
// в) a^7 за четыре операции;
// г) a^8  за три операции;
// д) a^9 за четыре операции;
// е) a^10  за четыре операции.

// Console.WriteLine("Введите значение вещественного числа - a:");
// double a = double.Parse(Console.ReadLine()!);
// double a1 = a * a;
// double a2 = a1 * a1;
// Console.WriteLine($"a^4 за две операции = {a2}");
// double a3 = a2 * a1;
// Console.WriteLine($"a^6  за три операции = {a3}");
// double a4 = a3 * a;
// Console.WriteLine($"a^7 за четыре операции = {a4}");

// double a5 = a1 * a;
// double a6 = a5 * a;
// double a7 = a6 * a2;
// Console.WriteLine($"a^8 за три операции = {a7}");
// double a8 = a7 * a;
// Console.WriteLine($"a^9 за четыре операции = {a8}");

// double a9 = a7 * a1;
// Console.WriteLine($"a^10 за четыре операции = {a9}");