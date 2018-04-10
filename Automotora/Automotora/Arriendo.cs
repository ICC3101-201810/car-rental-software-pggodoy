using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotora
{
    public class Arriendo
    {
        public Cliente cliente;
        public Vehiculo vehiculo;
        public Sucursal sucursal;
        public List<Accesorio> accesorios;
        public DateTime f_inicio, f_termino;
        public int suma_total;

        public Arriendo(Cliente Icliente, Vehiculo Ivehiculo, Sucursal Isucursal, List<Accesorio> Iaccesorios, DateTime If_inicio, DateTime If_termino, int Isuma_total)
        {
            cliente = Icliente;
            vehiculo = Ivehiculo;
            sucursal = Isucursal;
            accesorios = Iaccesorios;
            f_inicio = If_inicio;
            f_termino = If_termino;
            suma_total = Isuma_total;

        }
    }
}
