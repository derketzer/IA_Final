using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TCorrespondencias = System.Collections.Generic.List<string>;

namespace IA_Final
{
    class TEstacion:TLinea
    {
        private string nombreEstacion;
        private TCorrespondencias corresp;

        public TEstacion()
        {
            setEstacionNombre("");
            setCorrespondencias(new TCorrespondencias());
        }

        public TEstacion(string Nombre)
        {
            setEstacionNombre(Nombre);
            setCorrespondencias(new TCorrespondencias());
        }

        public TEstacion(string Nombre, TCorrespondencias Correspondencias)
        {
            setEstacionNombre(Nombre);
            setCorrespondencias(Correspondencias);
        }

        public void setEstacionNombre(string Nombre)
        {
            this.nombreEstacion = Nombre;
        }

        public void setCorrespondencias(TCorrespondencias Correspondencias)
        {
            this.corresp = Correspondencias;
        }

        public void setCorrespondencia(string Correspondencia)
        {
            this.corresp.Add(Correspondencia);
        }

        public string getEstacionNombre()
        {
            return this.nombreEstacion;
        }

        public TCorrespondencias getCorrespondencias()
        {
            return this.corresp;
        }

        public bool tieneCorrespondencias()
        {
            if (this.corresp.Count() != 0)
                return true;
            else
                return false;
        }
    }
}
