using AngieCrypter;

while (true)
{
    // If the method 'Crypto.EncryptDecrypt()' is called then it will be called twice.
    // This first line of code also calls the method 'Crypto.EncryptDecrypt()'.
    string userInput = Crypto.EncryptDecrypt();

    // Git conflict test_v1.
    Validate.Input(userInput);
}