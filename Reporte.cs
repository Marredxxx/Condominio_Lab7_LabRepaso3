using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio_Lab7_LabRepaso3
{
    internal class Reporte
    {
        string dpi;
        string nombre;
        string apellido;
        string numCasa;
        double cuota;

        public string Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string NumCasa { get => numCasa; set => numCasa = value; }
        public double Cuota { get => cuota; set => cuota = value; }
    }
}
