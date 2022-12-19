using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassTurismo
{
    public class FotoTuristica
    {
        private Image FotoLugar = null;
        public string Descripcion { get; set; }

        public void CargarImagen(Image cargada)
        {
            FotoLugar = cargada;
        }
        public Image ImagendeLugar()
        {
            return FotoLugar;
        }

        
    }
}
