using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventass
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Luis Lopez";
            cliente1.Telefono = 98745621;
            cliente1.Ciudad = "San Pedro Sula";

            var cliente2 = new Cliente();
            cliente2.Id = 1;
            cliente2.Nombre = "Carlos Lopez";
            cliente2.Telefono = 96582314;
            cliente2.Ciudad = "Choloma";

            var listadeProductos = new List<Cliente>();
            listadeProductos.Add(cliente1);
            listadeProductos.Add(cliente2);

            foreach (var cliente in listadeProductos)
            {
                MessageBox.Show(cliente.Nombre + " " + cliente.Ciudad);
            }
        }
     }
  }
