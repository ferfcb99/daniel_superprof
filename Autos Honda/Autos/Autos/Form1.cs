using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Autos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string nombrecliente, color, tipo;
        public static int precio;

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            Auto Camioneta = new Auto();
            nombrecliente = txtNombreCliente.Text;

            if (chkCRV.Checked == true)
            {
                Camioneta.Tipo = cmbTipoCRV.Text;
                Camioneta.Color = cmbColorCRV.Text;

                if (Camioneta.Tipo == "CRV ARS")
                {
                    Camioneta.Precio = 634900;
                }
                else if (Camioneta.Tipo == "CRV BENT")
                {
                    Camioneta.Precio = 634900;
                }
                else if (Camioneta.Tipo == "CRV Test") 
                {
                    Camioneta.Precio = 634900; 
                } 
            }
            if (chkHRV.Checked == true)
            {
                Camioneta.Tipo = cmbTipoHRV.Text;
                Camioneta.Color = cmbColorHRV.Text;

                if (Camioneta.Tipo == "HRV ARS")
                {
                    Camioneta.Precio = 533900;
                }
                else if (Camioneta.Tipo == "HRV BENT")
                {
                    Camioneta.Precio = 533900;
                }
                else if (Camioneta.Tipo == "HRV Test")
                {
                    Camioneta.Precio = 533900;
                }
            }
            if (chkPilot.Checked == true)
            {
                Camioneta.Tipo = cmbTipoPilot.Text;
                Camioneta.Color = cmbColorPilot.Text;

                if (Camioneta.Tipo == "Pilot ARS")
                {
                    Camioneta.Precio = 1029900;
                }
                else if (Camioneta.Tipo == "Pilot BENT")
                {
                    Camioneta.Precio = 1029900;
                }
                else if (Camioneta.Tipo == "Pilot Test")
                {
                    Camioneta.Precio = 1029900;
                }
            }
            if (chkBRV.Checked == true)
            {
                Camioneta.Tipo = cmbTipoBRV.Text;
                Camioneta.Color = cmbColorBRV.Text;

                if (Camioneta.Tipo == "BRV ARS")
                {
                    Camioneta.Precio = 449900;
                }
                else if (Camioneta.Tipo == "BRV BENT")
                {
                    Camioneta.Precio = 449900;

                }
                else if (Camioneta.Tipo == "BRV Test")
                {
                    Camioneta.Precio = 449900;
                }
            }
            if (chkOdyssey.Checked == true)
            {
                Camioneta.Tipo = cmbTipoOdyssey.Text;
                Camioneta.Color = cmbColorOdyssey.Text;

                if (Camioneta.Tipo == "Odyssey ARS")
                {
                    Camioneta.Precio = 1079900;
                }
                else if (Camioneta.Tipo == "Odyssey BENT")
                {
                    Camioneta.Precio = 1079900;
                }
                else if (Camioneta.Tipo == "Odyssey Test")
                {
                    Camioneta.Precio = 1079900;
                }
            }

            tipo = Camioneta.Tipo;
            color = Camioneta.Color;
            precio = Camioneta.Precio;
            this.Hide();
            Form2 form2 = new Form2();
            form2.setCamioneta(Camioneta);
            form2.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
