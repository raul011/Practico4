using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Practico4
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            
            int D, R=0;
            D = Convert.ToInt32(listBox3.Items[S]);
            if (D < V)
            {
                Interaction.MsgBox("No tenemos suficientes Articulos para realizar el pedido");
            }
            else
            {
                R = D - V;
                listBox3.Items.RemoveAt(S);
                listBox3.Items.Insert(S, R);
            }
            textBox1.Text = "";
            
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int B = 0;
            S = comboBox1.SelectedIndex;
            V = Convert.ToInt32(textBox1.Text.Length > 0 ? int.Parse(textBox1.Text): 0);
            B = matriz[0, S] * V;
            Resultado.Text = Convert.ToString(B);
            
        }
        string k = "", l = "", m = "", ñ = "";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        int V =0 , S;
        int[,] matriz;
        private void button1_Click(object sender, EventArgs e)
        {
            k = Interaction.InputBox("Ingrese la cantidad de productos que va a guardar el programa:");
            matriz = new int[2, Convert.ToInt32(k)];

            for (int c=0; c < Convert.ToInt32(k); c++)
            {
                l = Interaction.InputBox("Ingrese el nombre articulo numero [" + (c + 1) + "]");
                listBox1.Items.Add(l);
                comboBox1.Items.Add(l);
            }

            for (int i = 0; i < Convert.ToInt32(k); i++)
            {
                m = Interaction.InputBox("Ingrese el precio de [" + listBox1.Items[i] + "]");
                listBox2.Items.Add(m);
                listBox1.Items.Add("__________");
                matriz[0, i] = Convert.ToInt32(m);

            }
            for (int j = 0; j < Convert.ToInt32(k); j++)
            {
                ñ = Interaction.InputBox("Ingrese la cantida de [" + listBox1.Items[j] + "]");
                listBox3.Items.Add(ñ);
                listBox3.Items.Add("__________");
                matriz[1, j] = Convert.ToInt32(ñ);
            }

        }
    }
}
