using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotora
{
    public class Persona : Cliente
    {
        string nombre;
        List<string> licencias = new List<string>() { };

        public Persona(string Nombre)
        {
            nombre = Nombre;
        }

        void agregar_licencia(string Ilicencia)
        {
            licencias.Add(Ilicencia);
        }
    }
}
