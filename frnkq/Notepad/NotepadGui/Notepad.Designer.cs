namespace NotepadGui
{
    partial class Notepad
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.rtxtTextBox = new System.Windows.Forms.RichTextBox();
            this.lblStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.miArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.miAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.miAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.miGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.miGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miArchivo,
            this.miAyuda});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(643, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 228);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(643, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // rtxtTextBox
            // 
            this.rtxtTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtTextBox.Location = new System.Drawing.Point(0, 24);
            this.rtxtTextBox.Name = "rtxtTextBox";
            this.rtxtTextBox.Size = new System.Drawing.Size(643, 204);
            this.rtxtTextBox.TabIndex = 2;
            this.rtxtTextBox.Text = "";
            this.rtxtTextBox.TextChanged += new System.EventHandler(this.rtxtTextBox_TextChanged);
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(118, 17);
            this.lblStatusBar.Text = "toolStripStatusLabel1";
            // 
            // miArchivo
            // 
            this.miArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAbrir,
            this.miGuardar,
            this.miGuardarComo});
            this.miArchivo.Name = "miArchivo";
            this.miArchivo.Size = new System.Drawing.Size(60, 20);
            this.miArchivo.Text = "Archivo";
            // 
            // miAyuda
            // 
            this.miAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAcercaDe});
            this.miAyuda.Name = "miAyuda";
            this.miAyuda.Size = new System.Drawing.Size(53, 20);
            this.miAyuda.Text = "Ayuda";
            // 
            // miAcercaDe
            // 
            this.miAcercaDe.Name = "miAcercaDe";
            this.miAcercaDe.Size = new System.Drawing.Size(180, 22);
            this.miAcercaDe.Text = "Acerca de";
            // 
            // miAbrir
            // 
            this.miAbrir.Name = "miAbrir";
            this.miAbrir.Size = new System.Drawing.Size(233, 22);
            this.miAbrir.Tag = "";
            this.miAbrir.Text = "Abrir                       Ctrl+A";
            this.miAbrir.Click += new System.EventHandler(this.miAbrir_Click);
            // 
            // miGuardar
            // 
            this.miGuardar.Name = "miGuardar";
            this.miGuardar.Size = new System.Drawing.Size(233, 22);
            this.miGuardar.Text = "Guardar                 Ctrl+S";
            this.miGuardar.Click += new System.EventHandler(this.miGuardar_Click);
            // 
            // miGuardarComo
            // 
            this.miGuardarComo.Name = "miGuardarComo";
            this.miGuardarComo.Size = new System.Drawing.Size(233, 22);
            this.miGuardarComo.Text = "Guardar como      Ctrl+Shift+S";
            this.miGuardarComo.Click += new System.EventHandler(this.miGuardarComo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 250);
            this.Controls.Add(this.rtxtTextBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Notepad";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem miArchivo;
        private System.Windows.Forms.ToolStripMenuItem miAbrir;
        private System.Windows.Forms.ToolStripMenuItem miGuardar;
        private System.Windows.Forms.ToolStripMenuItem miGuardarComo;
        private System.Windows.Forms.ToolStripMenuItem miAyuda;
        private System.Windows.Forms.ToolStripMenuItem miAcercaDe;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusBar;
        private System.Windows.Forms.RichTextBox rtxtTextBox;
    }
}

