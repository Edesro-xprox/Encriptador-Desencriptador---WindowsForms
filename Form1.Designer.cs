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
            System.Windows.Forms.Button btnEncrypt;
            this.richTextBox1_encrypt_decryptor = new System.Windows.Forms.RichTextBox();
            this.richTextBox2_encryptor_decryptor = new System.Windows.Forms.RichTextBox();
            this.xprox_encrypt_decryptor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDecryptor = new System.Windows.Forms.Button();
            btnEncrypt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new System.Drawing.Point(15, 25);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new System.Drawing.Size(95, 23);
            btnEncrypt.TabIndex = 0;
            btnEncrypt.Text = "Encriptar";
            btnEncrypt.UseCompatibleTextRendering = true;
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // richTextBox1_encrypt_decryptor
            // 
            this.richTextBox1_encrypt_decryptor.Location = new System.Drawing.Point(24, 157);
            this.richTextBox1_encrypt_decryptor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1_encrypt_decryptor.Name = "richTextBox1_encrypt_decryptor";
            this.richTextBox1_encrypt_decryptor.Size = new System.Drawing.Size(470, 356);
            this.richTextBox1_encrypt_decryptor.TabIndex = 2;
            this.richTextBox1_encrypt_decryptor.Text = "";
            this.richTextBox1_encrypt_decryptor.TextChanged += new System.EventHandler(this.richTextBox1_encrypt_decryptor_TextChanged);
            // 
            // richTextBox2_encryptor_decryptor
            // 
            this.richTextBox2_encryptor_decryptor.Location = new System.Drawing.Point(546, 157);
            this.richTextBox2_encryptor_decryptor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox2_encryptor_decryptor.Name = "richTextBox2_encryptor_decryptor";
            this.richTextBox2_encryptor_decryptor.Size = new System.Drawing.Size(342, 356);
            this.richTextBox2_encryptor_decryptor.TabIndex = 3;
            this.richTextBox2_encryptor_decryptor.Text = "";
            this.richTextBox2_encryptor_decryptor.TextChanged += new System.EventHandler(this.richTextBox2_encryptor_decryptor_TextChanged);
            // 
            // xprox_encrypt_decryptor
            // 
            this.xprox_encrypt_decryptor.AutoSize = true;
            this.xprox_encrypt_decryptor.Font = new System.Drawing.Font("Calibri", 14.26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xprox_encrypt_decryptor.Location = new System.Drawing.Point(24, 29);
            this.xprox_encrypt_decryptor.Name = "xprox_encrypt_decryptor";
            this.xprox_encrypt_decryptor.Size = new System.Drawing.Size(453, 24);
            this.xprox_encrypt_decryptor.TabIndex = 4;
            this.xprox_encrypt_decryptor.Text = "Xprox - Encriptador y Desencriptador de contraseñas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDecryptor);
            this.panel1.Controls.Add(btnEncrypt);
            this.panel1.Location = new System.Drawing.Point(24, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 74);
            this.panel1.TabIndex = 5;
            // 
            // btnDecryptor
            // 
            this.btnDecryptor.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDecryptor.Location = new System.Drawing.Point(145, 25);
            this.btnDecryptor.Name = "btnDecryptor";
            this.btnDecryptor.Size = new System.Drawing.Size(127, 23);
            this.btnDecryptor.TabIndex = 1;
            this.btnDecryptor.Text = "Desencriptar";
            this.btnDecryptor.UseCompatibleTextRendering = true;
            this.btnDecryptor.UseVisualStyleBackColor = true;
            this.btnDecryptor.Click += new System.EventHandler(this.btnDecryptor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xprox_encrypt_decryptor);
            this.Controls.Add(this.richTextBox2_encryptor_decryptor);
            this.Controls.Add(this.richTextBox1_encrypt_decryptor);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Encriptador y Desencriptador de contraseñas";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBox richTextBox1_encrypt_decryptor;
        private RichTextBox richTextBox2_encryptor_decryptor;
        private Label xprox_encrypt_decryptor;
        private Panel panel1;
        private Button btnDecryptor;
    }
}