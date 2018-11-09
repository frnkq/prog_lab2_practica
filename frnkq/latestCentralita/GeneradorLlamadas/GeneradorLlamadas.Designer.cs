namespace GeneradorLlamadas
{
    partial class GeneradorLlamadas
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
            this.rtxtGeneradorLLamadas = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtGeneradorLLamadas
            // 
            this.rtxtGeneradorLLamadas.Location = new System.Drawing.Point(12, 18);
            this.rtxtGeneradorLLamadas.Name = "rtxtGeneradorLLamadas";
            this.rtxtGeneradorLLamadas.Size = new System.Drawing.Size(443, 217);
            this.rtxtGeneradorLLamadas.TabIndex = 0;
            this.rtxtGeneradorLLamadas.Text = "";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 241);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(443, 29);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // GeneradorLlamadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 282);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rtxtGeneradorLLamadas);
            this.Name = "GeneradorLlamadas";
            this.Text = "GeneradorLlamadas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtGeneradorLLamadas;
        private System.Windows.Forms.Button btnSalir;
    }
}

