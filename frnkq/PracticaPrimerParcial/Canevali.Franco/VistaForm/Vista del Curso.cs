using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace VistaForm
{
    public partial class Vista_del_Curso : Form
    {
        Curso curso;
        public Vista_del_Curso()
        {
            InitializeComponent();
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            this.nudAnio.Value = 0;

            //tabs settings
            this.nudAnioCurso.TabIndex = 01;
            this.cmbDivision.TabIndex = 02;
            this.txtNombreProfe.TabIndex = 03;
            this.txtApellidoProfe.TabIndex = 04;
            this.txtDocumentoProfe.TabIndex = 05;
            this.dtpFechaIngreso.TabIndex = 06;
            this.btnCrear.TabIndex = 07;
            this.btnMostrar.TabIndex = 08;
            this.txtNombre.TabIndex = 09;
            this.txtApellido.TabIndex = 10;
            this.txtDocumento.TabIndex = 11;
            this.nudAnio.TabIndex = 12;
            this.cmbDivision.TabIndex = 13;
            this.btnAgregar.TabIndex = 14;
            this.btnMostrar.TabIndex = 15;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            if(this.nudAnioCurso.Value > 0 && this.txtNombreProfe.Text != null &&
                this.txtApellidoProfe.Text != null && this.txtDocumentoProfe != null)
            {
                Divisiones division;
                Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
                Profesor profesor = new Profesor(this.txtNombreProfe.Text, 
                                                this.txtApellidoProfe.Text,
                                                this.txtDocumentoProfe.Text,
                                                this.dtpFechaIngreso.Value);
                this.curso = new Curso((short)this.nudAnioCurso.Value, division, profesor);

                this.nudAnio.Value = 0;
                this.txtNombreProfe.Clear();
                this.txtApellidoProfe.Clear();
                this.txtDocumentoProfe.Clear();
                
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.rtbDatos.Clear();
            if(curso is null)
                MessageBox.Show("Debe crear un curso primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.rtbDatos.Text = (string)this.curso;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            Alumno al = new Alumno(this.txtNombre.Text, this.txtApellido.Text,
                this.txtDocumento.Text, (short)this.nudAnio.Value, division);
            if (this.curso is null)
                MessageBox.Show("Debe crear un curso primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                this.curso += al;
        }
    }
}
