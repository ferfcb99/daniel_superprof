using System;
using System.Collections.Generic;
using System.Text;

namespace Autos
{
    public class Auto
    {
        private string tipo;
        private string color; 
        private int precio;

        public Auto(){}

        public string Tipo { get => tipo; set => tipo = value; }
        public string Color { get => color; set => color = value; }
        public int Precio { get => precio; set => precio = value; }

    }
}
