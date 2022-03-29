using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Double  peso , altura , resultado, imc; 

        public Form1()
        {
            InitializeComponent();
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
           if (!Double.TryParse(txtAltura.Text, out altura))
           {

           
               MessageBox.Show("Altura Inválida");
             // txtAltura.Focus();
           }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtAltura.Text, out altura))
            {


                MessageBox.Show("Altura Inválido");
                // txtAltura.Focus();
            }
            else

                if (!Double.TryParse(txtPeso.Text, out peso))
                {
                    MessageBox.Show("Peso Inválido");
                    //txtPeso.Focus();
                }
                else

                   imc = altura / peso * peso;

                txtResultado.Text = resultado.ToString()

                
        }

        private void txtPeso_Validated(object sender, EventArgs e)
        {
           if (!Double.TryParse(txtPeso.Text, out peso))
           {
               MessageBox.Show("Peso Inválido");
               //txtPeso.Focus();
           }
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text("");

            txtPeso.Text("");

            txtResultado.Text("");
           
        }
    }
}
