int a;
Console.WriteLine("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0 )
{
    Console.WriteLine("чётное число");
}
else
{
    Console.WriteLine("нечётное");
}
Console.ReadKey();