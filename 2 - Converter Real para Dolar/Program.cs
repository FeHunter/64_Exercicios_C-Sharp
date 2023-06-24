using System;
using System.Globalization;

class Program {
  static void Main() {

      try {
        Console.WriteLine("Qual a cotação atual do dolar?");
        double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("pt-BR"));
        
        Console.WriteLine("Quantos dolares você tem?");
        double valorEmDolares = double.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("pt-Brc"));
        
        double conversao = (valorEmDolares * cotacaoDolar);
        
        Console.WriteLine($"Você tem {conversao.ToString("F2", CultureInfo.CreateSpecificCulture("pt-BR"))} em reais.");

      }catch (Exception e){
        Console.WriteLine($"Erro: {e.Message}");
      }
  }
}

