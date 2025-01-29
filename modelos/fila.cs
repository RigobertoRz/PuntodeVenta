using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTienda.modelos
{
    public class fila
    {
        public int orden { get; set; }
        public double Precio => Cantidad * preciounidad;
        public string Precioconformato => Precio.ToString("C");
        public double Cantidad { get; set; }
        public string CantidadconFormato => Cantidad.ToString("");
        public string nombre { get; set; }
        //public int Unidades { get; set; }
        public double preciounidad { get; set; }
        public string preciounitarioconformato => preciounidad.ToString("C");


    }
}
