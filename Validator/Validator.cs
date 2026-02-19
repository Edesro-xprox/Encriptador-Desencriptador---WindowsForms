using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.Principal;
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

        public bool validExistKeys(string master, string key, string iv)
        {
            if (
                string.IsNullOrEmpty(master) ||
                string.IsNullOrEmpty(key) ||
                string.IsNullOrEmpty(iv))
            {
                return false;
            }
            return true;
        }

        public bool validLengthKeys(string master, string key, string iv) { 
            if(
                master.Length == 16 ||
                key.Length == 32 ||
                iv.Length == 16)
            {
                return true;
            }
            return false;
        }
    }
}