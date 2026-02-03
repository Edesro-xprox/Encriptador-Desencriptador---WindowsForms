using System;
using System.Runtime.InteropServices.Swift;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using xprox_encryptor_decryptor.CryptoSpace;

namespace xprox_encryptor_decryptor
{
    public partial class Form1 : Form
    {
        string codeEncrypt = "", codeDecryptor = "", master = "devespinoz@";
        byte[] masterBytes = null;
        Crypto cyp;

        private static byte[] fixedKey = Encoding.UTF8.GetBytes("12345678901234567890123456789012");
        private static byte[] fixedIV = Encoding.UTF8.GetBytes("1234567890123456");

        public Form1()
        {
            InitializeComponent();
            richTextBox2_encryptor_decryptor.ReadOnly = true;
            textBox1.Text = master;
            cyp = new Crypto(fixedKey, fixedIV);
        }



        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBox1_encrypt_decryptor.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            StringBuilder encryptedText = new StringBuilder();

            masterBytes = Encoding.UTF8.GetBytes(master);

            foreach (string line in lines)
            {
                //Cifrar cada línea por separado
                codeEncrypt = cyp.EncryptText(masterBytes, line);
                encryptedText.AppendLine(codeEncrypt);
            }

            richTextBox2_encryptor_decryptor.Text = encryptedText.ToString();
        }

        private void btnDecryptor_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBox1_encrypt_decryptor.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            StringBuilder decryptedText = new StringBuilder();

            masterBytes = Encoding.UTF8.GetBytes(master);

            foreach (string line in lines)
            {
                codeDecryptor = cyp.DecryptText(masterBytes, line);
                decryptedText.AppendLine(codeDecryptor);
            }

            richTextBox2_encryptor_decryptor.Text = decryptedText.ToString();
        }

        private void richTextBox1_encrypt_decryptor_TextChanged(object sender, EventArgs e)
        {

        }
        private void richTextBox2_encryptor_decryptor_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            master = textBox1.Text;
        }
    }
}