using System;

namespace BlazorAutoCotacao.Helpers
{
    public static class TextHelpers
    {
        public static string Capitalize(string? input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input ?? string.Empty;
            input = input.Trim();
            return char.ToUpper(input[0]) + (input.Length > 1 ? input.Substring(1) : string.Empty);
        }

        public static string ToLocalString(DateTime dateTime, string format = "dd/MM/yyyy HH:mm")
        {
            return dateTime.ToLocalTime().ToString(format);
        }

        public static string ToLocalString(DateTime? dateTime, string format = "dd/MM/yyyy HH:mm")
        {
            return dateTime.HasValue ? dateTime.Value.ToLocalTime().ToString(format) : string.Empty;
        }

        public static string ToCurrency(decimal amount, string culture = "pt-BR")
        {
            try
            {
                var ci = new System.Globalization.CultureInfo(culture);
                // Some runtimes (e.g. trimmed/globalization-limited Blazor WASM) may show the ISO code ("BRL").
                // Format the number using the culture's number format and prefix with the explicit "R$" symbol.
                var formatted = amount.ToString("N2", ci);
                if (amount < 0)
                {
                    // Ensure negative values render like "-R$ 1.234,56"
                    return "-R$ " + decimal.Negate(amount).ToString("N2", ci);
                }
                return "R$ " + formatted;
            }
            catch
            {
                // Fallback: simple numeric with 2 decimals prefixed by R$
                return "R$ " + amount.ToString("N2");
            }
        }
    }
}
