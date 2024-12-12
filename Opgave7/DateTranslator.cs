using System;
using System.Globalization;
namespace Opgave7;

public class DateTranslator
{
    public static string TranslateFraNyhedsbrevFormat(string date)
    {
        DateTime parsedDate = DateTime.ParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture);
        return parsedDate.ToString("dd/MM/yyyy");
    }

    public static string TranslateFraMedlemsregisterFormat(string date)
    {
        var monthNames = new Dictionary<string, string>()
        {
            { "januar", "01" },
            { "februar", "02" },
            { "marts", "03" },
            { "april", "04" },
            { "maj", "05" },
            { "juni", "06" },
            { "juli", "07" },
            { "august", "08" },
            { "september", "09" },
            { "oktober", "10" },
            { "november", "11" },
            { "december", "12" }
        };
        
        string[] parts = date.Split('.');
        if (parts.Length == 3)
        {
            string day = parts[0];
            string monthName = parts[1].ToLower();
            string year = parts[2];

            if (monthNames.ContainsKey(monthName))
            {
                string month = monthNames[monthName];
                return $"{day}/{month}/{year}";
            }
        }
        throw new Exception("Ugyldigt datoformat");
    }
}

