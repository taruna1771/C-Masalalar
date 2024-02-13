using System;

public class Program
{
    enum Burj
    {
        Maymun,
        Tovuq,
        It,
        Tongiz,
        Sichqon,
        Sigir,
        Yolbars,
        Quyon,
        Baliq,
        Ilon,
        Ot,
        Qoy
    }
    static void Main(string[] args)
    {
        Console.Write("Yil kiriting: ");
        int yil = Convert.ToInt32(Console.ReadLine());

        Burj natija = (Burj)(yil % 12);
        Console.WriteLine("Siz tanlagan " + yil + " yil " + natija + " yili");

        Console.ReadKey();
    }
}
