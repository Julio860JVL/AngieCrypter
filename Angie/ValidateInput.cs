namespace Angie
{
    internal class Validate
    {
        //static string userInput = Crypto.EncryptDecrypt();
        public static void Input(string userInput)
		{
			switch (userInput)
			{
				case "1":
					Encrypt.PlainMsg();
					break;
				case "2":
					Decrypt.EncryptedMsg();
                    break;

				default:
					Console.WriteLine("Invalid selection.");
					break;
			}
		}
    }
}
