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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroDeClientes ventanaRegistroDeClientes = new RegistroDeClientes();
            ventanaRegistroDeClientes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroDeVentas registroDeVentas = new RegistroDeVentas();
            registroDeVentas.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistroDeProducto ventanaRegistroDeProducto = new RegistroDeProducto();
            ventanaRegistroDeProducto.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistroDeEntrega ventanaRegistroDeEntrega = new RegistroDeEntrega();
            ventanaRegistroDeEntrega.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistroDePago ventanaRegistroDePago = new RegistroDePago();
            ventanaRegistroDePago.ShowDialog();
        }

        

    }   
  
  }

