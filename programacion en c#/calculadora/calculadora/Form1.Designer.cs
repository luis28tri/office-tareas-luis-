namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnSimbolo = new Button();
            btnCero = new Button();
            btnPunto = new Button();
            btn_tres = new Button();
            btn_dos = new Button();
            btn_uno = new Button();
            btn_seis = new Button();
            btn_cinco = new Button();
            btn_cuatro = new Button();
            btn_nueve = new Button();
            btn_ocho = new Button();
            btn_siente = new Button();
            button13 = new Button();
            btn_Suma = new Button();
            btn_Dividir = new Button();
            btn_Multiplicar = new Button();
            btn_Cuadrado = new Button();
            btn_Raiz = new Button();
            btn_Eliminar = new Button();
            btn_Quitar = new Button();
            btn_borrar = new Button();
            btnigual = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.Location = new Point(70, 50);
            txtResultado.MaxLength = 20;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(391, 47);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSimbolo
            // 
            btnSimbolo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSimbolo.Location = new Point(28, 357);
            btnSimbolo.Name = "btnSimbolo";
            btnSimbolo.Size = new Size(75, 51);
            btnSimbolo.TabIndex = 1;
            btnSimbolo.Text = "+/-";
            btnSimbolo.UseVisualStyleBackColor = true;
            btnSimbolo.Click += btnSimbolo_Click;
            // 
            // btnCero
            // 
            btnCero.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCero.Location = new Point(123, 357);
            btnCero.Name = "btnCero";
            btnCero.Size = new Size(75, 51);
            btnCero.TabIndex = 2;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = true;
            btnCero.Click += agregarNumero;
            // 
            // btnPunto
            // 
            btnPunto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPunto.Location = new Point(218, 357);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new Size(75, 51);
            btnPunto.TabIndex = 3;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = true;
            btnPunto.Click += btnPunto_Click;
            // 
            // btn_tres
            // 
            btn_tres.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_tres.Location = new Point(218, 300);
            btn_tres.Name = "btn_tres";
            btn_tres.Size = new Size(75, 51);
            btn_tres.TabIndex = 6;
            btn_tres.Text = "3";
            btn_tres.UseVisualStyleBackColor = true;
            btn_tres.Click += agregarNumero;
            // 
            // btn_dos
            // 
            btn_dos.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dos.Location = new Point(123, 300);
            btn_dos.Name = "btn_dos";
            btn_dos.Size = new Size(75, 51);
            btn_dos.TabIndex = 5;
            btn_dos.Text = "2";
            btn_dos.UseVisualStyleBackColor = true;
            btn_dos.Click += agregarNumero;
            // 
            // btn_uno
            // 
            btn_uno.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_uno.Location = new Point(28, 300);
            btn_uno.Name = "btn_uno";
            btn_uno.Size = new Size(75, 51);
            btn_uno.TabIndex = 4;
            btn_uno.Text = "1";
            btn_uno.UseVisualStyleBackColor = true;
            btn_uno.Click += agregarNumero;
            // 
            // btn_seis
            // 
            btn_seis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_seis.Location = new Point(218, 243);
            btn_seis.Name = "btn_seis";
            btn_seis.Size = new Size(75, 51);
            btn_seis.TabIndex = 9;
            btn_seis.Text = "6";
            btn_seis.UseVisualStyleBackColor = true;
            btn_seis.Click += agregarNumero;
            // 
            // btn_cinco
            // 
            btn_cinco.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cinco.Location = new Point(123, 243);
            btn_cinco.Name = "btn_cinco";
            btn_cinco.Size = new Size(75, 51);
            btn_cinco.TabIndex = 8;
            btn_cinco.Text = "5";
            btn_cinco.UseVisualStyleBackColor = true;
            btn_cinco.Click += agregarNumero;
            // 
            // btn_cuatro
            // 
            btn_cuatro.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cuatro.Location = new Point(28, 243);
            btn_cuatro.Name = "btn_cuatro";
            btn_cuatro.Size = new Size(75, 51);
            btn_cuatro.TabIndex = 7;
            btn_cuatro.Text = "4";
            btn_cuatro.UseVisualStyleBackColor = true;
            btn_cuatro.Click += agregarNumero;
            // 
            // btn_nueve
            // 
            btn_nueve.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_nueve.Location = new Point(218, 186);
            btn_nueve.Name = "btn_nueve";
            btn_nueve.Size = new Size(75, 51);
            btn_nueve.TabIndex = 12;
            btn_nueve.Text = "9";
            btn_nueve.UseVisualStyleBackColor = true;
            btn_nueve.Click += agregarNumero;
            // 
            // btn_ocho
            // 
            btn_ocho.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ocho.Location = new Point(123, 186);
            btn_ocho.Name = "btn_ocho";
            btn_ocho.Size = new Size(75, 51);
            btn_ocho.TabIndex = 11;
            btn_ocho.Text = "8";
            btn_ocho.UseVisualStyleBackColor = true;
            btn_ocho.Click += agregarNumero;
            // 
            // btn_siente
            // 
            btn_siente.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_siente.Location = new Point(28, 186);
            btn_siente.Name = "btn_siente";
            btn_siente.Size = new Size(75, 51);
            btn_siente.TabIndex = 10;
            btn_siente.Text = "7";
            btn_siente.UseVisualStyleBackColor = true;
            btn_siente.Click += agregarNumero;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(441, 243);
            button13.Name = "button13";
            button13.Size = new Size(75, 51);
            button13.TabIndex = 18;
            button13.Tag = "-";
            button13.Text = "-";
            button13.UseVisualStyleBackColor = true;
            button13.Click += clickOperador;
            // 
            // btn_Suma
            // 
            btn_Suma.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Suma.Location = new Point(360, 243);
            btn_Suma.Name = "btn_Suma";
            btn_Suma.Size = new Size(75, 51);
            btn_Suma.TabIndex = 17;
            btn_Suma.Tag = "+";
            btn_Suma.Text = "+";
            btn_Suma.UseVisualStyleBackColor = true;
            btn_Suma.Click += clickOperador;
            // 
            // btn_Dividir
            // 
            btn_Dividir.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Dividir.Location = new Point(441, 186);
            btn_Dividir.Name = "btn_Dividir";
            btn_Dividir.Size = new Size(75, 51);
            btn_Dividir.TabIndex = 16;
            btn_Dividir.Tag = "/";
            btn_Dividir.Text = "/";
            btn_Dividir.UseVisualStyleBackColor = true;
            btn_Dividir.Click += clickOperador;
            // 
            // btn_Multiplicar
            // 
            btn_Multiplicar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Multiplicar.Location = new Point(360, 186);
            btn_Multiplicar.Name = "btn_Multiplicar";
            btn_Multiplicar.Size = new Size(75, 51);
            btn_Multiplicar.TabIndex = 15;
            btn_Multiplicar.Tag = "*";
            btn_Multiplicar.Text = "x";
            btn_Multiplicar.UseVisualStyleBackColor = true;
            btn_Multiplicar.Click += clickOperador;
            // 
            // btn_Cuadrado
            // 
            btn_Cuadrado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cuadrado.Location = new Point(441, 129);
            btn_Cuadrado.Name = "btn_Cuadrado";
            btn_Cuadrado.Size = new Size(75, 51);
            btn_Cuadrado.TabIndex = 14;
            btn_Cuadrado.Tag = "²";
            btn_Cuadrado.Text = "X²";
            btn_Cuadrado.UseVisualStyleBackColor = true;
            btn_Cuadrado.Click += clickOperador;
            // 
            // btn_Raiz
            // 
            btn_Raiz.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Raiz.Location = new Point(360, 129);
            btn_Raiz.Name = "btn_Raiz";
            btn_Raiz.Size = new Size(75, 51);
            btn_Raiz.TabIndex = 13;
            btn_Raiz.Tag = "√";
            btn_Raiz.Text = "√";
            btn_Raiz.UseVisualStyleBackColor = true;
            btn_Raiz.Click += clickOperador;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Eliminar.Location = new Point(218, 129);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(75, 51);
            btn_Eliminar.TabIndex = 21;
            btn_Eliminar.Text = "<--";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Quitar
            // 
            btn_Quitar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Quitar.Location = new Point(123, 129);
            btn_Quitar.Name = "btn_Quitar";
            btn_Quitar.Size = new Size(75, 51);
            btn_Quitar.TabIndex = 20;
            btn_Quitar.Text = "C";
            btn_Quitar.UseVisualStyleBackColor = true;
            btn_Quitar.Click += btn_Quitar_Click;
            // 
            // btn_borrar
            // 
            btn_borrar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn_borrar.Location = new Point(28, 129);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(75, 51);
            btn_borrar.TabIndex = 19;
            btn_borrar.Text = "CE";
            btn_borrar.UseVisualStyleBackColor = true;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // btnigual
            // 
            btnigual.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnigual.Location = new Point(360, 316);
            btnigual.Name = "btnigual";
            btnigual.Size = new Size(170, 70);
            btnigual.TabIndex = 22;
            btnigual.Tag = "=";
            btnigual.Text = "=";
            btnigual.UseVisualStyleBackColor = true;
            btnigual.Click += btnigual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 450);
            Controls.Add(btnigual);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Quitar);
            Controls.Add(btn_borrar);
            Controls.Add(button13);
            Controls.Add(btn_Suma);
            Controls.Add(btn_Dividir);
            Controls.Add(btn_Multiplicar);
            Controls.Add(btn_Cuadrado);
            Controls.Add(btn_Raiz);
            Controls.Add(btn_nueve);
            Controls.Add(btn_ocho);
            Controls.Add(btn_siente);
            Controls.Add(btn_seis);
            Controls.Add(btn_cinco);
            Controls.Add(btn_cuatro);
            Controls.Add(btn_tres);
            Controls.Add(btn_dos);
            Controls.Add(btn_uno);
            Controls.Add(btnPunto);
            Controls.Add(btnCero);
            Controls.Add(btnSimbolo);
            Controls.Add(txtResultado);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnSimbolo;
        private Button btnCero;
        private Button btnPunto;
        private Button btn_tres;
        private Button btn_dos;
        private Button btn_uno;
        private Button btn_seis;
        private Button btn_cinco;
        private Button btn_cuatro;
        private Button btn_nueve;
        private Button btn_ocho;
        private Button btn_siente;
        private Button button13;
        private Button btn_Suma;
        private Button btn_Dividir;
        private Button btn_Multiplicar;
        private Button btn_Cuadrado;
        private Button btn_Raiz;
        private Button btn_Eliminar;
        private Button btn_Quitar;
        private Button btn_borrar;
        private Button btnigual;
    }
}