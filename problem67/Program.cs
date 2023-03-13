// 67. Напишите программу, которая будет принимать на вход число, и выдавать сумму его цифр.

int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

int SummDigits(int num)
{
  if (num == 0)
    return 0;
  else
    return num % 10 + SummDigits(num / 10);
}


int number = InputInt("Введите число");
Console.WriteLine(SummDigits(number));