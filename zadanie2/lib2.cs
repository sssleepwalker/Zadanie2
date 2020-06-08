using System;
using System.Security.Cryptography;

public class lib2
{
    
    static public string dva(string v)
    {
        string gg = "";
        string[] rus = new string[] {"А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р" ,"С",
                "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я",
        "а", "б", "в", "г", "д", "е", "ё", "ж", "з","и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", 
            "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я"};


        string[] eng = new string[] {"A", "B", "V", "G", "D", "E", "E", "ZH", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S",
                "T","U","F","KH","TS","CH","SH","SHCH",null,"Y",null,"E","YU","YA",
        "a","b","v","g","d","e","e","zh","z","i","y","k","l","m","n","o","p","r","s","t","u","f","kh","ts","ch",
            "sh","shch", null, "y", null, "e","yu","ya"};


        for (int cc = 0; cc < v.Length; cc++)
            for (int zz = 0; zz < rus.Length; zz++)
                if (v.Substring(cc, 1) == rus[zz]) gg = gg + eng[zz];
        return gg;
    }
   
   
}
