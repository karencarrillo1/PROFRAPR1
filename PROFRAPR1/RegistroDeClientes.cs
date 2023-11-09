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
    public partial class RegistroDeClientes : Form
    {
        public RegistroDeClientes()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'registrosDataSet5.RegistoDeClientes' Puede moverla o quitarla según sea necesario.
            this.registoDeClientesTableAdapter1.Fill(this.registrosDataSet5.RegistoDeClientes);
            // TODO: esta línea de código carga datos en la tabla 'registrosDataSet.RegistoDeClientes' Puede moverla o quitarla según sea necesario.
            this.registoDeClientesTableAdapter.Fill(this.registrosDataSet.RegistoDeClientes);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegistroDeVentas ventanaRegistroDeVenta = new RegistroDeVentas();
            ventanaRegistroDeVenta.ShowDialog();
            



           




         
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
