void mind(int n)
{
    for (int i = n; i > 0; i /= 10)
    {
        System.Console.WriteLine(Math.Min(i % 10));
    }
}
void mind(int n)
{
    for (int i = n; i > 0; i /= 10)
    {
        System.Console.WriteLine(Math.Max(i % 10));
    }
}
int n = Convert.ToInt32(Console.ReadLine());

mind(n);