using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace xprox_encryptor_decryptor
{
    public partial class Form1 : Form
    {
        string code = "", codeEncrypt = "", codeDecryptor = "";
        private static byte[] fixedKey = Encoding.UTF8.GetBytes("12345678901234567890123456789012");
        private static byte[] fixedIV = Encoding.UTF8.GetBytes("1234567890123456");

        public Form1()
        {
            InitializeComponent();
            richTextBox2_encryptor_decryptor.ReadOnly = true;
        }



        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBox1_encrypt_decryptor.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            StringBuilder encryptedText = new StringBuilder();

            foreach (string line in lines)
            {
                //Cifrar cada línea por separado
                codeEncrypt = EncryptText(line);
                encryptedText.AppendLine(codeEncrypt);
            }

            richTextBox2_encryptor_decryptor.Text = encryptedText.ToString();
        }

        private void btnDecryptor_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBox1_encrypt_decryptor.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            StringBuilder decryptedText = new StringBuilder();

            foreach (string line in lines)
            {
                codeDecryptor = DecryptText(line);
                decryptedText.AppendLine(codeDecryptor);
            }

            richTextBox2_encryptor_decryptor.Text = decryptedText.ToString();
        }

        private void richTextBox1_encrypt_decryptor_TextChanged(object sender, EventArgs e)
        {
            code = richTextBox1_encrypt_decryptor.Text;
        }
        private void richTextBox2_encryptor_decryptor_TextChanged(object sender, EventArgs e)
        {

        }

        private string EncryptText(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return string.Empty;
            }

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = fixedKey;
                aesAlg.IV = fixedIV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(code);
                        }
                        byte[] encrypted = msEncrypt.ToArray();
                        return Convert.ToBase64String(encrypted);
                    }
                }
            }
        }

        private string DecryptText(string encrypt)
        {
            bool isValidEncrypt = validEncrypt(encrypt);

            if (string.IsNullOrEmpty(encrypt))
            {
                return string.Empty;
            }

            if (!isValidEncrypt)
            {
                return string.Empty;
            }

            byte[] cipherText = Convert.FromBase64String(encrypt);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = fixedKey;
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

        private bool validEncrypt(string input)
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

        private void xprox_encrypt_decryptor_Click(object sender, EventArgs e)
        {

        }
    }
}