Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2)
{
    Console.WriteLine("Числа равны");
}
else  
{
    if(number1 > number2)
    {
        Console.WriteLine("Первое число " + number1 + " большее, второе число " + number2 + " меньшее.");
    }
    else
    {
         Console.WriteLine("Первое число " + number1 + " меньшее, второе число " + number2 + " большее.");
    }
}