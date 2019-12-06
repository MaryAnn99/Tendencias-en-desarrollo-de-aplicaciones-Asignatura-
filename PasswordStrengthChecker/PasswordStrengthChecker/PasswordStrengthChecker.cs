using System;

namespace PasswordStrengthChecker
{
    public class PasswordStrengthChecker
    {
        public static string Checker(string input)
        {
            int sz = input.Length;
            if(sz == 0)
            {
                return "El password es débil (weak). La entrada está vacía";
            }
            if(sz < 7)
            {
                return "El password es debil (weak)";
            }
            bool flag_digit = false, flag_char = false;
            for(int i = 0; i < sz; i++)
            {
                if((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z'))
                {
                    flag_char = true;
                }
                if (input[i] >= 48 && input[i] <= 57)
                {
                    flag_digit = true;
                }
            }
            if(!flag_digit || !flag_char)
            {
                return "El password es debil (weak)";
            }
            return "El password es fuerte (strong)";
        }
    }
}
