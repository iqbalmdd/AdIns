using System;

public class No5 {
    public void Decimal(int angka, int devider) {

        Console.WriteLine("=======");
        Console.WriteLine("No.5");

        float hasilKoma = angka/(float)Math.Pow(10, devider - 1);
        Console.WriteLine("Hasil Pembagian: " + hasilKoma);

        string hasilTanpaKoma = "";
        int panjang = devider - angka.ToString().Length;;
        for (int i = 0; i < panjang; i++)
        {
            hasilTanpaKoma += "0" ;
        }

        Console.WriteLine("Hasil Tanpa Koma: " + hasilTanpaKoma + angka);

        Console.WriteLine("=======");
    }
}