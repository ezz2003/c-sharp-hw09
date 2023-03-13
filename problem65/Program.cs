// 65.Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 

int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

void PrintSequence(int m, int n)
{
  if (m < n)
  {
    PrintSequence(m, n - 1);
    Console.Write(n + " ");
  }
  else if (n < m)
  {
    Console.Write(m + " ");
    PrintSequence(m - 1, n);
  }
  else
  {
    Console.Write(n + " ");
  }
}

int numM = InputInt("Введите число M");
int numN = InputInt("Введите число N");
PrintSequence(numM, numN);