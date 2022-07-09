Console.Write("Введите целое число от 3 до 20: "); // Поставил лимит, чтобы исключить большие числа
int a = Convert.ToInt32(Console.ReadLine());
while (a <= 2 || a > 20)
{
    Console.WriteLine("Это число не подходит");
        a = Convert.ToInt32(Console.ReadLine());
}
int i = 2;
while (i <= a)
{
    Console.Write(i);
    Console.Write(" ");
    i = i + 2;
}
