namespace AngieCrypter
{
    internal class Crypto
    {
        public static string EncryptDecrypt()
        {
            Console.WriteLine("Select your action:\n(1) Encrypt (2) Decrypt");
            string msg = Console.ReadLine();
            return msg;
        }
    }
}
