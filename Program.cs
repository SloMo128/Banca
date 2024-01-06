using System;

namespace Banca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 0;
            double newSaldo = 0;
            sbyte selezione = 0;

            Console.WriteLine("Benvenuto in banca");
            do
            {
                Console.WriteLine("Il tuo saldo è di: " + saldo + " EUR");
                Console.Write("Scegli un operazione: " +
                    "\n1) Aggiungi fondo." +
                    "\n2) Togli fondo." +
                    "\n3) Esci.\n");
                selezione = Convert.ToSByte(Console.ReadLine()); ;

                switch (selezione)
                {
                    case 1:
                        Console.WriteLine("Di quanto vuoi aggiungere: ");
                        newSaldo = Convert.ToDouble(Console.ReadLine());
                        saldo = saldo + newSaldo;
                        break;

                    case 2:
                        Console.WriteLine("Di quanto vuoi togliere: ");
                        newSaldo = Convert.ToDouble(Console.ReadLine());

                        if (saldo >= newSaldo)
                            saldo = saldo - newSaldo;
                        else
                            Console.WriteLine("Fondo insufficiente");
                        break;
                }
                Console.WriteLine("\n");
            } while (selezione < 3);

            Console.WriteLine("Sei uscito");

            Console.Read();

        }
    }
}
