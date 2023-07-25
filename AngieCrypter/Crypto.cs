namespace AngieCrypter
{
    class Crypto
    {
        internal static string EncryptDecrypt()
        {
            Console.WriteLine("Select your action:\n(1) Encrypt (2) Decrypt (3) Exit");
#pragma warning disable CS8600 // Possible null reference return.
            // Yes this line of code can possible return null. Is okay. Just ignore it.
            string msg = Console.ReadLine();
#pragma warning disable CS8600 // Possible null reference return.

#pragma warning disable CS8603 // Possible null reference return.
            // It is okay if the user inputs nothing (null).
            // The code will just loop like nothing happens.
            return msg;
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
