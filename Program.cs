using System;

namespace LCuellar_Assign3Task2_Section3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Presented by Liz");

            double pA=0, pB=0;
            double rA=0, rB=0;
            int years;
            
            while(pA >= pB)
            {
                Console.Clear();
                Console.Write("population of A: ");
                pA = double.Parse(Console.ReadLine());

                Console.Write("population of B: ");
                pB = double.Parse(Console.ReadLine());

                if(pA>= pB)
                {
                    Console.WriteLine("population of A must be less than population of B");
                    Console.WriteLine("Press any key to try again...");
                    Console.ReadKey();
                }
            }
            
            while(rB >= rA)
            {
                Console.Clear();
                Console.Write("growth rate of A: ");
                rA = double.Parse(Console.ReadLine());

                Console.Write("growth rate of B: ");
                rB = double.Parse(Console.ReadLine());

                if (rB >= rA)
                {
                    Console.WriteLine("the growth rate of A must be greater than the growth rate of B");
                    Console.WriteLine("Press any key to try again...");
                    Console.ReadKey();
                }
            }
            

            years = YearsForecast(pA, rA, pB, rB);
            Console.Clear();
            Console.WriteLine("Population of A: " + pA + "  growth rate of A:" + rA );
            Console.WriteLine("Population of B: " + pB + "  growth rate of B:" + rB);
            Console.WriteLine("Manteniendo las tasas de crecimiento, la población A será igual o mayor que " +
                "la población B en " + years + " years");
            Console.ReadKey();
  
        }

        static int YearsForecast(double pA, double tA, double pB, double tB)
        {
            int countYears = 0;
           
            while(pA < pB)
            {
                pA = ((pA*tA)/100) + pA;
                pB = ((pB * tB) / 100) + pB;
                countYears++;

                Console.WriteLine("Año " + countYears);
                Console.WriteLine("pA: " + pA);
                Console.WriteLine("pB: " + pB + "\n");
                Console.WriteLine("Presione una tecla para imprimir resumen");
                

            }
            Console.ReadKey();
            return countYears;
        }
    }
}
