using System;
using System.Globalization;

class Program {
  static void Main (){
      
      Console.WriteLine("\nCalcular volume de lata de óleo\n");
      
      Console.Write("Digite o Raio: ");
      double R = double.Parse(Console.ReadLine());
      
      Console.Write("Digite a Altura: ");
      double A = double.Parse(Console.ReadLine());
      
      double resultado = 3.14159 * R * R * A;
      
      Console.WriteLine($"\nO valor do volume de uma lata de óleo é {resultado.ToString("F2", CultureInfo.InvariantCulture)}.\n");
  }
}



