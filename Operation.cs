using System;
using Calculator.Language.Translations;
using System.ComponentModel.DataAnnotations;


namespace Calculator.operation
{ 
    public class Operation_Type 
    {
        public enum Operation
        {
            [Display (Name = nameof(Global.Subtraction))]
            Subtraction = 1,

            [Display (Name = nameof(Global.Addition))]
            Addition = 2,

            [Display (Name = nameof(Global.Multiplication))]
            Multiplication = 3,

            [Display (Name = nameof(Global.Division))]
            Division = 4
        }
    }
}