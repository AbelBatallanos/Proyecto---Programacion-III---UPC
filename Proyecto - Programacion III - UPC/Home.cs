namespace Proyecto___Programacion_III___UPC
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eLIASVASQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliasEjer1 eliasEjer1 = new EliasEjer1();
            eliasEjer1.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadenasEjer2 cadenasEjer2 = new CadenasEjer2();
            cadenasEjer2.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PalabraMasLargaEjer3 palabraMasLargaEjer3 = new PalabraMasLargaEjer3();
            palabraMasLargaEjer3.Show();
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadenas_ejer4 cadenas_4 = new Cadenas_ejer4();
            cadenas_4.Show();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadenas_ejer5 cadenas_Ejer5 = new Cadenas_ejer5();
            cadenas_Ejer5.Show();
        }
    }
}
