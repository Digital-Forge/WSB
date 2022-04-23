using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SystemOfBookHotel.Application.Extension
{
    public static class StringStripHTML
    {
        public static string StripHTML(this string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }
    }
}
