using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace TP2
{
    class part2
    {
        public void Conversion(int? celcius)
        {
            double fahrenheit = (double)celcius * 9 / 5 + 32;
            double kelvin = (double)celcius + 273.15;

            Console.WriteLine();
            Console.WriteLine($"Temperatura em Celcius: {celcius:F0} \n" +
                              $"Temperatura em Fahrenheit: {fahrenheit:F0} \n" +
                              $"Temperatura em Kelvin: {kelvin:F0} ");
        }

        public void BMICalculation(int CWeight, double CHeight)
        { 
            double BMI = CWeight / Math.Pow(CHeight, 2);

            string result = BMI switch
            {
                < 18.5 => "Abaixo do peso",
                >= 18.5 and <= 24.9 => "Peso normal",
                >= 25 and <= 29.9 => "Sobrepeso",
                >= 30 and <= 34.9 => "Obesidade Grau I",
                >= 35 and <= 39.9 => "Obesidade Grau II",
                >= 40 => "Obesidade Mórbida",
                _ => "Fora do Intervalo",
            };

            Console.WriteLine($" IMC: {BMI:F2} \n " +
                              $"Indica: {result}");
        }
    }
}
