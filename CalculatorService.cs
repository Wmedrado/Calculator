using System;
using Calculator.operation;
using Calculator.Language.Translations;


namespace Calculator.Service
{
    /// <summary>
    /// Classe utilizada para realização das operações aritiméticas básicas.
    /// </summary>
    public class CalculatorService()
    {
        public double Addition(double value1, double value2)
        {
            return value1 + value2;
        }

        // Método para subtração
        public double Subtract(double value1, double value2)
        {
            return value1 - value2;
        }

        // Método para multiplicação
        public double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }

        // Método para divisão
        public double Division(double value1, double value2)
        {
            return value1 / value2;
        }


    }
}