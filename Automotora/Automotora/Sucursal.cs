using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotora
{
    public class Sucursal
    {
        public string nombre;
        public List<Auto> autos = new List<Auto>() { };
        public List<Acuatico> acuaticos = new List<Acuatico>() { };
        public List<Moto> motos = new List<Moto>() { };
        public List<Camion> camiones = new List<Camion>() { };
        public List<Bus> buses = new List<Bus>() { };
        public List<M_Pesada> m_pesadas  = new List<M_Pesada>() { };

        public Sucursal(string nomb)
        {
            nombre = nomb;
        }

        public void agregar_vehiculo()
        {
        }

    }
}
