Console.WriteLine("Введите три целых числа. Нажмите Энтер после каждого из них");
int a, b, c;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
if (a > b & a > c )
{
    Console.Write("Наибольшее число = ");
    Console.WriteLine(a);
}
else
{
    if (b > c)
    {
        Console.Write("Наибольшее число = ");
        Console.WriteLine(b);
    }
    else
    {
        Console.Write("Наибольшее число = ");
        Console.WriteLine(c);
    }
}
