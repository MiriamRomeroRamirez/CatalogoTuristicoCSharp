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
    public partial class Form5 : Form
    {
        CatalogoTuristico copiCatalogo = null;
        string[] NombresLugares = null;
        public Form5(ref CatalogoTuristico copiaCatalogo, ref string[] NombresCopia)
        {
            InitializeComponent();
            copiCatalogo = copiaCatalogo;
            NombresLugares = NombresCopia;
        }
        private void listLugaresReferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            FotoTuristica objeto = null;
            objeto = copiCatalogo.DevolverImagenesPorPosicion(listNombresTuri.SelectedIndex, listLugaresReferencia.SelectedIndex);
            txtNombreRef.Text = objeto.Descripcion;
            picFotoColeccionRef.Image = objeto.ImagendeLugar();
        }
        private void listNombresTuri_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] NombresReferencia = null;
            NombresReferencia = copiCatalogo.MostrarNombreRefPosicion(listNombresTuri.SelectedIndex);
            listLugaresReferencia.Items.Clear();
            foreach (string Referencias in NombresReferencia)
            {
                listLugaresReferencia.Items.Add(Referencias);
            }
        }
        private void btnCambiarFoto_Click(object sender, EventArgs e)
        {
            Image temporal = null;
            if (oflNuevaFoto.ShowDialog() == DialogResult.OK)
            {
                temporal = Image.FromFile(oflNuevaFoto.FileName);
            }
            else
            {
                temporal = null;
            }
            picFotoColeccionRef.Image = temporal;
        }
        private void btnModificar1_Click(object sender, EventArgs e)
        {
            FotoTuristica NuevoCambio = new FotoTuristica();
            NuevoCambio.Descripcion = txtNombreRef.Text;
            NuevoCambio.CargarImagen(picFotoColeccionRef.Image);
            MessageBox.Show(copiCatalogo.ModificarInformacionReferente(listNombresTuri.SelectedIndex, 
                listLugaresReferencia.SelectedIndex, NuevoCambio)); 
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            string[] NombresLugares = null;
            NombresLugares = copiCatalogo.MostrarNombresLugar();
            listNombresTuri.Items.Clear();
            foreach (string Nombres in NombresLugares)
            {
                listNombresTuri.Items.Add(Nombres);
            }
        }
        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(copiCatalogo.EliminarColeccion_Referencias(listNombresTuri.SelectedIndex, 
                listLugaresReferencia.SelectedIndex));
        }
    }
}
