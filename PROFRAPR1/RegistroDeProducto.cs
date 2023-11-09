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
    public partial class RegistroDeProducto : Form
    {
        public RegistroDeProducto()
        {
            InitializeComponent();
        }

        private void RegistroDeProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'registrosDataSet2.RegistroDeProducto' Puede moverla o quitarla según sea necesario.
            this.registroDeProductoTableAdapter.Fill(this.registrosDataSet2.RegistroDeProducto);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegistroDeEntrega ventanaRegistroDeEntrega = new RegistroDeEntrega();
            ventanaRegistroDeEntrega.ShowDialog();


        }
    }
}
