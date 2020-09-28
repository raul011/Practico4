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
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(Matriz[0,0] = 4);
            textBox2.Text = Convert.ToString(Matriz[0,1] = 2);
            textBox3.Text = Convert.ToString(Matriz[0,2] = 6);
            textBox4.Text = Convert.ToString(Matriz[0,3] = 7);
            textBox5.Text = Convert.ToString(Matriz[0,4] = 1);
            textBox6.Text = Convert.ToString(Matriz[0,5] = 8);
            textBox7.Text = Convert.ToString(Matriz[0,6] = 4);
            textBox8.Text = Convert.ToString(Matriz[0,7] = 6);
            textBox9.Text = Convert.ToString(Matriz[0,8] = 9);

            textBox10.Text = Convert.ToString(Matriz[1, 0] = 6);
            textBox11.Text = Convert.ToString(Matriz[1, 1] = 3);
            textBox12.Text = Convert.ToString(Matriz[1, 2] = 6);
            textBox13.Text = Convert.ToString(Matriz[1, 3] = 1);
            textBox14.Text = Convert.ToString(Matriz[1, 4] = 4);
            textBox15.Text = Convert.ToString(Matriz[1, 5] = 8);
            textBox16.Text = Convert.ToString(Matriz[1, 6] = 9);
            textBox17.Text = Convert.ToString(Matriz[1, 7] = 1);
            textBox18.Text = Convert.ToString(Matriz[1, 8] = 4);

            textBox19.Text = Convert.ToString(Matriz[2, 0] = 0);
            textBox20.Text = Convert.ToString(Matriz[2, 1] = 0);
            textBox21.Text = Convert.ToString(Matriz[2, 2] = 0);
            textBox22.Text = Convert.ToString(Matriz[2, 3] = 0);
            textBox23.Text = Convert.ToString(Matriz[2, 4] = 0);
            textBox24.Text = Convert.ToString(Matriz[2, 5] = 0);
            textBox25.Text = Convert.ToString(Matriz[2, 6] = 0);
            textBox26.Text = Convert.ToString(Matriz[2, 7] = 0);
            textBox27.Text = Convert.ToString(Matriz[2, 8] = 0);
        }
        int[,] Matriz = new int[3,9];
        int V;

        private void Ejercicio5_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e) 
        { 
            for (int c = 0; c < 9; c++)
            {
               V = Matriz[0, c] + Matriz[1, c];
               Matriz[2, c] = V;
            }
            textBox19.Text = Convert.ToString(Matriz[2, 0]);
            textBox20.Text = Convert.ToString(Matriz[2, 1]);
            textBox21.Text = Convert.ToString(Matriz[2, 2]);
            textBox22.Text = Convert.ToString(Matriz[2, 3]);
            textBox23.Text = Convert.ToString(Matriz[2, 4]);
            textBox24.Text = Convert.ToString(Matriz[2, 5]);
            textBox25.Text = Convert.ToString(Matriz[2, 6]);
            textBox26.Text = Convert.ToString(Matriz[2, 7]);
            textBox27.Text = Convert.ToString(Matriz[2, 8]);
        }
        // Primera Matriz
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Matriz[0,0]);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(Matriz[0,1]);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Matriz[0,2]);


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(Matriz[0,3]);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(Matriz[0,4]);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = Convert.ToString(Matriz[0,5]);

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = Convert.ToString(Matriz[0,6]);

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.Text = Convert.ToString(Matriz[0,7]);

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.Text = Convert.ToString(Matriz[0,8]);

        }
        // Segunda matriz

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox10.Text = Convert.ToString(Matriz[1, 0]);

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox11.Text = Convert.ToString(Matriz[1, 1]);
        }

        private void textBox12_TextChanged_1(object sender, EventArgs e)
        {
            textBox12.Text = Convert.ToString(Matriz[1, 2]);


        }

        private void textBox13_TextChanged_1(object sender, EventArgs e)
        {
            textBox13.Text = Convert.ToString(Matriz[1, 3]);

        }

        private void textBox14_TextChanged_1(object sender, EventArgs e)
        {
            textBox14.Text = Convert.ToString(Matriz[1, 4]);

        }

        private void textBox15_TextChanged_1(object sender, EventArgs e)
        {
            textBox15.Text = Convert.ToString(Matriz[1, 5]);

        }

        private void textBox16_TextChanged_1(object sender, EventArgs e)
        {
            textBox16.Text = Convert.ToString(Matriz[1, 6]);

        }

        private void textBox17_TextChanged_1(object sender, EventArgs e)
        {
            textBox17.Text = Convert.ToString(Matriz[1, 7]);

        }
        private void textBox18_TextChanged_1(object sender, EventArgs e)
        {
            textBox18.Text = Convert.ToString(Matriz[1, 8]);

        }
        // Tersera Matriz

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            textBox10.Text = Convert.ToString(Matriz[2, 0]);

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            textBox11.Text = Convert.ToString(Matriz[2, 1]);
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            textBox12.Text = Convert.ToString(Matriz[2, 2]);


        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            textBox13.Text = Convert.ToString(Matriz[2, 3]);

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            textBox14.Text = Convert.ToString(Matriz[2, 4]);

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            textBox15.Text = Convert.ToString(Matriz[2, 5]);

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            textBox16.Text = Convert.ToString(Matriz[2, 6]);

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            textBox17.Text = Convert.ToString(Matriz[2, 7]);

        }
        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            textBox18.Text = Convert.ToString(Matriz[2, 8]);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int c = 0; c < 9; c++)
            {
                V = Matriz[0, c] - Matriz[1, c];
                Matriz[2, c] = V;
            }
            textBox19.Text = Convert.ToString(Matriz[2, 0]);
            textBox20.Text = Convert.ToString(Matriz[2, 1]);
            textBox21.Text = Convert.ToString(Matriz[2, 2]);
            textBox22.Text = Convert.ToString(Matriz[2, 3]);
            textBox23.Text = Convert.ToString(Matriz[2, 4]);
            textBox24.Text = Convert.ToString(Matriz[2, 5]);
            textBox25.Text = Convert.ToString(Matriz[2, 6]);
            textBox26.Text = Convert.ToString(Matriz[2, 7]);
            textBox27.Text = Convert.ToString(Matriz[2, 8]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int c = 0; c < 9; c++)
            {
                V = Matriz[0, c] * Matriz[1, c];
                Matriz[2, c] = V;
            }
            textBox19.Text = Convert.ToString(Matriz[2, 0]);
            textBox20.Text = Convert.ToString(Matriz[2, 1]);
            textBox21.Text = Convert.ToString(Matriz[2, 2]);
            textBox22.Text = Convert.ToString(Matriz[2, 3]);
            textBox23.Text = Convert.ToString(Matriz[2, 4]);
            textBox24.Text = Convert.ToString(Matriz[2, 5]);
            textBox25.Text = Convert.ToString(Matriz[2, 6]);
            textBox26.Text = Convert.ToString(Matriz[2, 7]);
            textBox27.Text = Convert.ToString(Matriz[2, 8]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int c = 0; c < 9; c++)
            {
                V = Matriz[0, c] / Matriz[1, c];
                Matriz[2, c] = V;
            }
            textBox19.Text = Convert.ToString(Matriz[2, 0]);
            textBox20.Text = Convert.ToString(Matriz[2, 1]);
            textBox21.Text = Convert.ToString(Matriz[2, 2]);
            textBox22.Text = Convert.ToString(Matriz[2, 3]);
            textBox23.Text = Convert.ToString(Matriz[2, 4]);
            textBox24.Text = Convert.ToString(Matriz[2, 5]);
            textBox25.Text = Convert.ToString(Matriz[2, 6]);
            textBox26.Text = Convert.ToString(Matriz[2, 7]);
            textBox27.Text = Convert.ToString(Matriz[2, 8]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
    }
}
