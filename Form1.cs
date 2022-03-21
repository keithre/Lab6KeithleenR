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
    public partial class Form1 : Form
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void GuardarVehiculo()
        {
            FileStream stream = new FileStream("Vehiculos.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var vehiculo in vehiculos)
            {
                writer.WriteLine(vehiculo.Placa);
                writer.WriteLine(vehiculo.Marca);
                writer.WriteLine(vehiculo.Modelo);
                writer.WriteLine(vehiculo.Color);
                writer.WriteLine(vehiculo.PrecioK);
            }
            
            writer.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Placa = txtPlaca.Text;
            vehiculo.Marca = txtMarca.Text;
            vehiculo.Color = txtColor.Text;
            vehiculo.PrecioK = Convert.ToDecimal(txtPrecio.Text);
            vehiculo.Modelo = Convert.ToInt16(txtModelo.Text);

            int pos = vehiculos.FindIndex(x => x.Placa == vehiculo.Placa);
            if(pos == -1)
            {
                vehiculos.Add(vehiculo);
                GuardarVehiculo();
            }
            else
            {
                MessageBox.Show("Placa repetida");
            }
            txtPlaca.Text = "";
            txtMarca.Text = "";
            txtColor.Text = "";
            txtPrecio.Text = Convert.ToString("");
            txtModelo.Text = Convert.ToString("");
        }

        private void btnAlquileres_Click(object sender, EventArgs e)
        {
            FormAlquiler form = new FormAlquiler();
            form.Show();
        }
    }
}
