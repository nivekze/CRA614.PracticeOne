
namespace CryptoTestWinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtToEncryptNum = new System.Windows.Forms.TextBox();
            this.cbxRadomKey = new System.Windows.Forms.CheckBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxlAlgorithms = new System.Windows.Forms.CheckedListBox();
            this.btnCryptDecrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el numero a Encriptar:";
            // 
            // txtToEncryptNum
            // 
            this.txtToEncryptNum.Location = new System.Drawing.Point(182, 54);
            this.txtToEncryptNum.Name = "txtToEncryptNum";
            this.txtToEncryptNum.Size = new System.Drawing.Size(166, 23);
            this.txtToEncryptNum.TabIndex = 1;
            // 
            // cbxRadomKey
            // 
            this.cbxRadomKey.AutoSize = true;
            this.cbxRadomKey.Location = new System.Drawing.Point(354, 27);
            this.cbxRadomKey.Name = "cbxRadomKey";
            this.cbxRadomKey.Size = new System.Drawing.Size(147, 19);
            this.cbxRadomKey.TabIndex = 2;
            this.cbxRadomKey.Text = "Usar una llave aleatoria";
            this.cbxRadomKey.UseVisualStyleBackColor = true;
            this.cbxRadomKey.CheckedChanged += new System.EventHandler(this.cbxRadomKey_CheckedChanged);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(182, 25);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(166, 23);
            this.txtKey.TabIndex = 4;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese la llave a utilizar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Algoritmo a utilizar:";
            // 
            // cbxlAlgorithms
            // 
            this.cbxlAlgorithms.FormattingEnabled = true;
            this.cbxlAlgorithms.Items.AddRange(new object[] {
            "Diferencia",
            "Multiplicacion",
            "XOR"});
            this.cbxlAlgorithms.Location = new System.Drawing.Point(182, 87);
            this.cbxlAlgorithms.Name = "cbxlAlgorithms";
            this.cbxlAlgorithms.Size = new System.Drawing.Size(166, 58);
            this.cbxlAlgorithms.TabIndex = 6;
            this.cbxlAlgorithms.SelectedIndexChanged += new System.EventHandler(this.cbxlAlgorithms_SelectedIndexChanged);
            // 
            // btnCryptDecrypt
            // 
            this.btnCryptDecrypt.Location = new System.Drawing.Point(182, 163);
            this.btnCryptDecrypt.Name = "btnCryptDecrypt";
            this.btnCryptDecrypt.Size = new System.Drawing.Size(166, 23);
            this.btnCryptDecrypt.TabIndex = 7;
            this.btnCryptDecrypt.Text = "Encriptar / Desencriptar";
            this.btnCryptDecrypt.UseVisualStyleBackColor = true;
            this.btnCryptDecrypt.Click += new System.EventHandler(this.btnCryptDecrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resultado:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(81, 205);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(418, 133);
            this.txtResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 357);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCryptDecrypt);
            this.Controls.Add(this.cbxlAlgorithms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxRadomKey);
            this.Controls.Add(this.txtToEncryptNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "UDB - Kevin Alvarez";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToEncryptNum;
        private System.Windows.Forms.CheckBox cbxRadomKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox cbxlAlgorithms;
        private System.Windows.Forms.Button btnCryptDecrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult;
    }
}

