using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MyMath
{
    public static int Sum(int min, int max)
    {
        int sum = 0;
        for (int i = min; i <= max; i++)
        {
            sum += i;
        }
        return sum;
    }

    public static int Mult(int x, int y)
    { 
        return x * y;
    }

    public static int Abs(int value)
    {
        return value < 0 ? -value : value;
    }

    public static double Abs(double value)
    {
        return value < 0 ? -value : value;
    }

}