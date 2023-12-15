void cip(int n, int sum = 0)
{
    int[] arr = new int[n];
    for (int i = 1; i < n - 1; i++)
    {
        sum = i + n;
        System.Console.Write("[" + sum + "]");
    }
}
int n = Convert.ToInt32(Console.ReadLine());
cip(n);