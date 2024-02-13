using System;

public class Program
{
    enum Signal
    {
        Past,
        Orta,
        Yuqori,
    }
    static void Main(string[] args)
    {
        Signal y;
        Console.Write("son kiritng: ");
        string txt = Console.ReadLine(); //1234
        char k;
        int d = 0;
        for (int i = 0; i < txt.Length; i++)
        {

            if (char.IsDigit(txt[i]))
            {
                d = Convert.ToInt32(txt[i] - 48);
                y = (Signal)d;
                Console.Write(y + ", ");
            }
        }
        Console.ReadKey();


    }
}
