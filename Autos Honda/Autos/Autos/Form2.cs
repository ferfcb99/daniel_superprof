using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Autos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        Auto camioneta = new Auto();

        public void setCamioneta(Auto camioneta)
        {
            this.camioneta = camioneta;
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            txtnombre.Text = Form1.nombrecliente;
            txttipo.Text = Form1.tipo;
            txtcolor.Text = Form1.color;
            txtprecio.Text = Convert.ToString(Form1.precio);
            
        }
    }
}
