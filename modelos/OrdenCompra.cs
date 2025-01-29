using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTienda.modelos
{
    public class OrdenCompra
    {
        public string fecha { get; set; }

        public string orden { get; set; }

        public string empresa{ get; set; }

        public string razon_social { get; set; }

        public string calle { get; set; }

        public string Numero { get; set; }

        public string Colonia { get; set; }

        public string CP { get; set; }

        public string telefono { get; set; }

        public string rfc { get; set; }

        public string comprador { get; set; }
        
        public string rfcempleado { get; set; }

        public IEnumerable<fila> Positions { get; set; }

        public double Precioincluyendoimpuestos => Preciosinimpuestos + Impuestos;

        public string Precioincluyendoimpuestosconformato => Precioincluyendoimpuestos.ToString("C");

        public double Preciosinimpuestos => Positions?.Sum(p => p.Precio) ?? 0;

        public string Preciosinimpuestosconformateo => Preciosinimpuestos.ToString("C");

        public double Impuestos => Preciosinimpuestos / 16;

        public string Impuestosconformato => Impuestos.ToString("C");
    }
}
