﻿void van(int a)
{
    for (int i = 1; i <= a; i++)
    {
        if (a % i == 0)
        {
            System.Console.Write(i + " ");
        }
    }
}
int x = Convert.ToInt32(Console.ReadLine());

van(x);
