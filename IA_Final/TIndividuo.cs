using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TGenes = System.Collections.Generic.List<IA_Final.TGen>;
using TLNombres = System.Collections.Generic.List<string>;

namespace IA_Final
{
    class TIndividuo:TGen
    {
        private TGenes genes;
        private double adaptacion;
        private double puntuacion;
        private double puntuacionAcumulada;
        private int cuantosTransbordos = 0;
        private int cuantasProhibidas = 0;
        private int cuantasObligatorias = 0;

        public TIndividuo()
        {
            setGenes(new TGenes());
            setAdaptacion(-1.0);
            setPuntuacion(-1.0);
            setPuntuacionAcumulada(-1.0);
        }

        public TIndividuo(TGenes Genes)
        {
            setGenes(Genes);
            setAdaptacion(-1.0);
            setPuntuacion(-1.0);
            setPuntuacionAcumulada(-1.0);
        }

        public TIndividuo(TGenes Genes, double Adaptacion)
        {
            setGenes(Genes);
            setAdaptacion(Adaptacion);
            setPuntuacion(-1.0);
            setPuntuacionAcumulada(-1.0);
        }

        public TIndividuo(TGenes Genes, double Adaptacion, double Puntuacion)
        {
            setGenes(Genes);
            setAdaptacion(Adaptacion);
            setPuntuacion(Puntuacion);
            setPuntuacionAcumulada(-1.0);
        }

        public TIndividuo(TGenes Genes, double Adaptacion, double Puntuacion, double PuntuacionAcumulada)
        {
            setGenes(Genes);
            setAdaptacion(Adaptacion);
            setPuntuacion(Puntuacion);
            setPuntuacionAcumulada(PuntuacionAcumulada);
        }

        public void setGenes(TGenes Genes)
        {
            this.genes = Genes;
        }

        public void setGen(TGen Gen)
        {
            this.genes.Add(Gen);
        }

        public void setAdaptacion(double Adaptacion)
        {
            this.adaptacion = Adaptacion;
        }

        public void setPuntuacion(double Puntuacion)
        {
            this.puntuacion = Puntuacion;
        }

        public void setPuntuacionAcumulada(double PuntuacionAcumulada)
        {
            this.puntuacionAcumulada = PuntuacionAcumulada;
        }

        public TGenes getGenes()
        {
            return this.genes;
        }

        public double getAdaptacion()
        {
            return this.adaptacion;
        }

        public double getPuntuacion()
        {
            return this.puntuacion;
        }

        public double getPuntuacionAcumulada()
        {
            return this.puntuacionAcumulada;
        }

        public int getLongitud()
        {
            return this.genes.Count();
        }

        public int tieneEstacion(string Estacion)
        {
            int posicion = -1;

            for (int n = 0; n < genes.Count(); n++)
            {
                if (this.genes[n].getEstacionNombre() == Estacion)
                {
                    posicion = n;
                    break;
                }
            }

            return posicion;
        }

        public void calcula(TLNombres listaObligatorias, TLNombres listaProhibidas)
        {
            calculaTransbordos();
            calculaObligatorias(listaObligatorias);
            calculaProhibidas(listaProhibidas);
        }

        public int transbordos()
        {
            return this.cuantosTransbordos;
        }

        private void calculaTransbordos()
        {
            int lineaTemp = -1;
            int cuantasLineas = 0;

            foreach (TGen gen in genes)
            {
                if (lineaTemp != gen.getLinea())
                {
                    cuantasLineas++;
                    lineaTemp = gen.getLinea();
                }
            }

            this.cuantosTransbordos = cuantasLineas;
        }

        public int prohibidas()
        {
            return this.cuantasProhibidas;
        }

        public void calculaProhibidas(TLNombres lista)
        {
            int estacionTemp = -1;
            int cuantasEstaciones = 0;

            foreach (TGen gen in genes)
            {
                if (estacionTemp != gen.getEstacion())
                {
                    if (lista.IndexOf(gen.getEstacionNombre()) != -1)
                    {
                        cuantasEstaciones++;
                        estacionTemp = gen.getLinea();
                    }
                }
            }

            this.cuantasProhibidas = cuantasEstaciones;
        }

        public int obligatorias()
        {
            return this.cuantasObligatorias;
        }

        public void calculaObligatorias(TLNombres lista)
        {
            int estacionTemp = -1;
            int cuantasEstaciones = 0;

            foreach (TGen gen in genes)
            {
                if (estacionTemp != gen.getEstacion())
                {
                    if (lista.IndexOf(gen.getEstacionNombre()) != -1)
                    {
                        cuantasEstaciones++;
                        estacionTemp = gen.getLinea();
                    }
                }
            }

            this.cuantasObligatorias = cuantasEstaciones;
        }
    }
}
