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
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            codeEncrypt = EncryptText(code);
            richTextBox2_encryptor_decryptor.Text = codeEncrypt;
        }

        private void btnDecryptor_Click(object sender, EventArgs e)
        {
            codeDecryptor = DecryptText(code);
            richTextBox2_encryptor_decryptor.Text = codeDecryptor;
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
            bool isValidText = IsPlainText(code);

            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Ingrese una contraseña para encriptar");
                return string.Empty;
            }

            if (!isValidText)
            {
                MessageBox.Show("Texto plano inválido");
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
                MessageBox.Show("Ingrese una contraseña encriptada");
                return string.Empty;
            }

            if (!isValidEncrypt)
            {
                MessageBox.Show("Texto cifrado inválido");
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

        private bool IsPlainText(string input)
        {
            input = input.Trim();
            return Regex.IsMatch(input, @"^[a-zA-Z0-9\s]*$");
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

    }
}