﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. Например: 3 -> 1, 8, 27;  5 -> 1, 8, 27, 64, 125

int number = ReadInt("Type N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{Math.Pow(i, 3)} ");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

