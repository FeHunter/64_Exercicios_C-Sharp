using System;

namespace ProgramarComissao{
  class Pecas {
      public int IdPeca {get; set;}
      public int IdVendedor {get; set;}
      public double PrecoPorPeca {get; set;}
      public int QuantidadeVendida {get; set;}

      private double _valorTotal;
      private double _porcentagem;

      public Pecas (int idP, int idV, double precoPorPeca, int quantidadeVendida){
        IdPeca = idP;
        IdVendedor = idV;
        PrecoPorPeca = precoPorPeca;
        QuantidadeVendida = quantidadeVendida;
      }
      
      public double CalcularComissao (){
          _valorTotal = PrecoPorPeca * QuantidadeVendida;
          _porcentagem = 5 * (_valorTotal / 100);
          return _valorTotal + _porcentagem;
      }
  }
  
}
