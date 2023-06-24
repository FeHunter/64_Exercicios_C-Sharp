using System;
class Program{
  static void Main (){
      
      Console.WriteLine("Digite o 1° número");
      int n1 = int.Parse(Console.ReadLine());
      
      Console.WriteLine("Digite o 2° número");
      int n2 = int.Parse(Console.ReadLine());
      
      
      // Igual e Não Igual
      if (n1 == n2){
          Console.WriteLine($"O N° {n1} é Igual ao N° {n2}");
      }else {
          Console.WriteLine($"O N° {n1} é diferente N° {n2}");
      }
      
      // Maior e Menor
      if (n1 > n2){
          Console.WriteLine($"O N° {n1} e maior que o N° {n2}");
      }else {
          Console.WriteLine($"O N° {n1} e menor que o N° {n2}");
      }
      
       // Maior ou Igual e Menor ou Igual
      if (n1 >= n2){
          Console.WriteLine($"O N° {n1} e maior ou igual que o N° {n2}");
      }else {
          Console.WriteLine($"O N° {n1} e menor ou igual que o N° {n2}");
      }
  }
}

