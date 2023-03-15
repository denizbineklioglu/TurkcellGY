namespace PasswordControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Bir şifre giriniz: ");
            string password = Console.ReadLine();

            PasswordControl(password);


            Console.ReadKey();
        }

        /// <summary>
        /// Söz diziminin içerisinde sayısal
        /// bir değer olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="password">Söz Dizimi</param>
        /// <returns></returns>
        public static bool IsDigit(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Söz diziminin sadece karakterlerden mi oluştuğunu
        /// kontrol eder. 
        /// </summary>
        /// <param name="password">Söz Dizimi
        /// </param>
        /// <returns></returns>
        public static bool IsLetter(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Söz dizimi içerisinde hem karakter hem de 
        /// sayısal karakterler olup olmadığını kontrol eder. 
        /// </summary>
        /// <param name="password">Söz Dizimi</param>
        /// <returns></returns>
        public static bool IsLetterAndDigit(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        /// Söz diziminin 6 karakterden uzun mu 
        /// kısa mı olduğunu kontrol eder.
        /// </summary>
        /// <param name="password">Söz dizimi</param>
        /// <returns></returns>
        public static bool IsPassword6Character(string password)
        {
            if (password.Length < 6)
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// Söz diziminin içerisinde hem numeric
        /// hem alfa numeric hem de normal karakterlerden olup olmadığını
        /// kontrol eder. 
        /// </summary>
        /// <param name="password">Söz Dizimi</param>
        /// <returns></returns>
        public static bool IsLetterAndDigitAndAlfaNumeric(string password)
        {
            bool letter = false, digit = false, symbol = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c))
                {
                    letter = true;
                }
                else if (char.IsDigit(c))
                {
                    digit = true;
                }
                else
                {
                    symbol = true;
                }
            }
            return letter & digit & symbol;
        }

        public static void PasswordControl(string password)
        {
            if (IsPassword6Character(password))
            {
                if (IsLetter(password) || IsDigit(password))
                {
                    Console.WriteLine("ZAYIF şifre");
                }
                else
                {
                    if (!IsLetterAndDigit(password))
                    {
                        if (IsLetterAndDigitAndAlfaNumeric(password))
                        {
                            Console.WriteLine("GÜÇLÜ şifre");
                        }
                    }
                    else
                    {
                        Console.WriteLine("ORTA şifre.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Şifre 6 karakterden az olamaz!");
            }
        }
    }
}
