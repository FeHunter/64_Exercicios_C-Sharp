using System;
using System.Globalization;

namespace Programa {
    class Program{
        static void Main (){
        
            const double ANO = 365;
            const double MES = 30;
              
            Console.Write("\nAno de Nascimento: ");
            double ano = double.Parse(Console.ReadLine());
              
            Console.Write("Mês de Nascimento: ");
            double mes = double.Parse(Console.ReadLine());
              
            Console.Write("Dia do Nascimento: ");
            double dias = double.Parse(Console.ReadLine());
              
            dias += ( ano * ANO ) + ( mes * MES );
              
            Console.WriteLine($"\nSua idade em dias é {dias.ToString(CultureInfo.CreateSpecificCulture("pt-BR"))}\n");
        }
    }
}
