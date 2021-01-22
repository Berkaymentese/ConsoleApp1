using System;

namespace classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();
            kurs1.Kursadi = "c#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.Izlenmeorani = 68;

            kurs kurs2 = new kurs();
            kurs2.Kursadi = "phyton";
            kurs2.Egitmen = "Berkay";
            kurs2.Izlenmeorani = 84;

            kurs kurs3 = new kurs();
            kurs3.Kursadi = "css";
            kurs3.Egitmen = "ahmet";
            kurs3.Izlenmeorani = 48;

            //Console.WriteLine(kurs1.Kursadi +" : "+kurs1.Egitmen);

            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Kursadi + " : " + kurs.Egitmen);
            }
        }
    }

    class kurs
    {
        public string Kursadi { get; set; }
        public string Egitmen{ get; set; }
        public int Izlenmeorani { get; set; }
    }
}
