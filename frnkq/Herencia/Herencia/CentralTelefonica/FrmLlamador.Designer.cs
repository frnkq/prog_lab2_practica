namespace CentralTelefonica
{
    partial class Llamador
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
            this.txtNumeroDestino = new System.Windows.Forms.TextBox();
            this.grpPanel = new System.Windows.Forms.GroupBox();
            this.btnDial1 = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNumeroOrigen = new System.Windows.Forms.TextBox();
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.btnDial2 = new System.Windows.Forms.Button();
            this.btnDialPound = new System.Windows.Forms.Button();
            this.btnDial0 = new System.Windows.Forms.Button();
            this.btnDialAsterisc = new System.Windows.Forms.Button();
            this.btnDial9 = new System.Windows.Forms.Button();
            this.btnDial8 = new System.Windows.Forms.Button();
            this.btnDial7 = new System.Windows.Forms.Button();
            this.btnDial6 = new System.Windows.Forms.Button();
            this.btnDial5 = new System.Windows.Forms.Button();
            this.btnDial4 = new System.Windows.Forms.Button();
            this.btnDial3 = new System.Windows.Forms.Button();
            this.grpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumeroDestino
            // 
            this.txtNumeroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNumeroDestino.Location = new System.Drawing.Point(15, 12);
            this.txtNumeroDestino.Name = "txtNumeroDestino";
            this.txtNumeroDestino.Size = new System.Drawing.Size(254, 32);
            this.txtNumeroDestino.TabIndex = 0;
            this.txtNumeroDestino.TextChanged += new System.EventHandler(this.txtNumeroDestino_TextChanged);
            // 
            // grpPanel
            // 
            this.grpPanel.Controls.Add(this.btnDial3);
            this.grpPanel.Controls.Add(this.btnDial4);
            this.grpPanel.Controls.Add(this.btnDial5);
            this.grpPanel.Controls.Add(this.btnDial6);
            this.grpPanel.Controls.Add(this.btnDial7);
            this.grpPanel.Controls.Add(this.btnDial8);
            this.grpPanel.Controls.Add(this.btnDial9);
            this.grpPanel.Controls.Add(this.btnDialAsterisc);
            this.grpPanel.Controls.Add(this.btnDial0);
            this.grpPanel.Controls.Add(this.btnDialPound);
            this.grpPanel.Controls.Add(this.btnDial2);
            this.grpPanel.Controls.Add(this.btnDial1);
            this.grpPanel.Location = new System.Drawing.Point(12, 56);
            this.grpPanel.Name = "grpPanel";
            this.grpPanel.Size = new System.Drawing.Size(159, 184);
            this.grpPanel.TabIndex = 1;
            this.grpPanel.TabStop = false;
            this.grpPanel.Text = "Panel";
            // 
            // btnDial1
            // 
            this.btnDial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDial1.Location = new System.Drawing.Point(3, 16);
            this.btnDial1.Name = "btnDial1";
            this.btnDial1.Size = new System.Drawing.Size(42, 33);
            this.btnDial1.TabIndex = 0;
            this.btnDial1.Text = "1";
            this.btnDial1.UseVisualStyleBackColor = true;
            this.btnDial1.Click += new System.EventHandler(this.btnDial1_Click);
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(177, 72);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(92, 23);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(177, 111);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(177, 189);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNumeroOrigen
            // 
            this.txtNumeroOrigen.Location = new System.Drawing.Point(177, 150);
            this.txtNumeroOrigen.Name = "txtNumeroOrigen";
            this.txtNumeroOrigen.Size = new System.Drawing.Size(92, 20);
            this.txtNumeroOrigen.TabIndex = 5;
            // 
            // cmbFranja
            // 
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Location = new System.Drawing.Point(15, 250);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(254, 21);
            this.cmbFranja.TabIndex = 6;
            // 
            // btnDial2
            // 
            this.btnDial2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDial2.Location = new System.Drawing.Point(51, 16);
            this.btnDial2.Name = "btnDial2";
            this.btnDial2.Size = new System.Drawing.Size(42, 33);
            this.btnDial2.TabIndex = 1;
            this.btnDial2.Text = "2";
            this.btnDial2.UseVisualStyleBackColor = true;
            this.btnDial2.Click += new System.EventHandler(this.btnDial2_Click);
            // 
            // btnDialPound
            // 
            this.btnDialPound.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDialPound.Location = new System.Drawing.Point(99, 133);
            this.btnDialPound.Name = "btnDialPound";
            this.btnDialPound.Size = new System.Drawing.Size(42, 33);
            this.btnDialPound.TabIndex = 2;
            this.btnDialPound.Text = "#";
            this.btnDialPound.UseVisualStyleBackColor = true;
            this.btnDialPound.Click += new System.EventHandler(this.btnDialPound_Click);
            // 
            // btnDial0
            // 
            this.btnDial0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDial0.Location = new System.Drawing.Point(51, 133);
            this.btnDial0.Name = "btnDial0";
            this.btnDial0.Size = new System.Drawing.Size(42, 33);
            this.btnDial0.TabIndex = 3;
            this.btnDial0.Text = "0";
            this.btnDial0.UseVisualStyleBackColor = true;
            this.btnDial0.Click += new System.EventHandler(this.btnDial0_Click);
            // 
            // btnDialAsterisc
            // 
            this.btnDialAsterisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDialAsterisc.Location = new System.Drawing.Point(3, 133);
            this.btnDialAsterisc.Name = "btnDialAsterisc";
            this.btnDialAsterisc.Size = new System.Drawing.Size(42, 33);
            this.btnDialAsterisc.TabIndex = 4;
            this.btnDialAsterisc.Text = "*";
            this.btnDialAsterisc.UseVisualStyleBackColor = true;
            this.btnDialAsterisc.Click += new System.EventHandler(this.btnDialAsterisc_Click);
            // 
            // btnDial9
            // 
            this.btnDial9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDial9.Location = new System.Drawing.Point(99, 94);
            this.btnDial9.Name = "btnDial9";
            this.btnDial9.Size = new System.Drawing.Size(42, 33);
            this.btnDial9.TabIndex = 5;
            this.btnDial9.Text = "9";
            this.btnDial9.UseVisualStyleBackColor = true;
            this.btnDial9.Click += new System.EventHandler(this.btnDial9_Click);
            // 
            // btnDial8
            // 
            this.btnDial8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDial8.Location = new System.Drawing.Point(51, 94);
            this.btnDial8.Name = "btnDial8";
            this.btnDial8.Size = new System.Drawing.Size(42, 33);
            this.btnDial8.TabIndex = 6;
            this.btnDial8.Text = "8";
            this.btnDial8.UseVisualStyleBackColor = true;
            this.btnDial8.Click += new System.EventHandler(this.btnDial8_Click);
            // 
            // btnDial7
            // 
            this.btnDial7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDial7.Location = new System.Drawing.Point(3, 94);
            this.btnDial7.Name = "btnDial7";
            this.btnDial7.Size = new System.Drawing.Size(42, 33);
            this.btnDial7.TabIndex = 7;
            this.btnDial7.Text = "7";
            this.btnDial7.UseVisualStyleBackColor = true;
            this.btnDial7.Click += new System.EventHandler(this.btnDial7_Click);
            // 
            // btnDial6
            // 
            this.btnDial6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDial6.Location = new System.Drawing.Point(99, 55);
            this.btnDial6.Name = "btnDial6";
            this.btnDial6.Size = new System.Drawing.Size(42, 33);
            this.btnDial6.TabIndex = 8;
            this.btnDial6.Text = "6";
            this.btnDial6.UseVisualStyleBackColor = true;
            this.btnDial6.Click += new System.EventHandler(this.btnDial6_Click);
            // 
            // btnDial5
            // 
            this.btnDial5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDial5.Location = new System.Drawing.Point(51, 55);
            this.btnDial5.Name = "btnDial5";
            this.btnDial5.Size = new System.Drawing.Size(42, 33);
            this.btnDial5.TabIndex = 9;
            this.btnDial5.Text = "5";
            this.btnDial5.UseVisualStyleBackColor = true;
            this.btnDial5.Click += new System.EventHandler(this.btnDial5_Click);
            // 
            // btnDial4
            // 
            this.btnDial4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDial4.Location = new System.Drawing.Point(3, 55);
            this.btnDial4.Name = "btnDial4";
            this.btnDial4.Size = new System.Drawing.Size(42, 33);
            this.btnDial4.TabIndex = 10;
            this.btnDial4.Text = "4";
            this.btnDial4.UseVisualStyleBackColor = true;
            this.btnDial4.Click += new System.EventHandler(this.btnDial4_Click);
            // 
            // btnDial3
            // 
            this.btnDial3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDial3.Location = new System.Drawing.Point(99, 16);
            this.btnDial3.Name = "btnDial3";
            this.btnDial3.Size = new System.Drawing.Size(42, 33);
            this.btnDial3.TabIndex = 11;
            this.btnDial3.Text = "3";
            this.btnDial3.UseVisualStyleBackColor = true;
            this.btnDial3.Click += new System.EventHandler(this.btnDial3_Click);
            // 
            // Llamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 283);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.txtNumeroOrigen);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.grpPanel);
            this.Controls.Add(this.txtNumeroDestino);
            this.Name = "Llamador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmLlamador";
            this.grpPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroDestino;
        private System.Windows.Forms.GroupBox grpPanel;
        private System.Windows.Forms.Button btnDial3;
        private System.Windows.Forms.Button btnDial4;
        private System.Windows.Forms.Button btnDial5;
        private System.Windows.Forms.Button btnDial6;
        private System.Windows.Forms.Button btnDial7;
        private System.Windows.Forms.Button btnDial8;
        private System.Windows.Forms.Button btnDial9;
        private System.Windows.Forms.Button btnDialAsterisc;
        private System.Windows.Forms.Button btnDial0;
        private System.Windows.Forms.Button btnDialPound;
        private System.Windows.Forms.Button btnDial2;
        private System.Windows.Forms.Button btnDial1;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNumeroOrigen;
        private System.Windows.Forms.ComboBox cmbFranja;
    }
}