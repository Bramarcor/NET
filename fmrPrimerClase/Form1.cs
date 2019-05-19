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

        
        #region Evento Click
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //El Void indica que esta funcion no retorna ningun valor
            valorCalculado = sumarNumeros(this.txtNumeroUno.Text, this.txtNumeroDos.Text);

            // El Sigo $ Permite junto con las llaves mostrar el valor de una variable
            // Sin el signo no lo permite

            //MessageBox.Show("La Suma Es: " + valorCalculado);

            this.lblResultado.Text = $"Resultado de la suma Es: {valorCalculado}";
            this.lblResultado.Visible = true;
            
        }
        #endregion

        
        #region Metodo Suma
        private int sumarNumeros(string num1, string num2)
        {
            //el int antes de la funcion indica que va a retornar un valor entero
            int valorAuxiliar = 0;

            valorAuxiliar = Convert.ToInt32(num1) + Convert.ToInt32(num2);

            return valorAuxiliar;
        }

        #endregion
    }
}
