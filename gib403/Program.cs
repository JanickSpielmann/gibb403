using System;
using System.IO.Enumeration;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine(Aufgabe9_5());
        Aufgabe9_6();
    }

    public static int Aufgabe9_5()
    {
        Console.WriteLine("Geben Sie nun die erste Zahl ein");
        int zahl1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Geben Sie nun die zweite Zahl ein");
        int zahl2 = Convert.ToInt32(Console.ReadLine());

        if (zahl1 < zahl2)
        {
            int i = zahl2;
            zahl2 = zahl1;
            zahl1 = i;
        }

        while (zahl2 != 0)
        {
            int rest = zahl1 % zahl2;
            zahl1 = zahl2;
            zahl2 = rest;
        }

        Console.Write("Der ggt ist: ");
        return zahl1;
    }

    public static void Aufgabe9_6()
    {
        Console.WriteLine("Mit diesem Programm können Sie Kopfrechnen üben \n" +
                          "Möglich sind Multiplikationen der Zahlen 2-12\n" +
                          "Um das Programm zu Beenden geben Sie die Zahl 9999 ein.\n" +
                          "Geben Sie nun die Zahlenreihe ein,die Sie üben möchten: ");
        char fertig = ' ';
        int eingabe = 0;
        Random random = new Random();
        int zahl = random.Next(2, 12);

        do
        {
            if (fertig == 'j')
            {
                Console.Write("GebenSie die neue Reihe ein: ");
                eingabe = 0;
            }

            int zahlenreihe = Convert.ToInt32(Console.ReadLine());


            while (eingabe != 9999)
            {
                Console.WriteLine(zahl + " * " + zahlenreihe);

                eingabe = Convert.ToInt32(Console.ReadLine());

                if (eingabe == 9999)
                {
                }
                else
                {
                    if (eingabe != (zahl * zahlenreihe))
                    {
                        Console.WriteLine("Falsch!");
                    }
                    else
                    {
                        zahl = random.Next(2, 12);
                    }
                }
            }


            Console.WriteLine("Möchten Sie eine andere Zahlenreihe trainieren <j/n>?");
            fertig = Convert.ToChar(Console.ReadLine());
        } while (fertig != 'n');

        return;
    }
}