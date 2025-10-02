namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //Convert Celsius To Fahrenheit
            var temp1 = 30;
            var tempConversionOne = TempConverter.CelsiusToFahrenheit(temp1);
            Console.WriteLine($"{temp1} Celsius = {tempConversionOne} Fahrenheit");
            
            //Convert Fahrenheit To Celsius
            var temp2 = 110;
            var tempConversionTwo = TempConverter.FahrenheitToCelsius(temp2);
            Console.WriteLine($"{temp2} Fahrenheit = {tempConversionTwo} Celsius");

        }
    }
}
