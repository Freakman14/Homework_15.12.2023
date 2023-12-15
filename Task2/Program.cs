int add(int a, int b, int sum = 0)
{
    sum = a + b;
    return sum;

}
int subt(int a, int b, int sub = 0)
{
    sub = a - b;
    return sub;

}

int mult(int a, int b, int mul = 0)
{
    mul = a * b;
    return mul;

}

int divis(int a, int b, int div = 0)
{
    div = a / b;
    return div;

}


int v = Convert.ToInt32(Console.ReadLine());
int g = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Add:" + add(v, g));
System.Console.WriteLine("Subtract:" + subt(v, g));
System.Console.WriteLine("Multiply:" + mult(v, g));
System.Console.WriteLine("Division:" + divis(v, g));
