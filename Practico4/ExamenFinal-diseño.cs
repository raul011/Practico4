using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Practico4
{
    public partial class ExamenFinal_diseño : Form
    {
        public ExamenFinal_diseño()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        String a, b , c  = "";

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        int D = 0, R = 0, S = 0;

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TXT PRECIO DEL PRODUCTO
            int B = 0;
            S = productComboBox.SelectedIndex;
            B = Vprecio[S+1] ;
            txt_precio.Text = Convert.ToString(B);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = nombre_completoTexbox.Text;
            Interaction.MsgBox("FACTURA A :  " + name + "\n" + "CI O NIT : " + ci_textbox.Text +"\n"+ "TELÉFONO: " + telef_textbox.Text + "\n" );
           
        }

 
        private void label9_Click(object sender, EventArgs e)
        {

        }

        int cont = 0;
      
        private void txt_precio_Click(object sender, EventArgs e)
        {

           // txt precio
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ExamenFinal_diseño_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        double acu = 0; int total = 0;
        int cantidadProducto = 0 ;
        private void cantidad_textbox_TextChanged(object sender, EventArgs e)
        {
            //textbox cantidad de productos a llevar 
            int selec = 0, cantInput = 0, tot = 0;
            selec = productComboBox.SelectedIndex;
            cantInput = Convert.ToInt32(cantidad_textbox.Text.Length > 0 ? int.Parse(cantidad_textbox.Text) : 0);
            tot = Vprecio[S + 1] * cantInput;
            acu = acu + tot;
            total = Convert.ToInt32(acu);
            if( acu > 3500){
                Interaction.MsgBox("Sr. Cliente se le hara un descuento al total de su compra");
                double descuento = acu* 0.03;
                acu  = acu - descuento;
                total = Convert.ToInt32(acu);
                total_pagar_txt.Text = Convert.ToString( total + " BS");
            }
            else
            {
                total_pagar_txt.Text = Convert.ToString(total + " BS");
            }
            cantidadProducto = cantInput;
            if(cantidadProducto != 0){
                articulos_lleva_Lista.Items.Add("" + Vproductos[S + 1] + " : " + cantidadProducto);
            }
            
        }

        private void btn_vaciar_Click(object sender, EventArgs e)
        {
            // eliminando listas de productos

            productLista.Items.Clear();
            precioLista.Items.Clear();
            cantidadLista.Items.Clear();
            productComboBox.Items.Clear();
        }


        int contador = 0;

        private void nombre_completoTexbox_TextChanged(object sender, EventArgs e)
        {

        }

        int[] Vprecio = new int[14];
        String[] Vproductos = new String[10];
        int[] Vcantidad = new int[10];
        private void btn_ingrese_accesorio_Click(object sender, EventArgs e)
        {

          //  int[] Vprecio; // Declaración del array
          //  Vprecio  = new int[13]; // Instanciación del array
            contador = contador + 1;
            // nombre de articulo
            a = Interaction.InputBox("INGRESE EL NOMBRE DEL PRODUCTO ");
            productLista.Items.Add(a);
            productLista.Items.Add("________________");
            productComboBox.Items.Add(a);
            Vproductos[contador] = a;
            // precio
            b = Interaction.InputBox("INGRESE EL PRECIO EN BOLIVIANOS ");
          //  int valor = Convert.ToInt32(b);

            precioLista.Items.Add(b + "  BS");
            precioLista.Items.Add("_______________");
            Vprecio[contador] = Convert.ToInt32(b) ;

            // cantidad 
            c = Interaction.InputBox("INGRESE LA CANTIDAD ");
            cantidadLista.Items.Add(c + " Uni.");
            cantidadLista.Items.Add("_______________");
            Vcantidad[contador] = Convert.ToInt32(c);
          
            
        }
    }
}
