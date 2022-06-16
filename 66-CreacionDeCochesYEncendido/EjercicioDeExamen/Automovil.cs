    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioDeExamen
{
    class Automovil
    {
        public string Color { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Encender ()
        {
            return "Encender auto marca " + this.Marca + ", modelo " + this.Modelo + ", color " + this.Color;
        }
    }
}
