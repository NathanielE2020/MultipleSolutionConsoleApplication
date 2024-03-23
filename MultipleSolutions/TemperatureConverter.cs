using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MultipleSolutions
{
    public class TemperatureConverter
    {
        public static void Converter()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO TEMPERATURE CONVERTER\n");

            do
            {
                double temperature;
                Console.Write("Enter a temperature value to convert: ");
                temperature = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Celsuis to Fahrenheit: " + CelsiusToFahrenheit(temperature) + "\u00B0F");
                Console.WriteLine("Fahrenheit to Celsius: " + FahrenheitToCelsius(temperature) + "\u00B0C");
                Console.WriteLine("Celsius to Kelvin: " + CelsiusToKelvin(temperature) + "\u00B0K");
                Console.WriteLine("Kelvin to Celsius: " + KelvinToCelsius(temperature) + "\u00B0C");
                Console.WriteLine("Fahrenheit to Kelvin: " + FahrenheitToKelvin(temperature) + "\u00B0K");
                Console.WriteLine("Kelvin to Fahrenheit: " + KelvinToFahrenheit(temperature) + "\u00B0F");
                Console.WriteLine();

                Console.Write("Do you want to convert another temperature (y/n)? ");
                char input = Convert.ToChar(Console.ReadLine().ToLower());
                if(input != 'y')
                {
                    Console.WriteLine("Exiting the temperature Converter. Goodbye.");
                    break;
                }
                Console.Clear();
            } while (true);
        }

        static double CelsiusToFahrenheit(double temp)
        {
            return (temp * 9.0 / 5.0) + 32.0;
        }

        static double FahrenheitToCelsius(double temp)
        {
            return (temp - 32.0) * (5.0 / 9.0);
        }

        static double CelsiusToKelvin(double temp)
        {
            return (temp + 273.15);
        }

        static double KelvinToCelsius(double temp)
        {
            return (temp + 273.15);
        }

        static double FahrenheitToKelvin(double temp)
        {
            return (5.0 / 9.0) * (temp - 32) + 273.15;
        }

        static double KelvinToFahrenheit(double temp)
        {
            return (9.0 / 5.0) * (temp - 273.15) + 32;
        }
    }
}

