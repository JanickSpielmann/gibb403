using System;


    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Aufgabe9_5());  
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
    }



