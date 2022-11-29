// Задача №10. Программа, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("Пожалуйста введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int d = 0, k = 0;

if (num > 99)
{
    k = num;
    while (k >= 100)
    {
        k /= 10;
        d = k % 10;
    }
    Console.WriteLine($"Вторая цифра этого числа {d}");
}
else
{
    Console.WriteLine($"Второй цифры нет, извините");
}
