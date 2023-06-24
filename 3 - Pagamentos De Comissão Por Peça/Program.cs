using System;
using System.Globalization;
using ProgramarComissao;


namespace ProgramarComissao{
  class Program {
    static void Main (){
        
        try {
            Console.WriteLine("ID do vendedor:");
            int IdVendedor = int.Parse(Console.ReadLine());
            
            Console.WriteLine("ID da peça:");
            int IdPeca = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Preço por unidade:");
            double PrecoPorPeca = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Quantidade de peças vendidas:");
            int QuantidadeVendida = int.Parse(Console.ReadLine());

            Pecas peca = new Pecas(IdPeca, IdVendedor, PrecoPorPeca, QuantidadeVendida);
            
            Console.WriteLine($"\nO valor que o funcionário vai receber com a comissão de 5% é ${peca.CalcularComissao().ToString("F2", CultureInfo.InstalledUICulture)}");

        }catch (Exception e){
            Console.WriteLine($"Error: {e.Message}");
        }
        
    }
  }
}
