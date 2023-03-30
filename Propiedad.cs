using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio_Lab7_LabRepaso3
{
    internal class Propiedad
    {
        string numCasa;
        string dpi;
        double cuota;

        public string NumCasa { get => numCasa; set => numCasa = value; }
        public string Dpi { get => dpi; set => dpi = value; }
        public double Cuota { get => cuota; set => cuota = value; }
    }
}
