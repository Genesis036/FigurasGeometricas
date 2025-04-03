using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geometricas
{
    public partial class Form1 : Form
    {
        private List<Figura> figuras = new List<Figura> (); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer y validar coordenadas
                int x = int.Parse(txtX.Text);
                int y = int.Parse(txtY.Text);

                // Obtener el tipo de figura seleccionada
                string tipoFigura = cmbFigura.SelectedItem.ToString();

                // Crear figura usando la Factory
                Figura figura = FiguraFactory.CrearFigura(tipoFigura, pictureBox1.BackColor, x, y);

                figuras.Add(figura);

                panel1.Invalidate();

                // Incrementar contador y actualizar el TextBox
                /*   int numero = int.Parse(txtContador.Text) + 1;
                   txtContador.Text = txtContador.ToString(); */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.BackColor = colorDialog.Color;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Dibujar todas las figuras almacenadas en la lista
            foreach (Figura figura in figuras)
            {
                figura.Dibujar(g);
            }
        }
    }
}
