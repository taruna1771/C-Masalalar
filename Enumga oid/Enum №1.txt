using System;

public class Program
{
    enum Svetofor
    {
       Qizil,
       Sariq,
       Yashil
    }
    static void Main(string[] args)
    {
        Console.Write("Raqam kiriting ");
        int son = Convert.ToInt32(Console.ReadLine());
        Svetofor natija;
        if (son >= 0 && son <= 2)
        {
            natija = (Svetofor)son;
            Console.WriteLine("Svetafor rangi: " + natija);
        }
        else
        {
            Console.WriteLine("Svetaforda yo'q rangni tanladiz.");
        }
        Console.ReadLine();
       

        

    }
}
