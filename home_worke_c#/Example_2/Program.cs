// Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
int a = 22;
int b = 3;
int c = 9;
int biggre = 0;
if (a > biggre) biggre = a;
if (b > biggre) biggre = b;
if (c > biggre) biggre = c;
Console.Write("это число ");
Console.Write(biggre);