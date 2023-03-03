using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3deMarzo.Algoritmos.Models
{
    public class Demanda
    {
        public string IdCliente { get; set; }
        public string IdProducto { get; set; }
        public double Cantidad { get; set; }
        public Demanda() { }    

        public Demanda( string idCliente, string idProducto, double Cantidad)
        {
            IdCliente = idCliente;
            IdProducto = idProducto;
            Cantidad = Cantidad;
        }
    }
}
