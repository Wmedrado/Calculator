using System;
using System.Globalization;
using Calculator.Language;
using Calculator.operation;
using Calculator.Language.Translations;
using Calculator.Service;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Language Selection

            Console.WriteLine($"{Global.SelectLanguage}: ");
            Console.WriteLine($"1 - {Global.English}");
            Console.WriteLine($"2 - {Global.Spanish}");
            Console.WriteLine($"3 - {Global.Portuguese}");
            Console.Write($"\n{Global.Select}: ");

            int language = int.Parse(Console.ReadLine());

            if (language == 1 || language == 2 || language == 3)
            {
                ELanguage selectedLanguage = (ELanguage)language;
                LanguageSelector.SelectLanguage(selectedLanguage);
                Console.Clear();

                Console.WriteLine($"{Global.SelectedLanguage}: \n\n{EnumHelper.GetDisplayName(selectedLanguage)}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(Global.InvalidLanguage);
                Console.ReadLine();
                return;
            }
            #endregion

            #region Operation Type Selection

            Console.Clear();
            Console.WriteLine("===========================================================");
            Console.WriteLine($"                        {Global.CalculatorName}                        ");
            Console.WriteLine($"         {Global.Welcome}     ");
            Console.WriteLine("===========================================================\n");
            Console.WriteLine(Global.SelectOperationType);
            Console.WriteLine($"\n" +
                $"1 - {Global.Addition} \n" +
                $"2 - {Global.Subtraction} \n" +
                $"3 - {Global.Multiplication} \n" +
                $"4 - {Global.Division} \n");
            Console.Write($"{Global.Response}: ");
            int operation = int.Parse(Console.ReadLine());

            if (!Enum.IsDefined(typeof(Operation_Type.Operation), operation))
            {
                Console.WriteLine(Global.InvalidOperation);
                return;
            }

            var operationType = (Operation_Type.Operation)operation;
            Console.Clear();

            Console.WriteLine($"{Global.EnterTheValue} 1: ");
            double value1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Global.EnterTheValue} 2: ");
            double value2 = double.Parse(Console.ReadLine());

            CalculatorService calculatorService = new CalculatorService();
            double result = 0;

            if (value1 != 0 && value2 != 0)
            {
                switch (operationType)
                {
                    case Operation_Type.Operation.Addition:
                        result = calculatorService.Addition(value1, value2);
                        break;
                    case Operation_Type.Operation.Subtraction:
                        result = calculatorService.Subtract(value1, value2);
                        break;
                    case Operation_Type.Operation.Multiplication:
                        result = calculatorService.Multiply(value1, value2);
                        break;
                    case Operation_Type.Operation.Division:
                        result = calculatorService.Division(value1, value2);
                        break;
                }

                Console.WriteLine($"{Global.TheResultOf} {result}");
            }
            else 
            { 
                Console.WriteLine(Global.InvalidOperation + Global.ZeroValue); return; 
            }
            #endregion
        }
    }
}
