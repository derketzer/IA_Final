using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IA_Final
{
    class TGen
    {
        private int linea;
        private int estacion;

        private string estacionNombre;
        private string lineaNombre;

        public TGen()
        {
            setLinea(-1);
            setEstacion(-1);
        }

        public TGen(int Linea)
        {
            setLinea(Linea);
            setEstacion(-1);
        }

        public TGen(int Linea, int Estacion)
        {
            setLinea(Linea);
            setEstacion(Estacion);
        }

        public TGen(int Linea, int Estacion, string LineaNombre)
        {
            setLinea(Linea);
            setEstacion(Estacion);
            setLineaNombre(LineaNombre);
            setEstacionNombre("");
        }
        
        public TGen(int Linea, int Estacion, string LineaNombre, string EstacionNombre)
        {
            setLinea(Linea);
            setEstacion(Estacion);
            setLineaNombre(LineaNombre);
            setEstacionNombre(EstacionNombre);
        }

        public void setLinea(int Linea)
        {
            this.linea = Linea;
        }

        public void setEstacion(int Estacion)
        {
            this.estacion = Estacion;
        }

        public void setLineaNombre(string Nombre)
        {
            this.lineaNombre = Nombre;
        }

        public void setEstacionNombre(string Nombre)
        {
            this.estacionNombre = Nombre;
        }

        public int getLinea()
        {
            return this.linea;
        }

        public int getEstacion()
        {
            return this.estacion;
        }

        public string getLineaNombre()
        {
            return this.lineaNombre;
        }

        public string getEstacionNombre()
        {
            return this.estacionNombre;
        }
    }
}
