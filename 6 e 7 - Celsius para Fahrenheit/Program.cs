using System;

namespace ConverterTemperatura {
    class Program {
        static void Main (){
            
            try {
                int fim = 0;                
                ConversorTemperatura conversor = new ConversorTemperatura ();

                do {

                    Console.WriteLine("\nProgramar para converter temperaturas. ( 1 - Celsius para Fahrenheit, 2 - Fahrenheit para Celsius )");
                    double converterPara = double.Parse(Console.ReadLine());

                    if (converterPara == 1){
                        conversor.ParaCelsius();
                    }else if (converterPara == 2){
                        conversor.ParaFahrenheit();
                    }else {
                        Console.WriteLine("\nComando não identificado!\n");
                    }

                    Console.WriteLine("\nFinalizar aplicação? (0 - Não, 1 - Sim)");
                    do {
                        Console.WriteLine("Finalizar aplicação? (0 - Não, 1 - Sim)");
                        fim = int.Parse(Console.ReadLine());
                    }while (fim < 0 || fim > 1); // Força para que sai do loop

                }while (fim == 0);
            }
            catch (Exception e) {
                Console.WriteLine($"Error: {e.Message}");
            }
            
        }
    }
}


