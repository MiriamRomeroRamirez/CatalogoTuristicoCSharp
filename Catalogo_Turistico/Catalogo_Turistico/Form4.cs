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
    public partial class Form4 : Form
    {
        CatalogoTuristico CatalogoCompleto = null;
        string[] NombresLugares = null, NombresReferencia = null;
        int localidad = -1, control = 0;
        FotoTuristica Datos = null;
        public Form4(ref CatalogoTuristico CatalogoCopia, ref string[] Nombres)
        {
            InitializeComponent();
            CatalogoCompleto = CatalogoCopia;
            NombresLugares = Nombres;
        }
        private void listNombresReferentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image ImagenDevuleta = null;
            ImagenDevuleta = CatalogoCompleto.MostrarImagenReferencia(cmbLugaresCatalogo.SelectedIndex, listNombresReferentes.SelectedIndex);
            picFotoColeccion.Image = ImagenDevuleta;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            string[] NombresLugares = null;
            NombresLugares = CatalogoCompleto.MostrarNombresLugar();
            cmbLugaresCatalogo.Items.Clear();
            foreach (string Nombres in NombresLugares)
            {
                cmbLugaresCatalogo.Items.Add(Nombres);
            }
        }
        private void cmbLugaresCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(CatalogoCompleto.BuscarLocalidad_porNombre(cmbLugaresCatalogo.SelectedItem.ToString(), ref localidad));
            UnLugarTuristico recibir = null;
            if (localidad >= 0)
            {
                panel2.Visible = true;
                recibir = CatalogoCompleto.DevolverDatos(localidad);
                lblNombreLugar.Text = recibir.NombreLugar;
                txtIndicaciones.Text = recibir.Indicaciones;
                txtReseña.Text = recibir.Reseña;
                txtTiempo.Text = recibir.TiempoDistancia.ToString();
                Datos = CatalogoCompleto.DevolverImagenesPorPosicion(cmbLugaresCatalogo.SelectedIndex, control);
                NombresReferencia = CatalogoCompleto.MostrarNombreRefPosicion(cmbLugaresCatalogo.SelectedIndex);
                listNombresReferentes.Items.Clear();
                foreach (string Nombres in NombresReferencia)
                {
                    listNombresReferentes.Items.Add(Nombres);
                }
            }
        }
    }
}
