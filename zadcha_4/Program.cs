Console.Clear();

Console.Write("Введите номер дня недели: ");
int count = 0;
int number1 = int.Parse (Console.ReadLine());
if (number1 > 0)
{
    count = number1*(-1);
    while (count <= number1)
    {
        Console.Write($"{count}," );
        count++;
    }
}
else
{
    count = number1*(-1);
    while (count <= number1*(-1));
    {
        Console.Write($"{count}," );
        count++;
    }
}