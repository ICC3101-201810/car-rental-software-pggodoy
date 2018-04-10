using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotora
{
    public abstract class Vehiculo
    {
        public static int P_ID = 0;
        public string marca;
        public Vehiculo()
        {
        }
    }

    public class Auto : Vehiculo
    {
        public int ID;

        public Auto(string Imarca)
        {
            marca = Imarca;
            ID = P_ID;
            P_ID++;
        }
    }
    public class Acuatico : Vehiculo
    {
        public int ID;

        public Acuatico(string Imarca)
        {
            marca = Imarca;
            ID = P_ID;
            P_ID++;
        }
    }
    public class Moto : Vehiculo
    {
        public int ID;

        public Moto(string Imarca)
        {
            marca = Imarca;
            ID = P_ID;
            P_ID++;
        }
    }
    public class Camion : Vehiculo
    {
        public int ID;

        public Camion(string Imarca)
        {
            marca = Imarca;
            ID = P_ID;
            P_ID++;
        }
    }
    public class Bus : Vehiculo
    {
        public int ID;

        public Bus(string Imarca)
        {
            marca = Imarca;
            ID = P_ID;
            P_ID++;
        }
    }
    public class M_Pesada : Vehiculo
    {
        public int ID;

        public M_Pesada(string Imarca)
        {
            marca = Imarca;
            ID = P_ID;
            P_ID++;
        }
    }
}
