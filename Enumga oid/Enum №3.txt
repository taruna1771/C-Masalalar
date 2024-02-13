using System;

public class Program
{
    enum Yonalish
    {
        Shimol,
        Janub,
        Sharq,
        Garb
    }
    static void Main(string[] args)
    {
        Yonalish y;
        Console.Write("son kiritng: ");
        string txt = Console.ReadLine(); //1234
        char k;
        int d = 0;
        for (int i = 0; i < txt.Length; i++)
        {

            if (char.IsDigit(txt[i]))
            {
                d = Convert.ToInt32(txt[i] - 48);
                y = (Yonalish)d;
                Console.Write(y + ", ");
            }
        }
        Console.ReadKey();


    }
}
