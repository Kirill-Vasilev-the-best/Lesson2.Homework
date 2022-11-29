// Задача №15. Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Пожалуйста введите день недели (численное значение)");
int num = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek(int num)
{

    if (num >= 1 && num <= 5)
    {
        Console.Write("Нет, к сожалению это не выходной");
    }
    else if (num >= 6 && num <= 7)
    {
        Console.Write("Ура! Это выходной");
    }

    else Console.Write("Увы, такого дня недели не существует");
}
CheckingTheDayOfTheWeek(num);
