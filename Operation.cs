using System;
using Calculator.Language;
using System.ComponentModel.DataAnnotations;


namespace Calculator.operation
{ 
    public class Operation_Type 
    {
        public enum Operation
        {
            [Display (Name = nameof(Global.Subtration))]
            Subtracao = 1,

            [Display (Name = nameof(Global.Addition))]
            Adicao = 2,

            [Display (Name = nameof(Global.Division))]
            Divisão = 3,

            [Display (Name = nameof(Global.Multiplication))]
            Multiplicacao = 4
        }
    }
}