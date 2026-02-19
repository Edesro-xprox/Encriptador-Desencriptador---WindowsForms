using System;
using System.Runtime.InteropServices.Swift;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using xprox_encryptor_decryptor.CryptoSpace;
using xprox_encryptor_decryptor.ValidatorSpace;

namespace xprox_encryptor_decryptor
{
    public partial class Frm_Encrypt_Decrypt : Form
    {
        string codeEncrypt, codeDecryptor;
        byte[] masterBytes;
        Crypto cyp; Validator vld;

        string master, key, iv;

        private byte[] fixedKey;
        private byte[] fixedIV;

        public Frm_Encrypt_Decrypt()
        {
            vld = new Validator();

            master = AppConfig.Configuration["Settings:master"];
            key = AppConfig.Configuration["Settings:key"];
            iv = AppConfig.Configuration["Settings:iv"];

            if (
                (!vld.validExistKeys(master, key, iv)) ||
                (!vld.validLengthKeys(master, key, iv))
            )
            {
                MessageBox.Show("Configuración AES incorrecta");
                Application.Exit();
                return;
            }

            fixedKey = Encoding.UTF8.GetBytes(key);
            fixedIV = Encoding.UTF8.GetBytes(iv);

            InitializeComponent();
            richTextBox2_encryptor_decryptor.ReadOnly = true;
            txtMaster.Text = master;
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


        private void txtMaster_TextChanged(object sender, EventArgs e)
        {
            master = txtMaster.Text;
        }
    }
}