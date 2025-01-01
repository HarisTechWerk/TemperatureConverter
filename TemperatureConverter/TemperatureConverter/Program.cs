using System;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Professional Temperature Converter!");
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\nChoose a conversion type:");
                Console.WriteLine("1. Celsius to Fahrenheit and Kelvin");
                Console.WriteLine("2. Fahrenheit to Celsius and Kelvin");
                Console.WriteLine("3. Kelvin to Celsius and Fahrenheit");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ConvertFromCelsius();
                        break;
                    case "2":
                        ConvertFromFahrenheit();
                        break;
                    case "3":
                        ConvertFromKelvin();
                        break;
                    case "4":
                        Console.WriteLine("Exiting the Temperature Converter. Goodbye!");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a number between 1 and 4.");
                        break;
                }
            }
        }

        static void ConvertFromCelsius()
        {
            try
            {
                Console.Write("Enter temperature in Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                double kelvin = celsius + 273.15;

                Console.WriteLine($"Fahrenheit: {fahrenheit:F2}°F");
                Console.WriteLine($"Kelvin: {kelvin:F2}K");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }

        static void ConvertFromFahrenheit()
        {
            try
            {
                Console.Write("Enter temperature in Fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit - 32) * 5 / 9;
                double kelvin = celsius + 273.15;

                Console.WriteLine($"Celsius: {celsius:F2}°C");
                Console.WriteLine($"Kelvin: {kelvin:F2}K");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }

        static void ConvertFromKelvin()
        {
            try
            {
                Console.Write("Enter temperature in Kelvin: ");
                double kelvin = Convert.ToDouble(Console.ReadLine());
                if (kelvin < 0)
                {
                    Console.WriteLine("Error: Temperature in Kelvin cannot be negative.");
                    return;
                }

                double celsius = kelvin - 273.15;
                double fahrenheit = (celsius * 9 / 5) + 32;

                Console.WriteLine($"Celsius: {celsius:F2}°C");
                Console.WriteLine($"Fahrenheit: {fahrenheit:F2}°F");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
    }
}
