using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtExa1.Clear();
            txtExa2.Clear();
            txtExa3.Clear();
            txtProm.Clear();
            txtExa1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double Nota1 = Convert.ToDouble(txtExa1.Text), Nota2 = Convert.ToDouble(txtExa2.Text), Nota3 = Convert.ToDouble(txtExa3.Text), Prom;
                if (((Nota1 >= 0 && Nota1 <= 10) && (Nota2 >= 0 && Nota2 <= 10)) && (Nota3 >= 0 && Nota3 <= 10))
                {
                    Prom = (Nota1 + Nota2 + Nota3) / 3;
                    txtProm.Text = Prom.ToString("N2");
                }
                else
                {
                    MessageBox.Show("Revise que las calificaciones que ha ingresado estan en el rango indicado (0 - 10)", "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Para el funcionamiento de la aplicación ingrese solo números", "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
