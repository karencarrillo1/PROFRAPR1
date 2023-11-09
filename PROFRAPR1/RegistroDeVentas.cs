using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROFRAPR1
{
    public partial class RegistroDeVentas : Form
    {
        public RegistroDeVentas()
        {
            InitializeComponent();
        }

        private void RegistroDeVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'registrosDataSet1.RegistroDeVenta' Puede moverla o quitarla según sea necesario.
            this.registroDeVentaTableAdapter.Fill(this.registrosDataSet1.RegistroDeVenta);

        }


        private void button8_Click(object sender, EventArgs e)
        {
            RegistroDeProducto ventanaRegistroDeProducto = new RegistroDeProducto();
            ventanaRegistroDeProducto.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
