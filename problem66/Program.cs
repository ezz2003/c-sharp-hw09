// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// 
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

int GetSummSequence(int m, int n)
{
  if (n == m)
    return n;
  else
    return GetSummSequence(m + 1, n) + m;
}

int numM = InputInt("Введите число M");
int numN = InputInt("Введите число N");
if (numN < numM) (numM, numN) = (numN, numM);
Console.WriteLine(GetSummSequence(numM, numN));