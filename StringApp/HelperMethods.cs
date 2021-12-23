using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp
{
    public class HelperMethods
    {
        public static string Ozetle(string str, int maxKarakter = 30)
        {
            if (maxKarakter > str.Length)
                return str;

            var kelimeler = str.Split(' ');
            var toplamkarakter = 0;
            var ozetkelimeler = new List<string>();

            foreach (var kelime in kelimeler)
            {
                ozetkelimeler.Add(kelime);
                toplamkarakter += kelime.Length;
                if (toplamkarakter > maxKarakter)
                    break;

            }
            return string.Join(" ", ozetkelimeler) + "...";

        }
    }
}
