﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// 
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

void PrintSequence(int n, int i = 1)
{
  if (n == 0) return;
  if (n > 0)
  {
    Console.Write(n + " ");
    PrintSequence(n - 1);
  }
  else if (n < 0)
  {
    Console.Write(n + " ");
    PrintSequence(n + 1);
  }


}

int num = InputInt("Введите число");
PrintSequence(num);