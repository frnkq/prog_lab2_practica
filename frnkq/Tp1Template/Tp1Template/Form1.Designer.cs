namespace Tp1Template
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Operar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.DecimalBinario = new System.Windows.Forms.Button();
            this.BinarioDecimal = new System.Windows.Forms.Button();
            this.Numero1 = new System.Windows.Forms.RichTextBox();
            this.Numero2 = new System.Windows.Forms.RichTextBox();
            this.Cerrar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Operar
            // 
            this.Operar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operar.Location = new System.Drawing.Point(12, 71);
            this.Operar.Name = "Operar";
            this.Operar.Size = new System.Drawing.Size(112, 36);
            this.Operar.TabIndex = 0;
            this.Operar.Text = "Operar";
            this.Operar.UseVisualStyleBackColor = true;
            this.Operar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.Location = new System.Drawing.Point(162, 71);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(69, 36);
            this.Limpiar.TabIndex = 2;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.button3_Click);
            // 
            // DecimalBinario
            // 
            this.DecimalBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecimalBinario.Location = new System.Drawing.Point(12, 113);
            this.DecimalBinario.Name = "DecimalBinario";
            this.DecimalBinario.Size = new System.Drawing.Size(170, 37);
            this.DecimalBinario.TabIndex = 3;
            this.DecimalBinario.Text = "Convertir a binario";
            this.DecimalBinario.UseVisualStyleBackColor = true;
            // 
            // BinarioDecimal
            // 
            this.BinarioDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinarioDecimal.Location = new System.Drawing.Point(188, 113);
            this.BinarioDecimal.Name = "BinarioDecimal";
            this.BinarioDecimal.Size = new System.Drawing.Size(195, 37);
            this.BinarioDecimal.TabIndex = 4;
            this.BinarioDecimal.Text = "Convertir a decimal";
            this.BinarioDecimal.UseVisualStyleBackColor = true;
            // 
            // Numero1
            // 
            this.Numero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero1.Location = new System.Drawing.Point(12, 21);
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(112, 32);
            this.Numero1.TabIndex = 5;
            this.Numero1.Text = "";
            this.Numero1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Numero2
            // 
            this.Numero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero2.Location = new System.Drawing.Point(261, 21);
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(112, 32);
            this.Numero2.TabIndex = 5;
            this.Numero2.Text = "";
            // 
            // Cerrar
            // 
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.Location = new System.Drawing.Point(261, 71);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(112, 36);
            this.Cerrar.TabIndex = 0;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(162, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(69, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 162);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Numero1);
            this.Controls.Add(this.BinarioDecimal);
            this.Controls.Add(this.DecimalBinario);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Operar);
            this.Name = "Form1";
            this.Text = "Calculadora de Franco Canevali  del curso 2C";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Operar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button DecimalBinario;
        private System.Windows.Forms.Button BinarioDecimal;
        private System.Windows.Forms.RichTextBox Numero1;
        private System.Windows.Forms.RichTextBox Numero2;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

