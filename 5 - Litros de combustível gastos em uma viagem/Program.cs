using System;
using System.Globalization;

class Program{
  static void Main (){
      
      try {
        Console.WriteLine("\n** Calcular litros gastos em uma viagem **\n");

        Console.WriteLine("Qual a duração da viagem?\nDigite no formato horas:minutos. Ex: 01:20 'Uma hora e vine minutos'.");
        string getTempo = Console.ReadLine();
        string[] formatarTempo = getTempo.Split(":");
        TimeSpan tempo = new TimeSpan(int.Parse(formatarTempo[0]), int.Parse(formatarTempo[1]), 0);
        double tempoCal = tempo.Hours + tempo.Minutes;
        
        Console.WriteLine("\nQual a velocidade média em KM/H durante a viagem?");
        double velocidade = double.Parse(Console.ReadLine());
        
        double distancia = tempoCal * velocidade;
        double litrosUsados = distancia / 12;
        
        Console.WriteLine("\nResultados:");
        Console.WriteLine($"\nVelocidade Média: {velocidade} Km/h \nTempo Média: {tempo} \nDistância Percorrida: {distancia} KM \nLitros Gastos: {litrosUsados.ToString("F2", CultureInfo.InvariantCulture)} L\n");
      }
      catch (Exception e){
        Console.WriteLine($"Error: {e.Message}");
      }
  }
}

