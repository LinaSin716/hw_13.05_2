using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num_3
{
    public class ToMorse
    {
        public Dictionary<string, string> RusToMorse = new Dictionary<string, string>()
        {
            { "а", ".-" }, { "б", "-..." }, { "в", ".--" }, { "г", "--." },
            { "д", "-.." }, { "е", "." }, { "ж", "...-" }, { "з", "--.." },
            { "и", ".." }, { "й", ".---" }, { "к", "-.-" }, { "л", ".-.." },
            { "м", "--" }, { "н", "-." }, { "о", "---" }, { "п", ".--." },
            { "р", ".-." }, { "с", "..." }, { "т", "-" }, { "у", "..-" },
            { "ф", "..-." }, { "х", "...." }, { "ц", "-.-." }, { "ч", "---." },
            { "ш", "----" }, { "щ", "--.-" }, { "ъ", "--.--" }, { "ы", "-.--" },
            { "ь", "-..-" }, { "э", "..-.." }, { "ю", "..--" }, { "я", ".-.-" },
            { " ", "/" }
        };
        public string StrToMorse(string str)
        {
            str = str.ToLower();
            string str_morse = "";
            foreach (char el in str)
            {
                str_morse += RusToMorse[el.ToString()] + " ";
            }
            return str_morse;
        }
    }
}
