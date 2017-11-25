using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado abrir = new Empleado();

            abrir.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea Salir del Menu - Listado ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {

                return;



            }

            this.Dispose();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Cargo  abrir = new Cargo();

            abrir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nomina  abrir = new Nomina ();

            abrir.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Detalle_Nomina  abrir = new  Detalle_Nomina ();

            abrir.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Consultar abrir = new Consultar();

            abrir.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
