using System;
using Calculator.Language;
using Calculator.operation;


namespace Calculator
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine($"{Global.SelectLanguage}: ");
            Console.WriteLine($"1 - {Global.English}");
            Console.WriteLine($"2 - {Global.Espanish}");
            Console.WriteLine($"3 - {Global.Portuguese}");
            Console.Write($"{Global.Select}: ");
            int language = int.Parse(Console.ReadLine());
            ELanguage selectedLanguage = (ELanguage)language;

            LanguageSelector.SelectLanguage(selectedLanguage);

            Console.WriteLine("=======================================");
            Console.WriteLine($"              {Global.CalculatorName}              ");
            Console.WriteLine(Global.Welcome);
            Console.WriteLine("=======================================\n");

            Console.WriteLine(Global.SelectOperationType);
            Console.WriteLine($"1 - {Global.Addition}");
            Console.WriteLine($"2 - {Global.Subtration}");
            Console.WriteLine($"3 - {Global.Multiplication}");
            Console.WriteLine($"4 - {Global.Division}");
            Console.Write($"{Global.Response}: ");
            int operation = int.Parse(Console.ReadLine());

            //Conversão do número da operação para o enum
            var operationType = (Operation_Type.Operation)operation;

            Console.WriteLine($"Você selecionou {operationType}");

            Console.WriteLine("Primeiro valor: ");
            long value1 = long.Parse(Console.ReadLine());

            Console.WriteLine("Primeiro valor: ");
            long value2 = long.Parse(Console.ReadLine());


            Console.WriteLine(value1);
            Console.WriteLine(value2);

        }
    }
}