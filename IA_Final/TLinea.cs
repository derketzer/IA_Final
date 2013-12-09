using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TLEstaciones = System.Collections.Generic.List<IA_Final.TEstacion>;

namespace IA_Final
{
    class TLinea:ruta_genetica
    {
        private string nombreLinea;
        private TLEstaciones estaciones;
        private bool circular;

        public TLinea()
        {
            setLineaNombre("");
            setEstaciones(new TLEstaciones());
            setCircular(false);
        }

        public TLinea(string Nombre)
        {
            setLineaNombre(Nombre);
            setEstaciones(new TLEstaciones());
            setCircular(false);
        }

        public TLinea(string Nombre, TLEstaciones Estaciones)
        {
            setLineaNombre(Nombre);
            setEstaciones(Estaciones);
            setCircular(false);
        }

        public TLinea(string Nombre, TLEstaciones Estaciones, bool Circular)
        {
            setLineaNombre(Nombre);
            setEstaciones(Estaciones);
            setCircular(Circular);
        }

        public void setLineaNombre(string Nombre)
        {
            this.nombreLinea = Nombre;
        }

        public void setEstaciones(TLEstaciones Estaciones)
        {
            this.estaciones = Estaciones;
        }

        public void setEstacion(TEstacion Estacion)
        {
            this.estaciones.Add(Estacion);
        }

        public void setCircular(bool Circular)
        {
            this.circular = Circular;
        }

        public string getLineaNombre()
        {
            return this.nombreLinea;
        }

        public TLEstaciones getEstaciones()
        {
            return this.estaciones;
        }

        public bool esCircular()
        {
            return this.circular;
        }
    }
}
