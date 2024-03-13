namespace password_generator;

class Program
{
    static void Main(string[] args)
    {
        
    }

    public static class PasswordGenerator
    {
        private static string Numbers = "0123456789";
        private static string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string Symbols = "!@#$%^&*_-/<>";

        public static string Generate(int passwordLength = 4, bool useUpperCase = false, bool useSymbols = false)
        {
            Random random = new Random();
            string allowedChars = Numbers + UpperCase.ToLower();
            char[] password = new char[passwordLength];

            if (useUpperCase) allowedChars += UpperCase;
            if (useSymbols) allowedChars += Symbols;

            for (int i = 0; i < password.Length; i++)
            {
                password[i] = allowedChars[random.Next(allowedChars.Length - 1)];
            }
            
            return new string(password);
        }
    }
}