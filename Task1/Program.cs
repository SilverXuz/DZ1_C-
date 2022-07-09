Console.WriteLine("Введите два целых числа. Нажмите Энтер после каждого из них");
int a, b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write("Наибольшее число = ");
    Console.WriteLine(a);
    Console.Write("Наименьшее число = ");
    Console.WriteLine(b);
}
else
{
    Console.Write("Наибольшее число = ");
    Console.WriteLine(b);
    Console.Write("Наименьшее число = ");
    Console.WriteLine(a);
}