void  num(int n, int even = 0, int odd = 0, int digit = 0, int sum = 0)
{
    for (int i = n; i > 0; i /= 10)
    {
        if (i % 2 == 0)
            even++;
    }
    System.Console.WriteLine("Even:" + even);

    for (int i = n; i > 0; i /= 10)
    {
        if (i % 2 != 0)
        {
            odd++;
        }
    }
    System.Console.WriteLine("Odd:" + odd);

    for (int i = n; i > 0; i /= 10)
    {
        digit++;
    }
    System.Console.WriteLine("Digit:" + digit);

    for (int i = n; i > 0; i /= 10)
    {
        sum += i%10;
    }
    System.Console.WriteLine("Sum:" + sum);
}
int s = Convert.ToInt32(Console.ReadLine());
num(s);