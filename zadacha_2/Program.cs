﻿//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятн

Console.Clear();

Console.Write("Введите число : ");

int number1 = int.Parse (Console.ReadLine());

Console.Write("Введите число : ");

int number2 = int.Parse (Console.ReadLine());

int square = number2*number2;

if (number1 == square)
{
    Console.Write( "Верно !!");
}
else
{
    Console.Write( "Неверно!!");
}
