using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condominio_Lab7_LabRepaso3
{
    public partial class Form1 : Form
    {
        List<Propietario> propietarios = new List<Propietario>();
        List<Propiedad> propiedades = new List<Propiedad>();
        List<Reporte> reportes = new List<Reporte>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerDatos();
        }

        private void LeerDatos()
        {
            {
                FileStream stream = new FileStream("propietarios.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Propietario propietario = new Propietario();
                    propietario.Dpi = reader.ReadLine();
                    propietario.Nombre = reader.ReadLine();
                    propietario.Apellido = reader.ReadLine();
                    propietarios.Add(propietario);
                }
                reader.Close();
            }

            {
                FileStream stream = new FileStream("propiedades.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Propiedad propiedad = new Propiedad();
                    propiedad.NumCasa = reader.ReadLine();
                    propiedad.Dpi = reader.ReadLine();
                    propiedad.Cuota = Convert.ToDouble(reader.ReadLine());
                    propiedades.Add(propiedad);
                }
                reader.Close();
            }
        }
        
        private void MostrarDatos(bool ordenada = false)
        {
            reportes.Clear();

            foreach (var propiedad in propiedades) 
            { 
                Reporte reporte = new Reporte();
                Propietario propietario = propietarios.Find(p => p.Dpi == propiedad.Dpi);
                reporte.Dpi = propietario.Dpi;
                reporte.Nombre = propietario.Nombre;
                reporte.Apellido = propietario.Apellido;
                reporte.NumCasa = propiedad.NumCasa;
                reporte.Cuota = propiedad.Cuota;
                reportes.Add(reporte);

            }

            if (ordenada) reportes = reportes.OrderBy(r => r.Cuota).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reportes;

        }

        private void buttonCargarDatos_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void buttonOrdenarxCuotas_Click(object sender, EventArgs e)
        {
            MostrarDatos(true);
        }

        private void buttonPropietarioMasCuotas_Click(object sender, EventArgs e)
        {
            MostrarDatos(true);//lista ordenada
            int ctcuotas = reportes.Count;//contar cuantas cuotas son
            labelCuotaBaja.Text = "*Más bajas: " + reportes[0].Cuota.ToString() + " - " + reportes[1].Cuota.ToString() + " - " + reportes[2].Cuota.ToString();// ordenado de menor a mayor las bajas estan en la posicion 0-1-2
            labelCuotaAlta.Text = "Más Altas: " + reportes[ctcuotas - 1].Cuota.ToString() + " - " + reportes[ctcuotas - 2].Cuota.ToString() + " - " + reportes[ctcuotas - 3].Cuota.ToString();//ordenado de menor a mayor las ultimas 3 son las mayores
        }

        private void buttonPropMasAlta_Click(object sender, EventArgs e)
        {
            {
                var agrupado = reportes.GroupBy(r => r.Dpi);

                double maxCuota = 0;
                string maxDpi = "";

                foreach (var grupo in agrupado)//Recorrer cada dato agrupado
                {

                    double sumaCuota = 0;
                    string dpi = "";

                    foreach (var p in grupo)
                    {
                        sumaCuota += p.Cuota;
                        dpi = p.Dpi;
                    }

                    if (sumaCuota > maxCuota)
                    {
                        maxCuota = sumaCuota;
                        maxDpi = dpi;
                    }
                }
                labelPropietario.Text = maxDpi;
                labelCuotaAcumulada.Text = maxCuota.ToString();
            }
        }
    }
}
