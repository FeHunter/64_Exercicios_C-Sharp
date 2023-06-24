using System;
class HelloWorld{
  static void Main (){
      
      try {
        int[] numero = new int[4];
        int[] somas = new int[4];
        int[] multi = new int[4];
        char[] letra = new char[4] {'A', 'B', 'C', 'D'};

        for (int i=0; i < 4; i++){
            Console.Write($"Digite o {i+1}° número para {letra[i]}: ");
            numero[i] = int.Parse(Console.ReadLine());
        }

        for (int i=0; i < 4; i++){
            Console.WriteLine($"\nResultados de ( {letra[i]} ):");
            for (int j=0; j < 4; j++){
                somas[i] = ( numero[i] + numero[j] );
                multi[i] = ( numero[i] * numero[j] );
                Console.WriteLine($"Soma {letra[i]} + {letra[j]} = {somas[i]}");
                Console.WriteLine($"Multi {letra[i]} x {letra[j]} = {multi[i]}");
                Console.WriteLine("........");
            }
        }
      }
      catch (Exception e){
        Console.WriteLine($"Error: {e.Message}");
      }
  }
}


