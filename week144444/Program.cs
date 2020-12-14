using System;

namespace week144444
{
    class Program
    {
        static void Main(string[] args)
        {
            int angka = 123;
            string angka2 = angka.ToString();
            string nama = "aldi";
            string nama2 = nama + "mahotma";
            string nama3 = string.Concat(nama, nama2, angka2);
            string nama4 = nama3.Substring(3, 5);
            Console.WriteLine(nama4[1]);
        }
        
    }
}
