using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico4
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int P;
            P = comboBox1.SelectedIndex;
            if (P == 0)
            {
                Image image = Image.FromFile("Sándwich de chola.png");
                pictureBox1.Image = image;
                label1.Text = "Sándwich de chola";
                label2.Text = "Precio: 14 Bs";
            }
            else
            {
                if (P == 1)
                {
                    Image image = Image.FromFile("Salteñas bolivianas.png");
                    pictureBox1.Image = image;
                    label1.Text = "Salteñas bolivianas";
                    label2.Text = "Precio: 5 Bs";
                }
                else
                {
                    if (P == 2)
                    {
                        Image image = Image.FromFile("Rostro asado.png");
                        pictureBox1.Image = image;
                        label1.Text = "Rostro asado";
                        label2.Text = "Precio: 20 Bs";
                    }
                    else
                    {
                        if (P == 3)
                        {
                            Image image = Image.FromFile("Pique macho.png");
                            pictureBox1.Image = image;
                            label1.Text = "Pique macho";
                            label2.Text = "Precio: 23 Bs";
                        }
                        else
                        {
                            if (P == 4)
                            {
                                Image image = Image.FromFile("El intendente.png");
                                pictureBox1.Image = image;                              
                                label1.Text = "El intendente";
                                label2.Text = "Precio: 24 Bs";
                            }
                            
                        }
                    }
                }
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile("");
            pictureBox1.Image = image;
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
