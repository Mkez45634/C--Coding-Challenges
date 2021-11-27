class Program 
{
    static void TimesTable() 
    {
        //when called prints the 1 - 10 times table, for the first 10 muliplications
        for (int i = 1; i <= 10; i++) 
        {
            for (int j = 1; j <= 10; j++) 
            {
                Console.Write($" {i * j}");
            }
            Console.Write("\n");
        }
    }

    static double FractionsSum(int x) 
    {
        double result = 0;
        for (int i = 1; i<=x; i++) 
        {
            result += (1 / (double)(i * i));
        }
        return result;
    }

    static int[] ArraySort(int[] x) 
    {
        int length = x.Length;
        for (int i = 1; i < length; i++) 
        {
            int temp = x[i];
            int j = i - 1;

            while (j>=0 && x[j] > temp) 
            {
                x[j + 1] = x[j];
                j = j - 1;
            }

            x[j + 1] = temp;
        }

        return x;  
    }

    static int BiggestNum(int[] x) 
    {
        x = ArraySort(x);
        return x[x.Length - 1];
    }

    static int Sevens(int[] x)
    {
        int SevensCount = 0;

        for (int i = 0; i < x.Length - 1; i++) 
        {
            if ( x[i] == 7  && x[i+1] == 7) 
            {
                SevensCount++;
            }
        }

        return SevensCount;
    }

    static bool ThreeAdjacent(int[] x) 
    {
        bool Flag = false;

        for (int i = 1; i < x.Length - 2; i++) 
        {
            if (x[i-1] + 1 == x[i] && x[i] == x[i+1] -1) 
            {
                Flag = true;
            }
        }

        return Flag;
    }

    static string Evens() 
    {
        string s = "";

        for (int i = 1; i < 100; i++) 
        {
            if ( i % 2 == 0)  //it is even
            {
                s += i + " ";
            }
        }

        return s;
    }

    static void Main() 
    {
        TimesTable();
        Console.WriteLine(FractionsSum(3));
        Console.WriteLine(FractionsSum(5));
        Array.ForEach(ArraySort(new int[] { 9, 5, 7, 2, 1, 8 }), Console.Write);
        Console.WriteLine();
        Console.WriteLine(BiggestNum(new int[] { 9, 5, 7, 2, 1, 8 }));
        Console.WriteLine(BiggestNum(new int[] { -34, -54, -7, -40, -123, -99 }));
        Console.WriteLine(Sevens(new int[] { 7, 7, 8, 4, 3, 7, 2, 1, 0, 7 }));
        Console.WriteLine(Sevens(new int[] { 4, 7, 8, 2, 0, 5, 2, 7, 5, 8 }));
        Console.WriteLine(Sevens(new int[] { 7, 7, 7, 0, 2, 6, 4, 8, 6, 5, 2, 7, 7 }));
        Console.WriteLine(ThreeAdjacent(new int[] { 7, 8, 9, 2, 4, 5, 0 }));
        Console.WriteLine(ThreeAdjacent(new int[] { -9, 0, -1, -6, -5, -4, -8, 0 }));
        Console.WriteLine(ThreeAdjacent(new int[] { 15, 17, 14, 11, 18, 19, 16, 16 }));
        Console.WriteLine(Evens());
    }
}
