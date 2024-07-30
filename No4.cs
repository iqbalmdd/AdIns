using System;

public class No4 {
    public void Star(int angka) {
        int k = 1;
        Console.WriteLine("=======");
        Console.WriteLine("No.4");
        for (int i = 0; i < angka; i++)
        {
            for (int j = 0; j < k; j++)
            {
                Console.Write("*") ;
            }
            k += 2 ;
            Console.WriteLine();
        }
        Console.WriteLine("=======");
    }
}