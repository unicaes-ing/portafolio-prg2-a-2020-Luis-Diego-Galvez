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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInversion1.Clear();
            txtInversion2.Clear();
            txtInversion3.Clear();
            txtPer1.Clear();
            txtPer2.Clear();
            txtPer3.Clear();
            txtTotal.Clear();
            txtInversion1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double Inv1 = Convert.ToDouble(txtInversion1.Text), Inv2 = Convert.ToDouble(txtInversion2.Text), Inv3 = Convert.ToDouble(txtInversion3.Text), P1, P2, P3, Total;
                if ((Inv1 > 0 && Inv2 > 0) && Inv3 > 0)
                {
                    Total = Inv1 + Inv2 + Inv3;
                    P1 = Inv1 / Total;
                    P2 = Inv2 / Total;
                    P3 = Inv3 / Total;
                    txtPer1.Text = P1.ToString("P2");
                    txtPer2.Text = P2.ToString("P2");
                    txtPer3.Text = P3.ToString("P2");
                    txtTotal.Text = Total.ToString("C2");
                }
                else
                {
                    MessageBox.Show("Los números ingresados deben corresponder a cantidades positivas de dinero, favor revisar la información", "Datos no validos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Los datos ingresados deben ser números reales", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
