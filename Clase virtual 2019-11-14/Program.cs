using System;

namespace Clase_virtual_2019_11_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            password = Console.ReadLine();
            int password_sz = password.Length;
            bool Length_check = false, char_check = false, digit_check = false;
            for(int i = 0; i < password_sz; i++){
                if(password[i] >= 48 && password[i] <= 57){
                    digit_check = true;
                }
                if((password[i] >= 97 && password[i] <= 122) || (password[i] >= 65 && password[i] <= 90)){
                    char_check = true;
                }
            }
            if(password_sz >= 7)
            {
                Length_check = true;
            }
            if(Length_check == true && char_check == true && digit_check == true){
                Console.WriteLine("El password es fuerte (strong).");
            }else{
                Console.WriteLine("El password es débil (weak).");
            }
        }
    }
}
