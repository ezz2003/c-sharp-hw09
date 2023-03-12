// 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа от 1 до N

int InputInt(string message)
{
    Console.Write(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintSequence(int n, int i = 1)
{
    if (n == 0) return;
    PrintSequence(n - 1);
    Console.Write(n+" ");
}

int num = InputInt("Введите число");
PrintSequence(num);