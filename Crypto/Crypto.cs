using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using xprox_encryptor_decryptor.ValidatorSpace;

namespace xprox_encryptor_decryptor.CryptoSpace
{
    internal class Crypto
    {
        byte[] fixedIV, fixedKey;
        Validator vld;
        public Crypto(byte[] fKey, byte[] fIV)
        {
            fixedIV = fIV;
            fixedKey = fKey;
            vld = new Validator();
        }
        public string EncryptText(byte[] masterBytes, string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return string.Empty;
            }

            using (Aes aesAlg = Aes.Create())
            {
                var combined = masterBytes.Concat(fixedKey).ToArray();
                Array.Resize(ref combined, 32); //el método Resize no devuelve nada
                aesAlg.Key = combined;
                aesAlg.IV = fixedIV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream()) //memoria temporal
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)) //conectar el cifrado al stream
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt)) //escribe texto
                        {
                            swEncrypt.Write(code);
                        }
                        byte[] encrypted = msEncrypt.ToArray();
                        return Convert.ToBase64String(encrypted);
                    }
                }
            }
        }

        public string DecryptText(byte[] masterBytes, string encrypt)
        {
            bool isValidEncrypt = vld.validEncrypt(encrypt);

            if (string.IsNullOrEmpty(encrypt))
            {
                return string.Empty;
            }

            if (!isValidEncrypt)
            {
                return string.Empty;
            }

            byte[] cipherText = Convert.FromBase64String(encrypt);

            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    var combined = masterBytes.Concat(fixedKey).ToArray();
                    Array.Resize(ref combined, 32); //el método Resize no devuelve nada

                    aesAlg.Key = combined;
                    aesAlg.IV = fixedIV;

                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                return srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch
            {
                return "keyError";
            }
        }
    }
}