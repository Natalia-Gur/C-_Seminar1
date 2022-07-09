Console.Write("Введите целое неотрицательное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int start = 2;

if(number <= 1)
{
    Console.Write("Введены некоректные данные!!! Перезапустите программу и повторите ввод вновь!");
}
else
{
    while (start <= number)
    {
        Console.Write(start + " ");
        start = start + 2;
    }
}
Console.WriteLine();