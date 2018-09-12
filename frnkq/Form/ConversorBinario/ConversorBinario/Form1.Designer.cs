namespace ConversorBinario
{
    partial class ConversorNumerico
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
            this.lblBinarioDecimal = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.btnBinToDec = new System.Windows.Forms.Button();
            this.btnDecToBin = new System.Windows.Forms.Button();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.lblDecimalBinario = new System.Windows.Forms.Label();
            this.txtResultadoDecimal = new System.Windows.Forms.TextBox();
            this.txtResultadoBinario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBinarioDecimal
            // 
            this.lblBinarioDecimal.AutoSize = true;
            this.lblBinarioDecimal.Location = new System.Drawing.Point(0, 18);
            this.lblBinarioDecimal.Name = "lblBinarioDecimal";
            this.lblBinarioDecimal.Size = new System.Drawing.Size(87, 13);
            this.lblBinarioDecimal.TabIndex = 0;
            this.lblBinarioDecimal.Text = "Binario a decimal";
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(109, 15);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(100, 20);
            this.txtBinario.TabIndex = 1;
            // 
            // btnBinToDec
            // 
            this.btnBinToDec.Location = new System.Drawing.Point(231, 13);
            this.btnBinToDec.Name = "btnBinToDec";
            this.btnBinToDec.Size = new System.Drawing.Size(32, 23);
            this.btnBinToDec.TabIndex = 2;
            this.btnBinToDec.Text = "->";
            this.btnBinToDec.UseVisualStyleBackColor = true;
            this.btnBinToDec.Click += new System.EventHandler(this.btnBinToDec_Click);
            // 
            // btnDecToBin
            // 
            this.btnDecToBin.Location = new System.Drawing.Point(231, 69);
            this.btnDecToBin.Name = "btnDecToBin";
            this.btnDecToBin.Size = new System.Drawing.Size(32, 23);
            this.btnDecToBin.TabIndex = 3;
            this.btnDecToBin.Text = "->";
            this.btnDecToBin.UseVisualStyleBackColor = true;
            this.btnDecToBin.Click += new System.EventHandler(this.btnDecToBin_Click);
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(109, 71);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 4;
            // 
            // lblDecimalBinario
            // 
            this.lblDecimalBinario.AutoSize = true;
            this.lblDecimalBinario.Location = new System.Drawing.Point(0, 75);
            this.lblDecimalBinario.Name = "lblDecimalBinario";
            this.lblDecimalBinario.Size = new System.Drawing.Size(84, 13);
            this.lblDecimalBinario.TabIndex = 5;
            this.lblDecimalBinario.Text = "DecimalABinario";
            // 
            // txtResultadoDecimal
            // 
            this.txtResultadoDecimal.Location = new System.Drawing.Point(280, 15);
            this.txtResultadoDecimal.Name = "txtResultadoDecimal";
            this.txtResultadoDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoDecimal.TabIndex = 6;
            // 
            // txtResultadoBinario
            // 
            this.txtResultadoBinario.Location = new System.Drawing.Point(280, 71);
            this.txtResultadoBinario.Name = "txtResultadoBinario";
            this.txtResultadoBinario.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoBinario.TabIndex = 7;
            // 
            // ConversorNumerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 105);
            this.Controls.Add(this.txtResultadoBinario);
            this.Controls.Add(this.txtResultadoDecimal);
            this.Controls.Add(this.lblDecimalBinario);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.btnDecToBin);
            this.Controls.Add(this.btnBinToDec);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.lblBinarioDecimal);
            this.Name = "ConversorNumerico";
            this.Text = "Conversor numerico";
            this.Load += new System.EventHandler(this.ConversorNumerico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinarioDecimal;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.Button btnBinToDec;
        private System.Windows.Forms.Button btnDecToBin;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Label lblDecimalBinario;
        private System.Windows.Forms.TextBox txtResultadoDecimal;
        private System.Windows.Forms.TextBox txtResultadoBinario;
    }
}

