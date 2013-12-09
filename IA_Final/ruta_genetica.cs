using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TPlano = System.Collections.Generic.List<IA_Final.TLinea>;
using TPoblacion = System.Collections.Generic.List<IA_Final.TIndividuo>;

namespace IA_Final
{
    class ruta_genetica
    {
        private TPlano plano;
        private TConsulta consulta;
        private TPoblacion poblacion;
        private int tamanhoPoblacion;
        private int longitudCromosoma;
        private int iteraciones;
        private double probabilidadCruce;
        private double probabilidadMutacion;
        private int penalizacionObligatorias;
        private int penalizacionTransbordos;
        private int penalizacionProhibidas;
        private int penalizacionRecorrido;
        private int posicionMejorLinea;
        private Dictionary<string, List<string>> listadoEstaciones = new Dictionary<string, List<string>>();
        private bool mutar = false;

        public ruta_genetica()
        {
            setPlano(new TPlano());
            setConsulta(new TConsulta());
        }

        public ruta_genetica(TPlano Plano)
        {
            setPlano(Plano);
            setConsulta(new TConsulta());
        }

        public ruta_genetica(TPlano Plano, TConsulta Consulta)
        {
            setPlano(Plano);
            setConsulta(Consulta);
        }

        public void setPlano(TPlano Plano)
        {
            this.plano = Plano;
        }

        public void setLinea(TLinea Linea)
        {
            this.plano.Add(Linea);
        }

        public void setConsulta(TConsulta Consulta)
        {
            this.consulta = Consulta;
        }

        public void setTamanhoPoblacion(int Tam)
        {
            this.tamanhoPoblacion = Tam;
        }

        public void setLongitudCromosoma(int Cromosoma)
        {
            this.longitudCromosoma = Cromosoma;
        }

        public void setIteraciones(int Iteraciones)
        {
            this.iteraciones = Iteraciones;
        }

        public void setProbabilidadCruce(double Cruce)
        {
            this.probabilidadCruce = Cruce;
        }

        public void setProbabilidadMutacion(double Mutacion)
        {
            this.probabilidadMutacion = Mutacion;
        }

        public void setPenalizacionObligatorias(int Penalizacion)
        {
            this.penalizacionObligatorias = Penalizacion;
        }

        public void setPenalizacionTransbordos(int Penalizacion)
        {
            this.penalizacionTransbordos = Penalizacion;
        }

        public void setPenalizacionProhibidas(int Penalizacion)
        {
            this.penalizacionProhibidas = Penalizacion;
        }

        public void setPenalizacionRecorrido(int Penalizacion)
        {
            this.penalizacionRecorrido = Penalizacion;
        }

        public TPlano getPlano()
        {
            return this.plano;
        }

        public void setListadoEstacion(string Nombre, string Linea)
        {
            if (this.listadoEstaciones.ContainsKey(Nombre))
            {
                List<string> temp = this.listadoEstaciones[Nombre];
                temp.Add(Linea);
                this.listadoEstaciones[Nombre] = temp;
            }
            else
            {
                List<string> listadoLineas = new List<string>();
                listadoLineas.Add(Linea);
                this.listadoEstaciones.Add(Nombre, listadoLineas);
            }
        }

        public Dictionary<string, List<string>> getListadoEstaciones()
        {
            return this.listadoEstaciones;
        }

        public void setMutar(bool Mutar)
        {
            this.mutar = Mutar;
        }

        public void calcula()
        {
            inicializaPoblacion();
            evaluacion();

            for (int i = 0; i < this.iteraciones; i++)
            {
                seleccion();
                reproduccion();

                if(this.mutar)
                    mutacion();

                evaluacion();
            }

            despliegaTabla();
        }

        private void inicializaPoblacion()
        {
            poblacion = new TPoblacion();
            TIndividuo indiv = new TIndividuo();

            for(int i=0; i<this.tamanhoPoblacion; i++)
            {
                do
                {
                    indiv = generaIndividuo("", "", 0);
                } while (indiv == null);

                this.poblacion.Add(indiv);
            }
        }

        private TIndividuo generaIndividuo(string ini, string fin, int longitudUsada)
        {
            TIndividuo indiv = new TIndividuo();
            Random random = new Random();
            int avanza;
            bool cambio;
            bool finInicio;
            List<string> tempLineas = new List<string>();
            string tempLinea;
            int indexLinea = -1;
            int indexEstacion = -1;
            int sigEstacion = -1;
            string tempEstacion;
            int cambioIndex = -1;
            List<string> estacionesUsadas = new List<string>();
            string estacionInicial;
            string estacionFinal;

            if (ini == "")
                estacionInicial = this.consulta.getEstacionOrigen();
            else
                estacionInicial = ini;

            if (fin == "")
                estacionFinal = this.consulta.getEstacionDestino();
            else
                estacionFinal = fin;

            tempLineas = this.listadoEstaciones[estacionInicial];

            tempLinea = tempLineas[random.Next(0, tempLineas.Count())];

            for (int n = 0; n < this.plano.Count; n++)
            {
                if (this.plano[n].getLineaNombre() == tempLinea)
                {
                    indexLinea = n;
                    break;
                }
            }

            if (indexLinea == -1)
            {
                MessageBox.Show("¡No se encontró la línea!",
                    "Línea enfermita",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                System.Windows.Forms.Application.Exit();
            }

            for (int n = 0; n < this.plano[indexLinea].getEstaciones().Count; n++)
            {
                if (this.plano[indexLinea].getEstaciones()[n].getEstacionNombre() == estacionInicial)
                {
                    indexEstacion = n;
                    break;
                }
            }

            if (indexEstacion == -1)
            {
                MessageBox.Show("¡No se encontró la estación!",
                    "Estación enfermita",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                System.Windows.Forms.Application.Exit();
            }

            indiv.setGen(new TGen(indexLinea, indexEstacion, tempLinea, estacionInicial));

            estacionesUsadas.Add(estacionInicial);

            if (indexEstacion == 0)
            {
                avanza = 1;
            }
            else if (indexEstacion == this.plano[indexLinea].getEstaciones().Count - 1)
            {
                avanza = -1;
            }
            else
            {
                if (random.NextDouble() < 0.5)
                    avanza = -1;
                else
                    avanza = 1;
            }

            for (int n = 1; n < this.longitudCromosoma-longitudUsada; n++)
            {
                finInicio = false;
                sigEstacion = indexEstacion + avanza;

                if (sigEstacion < 0 || sigEstacion >= this.plano[indexLinea].getEstaciones().Count())
                {
                    avanza *= -1;
                    sigEstacion = indexEstacion + avanza;
                    finInicio = true;
                }

                tempEstacion = this.plano[indexLinea].getEstaciones()[sigEstacion].getEstacionNombre();

                if (estacionesUsadas.IndexOf(tempEstacion) != -1)
                {
                    if (finInicio)
                        return null;

                    avanza *= -1;
                    sigEstacion = indexEstacion + avanza;
                    tempEstacion = this.plano[indexLinea].getEstaciones()[sigEstacion].getEstacionNombre();
                }

                if (estacionesUsadas.IndexOf(tempEstacion) != -1)
                {
                    return null;
                }

                indiv.setGen(new TGen(indexLinea, sigEstacion, tempLinea, tempEstacion));

                if (tempEstacion == estacionFinal)
                {
                    break;
                }

                estacionesUsadas.Add(tempEstacion);

                cambio = false;
                if (this.plano[indexLinea].getEstaciones()[indexEstacion + avanza].tieneCorrespondencias())
                {
                    if (random.NextDouble() < 0.5)
                        cambio = true;
                }

                if (cambio)
                {
                    cambioIndex = random.Next(0, this.plano[indexLinea].getEstaciones()[indexEstacion + avanza].getCorrespondencias().Count());
                    tempLinea = this.plano[indexLinea].getEstaciones()[indexEstacion + avanza].getCorrespondencias()[cambioIndex];

                    for (int m = 0; m < this.plano.Count; m++)
                    {
                        if (this.plano[m].getLineaNombre() == tempLinea)
                        {
                            indexLinea = m;
                            break;
                        }
                    }

                    for (int m = 0; m < this.plano[indexLinea].getEstaciones().Count; m++)
                    {
                        if (this.plano[indexLinea].getEstaciones()[m].getEstacionNombre() == tempEstacion)
                        {
                            indexEstacion = m;
                            break;
                        }
                    }

                    if (indexEstacion == 0)
                    {
                        avanza = 1;
                    }
                    else if (indexEstacion == this.plano[indexLinea].getEstaciones().Count - 1)
                    {
                        avanza = -1;
                    }
                    else
                    {
                        if (random.NextDouble() < 0.5)
                            avanza = -1;
                        else
                            avanza = 1;
                    }

                    sigEstacion = indexEstacion + avanza;
                }

                indexEstacion = sigEstacion;
            }

            return indiv;
        }

        private void evaluacion()
        {
            double puntuacionAcumulada = 0;
            double mejorAdaptacion = 1000000;
            double sumaAdaptacion = 0;

            for (int i = 0; i < this.tamanhoPoblacion; i++)
            {
                sumaAdaptacion += this.poblacion[i].getAdaptacion();

                if (this.poblacion[i].getAdaptacion() < mejorAdaptacion)
                {
                    this.posicionMejorLinea = i;
                    mejorAdaptacion = this.poblacion[i].getAdaptacion();
                }
            }

            for (int i = 0; i < this.tamanhoPoblacion; i++)
            {
                this.poblacion[i].setPuntuacion(this.poblacion[i].getAdaptacion() / sumaAdaptacion);
                this.poblacion[i].setPuntuacionAcumulada(this.poblacion[i].getPuntuacion() + puntuacionAcumulada);
                puntuacionAcumulada += this.poblacion[i].getPuntuacion();
                this.poblacion[i].calcula(this.consulta.getEstacionesObligatorias(), this.consulta.getEstacionesProhibidas());
            }
        }

        private void seleccion()
        {
            int[] seleccionSuperior = new int[this.tamanhoPoblacion];
            double probabilidad;
            int posicionSuperior;
            TPoblacion poblacionAuxiliar = new TPoblacion();
            Random random = new Random();

            for (int i = 0; i < tamanhoPoblacion; i++)
            {
                probabilidad = random.NextDouble();
                posicionSuperior = 0;

                while( (probabilidad > this.poblacion[posicionSuperior].getPuntuacionAcumulada())
                    && (posicionSuperior < this.tamanhoPoblacion))
                {
                    posicionSuperior++;
                }

                seleccionSuperior[i] = posicionSuperior;
            }

            for (int i = 0; i < tamanhoPoblacion; i++)
            {
                poblacionAuxiliar.Add(this.poblacion[seleccionSuperior[i]]);
            }

            this.poblacion = new TPoblacion();

            for (int i = 0; i < tamanhoPoblacion; i++)
            {
                this.poblacion.Add(poblacionAuxiliar[i]);
            }
        }

        private void reproduccion()
        {
            int[] seleccionCruce = new int[this.tamanhoPoblacion];
            int numeroSeleccionCruce = 0;
            Random random = new Random();

            for(int i=0; i<this.tamanhoPoblacion; i++)
            {
                if(random.NextDouble() < this.probabilidadCruce)
                {
                    seleccionCruce[numeroSeleccionCruce] = i;
                    numeroSeleccionCruce++;
                }
            }

            if (numeroSeleccionCruce % 2 == 1)
            {
                numeroSeleccionCruce--;
            }

            for (int i = 0; i < numeroSeleccionCruce; i+=2)
            {
                cruce(seleccionCruce[i], seleccionCruce[i+1]);
            }
        }

        private void cruce(int padreIndex, int madreIndex)
        {
            Random random = new Random();
            int puntoCrucePadre, puntoCruceMadre;
            TIndividuo hijo1 = null;
            TIndividuo hijo2 = null;

            puntoCrucePadre = (int)random.Next(0, this.poblacion[padreIndex].getLongitud());

            int lineaPadre = this.poblacion[padreIndex].getGenes()[puntoCrucePadre].getLinea();
            int estacionPadre = this.poblacion[padreIndex].getGenes()[puntoCrucePadre].getEstacion();
            string estacionPadreNombre = this.plano[lineaPadre].getEstaciones()[estacionPadre].getEstacionNombre();

            bool recorrido = false;
            int cruceOriginal = puntoCrucePadre;

            do
            {
                puntoCruceMadre = this.poblacion[madreIndex].tieneEstacion(estacionPadreNombre);

                if (puntoCruceMadre != -1)
                {
                    hijo1 = new TIndividuo();
                    hijo2 = new TIndividuo();

                    for (int n = 0; n < puntoCrucePadre; n++)
                    {
                        hijo1.setGen(this.poblacion[padreIndex].getGenes()[n]);
                    }

                    for (int n = puntoCruceMadre; n < this.poblacion[madreIndex].getLongitud(); n++)
                    {
                        hijo1.setGen(this.poblacion[madreIndex].getGenes()[n]);
                    }

                    for (int n = 0; n < puntoCruceMadre; n++)
                    {
                        hijo2.setGen(this.poblacion[madreIndex].getGenes()[n]);
                    }

                    for (int n = puntoCrucePadre; n < this.poblacion[padreIndex].getLongitud(); n++)
                    {
                        hijo2.setGen(this.poblacion[padreIndex].getGenes()[n]);
                    }

                    recorrido = true;
                }

                puntoCrucePadre++;

                if (puntoCrucePadre == this.poblacion[padreIndex].getLongitud())
                    puntoCrucePadre = 0;

                if (puntoCrucePadre == cruceOriginal)
                    recorrido = true;

            } while (!recorrido);

            if (hijo1 != null && hijo2 != null)
            {
                hijo1.setAdaptacion(adaptacion(ref hijo1));
                hijo2.setAdaptacion(adaptacion(ref hijo2));

                this.poblacion[padreIndex] = hijo1;
                this.poblacion[madreIndex] = hijo2;
            }
        }

        private double adaptacion(ref TIndividuo indiv)
        {
            double adapt = 0;

            adapt = indiv.getLongitud() * this.penalizacionRecorrido;

            adapt += indiv.transbordos() * this.penalizacionTransbordos;

            adapt += indiv.prohibidas() * this.penalizacionProhibidas;

            adapt += indiv.obligatorias() * this.penalizacionObligatorias;

            return adapt;
        }

        private void mutacion()
        {
            bool mutado;
            Random random = new Random();
            int posicionMutacion = 0;

            for (int i = 0; i < this.tamanhoPoblacion; i++)
            {
                mutado = false;

                if (random.NextDouble() < this.probabilidadMutacion)
                {
                    posicionMutacion = (int)random.Next(0, this.poblacion[i].getLongitud());
                    TIndividuo temp = null;
                    TIndividuo temp2 = null;
                    int lim = 0;

                    if (random.NextDouble() < 0.5)
                    {
                        do
                        {
                            temp = generaIndividuo(this.poblacion[i].getGenes()[0].getEstacionNombre(),
                                                              this.poblacion[i].getGenes()[posicionMutacion].getEstacionNombre(),
                                                              posicionMutacion);
                            lim++;
                        } while (temp == null && lim < 100);

                        if (temp != null)
                        {
                            for (int m = posicionMutacion + 1; m < this.poblacion[i].getLongitud(); m++)
                            {
                                temp.setGen(this.poblacion[i].getGenes()[m]);
                            }

                            this.poblacion[i] = temp;
                        }
                    }
                    else
                    {
                        do
                        {
                            temp2 = generaIndividuo(this.poblacion[i].getGenes()[posicionMutacion].getEstacionNombre(),
                                                              this.poblacion[i].getGenes()[this.poblacion[i].getLongitud()-1].getEstacionNombre(),
                                                              this.poblacion[i].getLongitud() - posicionMutacion);
                            lim++;
                        } while (temp2 == null && lim < 100);

                        if (temp2 != null)
                        {
                            temp = new TIndividuo();

                            for (int m = 0; m < posicionMutacion; m++)
                            {
                                temp.setGen(this.poblacion[i].getGenes()[m]);
                            }

                            for (int m = posicionMutacion; m < temp2.getLongitud(); m++)
                            {
                                temp.setGen(temp2.getGenes()[m]);
                            }

                            this.poblacion[i] = temp;
                        }
                    }

                    if(temp != null)
                        mutado = true;
                }

                if (mutado)
                {
                    TIndividuo tempIndividuo = this.poblacion[1];

                    this.poblacion[i].setAdaptacion(adaptacion(ref tempIndividuo));
                }
            }
        }

        private void despliegaTabla()
        {
            TIndividuo mejorRuta = this.poblacion[this.posicionMejorLinea];
            Form2 tabla = new Form2();
            string accion, lin1, lin2, est1, est2;

            for (int n = 1; n < mejorRuta.getLongitud(); n++)
            {
                accion = "";
                lin1 = mejorRuta.getGenes()[n - 1].getLineaNombre();
                est1 = mejorRuta.getGenes()[n - 1].getEstacionNombre();
                lin2 = mejorRuta.getGenes()[n].getLineaNombre();
                est2 = mejorRuta.getGenes()[n].getEstacionNombre();

                if (mejorRuta.getGenes()[n - 1].getLineaNombre() != mejorRuta.getGenes()[n].getLineaNombre())
                {
                    accion = "Transbordo a: " + mejorRuta.getGenes()[n].getLineaNombre();
                    lin2 = lin1;

                    if (n == mejorRuta.getLongitud() - 1)
                        accion = "";
                }
                                    
                string[] fila = {n.ToString(), lin1, est1, lin2, est2, accion};
                tabla.llenaTabla(fila);
            }

            tabla.Show();
        }
    }
}
