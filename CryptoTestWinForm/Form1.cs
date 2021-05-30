using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cryptography;

namespace CryptoTestWinForm
{
    public partial class Form1 : Form
    {
        public List<Algorithm> algorithms { get; set; }
        public Form1()
        {
            InitializeComponent();
            algorithms = new List<Algorithm>();
        }

        private void cbxRadomKey_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRadomKey.Checked)
            {
                txtKey.Text = (new Random()).Next(1, 100).ToString();
                txtKey.Enabled = false;
            }
            else {
                txtKey.Text = "";
                txtKey.Enabled = true;
            }
        }

        private void cbxlAlgorithms_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxlAlgorithms.Enabled = false;
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            int tmp;
            cbxlAlgorithms.Enabled = int.TryParse(txtKey.Text, out tmp);
        }

        private void btnCryptDecrypt_Click(object sender, EventArgs e)
        {
            algorithms.Clear();
            int tmpKey;
            int.TryParse(txtKey.Text.ToString(), out tmpKey);
            foreach (var item in cbxlAlgorithms.CheckedItems)
            {
                switch (item)
                {
                    case "Diferencia":
                        algorithms.Add(new SubtractionAlgorithm(tmpKey));
                        break;
                    case "Multiplicacion":
                        algorithms.Add(new MultiplicationAlgorithm(tmpKey));
                        break;
                    case "XOR":
                        algorithms.Add(new XORAlgorithm(tmpKey));
                        break;
                    default:
                        break;
                }
            }
            txtResult.Text = "";
            if (txtKey.Text.Length == 0 || txtToEncryptNum.Text.Length == 0 || algorithms.Count() == 0)
            {
                MessageBox.Show("Falta información requerida!");
            }
            else {
                int tmpNumToCrypt, tmpCryptNum, tmpDecryptNum;
                int.TryParse(txtToEncryptNum.Text.ToString(), out tmpNumToCrypt);
                var text = new StringBuilder();
                text.Append("\r\n**********************************************************\r\n");
                foreach (var a in algorithms)
                {

                    text.Append($"\tAlgoritmo Usado: {a.GetType().Name}\r\n");
                    tmpCryptNum = a.Crypt(tmpNumToCrypt);
                    tmpDecryptNum = a.Decrypt(tmpCryptNum);
                    text.Append($"\t\tNumero Original: {tmpNumToCrypt}\r\n");
                    text.Append($"\t\tLlave: {a.GetKey()}\r\n");
                    text.Append($"\t\tNumero Encriptado: {tmpCryptNum}\r\n");
                    text.Append($"\t\tNumero Desencriptado: {tmpDecryptNum}\r\n");
                    text.Append("\r\n**********************************************************\r\n");
                }
                txtResult.Text = text.ToString();
            }
        }
    }
}
