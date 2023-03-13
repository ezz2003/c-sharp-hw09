// 69.Напишите программу, которая на вход ринимает два числа А и В, и возводит А в целую степень В с помощью рекурсии.

int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

int CustomPow(int num, int deg)
{
  if (deg == 0)
    return 1;
  else
    return num * CustomPow(num, deg - 1);
}


int number = InputInt("Введите число");
int degree = InputInt("Введите степень числа");
Console.WriteLine(CustomPow(number, degree));
