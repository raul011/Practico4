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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(Matriz[0] = 4);
            textBox2.Text = Convert.ToString(Matriz[1] = 2);
            textBox3.Text = Convert.ToString(Matriz[2] = 6);
            textBox4.Text = Convert.ToString(Matriz[3] = 7);
            textBox5.Text = Convert.ToString(Matriz[4] = 1);
            textBox6.Text = Convert.ToString(Matriz[5] = 8);
            textBox7.Text = Convert.ToString(Matriz[6] = 4);
            textBox8.Text = Convert.ToString(Matriz[7] = 6);
            textBox9.Text = Convert.ToString(Matriz[8] = 9);

        }

        int[] Matriz = new int [9];
        int V;
        
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.Text = Convert.ToString(Matriz[8]);
            
            
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int c = 0; c < 9; c++)
            {
                V = Convert.ToInt32(textBox10.Text.Length > 0 ? int.Parse(textBox10.Text) : 0);
                Matriz[c] *= V;
            }
            textBox1.Text = Convert.ToString(Matriz[0]);
            textBox2.Text = Convert.ToString(Matriz[1]);
            textBox3.Text = Convert.ToString(Matriz[2]);
            textBox4.Text = Convert.ToString(Matriz[3]);
            textBox5.Text = Convert.ToString(Matriz[4]);
            textBox6.Text = Convert.ToString(Matriz[5]);
            textBox7.Text = Convert.ToString(Matriz[6]);
            textBox8.Text = Convert.ToString(Matriz[7]);
            textBox9.Text = Convert.ToString(Matriz[8]);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Matriz[0]);
          
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(Matriz[1]);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Matriz[2]);
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(Matriz[3]);
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(Matriz[4]);
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = Convert.ToString(Matriz[5]);
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = Convert.ToString(Matriz[6]);
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = Convert.ToString(Matriz[7]);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
    }
}
