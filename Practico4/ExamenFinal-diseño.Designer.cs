namespace Practico4
{
    partial class ExamenFinal_diseño
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ingrese_accesorio = new System.Windows.Forms.Button();
            this.productLista = new System.Windows.Forms.ListBox();
            this.precioLista = new System.Windows.Forms.ListBox();
            this.cantidadLista = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_vaciar = new System.Windows.Forms.Button();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.Procesar_venta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre_completoTexbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ci_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.telef_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_precio = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.total_pagar_txt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.articulos_lleva_Lista = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cantidad_textbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ingrese_accesorio
            // 
            this.btn_ingrese_accesorio.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ingrese_accesorio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingrese_accesorio.ForeColor = System.Drawing.Color.White;
            this.btn_ingrese_accesorio.Location = new System.Drawing.Point(787, 516);
            this.btn_ingrese_accesorio.Name = "btn_ingrese_accesorio";
            this.btn_ingrese_accesorio.Size = new System.Drawing.Size(230, 44);
            this.btn_ingrese_accesorio.TabIndex = 0;
            this.btn_ingrese_accesorio.Text = "INGRESE UN ACCESORIO";
            this.btn_ingrese_accesorio.UseVisualStyleBackColor = false;
            this.btn_ingrese_accesorio.Click += new System.EventHandler(this.btn_ingrese_accesorio_Click);
            // 
            // productLista
            // 
            this.productLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLista.ForeColor = System.Drawing.Color.Blue;
            this.productLista.FormattingEnabled = true;
            this.productLista.ItemHeight = 16;
            this.productLista.Location = new System.Drawing.Point(0, 71);
            this.productLista.Name = "productLista";
            this.productLista.Size = new System.Drawing.Size(105, 276);
            this.productLista.TabIndex = 1;
            // 
            // precioLista
            // 
            this.precioLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioLista.ForeColor = System.Drawing.Color.Blue;
            this.precioLista.FormattingEnabled = true;
            this.precioLista.ItemHeight = 16;
            this.precioLista.Location = new System.Drawing.Point(105, 71);
            this.precioLista.Name = "precioLista";
            this.precioLista.Size = new System.Drawing.Size(101, 276);
            this.precioLista.TabIndex = 2;
            this.precioLista.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // cantidadLista
            // 
            this.cantidadLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadLista.ForeColor = System.Drawing.Color.Blue;
            this.cantidadLista.FormattingEnabled = true;
            this.cantidadLista.ItemHeight = 16;
            this.cantidadLista.Location = new System.Drawing.Point(205, 71);
            this.cantidadLista.Name = "cantidadLista";
            this.cantidadLista.Size = new System.Drawing.Size(92, 276);
            this.cantidadLista.TabIndex = 3;
            this.cantidadLista.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.productLista);
            this.groupBox1.Controls.Add(this.cantidadLista);
            this.groupBox1.Controls.Add(this.precioLista);
            this.groupBox1.Location = new System.Drawing.Point(742, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 367);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "CANTIDAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "PRECIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "PRODUCTO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_vaciar
            // 
            this.btn_vaciar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_vaciar.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vaciar.ForeColor = System.Drawing.Color.White;
            this.btn_vaciar.Location = new System.Drawing.Point(847, 626);
            this.btn_vaciar.Name = "btn_vaciar";
            this.btn_vaciar.Size = new System.Drawing.Size(128, 31);
            this.btn_vaciar.TabIndex = 5;
            this.btn_vaciar.Text = "VACIAR";
            this.btn_vaciar.UseVisualStyleBackColor = false;
            this.btn_vaciar.Click += new System.EventHandler(this.btn_vaciar_Click);
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(0, 73);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(121, 21);
            this.productComboBox.TabIndex = 6;
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.productComboBox_SelectedIndexChanged);
            // 
            // Procesar_venta
            // 
            this.Procesar_venta.BackColor = System.Drawing.Color.DodgerBlue;
            this.Procesar_venta.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procesar_venta.ForeColor = System.Drawing.Color.White;
            this.Procesar_venta.Location = new System.Drawing.Point(75, 626);
            this.Procesar_venta.Name = "Procesar_venta";
            this.Procesar_venta.Size = new System.Drawing.Size(269, 38);
            this.Procesar_venta.TabIndex = 8;
            this.Procesar_venta.Text = "PROCESAR VENTA";
            this.Procesar_venta.UseVisualStyleBackColor = false;
            this.Procesar_venta.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "PRODUCTO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "CANTIDAD";
            // 
            // nombre_completoTexbox
            // 
            this.nombre_completoTexbox.Location = new System.Drawing.Point(37, 289);
            this.nombre_completoTexbox.Name = "nombre_completoTexbox";
            this.nombre_completoTexbox.Size = new System.Drawing.Size(343, 20);
            this.nombre_completoTexbox.TabIndex = 11;
            this.nombre_completoTexbox.TextChanged += new System.EventHandler(this.nombre_completoTexbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre Completo";
            // 
            // ci_textbox
            // 
            this.ci_textbox.Location = new System.Drawing.Point(30, 384);
            this.ci_textbox.Name = "ci_textbox";
            this.ci_textbox.Size = new System.Drawing.Size(141, 20);
            this.ci_textbox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "CI o NIT";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // telef_textbox
            // 
            this.telef_textbox.Location = new System.Drawing.Point(223, 384);
            this.telef_textbox.Name = "telef_textbox";
            this.telef_textbox.Size = new System.Drawing.Size(127, 20);
            this.telef_textbox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(218, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Teléfono";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cantidad_textbox);
            this.groupBox2.Controls.Add(this.txt_precio);
            this.groupBox2.Controls.Add(this.productComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(30, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txt_precio
            // 
            this.txt_precio.AutoSize = true;
            this.txt_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.Location = new System.Drawing.Point(175, 67);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(19, 20);
            this.txt_precio.TabIndex = 19;
            this.txt_precio.Text = "=";
            this.txt_precio.Click += new System.EventHandler(this.txt_precio_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(138, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Costo Unitario";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(124, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "TOTAL A PAGAR";
            // 
            // total_pagar_txt
            // 
            this.total_pagar_txt.AutoSize = true;
            this.total_pagar_txt.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_pagar_txt.ForeColor = System.Drawing.Color.Red;
            this.total_pagar_txt.Location = new System.Drawing.Point(180, 516);
            this.total_pagar_txt.Name = "total_pagar_txt";
            this.total_pagar_txt.Size = new System.Drawing.Size(60, 32);
            this.total_pagar_txt.TabIndex = 20;
            this.total_pagar_txt.Text = "0BS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(431, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(240, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "ARTICULOS QUE LLEVA";
            // 
            // articulos_lleva_Lista
            // 
            this.articulos_lleva_Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articulos_lleva_Lista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.articulos_lleva_Lista.FormattingEnabled = true;
            this.articulos_lleva_Lista.ItemHeight = 20;
            this.articulos_lleva_Lista.Location = new System.Drawing.Point(487, 419);
            this.articulos_lleva_Lista.Name = "articulos_lleva_Lista";
            this.articulos_lleva_Lista.Size = new System.Drawing.Size(137, 264);
            this.articulos_lleva_Lista.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(225, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(543, 41);
            this.label13.TabIndex = 23;
            this.label13.Text = "INFORMATICA SOLUTIONS SCZ";
            // 
            // cantidad_textbox
            // 
            this.cantidad_textbox.Location = new System.Drawing.Point(281, 73);
            this.cantidad_textbox.Name = "cantidad_textbox";
            this.cantidad_textbox.Size = new System.Drawing.Size(118, 20);
            this.cantidad_textbox.TabIndex = 20;
            this.cantidad_textbox.TextChanged += new System.EventHandler(this.cantidad_textbox_TextChanged);
            // 
            // ExamenFinal_diseño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1070, 695);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.articulos_lleva_Lista);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.total_pagar_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.telef_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ci_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nombre_completoTexbox);
            this.Controls.Add(this.Procesar_venta);
            this.Controls.Add(this.btn_vaciar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ingrese_accesorio);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "ExamenFinal_diseño";
            this.Text = "ExamenFinal_diseño";
            this.Load += new System.EventHandler(this.ExamenFinal_diseño_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ingrese_accesorio;
        private System.Windows.Forms.ListBox productLista;
        private System.Windows.Forms.ListBox precioLista;
        private System.Windows.Forms.ListBox cantidadLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_vaciar;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Button Procesar_venta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombre_completoTexbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ci_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox telef_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txt_precio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label total_pagar_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox articulos_lleva_Lista;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cantidad_textbox;
    }
}