using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fmrPrimerClase
{
    public partial class Form1 : Form
    {
        private int valorCalculado = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            valorCalculado = Convert.ToInt32(this.txtNumeroUno.Text) + Convert.ToInt32(this.txtNumeroDos.Text);

            // El Sigo $ Permite junto con las llaves mostrar el valor de una variable
            // Sin el signo no lo permite

            //MessageBox.Show("La Suma Es: " + valorCalculado);

            MessageBox.Show($"La Suma Es: {valorCalculado}");
        }

    }
}
