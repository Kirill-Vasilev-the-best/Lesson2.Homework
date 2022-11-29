// Задача №13. Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Пожалуйста введите число");
int num = Convert.ToInt32(Console.ReadLine());
int d = 0, k = 0;

if (num > 99)
{
    k = num;
    while (k >= 1000)
    {
        k /= 10;
        d = k % 10;
    }
    Console.WriteLine($"Третья цифра этого числа {d}");
}
else
{
    Console.WriteLine($"Извините, третьей цифры нет");
}
