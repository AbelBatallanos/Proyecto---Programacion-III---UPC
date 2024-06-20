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
    public partial class EliasEjer1 : Form
    {
        public EliasEjer1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public int count_words(string words) {

            int res = 0;
            string[] arreglo = words.Split();
            res = arreglo.Length;
            return res;
        }

        private void Ejecutar_Click(object sender, EventArgs e)
        {
            string words = textBox1.Text;
            int res = count_words(words);
            label2.Text = $"RESPUESTA: {res} PALABRAS";
        }
    }
}
