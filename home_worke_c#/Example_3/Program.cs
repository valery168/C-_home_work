﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число 
// чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("введите целое число");
int num = int.Parse(Console.ReadLine());
 if (num % 2 == 0) Console.WriteLine("ДА");
 else Console.WriteLine("НЕТ");
