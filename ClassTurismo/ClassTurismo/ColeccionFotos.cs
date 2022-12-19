using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassTurismo
{
    public class ColeccionFotos
    {
        private FotoTuristica[] coleccion = new FotoTuristica[9];
        short control = 0;

        public string InsertarFotoDescrip(FotoTuristica nuevo)
        {
            string msj = "";
            if (control <= coleccion.Length - 1)
            {
                coleccion[control] = nuevo;
                control++;
                msj = "Ya se inserto una nueva foto";
            }
            else
            {
                msj = "Ya no caben mas imagenes";
            }
            return msj;
        }

        public string ModificarDatos(int posicion, FotoTuristica nuevoModi)
        {
            string msj = "";
            if (posicion >= 0)
            {
                coleccion[posicion] = nuevoModi;
                msj = "Se han guardado los cambios";
            }
            else
            {
                msj = "Los cambias no se han podido realizar";
            }
            return msj;
        }

        public string EliminarDatos(int Posicion)
        {
            string msj = "";
            int fin = control - 1;
            if (Posicion >= 0)
            {
                for (int i = Posicion; i <= fin; i++)
                {
                    coleccion[i] = coleccion[i + 1];
                }
                control--;
                msj = "La colección se ha eliminado";
            }
            else
            {
                msj = "No se ha podido eliminar la colección";
            }
            return msj;
        }
        public FotoTuristica DevolverDatosPosicion(int LocalidadColeccion)
        {
            FotoTuristica DevolverDatos = null;

            if (LocalidadColeccion >= 0)
            {
                DevolverDatos = coleccion[LocalidadColeccion];
            }
            return DevolverDatos;
        }
        public string[] MostrarNombresLugarRef()
        {
            string[] Descripcion = new string[control];
            int j = 0;
            for (j = 0; j <= control - 1; j++)
            {
                Descripcion[j] = coleccion[j].Descripcion;
            }
            return Descripcion;
        }
        public Image DevolverImagen_Referencia(int posFoto)
        {
            Image Foto_Coleccion = null;
            Foto_Coleccion = coleccion[posFoto].ImagendeLugar();
            return Foto_Coleccion;
        }
        public int DevolverTamañoArreglo()
        {
            int Tamaño = 0;
            Tamaño = control;
            return Tamaño;
        }
    }//FIN CLASS
}//FIN NAMESPACE
