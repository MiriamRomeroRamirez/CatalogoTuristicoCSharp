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
    public partial class Form3 : Form
    {
        CatalogoTuristico refCatalogo = null;
        string[] NombresLugares = null;
        public Form3(ref CatalogoTuristico copiaCatalogo, ref string[] Nombres)
        {
            InitializeComponent();
            refCatalogo = copiaCatalogo;
            NombresLugares = Nombres;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            cmbNombresTuris.Items.Clear();
            foreach (string Nombres in NombresLugares)
            {
                cmbNombresTuris.Items.Add(Nombres);
            }
        }
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            Image temporal = null;
            if (oflCargarImagen.ShowDialog() == DialogResult.OK)
            {
                temporal = Image.FromFile(oflCargarImagen.FileName);
            }
            else
            {
                temporal = null;
            }
            picImagenTuri.Image = temporal;
        }
        private void btnAgregarTuri_Click(object sender, EventArgs e)
        {
            FotoTuristica nuevo = new FotoTuristica();
            nuevo.CargarImagen(picImagenTuri.Image);
            nuevo.Descripcion = txtDescripcion.Text;
            int localidad = cmbNombresTuris.SelectedIndex;
            MessageBox.Show(refCatalogo.InsertarColeccionFotos_localidad(localidad, nuevo));
        }
    }
}
