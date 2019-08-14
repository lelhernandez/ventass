using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var heroe1 = new SuperPoderes();
            heroe1.NombreHeroe = "Superman";
            heroe1.NombreVillano = "Lex Lutor";

            var heroe2 = new SuperPoderes();
            heroe2.NombreHeroe = "Batman";
            heroe2.NombreVillano = "Wason";

            var heroe3 = new SuperPoderes();
            heroe3.NombreHeroe = "Spiderman";
            heroe3.NombreVillano = "El Duende Verde";

            var listadeHeroes = new List<SuperPoderes>();
            listadeHeroes.Add(heroe1);
            listadeHeroes.Add(heroe2);
            listadeHeroes.Add(heroe3);

            foreach(var heroe in listadeHeroes)
            {
                MessageBox.Show(heroe.NombreHeroe);
                MessageBox.Show(heroe.NombreVillano);
            }
        }
    }
}
