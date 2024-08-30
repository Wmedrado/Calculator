using System;
using System.ComponentModel.DataAnnotations;
using Calculator.Language;


namespace Calculator.Language
{
    public enum ELanguage
    {
        [Display (Name = nameof(Global.English))]
        English = 1,

        [Display (Name = nameof(Global.Espanish))]
        Espanish = 2,

        [Display (Name = nameof(Global.Portuguese))]
        Portuguese = 3,
    }

    public static class LanguageSelector
    {
        public static void SelectLanguage(ELanguage language)
        {
            switch (language)
            {
                case ELanguage.English:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    break;
                case ELanguage.Espanish:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-ES");
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");
                    break;
                case ELanguage.Portuguese:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt-BR");
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");
                    break;
                default:
                    throw new ArgumentException(Global.InvalidLanguage);
            }
        }
    }
}
