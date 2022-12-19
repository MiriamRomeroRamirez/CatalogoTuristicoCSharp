using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassTurismo
{
    public class UnLugarTuristico
    {
        public string NombreLugar { get; set; }
        public int TiempoDistancia { get; set; }
        public string Indicaciones { get; set; }
        public string Reseña { get; set; }

        private ColeccionFotos coleccionLugar = new ColeccionFotos();

        public string AgImagenDesc_Coleccion(FotoTuristica ParaColeccion)
        {
            return coleccionLugar.InsertarFotoDescrip(ParaColeccion);
        }
        public string Modificar_Coleccion(int posicion, FotoTuristica nuevaModi)
        {
            return coleccionLugar.ModificarDatos(posicion, nuevaModi);
        }
        public string Eliminar_Coleccion(int posicion)
        {
            return coleccionLugar.EliminarDatos(posicion);
        }
        public FotoTuristica MostrarReferencias(int localidadColeccion)
        {
            return coleccionLugar.DevolverDatosPosicion(localidadColeccion);
        }
        public string[] NombresLugarRef()
        {
            return coleccionLugar.MostrarNombresLugarRef();
        }
        public Image ImagenPorPosicion(int Posicion)
        {
            return coleccionLugar.DevolverImagen_Referencia(Posicion);
        }
    }
}
