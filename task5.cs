using System;
class Program5
{

    static void Main()
    {
        string s1 = "Сумма всех чисел меньше 1000, кратных 3, или 5 ровна:  ";
           
        int a = 0;
        for (int b = 3; b < 1000; b++)
        {
            if (b % 3 == 0 || b % 5 == 0)
            { a += b; }
        }

        double dblValue = a;

        Console.WriteLine(s1 + dblValue.ToString("N0"));


        }
}