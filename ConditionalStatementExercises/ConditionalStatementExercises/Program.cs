class Program 
{
    static int AbsoluteValue(int x) 
    {
        return Math.Abs(x);
    }

    static int DivisibleBy2or3(int x, int y) 
    {
        // if both integers are divisble by 2 or 3 return the multiplication, else the sum.
        if (((x % 2 == 0) || (x % 3 == 0)) && ((y % 2 == 0) || (y % 3 == 0)))
        {
            return x * y;
        }
        else
        {
            return x + y;
        }
    }
    static bool IsUppercase(string s)
    {
        return (s == s.ToUpper()) && (s.All(Char.IsLetter));
    }

    static bool GreatherThanThird(int[] x) 
    {
        //check if the sum or multiplication of the first two in the array is greater than the third
        if ((x[0] + x[1] > x[2]) || (x[0] * x[1] > x[2]))
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    static bool IsEven(int x) 
    {
        if (x % 2 == 0)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    static bool IsAscending(int[] x)
    {
        if (x[0] <= x[1] && x[1]<= x[2])
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    static bool HasNeighbour(string s) 
    {
        return s[0] == s[1] - 1 || s[0] == s[1] + 1 || s[2] == s[1] - 1 || s[2] == s[1] + 1;
    }

    static string PositiveNegativeOrZero(int x)
    {
        if (x > 0)
        {
            return "Postive";
        }
        else if( x == 0) 
        {
            return "Zero";
        }
        else
        {
            return "Negative";
        }
    }

    static bool IsLeapYear(int x) 
    {
        /*  A Year that is divisible by 4 is a leap year
         * except if it is divisible by 100
         * except if it is divisible by 400         
         */

        if ((x % 4 == 0 && x % 100 != 0) || x % 400 == 0)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    static bool ContainsThree(int x) 
    {
        // See if the integer contains the digit 3 without using inbuilt methods or non int types.
        while (x > 0) 
        {
            if (x % 10 == 3)  //check if the current last digit is three
            {
                return true;
            }

            x /= 10; // remove the lowest digit on the integer
        }

        return false;
    }

static void Main()
    {
        Console.WriteLine(AbsoluteValue(6832));
        Console.WriteLine(AbsoluteValue(-392));
        Console.WriteLine(DivisibleBy2or3(15, 30));
        Console.WriteLine(DivisibleBy2or3(2, 90));
        Console.WriteLine(DivisibleBy2or3(7, 12));
        Console.WriteLine(IsUppercase("xyz"));
        Console.WriteLine(IsUppercase("DOG"));
        Console.WriteLine(IsUppercase("L9#"));
        Console.WriteLine(GreatherThanThird(new int[] { 2, 7, 12 }));
        Console.WriteLine(GreatherThanThird(new int[] { -5, -8, 50 }));
        Console.WriteLine(IsEven(721));
        Console.WriteLine(IsEven(1248));
        Console.WriteLine(IsAscending(new int[] { 3, 7, 10 }));
        Console.WriteLine(IsAscending(new int[] {74, 62, 99}));
        Console.WriteLine(HasNeighbour("ABC"));
        Console.WriteLine(HasNeighbour("GMV"));
        Console.WriteLine(PositiveNegativeOrZero(12));
        Console.WriteLine(PositiveNegativeOrZero(0));
        Console.WriteLine(PositiveNegativeOrZero(-6));
        Console.WriteLine(IsLeapYear(2016));
        Console.WriteLine(IsLeapYear(2018));
        Console.WriteLine(ContainsThree(1234567890));
        Console.WriteLine(ContainsThree(87501));
    }
}