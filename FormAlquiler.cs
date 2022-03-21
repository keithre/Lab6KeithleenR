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

namespace Lab6KeithleenR
{
    public partial class FormAlquiler : Form
    {
        List<Alquiler> alquileres = new List<Alquiler>();
        List<Cliente> clientes = new List<Cliente>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Mostrar> datos = new List<Mostrar>();
        public FormAlquiler()
        {
            InitializeComponent();
        }
        private void CargarVehiculos()
        {
            FileStream stream = new FileStream("Vehiculos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Placa = reader.ReadLine();
                vehiculo.Marca = reader.ReadLine();
                vehiculo.Modelo = Convert.ToInt16(reader.ReadLine());
                vehiculo.Color = reader.ReadLine();
                vehiculo.PrecioK = Convert.ToDecimal(reader.ReadLine());
                vehiculos.Add(vehiculo);
            }
           
            reader.Close();
        }

        private void CargarClientes()
        {
            FileStream stream = new FileStream("Clientes.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Cliente cliente = new Cliente();
                cliente.NIT = reader.ReadLine();
                cliente.Nombre = reader.ReadLine();
                cliente.Direccion = reader.ReadLine();
                clientes.Add(cliente);
            }

            reader.Close();
        }
        private void CargarAlquileres()
        {
            FileStream stream = new FileStream("Alquileres.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Alquiler alquiler = new Alquiler();
                alquiler.NIT = reader.ReadLine();
                alquiler.Placa = reader.ReadLine();
                alquiler.KmRecorridos = Convert.ToInt16(reader.ReadLine());
                alquiler.FechaAlquiler = Convert.ToDateTime(reader.ReadLine());
                alquiler.FechaDevolucion = Convert.ToDateTime(reader.ReadLine());
                alquileres.Add(alquiler);
            }

            reader.Close();
        }

        private void GuardarAlquileres()
        {
            FileStream stream = new FileStream("Alquileres.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var alquiler in alquileres)
            {
                writer.WriteLine(alquiler.NIT);
                writer.WriteLine(alquiler.Placa);
                writer.WriteLine(alquiler.KmRecorridos);
                writer.WriteLine(alquiler.FechaAlquiler);
                writer.WriteLine(alquiler.FechaDevolucion);
            }

            writer.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Alquiler alquiler = new Alquiler();
            alquiler.NIT = txtNIT.Text;
            alquiler.Placa = txtPlaca.Text;
            alquiler.KmRecorridos = Convert.ToInt16(TxtKm.Text);
            alquiler.FechaAlquiler = FechaPrestamo.Value;
            alquiler.FechaDevolucion = FechaDevolucion.Value;
            alquileres.Add(alquiler);
            GuardarAlquileres();
            txtNIT.Text = "";
            txtPlaca.Text = "";
            TxtKm.Text = Convert.ToString("");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alquileres.Count; i++)
            {
                Mostrar mostrar = new Mostrar();

                for (int j = 0; j < clientes.Count; j++)
                {

                    if (alquileres[i].NIT == clientes[j].NIT)
                    {
                        mostrar.Nombre = clientes[j].Nombre;
                        mostrar.FechaDevolucion = alquileres[i].FechaDevolucion;

                    }

                    for (int k = 0; k < vehiculos.Count; k++)
                    {
                        if(alquileres[i].Placa == vehiculos[k].Placa)
                        {
                            mostrar.Placa = vehiculos[k].Placa;
                            mostrar.Modelo = vehiculos[k].Modelo;
                            mostrar.PagoTotal = vehiculos[k].PrecioK * alquileres[i].KmRecorridos;
                        }
                    }
                    datos.Add(mostrar);
                    dataGridViewResumen.DataSource = null;
                    dataGridViewResumen.Refresh();
                    dataGridViewResumen.DataSource = datos;
                    dataGridViewResumen.Refresh();
                }
            }
        }

        private void FormAlquiler_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarVehiculos();
            dataGridVehiculos.DataSource = vehiculos;
            dataGridVehiculos.Refresh();
            CargarAlquileres();
            dataGridalquileres.DataSource = alquileres;
            dataGridalquileres.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
