using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto___Programacion_III___UPC
{
    public partial class CadenasEjer2 : Form
    {
        public CadenasEjer2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        static string deleteVocals(string words) {
            string[] vocales = {"a", "e", "i", "o", "u", 
                "A", "E", "I", "O", "U", 
                "á", "é", "í", "ó", "ú", 
                "Á", "É", "Í", "Ó", "Ú"};
            for (int i = 0; i < vocales.Length; i++) {
                words = words.Replace(vocales[i], "");
            }
            
            
            return words;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string words = textBox1.Text;
            string res = deleteVocals(words);
            label2.Text = ($"RESPUESTA: \n {res}");

            
        }
    }
}
