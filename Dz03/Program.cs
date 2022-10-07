Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 6 || a == 7) 
{
    Console.Write("Выходной");
}
else if (a > 7 || a <=0)
{
    Console.Write("Не существует");
}
else Console.Write("Рабочий день");