namespace ConverterTemperatura {
    class ConversorTemperatura{

        public void ParaCelsius (){
            Console.WriteLine("Digite a temperatura em Celsius:");
        double Celsius = double.Parse(Console.ReadLine());
        
        double ParaFahrenheit = ( 9 * Celsius + 160 ) / 5;
        
        Console.WriteLine($"A temperatura convertida em Fahrenheit é {ParaFahrenheit}°F");
        }

        public void ParaFahrenheit (){
            Console.WriteLine("Digite a temperatura em Fahrenheit:");
        double Fahrenheit = double.Parse(Console.ReadLine());
        
        double ParaCelsius = ( Fahrenheit - 32 ) * 5 / 9;
        string PC = ParaCelsius.ToString("F1");
        
        Console.WriteLine($"A temperatura convertida em Celsius é {PC}°C");
        }
    }
}