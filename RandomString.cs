using System;
namespace PasswordGenerator.Console
{
    class RandomPasswordGenerator
    {
        const string lowerCase = "qwertyuopasdfghjklizxcvbnm";
        const string upperCase = "QWERTYUIOPASDFGHJKLZXCVBNM";
        const string numbers = "0123456789";
        const string specials = "!'^+%&/()=?_.€@~$*-";
        public string GeneratePassword(bool useNumbers, bool useUppercase, bool useLowercase, bool useSpecial,
            int passwordSize)
        {
            char[] _password = new char[passwordSize];
            string charSet = "";
            System.Random _random = new Random();

            if (useLowercase) charSet += lowerCase;
            if (useUppercase) charSet += upperCase;
            if (useNumbers) charSet += numbers;
            if (useSpecial) charSet += specials;
            if (charSet.Length==0) return charSet;

            for (int i = 0; i < passwordSize; i++)
            {
                _password[i] = charSet[_random.Next(charSet.Length - 1)];
            }

            return String.Join(null, _password);
        }
    }
}