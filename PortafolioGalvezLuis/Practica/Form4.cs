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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCant.Clear();
            txtPrecio.Clear();
            txtIva.Clear();
            txtSubtotal.Clear();
            txtPago.Clear();
            cbbLibro.SelectedItem = null;
            txtPrecio.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cbbLibro.SelectedItem.Equals(null))
            {
                MessageBox.Show("Debe elegir el titulo del libro que desea comprar entre los disponibles", "Libro no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    double Precio = Convert.ToDouble(txtPrecio.Text), Pago, Sub, IVA;
                    int Cant = Convert.ToInt32(txtCant.Text);
                    if (Precio > 0 && Cant > 0)
                    {
                        Sub = Cant * Precio;
                        IVA = Sub * 0.13;
                        Pago = Sub + IVA;
                    }
                    else
                    {
                        MessageBox.Show("Revise que el precio o la cantidad ingresada correspondan a un número valido mayor a 0", "Datos no encontrados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Los datos ingresados no corresponden a números u otro tipo de equivalente valido", "Datos no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
