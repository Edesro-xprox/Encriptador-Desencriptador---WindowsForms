using System;
using System.Collections.Generic;
using System.Text;

namespace xprox_encryptor_decryptor.ValidatorSpace
{
    internal class Validator
    {
        public bool validEncrypt(string input)
        {
            input = input.Trim();

            if (input.Length % 4 != 0)
            {
                return false;
            }

            try
            {
                byte[] cipherText = Convert.FromBase64String(input);
                return cipherText.Length >= 16 && cipherText.Length % 16 == 0;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}