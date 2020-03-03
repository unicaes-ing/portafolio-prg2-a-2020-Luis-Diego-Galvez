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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDecimal.Clear();
            txtBin.Clear();
            txtOctal.Clear();
            txtHex.Clear();
            txtDecimal.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal Dec = Convert.ToDecimal(txtDecimal.Text);
                txtBin.Text = Convert.ToString(Dec, 2);
                txtOctal.Text = Convert.ToString(Dec, 8);
                txtHex.Text = Convert.ToString(Dec, 16);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
