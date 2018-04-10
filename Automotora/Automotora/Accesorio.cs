using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotora
{
    public class Accesorio
    {
        public static int P_ID;
    }

    public class Bluetooth : Accesorio
    {
        public int ID;

        Bluetooth()
        {
            ID = P_ID;
            P_ID++;
        }
    }

    public class GPS : Accesorio
    {
        public int ID;

        public GPS()
        {
            ID = P_ID;
            P_ID++;
        }
    }

    public class R_Repuesto : Accesorio
    {
        public int ID;

        R_Repuesto()
        {
            ID = P_ID;
            P_ID++;
        }
    }

    public class C_Ventana : Accesorio
    {
        public int ID;

        C_Ventana()
        {
            ID = P_ID;
            P_ID++;
        }
    }

    public class S_Infante : Accesorio
    {
        public int ID;

        S_Infante()
        {
            ID = P_ID;
            P_ID++;
        }
    }
}
