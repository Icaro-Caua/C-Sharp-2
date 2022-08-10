using Sistema_2;
using System;


namespace Sistem_2 {
    class Program {
        static void Main(string[] args) {

            Pessoas x, y;

            x = new Pessoas();
            y = new Pessoas();


            //Pessoa 1
            Console.WriteLine("Dados da primeiroa pessoa:");
            Console.WriteLine("Nome:");
            x.A = Console.ReadLine();

            Console.WriteLine("Idade:");
            x.B = double.Parse(Console.ReadLine());

            //Pessoa 2
            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome:");
            y.A = (Console.ReadLine());

            Console.WriteLine("Idade:");
            y.B = double.Parse(Console.ReadLine());
            

            if (x.B > y.B) {
                System.Console.WriteLine(x.A);
            }
            else {
                System.Console.WriteLine(y.A);
            }

        }
    }
}
