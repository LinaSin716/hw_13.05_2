using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num_4
{
    public class ToRus
    {
        public Dictionary<string, string> MorseToRus = new Dictionary<string, string>()
        {
            { ".-", "а" }, { "-...", "б" }, { ".--", "в" }, { "--.", "г" },
            { "-..", "д" }, { ".", "е" }, { "...-", "ж" }, { "--..", "з" },
            { "..", "и" }, { ".---", "й" }, { "-.-", "к" }, { ".-..", "л" },
            { "--", "м" }, { "-.", "н" }, { "---", "о" }, { ".--.", "п" },
            { ".-.", "р" }, { "...", "с" }, { "-", "т" }, { "..-", "у" },
            { "..-.", "ф" }, { "....", "х" }, { "-.-.", "ц" }, { "---.", "ч" },
            { "----", "ш" }, { "--.-", "щ" }, { "--.--", "ъ" }, { "-.--", "ы" },
            { "-..-", "ь" }, { "..-..", "э" }, { "..--", "ю" }, { ".-.-", "я" },
            { "/", " " }, { " ", "" }, { "", "" }
        };
        public string StrToRus(string str)
        {
            string str_rus = "";
            foreach (string el in str.Split(" "))
            {
                str_rus += MorseToRus[el];
            }
            return str_rus;
        }
    }
}
