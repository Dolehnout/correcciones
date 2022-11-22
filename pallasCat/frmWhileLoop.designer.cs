namespace appLoop
{
    partial class frmWhileLoop
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
            this.label1 = new System.Windows.Forms.Label();
            this.ingEntero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.factorial = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Plum;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculo del factorial de un número";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ingEntero
            // 
            this.ingEntero.AutoSize = true;
            this.ingEntero.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingEntero.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ingEntero.Location = new System.Drawing.Point(12, 81);
            this.ingEntero.Name = "ingEntero";
            this.ingEntero.Size = new System.Drawing.Size(257, 62);
            this.ingEntero.TabIndex = 1;
            this.ingEntero.Text = "Ingresa un entero:";
            this.ingEntero.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(281, 101);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(281, 163);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // factorial
            // 
            this.factorial.AutoSize = true;
            this.factorial.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorial.ForeColor = System.Drawing.Color.MidnightBlue;
            this.factorial.Location = new System.Drawing.Point(12, 143);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(211, 62);
            this.factorial.TabIndex = 4;
            this.factorial.Text = "El factorial es:";
            this.factorial.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCalcular.Location = new System.Drawing.Point(98, 208);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(171, 46);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(440, 208);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(178, 46);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmWhileLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.ingEntero);
            this.Controls.Add(this.label1);
            this.Name = "frmWhileLoop";
            this.Text = "Bucles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ingEntero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label factorial;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
    }
}