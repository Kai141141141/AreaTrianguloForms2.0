using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTrianguloForms2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {

        }

        private void bntCal_Click(object sender, EventArgs e)
        {
            try
            {
                //Obter dados:
                double basee = double.Parse(txbBase.Text);
                double haltura = double.Parse(txbAltura.Text);

                double resultado = (basee * haltura) / 2;

                //Exibir resultado:

                lblRes.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Resultado inválido, não ouve dados informados!");
                //Limpar os dados:
                lblRes.Clear();
                txbAltura.Clear();
                txbBase.Clear();


            }
        }
    }
}
