﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
if ( int.Parse(a) < 99) {
    Console.WriteLine("Третьей цифры нет, поробуйте ввсести другое число");
} else
    Console.WriteLine($"{a} -> {a[2]}");


// погуглить что это и разобраться 
 Console.WriteLine("пробел");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n>99 ? n.ToString()[2] : '-');
 Console.ReadKey(true);