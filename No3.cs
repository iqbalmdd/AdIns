using System;

public class No3 {
    public void Fibbonaci(int angka) {
        int a = 1, b = 1, c;

        Console.WriteLine("=======");
        Console.WriteLine("No.3");

        Console.Write("Fibonacci series: ");
        for (int i = 0; a <= angka; i++) {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
        Console.WriteLine();
        Console.WriteLine("=======");
    }
}