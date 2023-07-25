namespace AngieCrypter
{
    class Validate
    {
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
				case "3":
                    Environment.Exit(0);
					break;

				default:
					Console.WriteLine("Invalid selection.");
					break;
			}
		}
    }
}
