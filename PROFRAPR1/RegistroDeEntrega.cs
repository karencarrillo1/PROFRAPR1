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
    public partial class RegistroDeEntrega : Form
    {
        public RegistroDeEntrega()
        {
            InitializeComponent();
        }

        private void RegistroDeEntrega_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'registrosDataSet4.RegistroDeEntrega' Puede moverla o quitarla según sea necesario.
            this.registroDeEntregaTableAdapter1.Fill(this.registrosDataSet4.RegistroDeEntrega);
            // TODO: esta línea de código carga datos en la tabla 'registrosDataSet3.RegistroDeEntrega' Puede moverla o quitarla según sea necesario.
            this.registroDeEntregaTableAdapter.Fill(this.registrosDataSet3.RegistroDeEntrega);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegistroDePago ventanaRegistroDePago = new RegistroDePago();
            ventanaRegistroDePago.ShowDialog();

        }
    }
}
