using NBitcoin;
using System;
using System.Security;

namespace WasabiEncryptedSecretTester
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Please provide exactly 2 arguments. Example: dotnet run \"6PYSeErf23ArQL7xXUWPKa3VBin6cuDaieSdABvVyTA51dS4Mxrtg1CpGN\" \"password\"");

                return;
            }

            var encryptedSecretString = args[0];
            var encryptedSecret = new BitcoinEncryptedSecretNoEC(encryptedSecretString);
            var password = args[1];

            try
            {
                encryptedSecret.GetKey(password);

                Console.WriteLine("SUCCESS! Correct password!");
            }
            catch (SecurityException)
            {
                Console.WriteLine("Wrong password.");
            }
        }
    }
}
