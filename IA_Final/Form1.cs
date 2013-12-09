using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IA_Final
{
    public partial class Form1 : Form
    {
        private string ultimoOrigen = "";
        private string ultimoDestino = "";
        private ruta_genetica ruta;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ruta = new ruta_genetica();

            try
            {
                //FileInfo fi = new FileInfo("lineas_metro.txt");
                StreamReader reader = new StreamReader("lineas_metro.txt", Encoding.UTF8);

                string line;
                string[] items;
                string estacionNombre;
                string lineaNombre = "";

                TLinea linea = new TLinea();
                bool nuevaLinea = true;

                TEstacion estacion;

                while ((line = reader.ReadLine()) != null)
                {
                    items = line.Split(' ');
                    estacionNombre = items[0].Replace("_", " ");

                    if (nuevaLinea)
                    {
                        linea = new TLinea();
                        linea.setLineaNombre(estacionNombre);
                        nuevaLinea = false;
                        lineaNombre = estacionNombre;
                    }

                    if (items[0] == "#")
                    {
                        ruta.setLinea(linea);
                        nuevaLinea = true;
                    }

                    if (items[0] != "#" && !items[0].StartsWith("Linea"))
                    {
                        if (estacionOrigen.Items.IndexOf(estacionNombre) == -1)
                        {
                            estacionOrigen.Items.Add(estacionNombre);
                            estacionDestino.Items.Add(estacionNombre);
                            selObligatoria.Items.Add(estacionNombre);
                            selProhibida.Items.Add(estacionNombre);
                        }

                        estacion = new TEstacion(estacionNombre);

                        if (items.Count() != 1)
                        {
                            for (int n = 1; n < items.Count(); n++)
                            {
                                estacion.setCorrespondencia(items[n]);
                            }
                        }

                        linea.setEstacion(estacion);
                        ruta.setListadoEstacion(estacionNombre, lineaNombre);
                    }
                }

                selObligatoria.SelectedIndex = 0;
                selProhibida.SelectedIndex = 0;
            }
            catch(Exception)
            {
                MessageBox.Show("¡El archivo no se pudo abrir!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (System.Windows.Forms.Application.MessageLoop)
                {
                    // Para Windows Form
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                  // Para Consola
                  System.Environment.Exit(1);
                }
            }
        }

        private void agrObligatoria_Click(object sender, EventArgs e)
        {
            if (listaObligatorias.Items.IndexOf(selObligatoria.Text) == -1)
            {
                if (listaProhibidas.Items.IndexOf(selObligatoria.Text) == -1)
                {
                    listaObligatorias.Items.Add(selObligatoria.Text);
                    // Eliminar esta linea para no borrar de la lista
                    selProhibida.Items.RemoveAt(selProhibida.Items.IndexOf(selObligatoria.Text));
                    estacionOrigen.Items.RemoveAt(estacionOrigen.Items.IndexOf(selObligatoria.Text));
                    estacionDestino.Items.RemoveAt(estacionDestino.Items.IndexOf(selObligatoria.Text));
                    selObligatoria.Items.RemoveAt(selObligatoria.SelectedIndex);
                    selObligatoria.SelectedIndex = 0;
                    selProhibida.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("¡La estación obligatoria no puede ser también prohibida!",
                    "Estación contradictoria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("¡La estación ya está agregada a la lista de obligatorias!",
                    "Estación duplicada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void agrProhibida_Click(object sender, EventArgs e)
        {
            if (listaProhibidas.Items.IndexOf(selProhibida.Text) == -1)
            {
                if (listaObligatorias.Items.IndexOf(selProhibida.Text) == -1)
                {
                    listaProhibidas.Items.Add(selProhibida.Text);
                    // Eliminar esta linea para no borrar de la lista
                    selObligatoria.Items.RemoveAt(selObligatoria.Items.IndexOf(selProhibida.Text));
                    estacionOrigen.Items.RemoveAt(estacionOrigen.Items.IndexOf(selProhibida.Text));
                    estacionDestino.Items.RemoveAt(estacionDestino.Items.IndexOf(selProhibida.Text));
                    selProhibida.Items.RemoveAt(selProhibida.SelectedIndex);
                    selProhibida.SelectedIndex = 0;
                    selObligatoria.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("¡La estación prohibida no puede ser también obligatoria!",
                    "Estación contradictoria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("¡La estación ya está agregada a la lista de prohibidas!",
                    "Estación duplicada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void eliObligatoria_Click(object sender, EventArgs e)
        {
            if (listaObligatorias.Text == "")
            {
                MessageBox.Show("¡Debes seleccionar una estación de la lista de obligatorias!",
                    "Estación no seleccionada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (selObligatoria.Items.IndexOf(listaObligatorias.Text) == -1)
                {
                    selObligatoria.Items.Add(listaObligatorias.Text);
                    selProhibida.Items.Add(listaObligatorias.Text);
                    estacionOrigen.Items.Add(listaObligatorias.Text);
                    estacionDestino.Items.Add(listaObligatorias.Text);
                    selObligatoria.SelectedIndex = 0;
                    selProhibida.SelectedIndex = 0;
                    listaObligatorias.Items.RemoveAt(listaObligatorias.SelectedIndex);
                }
            }
        }

        private void eliProhibida_Click(object sender, EventArgs e)
        {
            if (listaProhibidas.Text == "")
            {
                MessageBox.Show("¡Debes seleccionar una estación de la lista de prohibidas!",
                    "Estación no seleccionada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (selProhibida.Items.IndexOf(listaProhibidas.Text) == -1)
                {
                    selProhibida.Items.Add(listaProhibidas.Text);
                    selObligatoria.Items.Add(listaProhibidas.Text);
                    estacionOrigen.Items.Add(listaProhibidas.Text);
                    estacionDestino.Items.Add(listaProhibidas.Text);
                    selProhibida.SelectedIndex = 0;
                    selObligatoria.SelectedIndex = 0;
                    listaProhibidas.Items.RemoveAt(listaProhibidas.SelectedIndex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (estacionOrigen.Text == "")
            {
                MessageBox.Show("¡Debes seleccionar una estación de origen!",
                    "Estación no seleccionada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (estacionDestino.Text == "")
            {
                MessageBox.Show("¡Debes seleccionar una estación de la lista de destino!",
                    "Estación no seleccionada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                TConsulta consulta = new TConsulta(estacionOrigen.Text, estacionDestino.Text);

                foreach(string estacionConsulta in listaObligatorias.Items)
                {
                    consulta.setEstacionObligatoria(estacionConsulta);
                }

                foreach (string estacionConsulta in listaProhibidas.Items)
                {
                    consulta.setEstacionProhibida(estacionConsulta);
                }

                ruta.setConsulta(consulta);
                ruta.setTamanhoPoblacion(int.Parse(tamPoblacion.Value.ToString()));
                ruta.setLongitudCromosoma(int.Parse(tamIndividuo.Value.ToString()));
                ruta.setIteraciones(int.Parse(numIteraciones.Value.ToString()));
                ruta.setProbabilidadCruce(double.Parse(probCruce.Value.ToString()));
                ruta.setProbabilidadMutacion(double.Parse(probMutacion.Value.ToString()));
                ruta.setPenalizacionObligatorias(int.Parse(penObligatorias.Text.ToString()));
                ruta.setPenalizacionTransbordos(int.Parse(penTransbordos.Text.ToString()));
                ruta.setPenalizacionProhibidas(int.Parse(penProhibidas.Text.ToString()));
                ruta.setPenalizacionRecorrido(int.Parse(penRecorrido.Text.ToString()));
                ruta.setMutar(usarMutacion.Checked);

                ruta.calcula();
            }
        }

        private void estacionOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ultimoOrigen != "")
            {
                selObligatoria.Items.Add(ultimoOrigen);
                selProhibida.Items.Add(ultimoOrigen);
                estacionDestino.Items.Add(ultimoOrigen);
            }

            ultimoOrigen = estacionOrigen.Text;

            selObligatoria.Items.RemoveAt(selObligatoria.Items.IndexOf(ultimoOrigen));
            selProhibida.Items.RemoveAt(selProhibida.Items.IndexOf(ultimoOrigen));
            estacionDestino.Items.RemoveAt(estacionDestino.Items.IndexOf(ultimoOrigen));
            selProhibida.SelectedIndex = 0;
            selObligatoria.SelectedIndex = 0;
        }

        private void estacionDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ultimoDestino != "")
            {
                selObligatoria.Items.Add(ultimoDestino);
                selProhibida.Items.Add(ultimoDestino);
                estacionOrigen.Items.Add(ultimoDestino);
            }

            ultimoDestino = estacionDestino.Text;

            selObligatoria.Items.RemoveAt(selObligatoria.Items.IndexOf(ultimoDestino));
            selProhibida.Items.RemoveAt(selProhibida.Items.IndexOf(ultimoDestino));
            estacionOrigen.Items.RemoveAt(estacionDestino.Items.IndexOf(ultimoDestino));
            selProhibida.SelectedIndex = 0;
            selObligatoria.SelectedIndex = 0;
        }
    }
}
