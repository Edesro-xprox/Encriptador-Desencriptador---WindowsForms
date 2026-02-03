namespace xprox_encryptor_decryptor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnEncrypt;
            richTextBox1_encrypt_decryptor = new RichTextBox();
            richTextBox2_encryptor_decryptor = new RichTextBox();
            xprox_encrypt_decryptor = new Label();
            panel1 = new Panel();
            btnDecryptor = new Button();
            textBox1 = new TextBox();
            btnEncrypt = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(15, 25);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(95, 23);
            btnEncrypt.TabIndex = 0;
            btnEncrypt.Text = "Encriptar";
            btnEncrypt.UseCompatibleTextRendering = true;
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // richTextBox1_encrypt_decryptor
            // 
            richTextBox1_encrypt_decryptor.Location = new Point(24, 157);
            richTextBox1_encrypt_decryptor.Margin = new Padding(3, 4, 3, 4);
            richTextBox1_encrypt_decryptor.Name = "richTextBox1_encrypt_decryptor";
            richTextBox1_encrypt_decryptor.Size = new Size(470, 356);
            richTextBox1_encrypt_decryptor.TabIndex = 2;
            richTextBox1_encrypt_decryptor.Text = "";
            richTextBox1_encrypt_decryptor.TextChanged += richTextBox1_encrypt_decryptor_TextChanged;
            // 
            // richTextBox2_encryptor_decryptor
            // 
            richTextBox2_encryptor_decryptor.Location = new Point(546, 157);
            richTextBox2_encryptor_decryptor.Margin = new Padding(3, 4, 3, 4);
            richTextBox2_encryptor_decryptor.Name = "richTextBox2_encryptor_decryptor";
            richTextBox2_encryptor_decryptor.Size = new Size(342, 356);
            richTextBox2_encryptor_decryptor.TabIndex = 3;
            richTextBox2_encryptor_decryptor.Text = "";
            richTextBox2_encryptor_decryptor.TextChanged += richTextBox2_encryptor_decryptor_TextChanged;
            // 
            // xprox_encrypt_decryptor
            // 
            xprox_encrypt_decryptor.AutoSize = true;
            xprox_encrypt_decryptor.Font = new Font("Calibri", 14.26F, FontStyle.Bold);
            xprox_encrypt_decryptor.Location = new Point(24, 28);
            xprox_encrypt_decryptor.Name = "xprox_encrypt_decryptor";
            xprox_encrypt_decryptor.Size = new Size(612, 29);
            xprox_encrypt_decryptor.TabIndex = 4;
            xprox_encrypt_decryptor.Text = "Dev Espinoza - Encriptador y Desencriptador de contraseñas";
            //xprox_encrypt_decryptor.Click += xprox_encrypt_decryptor_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDecryptor);
            panel1.Controls.Add(btnEncrypt);
            panel1.Location = new Point(24, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 74);
            panel1.TabIndex = 5;
            // 
            // btnDecryptor
            // 
            btnDecryptor.DialogResult = DialogResult.OK;
            btnDecryptor.Location = new Point(145, 25);
            btnDecryptor.Name = "btnDecryptor";
            btnDecryptor.Size = new Size(127, 23);
            btnDecryptor.TabIndex = 1;
            btnDecryptor.Text = "Desencriptar";
            btnDecryptor.UseCompatibleTextRendering = true;
            btnDecryptor.UseVisualStyleBackColor = true;
            btnDecryptor.Click += btnDecryptor_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(726, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 30);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 541);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(xprox_encrypt_decryptor);
            Controls.Add(richTextBox2_encryptor_decryptor);
            Controls.Add(richTextBox1_encrypt_decryptor);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Encriptador y Desencriptador de contraseñas";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1_encrypt_decryptor;
        private RichTextBox richTextBox2_encryptor_decryptor;
        private Label xprox_encrypt_decryptor;
        private Panel panel1;
        private Button btnDecryptor;
        private TextBox textBox1;
    }
}