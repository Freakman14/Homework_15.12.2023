int cip(int x, int y)
{
    int z = 0;
    z = x;
    x = y;
    y = z;
    return x;
}

int pin(int x, int y)
{
    int z = 0;
    z = x;
    x = y;
    y = z;
    return y;
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("x = " + cip(a, b));
System.Console.WriteLine("y = " + pin(a, b));