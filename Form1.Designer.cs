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
            this.richTextBox1_encrypt_decryptor = new System.Windows.Forms.RichTextBox();
            this.richTextBox2_encryptor_decryptor = new System.Windows.Forms.RichTextBox();
            this.xprox_encrypt_decryptor = new System.Windows.Forms.Label();
            this.radioBtn2_encrypt_decryptor = new System.Windows.Forms.RadioButton();
            this.radioBtn1_encrypt_decryptor = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // radioBtn2_encrypt_decryptor
            // 
            this.radioBtn2_encrypt_decryptor.AutoSize = true;
            this.radioBtn2_encrypt_decryptor.Location = new System.Drawing.Point(148, 29);
            this.radioBtn2_encrypt_decryptor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtn2_encrypt_decryptor.Name = "radioBtn2_encrypt_decryptor";
            this.radioBtn2_encrypt_decryptor.Size = new System.Drawing.Size(105, 24);
            this.radioBtn2_encrypt_decryptor.TabIndex = 1;
            this.radioBtn2_encrypt_decryptor.Text = "Desencriptar";
            this.radioBtn2_encrypt_decryptor.UseVisualStyleBackColor = true;
            // 
            // radioBtn1_encrypt_decryptor
            // 
            this.radioBtn1_encrypt_decryptor.AutoSize = true;
            this.radioBtn1_encrypt_decryptor.Location = new System.Drawing.Point(3, 29);
            this.radioBtn1_encrypt_decryptor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtn1_encrypt_decryptor.Name = "radioBtn1_encrypt_decryptor";
            this.radioBtn1_encrypt_decryptor.Size = new System.Drawing.Size(84, 24);
            this.radioBtn1_encrypt_decryptor.TabIndex = 0;
            this.radioBtn1_encrypt_decryptor.Text = "Encriptar";
            this.radioBtn1_encrypt_decryptor.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtn1_encrypt_decryptor);
            this.panel1.Controls.Add(this.radioBtn2_encrypt_decryptor);
            this.panel1.Location = new System.Drawing.Point(24, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 74);
            this.panel1.TabIndex = 5;
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
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radioBtn1_encrypt_decryptor;
        private RadioButton radioBtn2_encrypt_decryptor;
        private RichTextBox richTextBox1_encrypt_decryptor;
        private RichTextBox richTextBox2_encryptor_decryptor;
        private Label xprox_encrypt_decryptor;
        private Panel panel1;
    }
}