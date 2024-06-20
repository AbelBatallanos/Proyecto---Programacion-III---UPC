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
    public partial class Cadenas_ejer4 : Form
    {
        public Cadenas_ejer4()
        {
            InitializeComponent();
        }
        public string quitarPrimerLetra(string cadena)
        {
            string[] palabras = cadena.Split(" ");
            for (int i = 0; i < palabras.Length; i++)
            {
                palabras[i] = palabras[i].Substring(1);
            }

            return string.Join(" ", palabras);
        }

        private void Ejecutar_Click(object sender, EventArgs e)
        {
            string cadena = Entrada.Text;
            string res = quitarPrimerLetra(cadena);
            Respuesta.Text = $"Respuesta: \n {res}";
        }
    }
}
