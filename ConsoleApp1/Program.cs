using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) 

        {
            string[] kurslar = new string[] {"a","b","c" };
             
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer ");
            
        }
    }
}
