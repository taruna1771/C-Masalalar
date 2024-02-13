using System;

public class Program
{
    enum Hafta
    {
        Dushanba = 1,
        Seshanba,
        Chorshanba,
        Payshanba,
        Juma,
        Shanba,
        Yakshanba
    }
    static void Main(string[] args)
    {
        Console.Write("Kun kiriting ");
        int kun = Convert.ToInt32(Console.ReadLine());

        Hafta otgan_kun;
        Hafta bugingi_kun;
        Hafta kelasi_kun;

        if (kun >= 0 && kun <= 7)
        {
            bugingi_kun = (Hafta)kun;
            kun--;
            if (kun <= 0) { kun = 7; }
            otgan_kun = (Hafta)kun;
            kun += 2; //kun=kun+2 degani;
            if (kun > 7) { kun = kun - 7; }
            kelasi_kun = (Hafta)kun;
            Console.WriteLine("O'tgan kun: " + otgan_kun);
            Console.WriteLine("Tanlangan kun: " + bugingi_kun);
            Console.WriteLine("Kelasi kun: " + kelasi_kun);
        }
        else
        {
            Console.WriteLine("Siz Hafta kuniga mos kun tanlamadiz!");
        }
        Console.ReadLine();




    }
}
