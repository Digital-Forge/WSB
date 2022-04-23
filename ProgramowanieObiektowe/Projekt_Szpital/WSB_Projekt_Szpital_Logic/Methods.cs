using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSB_Projekt_Szpital_Logic
{
    public class Methods
    {
        public static bool CheckPWZ(string number)
        {
            try
            {
                long.Parse(number);
            }
            catch
            {
                return false;
            }

            if (number.Length == 7 && number[0] != '0')
            {
                int buff = 0;

                for (int i = 1; i < 7; i++)
                {
                    buff += int.Parse(number[i].ToString()) * i;
                }

                if (buff % 11 == int.Parse(number[0].ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckPesel(string number)
        {
            try
            {
                long.Parse(number);
            }
            catch
            {
                return false;
            }

            if (number.Length == 11)
            {
                return true;
            }
            return false;
        }
    }
}
