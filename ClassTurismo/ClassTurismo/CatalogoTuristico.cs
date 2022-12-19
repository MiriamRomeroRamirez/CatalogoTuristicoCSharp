using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassTurismo
{
    public class CatalogoTuristico
    {
        private UnLugarTuristico[] LugarTuris = new UnLugarTuristico[15];
        private short control = 0;

        private ColeccionFotos Lacoleccion = new ColeccionFotos();
        public string InsertarUnLugar(UnLugarTuristico nuevo)
        {
            string mensaje = "";
            if (control <= LugarTuris.Length - 1)
            {
                LugarTuris[control] = nuevo;
                control++;
                mensaje = "Se agrego un nuevo lugar turistico";
            }
            else
            {
                mensaje = "Ya no se pueden agregar más lugares turísticos";
            }
            return mensaje;
        }
        public string[] MostrarNombresLugar()
        {
            string[] NombreLugar = new string[control];
            int j = 0;
            for (j = 0; j <= control - 1; j++)
            {
                NombreLugar[j] = LugarTuris[j].NombreLugar;
            }
            return NombreLugar;
        }
        public string BuscarLocalidad_porNombre(string NombreBuscar, ref int localidad)
        {
            string mensaje = "";
            int ini = 0;
            int fin = control - 1;
            localidad = -1;

            for (ini = 0; ini <= fin; ini++)
            {
                if (LugarTuris[ini].NombreLugar == NombreBuscar)
                {
                    localidad = ini;
                }
            }

            if (localidad < 0)
            {
                mensaje = "No se encontro";
            }
            else
            {
                mensaje = "Se encontro el objeto en la localidad " + localidad;
            }
            return mensaje;
        }
        public string ModificarUnLugarTuristico(int posicionLugarModi, UnLugarTuristico nuevo)
        {
            string mensaje = "";
            if (posicionLugarModi >= 0)
            {
                LugarTuris[posicionLugarModi] = nuevo;
                mensaje = "Se ha modificado el lugar turístico";
            }
            else
            {
                mensaje = "Posicion invalida";
            }
            return mensaje;
        }
        public string EliminarUnLugarTuristico(int PosicionLugar)
        {
            string mensaje = "";
            int fin = control - 1;
            if (PosicionLugar >= 0)
            {
                for (int i = PosicionLugar; i <= fin; i++)
                {
                    LugarTuris[i] = LugarTuris[i + 1];
                }
                control--;
                mensaje = "El lugar turístico ha sido eliminado";
            }
            else
            {
                mensaje = "No se puede eliminar el lugar turístico";
            }
            return mensaje;
        }
        //Metodos para insertar, modificar y eliminar una coleccion de Datos para FOTOTURISTICA
        public string InsertarColeccionFotos_localidad(int localidad, FotoTuristica nuevo)
        {
            string mensaje = "";
            if (localidad >= 0)
            {
                mensaje = LugarTuris[localidad].AgImagenDesc_Coleccion(nuevo);
            }
            else
            {
                mensaje = "Esta dando una posición NO VALIDA";
            }
            return mensaje;
        }
        public string ModificarInformacionReferente(int posicionLugar, int PosicionDatos, FotoTuristica nuevo)
        {
            return LugarTuris[posicionLugar].Modificar_Coleccion(PosicionDatos, nuevo);
        }
        public string EliminarColeccion_Referencias(int posicionLugar, int PosicionDatos)
        {
            return LugarTuris[posicionLugar].Eliminar_Coleccion(PosicionDatos);
        }
        public string[] MostrarNombreRefPosicion(int posicion)
        {
            return LugarTuris[posicion].NombresLugarRef();
        }
        public Image MostrarImagenReferencia(int posLugar, int PosImage)
        {
            return LugarTuris[posLugar].ImagenPorPosicion(PosImage);
        }
        //Metodos que devuelven objetos 
        public FotoTuristica DevolverImagenesPorPosicion(int LocalidadLugar, int LocalidadFoto)
        {
            FotoTuristica Devolver = null;
            if (LocalidadLugar >= 0 && LocalidadFoto >= 0)
            {
                Devolver = LugarTuris[LocalidadLugar].MostrarReferencias(LocalidadFoto);
            }
            return Devolver;
        }
        public UnLugarTuristico DevolverDatos(int localidad)
        {
            UnLugarTuristico DatosTuristicos = null;
            if (localidad <= control)
            {
                DatosTuristicos = LugarTuris[localidad];
            }
            return DatosTuristicos;
        }
        public int TamañoArregloFotos()
        {
            return Lacoleccion.DevolverTamañoArreglo();
        }
    }
}
