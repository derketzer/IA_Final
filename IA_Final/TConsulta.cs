using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TLNombres = System.Collections.Generic.List<string>;

namespace IA_Final
{
    class TConsulta
    {
        private string estacionOrigen;
        private string estacionDestino;
        private TLNombres listaObligatorias;
        private TLNombres listaProhibidas;

        public TConsulta()
        {
            setEstacionOrigen("");
            setEstacionDestino("");
            setListaObligatorias(new TLNombres());
            setListaProhibidas(new TLNombres());
        }

        public TConsulta(string Origen)
        {
            setEstacionOrigen(Origen);
            setEstacionDestino("");
            setListaObligatorias(new TLNombres());
            setListaProhibidas(new TLNombres());
        }

        public TConsulta(string Origen, string Destino)
        {
            setEstacionOrigen(Origen);
            setEstacionDestino(Destino);
            setListaObligatorias(new TLNombres());
            setListaProhibidas(new TLNombres());
        }

        public TConsulta(string Origen, string Destino, TLNombres Obligatorias)
        {
            setEstacionOrigen(Origen);
            setEstacionDestino(Destino);
            setListaObligatorias(Obligatorias);
            setListaProhibidas(new TLNombres());
        }

        public TConsulta(string Origen, string Destino, TLNombres Obligatorias, TLNombres Prohibidas)
        {
            setEstacionOrigen(Origen);
            setEstacionDestino(Destino);
            setListaObligatorias(Obligatorias);
            setListaProhibidas(Prohibidas);
        }

        public void setEstacionOrigen(string Nombre)
        {
            this.estacionOrigen = Nombre;
        }

        public void setEstacionDestino(string Nombre)
        {
            this.estacionDestino = Nombre;
        }

        public void setListaObligatorias(TLNombres Obligatorias)
        {
            this.listaObligatorias = Obligatorias;
        }

        public void setEstacionObligatoria(string Estacion)
        {
            this.listaObligatorias.Add(Estacion);
        }

        public void setListaProhibidas(TLNombres Prohibidas)
        {
            this.listaProhibidas = Prohibidas;
        }

        public void setEstacionProhibida(string Estacion)
        {
            this.listaProhibidas.Add(Estacion);
        }

        public string getEstacionOrigen()
        {
            return this.estacionOrigen;
        }

        public string getEstacionDestino()
        {
            return this.estacionDestino;
        }

        public TLNombres getEstacionesObligatorias()
        {
            return this.listaObligatorias;
        }

        public TLNombres getEstacionesProhibidas()
        {
            return this.listaProhibidas;
        }
    }
}
