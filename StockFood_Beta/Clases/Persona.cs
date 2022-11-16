using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFood_Beta.Clases
{
    internal class Persona
    {

        public int identificacion;
        public string name;
        public string puesto;
        public double salario;
        public int codigo;
        public byte nivelDeSeguridad;
        public string TipoDeApp;
        public double numeroDeSeguro;

        public void setIdentificacion(int id)
        {
            this.identificacion = id;
        }
        public int getIdentificacion()
        { return identificacion; }

        public void setName(string Name)
        {
            name = Name;
        }

    }
}
