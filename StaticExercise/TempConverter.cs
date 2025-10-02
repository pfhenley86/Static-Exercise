namespace StaticExercise;

public class TempConverter
{
    //Method 1
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32.0) / 1.8;
    }
    
    //Method 2
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9.0/5.0) + 32.0;
    }
}