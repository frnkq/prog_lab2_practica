namespace Ej_28
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
            this.rtxtTextBox = new System.Windows.Forms.RichTextBox();
            this.btnContar = new System.Windows.Forms.Button();
            this.lblCantPalabras = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtTextBox
            // 
            this.rtxtTextBox.Location = new System.Drawing.Point(12, 12);
            this.rtxtTextBox.Name = "rtxtTextBox";
            this.rtxtTextBox.Size = new System.Drawing.Size(675, 244);
            this.rtxtTextBox.TabIndex = 0;
            this.rtxtTextBox.Text = "";
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(277, 274);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(121, 23);
            this.btnContar.TabIndex = 1;
            this.btnContar.Text = "Contar palabras";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // lblCantPalabras
            // 
            this.lblCantPalabras.AutoSize = true;
            this.lblCantPalabras.Location = new System.Drawing.Point(652, 287);
            this.lblCantPalabras.Name = "lblCantPalabras";
            this.lblCantPalabras.Size = new System.Drawing.Size(0, 13);
            this.lblCantPalabras.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 309);
            this.Controls.Add(this.lblCantPalabras);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.rtxtTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtTextBox;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Label lblCantPalabras;
    }
}

