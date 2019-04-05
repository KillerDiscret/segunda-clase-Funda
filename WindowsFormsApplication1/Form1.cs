using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        CArreglo objarreglo = new CArreglo();
        CAlumno objalumno = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            int ncursos = Convert.ToInt32(txtnrocursos.Text);
            string carrera = cbocarrera.Text;
            int cod = Convert.ToInt32(txtcodigo.Text);
            string nom = txtnombre.Text;
            objalumno = new CAlumno(ncursos, carrera, cod, nom);
            objarreglo.Insertar(objalumno);
            lboxlista.Items.Add(objalumno.Informacion());
            txtcodigo.Clear();
            txtnombre.Clear();
            txtnrocursos.Clear();
            cbocarrera.SelectedIndex = -1;
            txtnrocursos.Focus();

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if(txtcodigo.Text!="")
            {
                objalumno = objarreglo.Buscar_por_codigo(Convert.ToInt32(txtcodigo.Text));
                if(objalumno!=null)
                {
                    MessageBox.Show(objalumno.Nombre);
                }
            }
        }

        private void btncontar_Click(object sender, EventArgs e)
        {
            if(cbocarrera.SelectedIndex !=-1)
            {
                int cantidadxcarrera = objarreglo.Contar_por_carrera(cbocarrera.Text);
                MessageBox.Show(cantidadxcarrera.ToString());

            }
        }
    }




}
