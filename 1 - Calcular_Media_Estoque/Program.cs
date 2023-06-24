using System;
using System.Globalization;

namespace Exercicios {
    class Program {
        static void Main (){
                        
            try {
                Console.WriteLine("Quantidade Maxima:");
                int _qMaxima = int.Parse(Console.ReadLine());
                
                
                Console.WriteLine("Quantidade Minima");
                int _qMinima = int.Parse(Console.ReadLine());
                
                int _media = (_qMaxima + _qMinima) / 2;
                
                Console.WriteLine("A Media do estoque é " + _media);
            }
            catch (Exception e){
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }
}
