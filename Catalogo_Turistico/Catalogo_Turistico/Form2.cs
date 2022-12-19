using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassTurismo;

namespace Catalogo_Turistico
{
    public partial class Form2 : Form
    {
        CatalogoTuristico catalogo = new CatalogoTuristico();
        int localidad = -1;
        string[] NombresLugares = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                UnLugarTuristico NuevoLugar = new UnLugarTuristico();
                NuevoLugar.NombreLugar = txtNombreLugar.Text;
                NuevoLugar.Indicaciones = txtIndicaciones.Text;
                NuevoLugar.Reseña = txtReseña.Text;
                NuevoLugar.TiempoDistancia = Convert.ToInt32(txtTiempo.Text);
                MessageBox.Show(catalogo.InsertarUnLugar(NuevoLugar));
                txtNombreLugar.Clear(); txtTiempo.Clear();
                txtReseña.Clear(); txtIndicaciones.Clear();
                NombresLugares = catalogo.MostrarNombresLugar();
            }
            catch (FormatException)
            {
                MessageBox.Show("Campos con formato incorrecto", "Error");
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string[] NombresLugares = null;
            NombresLugares = catalogo.MostrarNombresLugar();

            cmbNombresTuris.Items.Clear();

            foreach (string Nombres in NombresLugares)
            {
                cmbNombresTuris.Items.Add(Nombres);
            }
        }
        private void cmbNombresTuris_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(catalogo.BuscarLocalidad_porNombre(cmbNombresTuris.SelectedItem.ToString(), ref localidad));
            UnLugarTuristico recibir = null;

            if (localidad >= 0)
            {
                recibir = catalogo.DevolverDatos(localidad);
                txtNombreRecu.Text = recibir.NombreLugar;
                txtIndicacionesRecu.Text = recibir.Indicaciones;
                txtResenaRecu.Text = recibir.Reseña;
                txtTiempoRecu.Text = recibir.TiempoDistancia.ToString();
            }
        }
        private void btnFormularioFotos_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(ref catalogo, ref NombresLugares);
            f3.ShowDialog();
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(ref catalogo, ref NombresLugares);
            f4.ShowDialog();
            Form2 f2 = new Form2();
            f2.Close();
        }

        private void txtNombreLugar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                UnLugarTuristico Cambios = new UnLugarTuristico();
                Cambios.NombreLugar = txtNombreRecu.Text;
                Cambios.TiempoDistancia = Convert.ToInt32(txtTiempoRecu.Text);
                Cambios.Indicaciones = txtIndicacionesRecu.Text;
                Cambios.Reseña = txtResenaRecu.Text;
                MessageBox.Show(catalogo.ModificarUnLugarTuristico(cmbNombresTuris.SelectedIndex, Cambios));
            }
            catch (FormatException)
            {
                MessageBox.Show("Campos con formato incorrecto", "Error");
            }

            
        }
        private void btnModifiColec_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(ref catalogo, ref NombresLugares);
            f5.ShowDialog();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(catalogo.EliminarUnLugarTuristico(cmbNombresTuris.SelectedIndex)); 
        }
    }
}
