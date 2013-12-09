namespace IA_Final
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.estacionDestino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.estacionOrigen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eliProhibida = new System.Windows.Forms.Button();
            this.agrProhibida = new System.Windows.Forms.Button();
            this.eliObligatoria = new System.Windows.Forms.Button();
            this.agrObligatoria = new System.Windows.Forms.Button();
            this.selProhibida = new System.Windows.Forms.ComboBox();
            this.selObligatoria = new System.Windows.Forms.ComboBox();
            this.listaProhibidas = new System.Windows.Forms.ListBox();
            this.listaObligatorias = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tamIndividuo = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.probCruce = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.probMutacion = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numIteraciones = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tamPoblacion = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.penRecorrido = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.penTransbordos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.penProhibidas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.penObligatorias = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.usarMutacion = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tamIndividuo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probCruce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probMutacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIteraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamPoblacion)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.estacionDestino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.estacionOrigen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ruta de Viaje";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // estacionDestino
            // 
            this.estacionDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estacionDestino.FormattingEnabled = true;
            this.estacionDestino.Location = new System.Drawing.Point(471, 24);
            this.estacionDestino.Name = "estacionDestino";
            this.estacionDestino.Size = new System.Drawing.Size(181, 21);
            this.estacionDestino.Sorted = true;
            this.estacionDestino.TabIndex = 3;
            this.estacionDestino.SelectedIndexChanged += new System.EventHandler(this.estacionDestino_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estación de Destino:";
            // 
            // estacionOrigen
            // 
            this.estacionOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estacionOrigen.FormattingEnabled = true;
            this.estacionOrigen.Location = new System.Drawing.Point(112, 24);
            this.estacionOrigen.Name = "estacionOrigen";
            this.estacionOrigen.Size = new System.Drawing.Size(181, 21);
            this.estacionOrigen.Sorted = true;
            this.estacionOrigen.TabIndex = 1;
            this.estacionOrigen.SelectedIndexChanged += new System.EventHandler(this.estacionOrigen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estación de Origen:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 570);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(687, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "Listo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eliProhibida);
            this.groupBox2.Controls.Add(this.agrProhibida);
            this.groupBox2.Controls.Add(this.eliObligatoria);
            this.groupBox2.Controls.Add(this.agrObligatoria);
            this.groupBox2.Controls.Add(this.selProhibida);
            this.groupBox2.Controls.Add(this.selObligatoria);
            this.groupBox2.Controls.Add(this.listaProhibidas);
            this.groupBox2.Controls.Add(this.listaObligatorias);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 291);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restricciones";
            // 
            // eliProhibida
            // 
            this.eliProhibida.Location = new System.Drawing.Point(362, 254);
            this.eliProhibida.Name = "eliProhibida";
            this.eliProhibida.Size = new System.Drawing.Size(97, 23);
            this.eliProhibida.TabIndex = 9;
            this.eliProhibida.Text = "Eliminar";
            this.eliProhibida.UseVisualStyleBackColor = true;
            this.eliProhibida.Click += new System.EventHandler(this.eliProhibida_Click);
            // 
            // agrProhibida
            // 
            this.agrProhibida.Location = new System.Drawing.Point(244, 254);
            this.agrProhibida.Name = "agrProhibida";
            this.agrProhibida.Size = new System.Drawing.Size(97, 23);
            this.agrProhibida.TabIndex = 8;
            this.agrProhibida.Text = "Agregar";
            this.agrProhibida.UseVisualStyleBackColor = true;
            this.agrProhibida.Click += new System.EventHandler(this.agrProhibida_Click);
            // 
            // eliObligatoria
            // 
            this.eliObligatoria.Location = new System.Drawing.Point(127, 254);
            this.eliObligatoria.Name = "eliObligatoria";
            this.eliObligatoria.Size = new System.Drawing.Size(97, 23);
            this.eliObligatoria.TabIndex = 7;
            this.eliObligatoria.Text = "Eliminar";
            this.eliObligatoria.UseVisualStyleBackColor = true;
            this.eliObligatoria.Click += new System.EventHandler(this.eliObligatoria_Click);
            // 
            // agrObligatoria
            // 
            this.agrObligatoria.Location = new System.Drawing.Point(9, 254);
            this.agrObligatoria.Name = "agrObligatoria";
            this.agrObligatoria.Size = new System.Drawing.Size(97, 23);
            this.agrObligatoria.TabIndex = 6;
            this.agrObligatoria.Text = "Agregar";
            this.agrObligatoria.UseVisualStyleBackColor = true;
            this.agrObligatoria.Click += new System.EventHandler(this.agrObligatoria_Click);
            // 
            // selProhibida
            // 
            this.selProhibida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selProhibida.FormattingEnabled = true;
            this.selProhibida.Location = new System.Drawing.Point(244, 225);
            this.selProhibida.Name = "selProhibida";
            this.selProhibida.Size = new System.Drawing.Size(215, 21);
            this.selProhibida.Sorted = true;
            this.selProhibida.TabIndex = 5;
            // 
            // selObligatoria
            // 
            this.selObligatoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selObligatoria.FormattingEnabled = true;
            this.selObligatoria.Location = new System.Drawing.Point(9, 225);
            this.selObligatoria.Name = "selObligatoria";
            this.selObligatoria.Size = new System.Drawing.Size(215, 21);
            this.selObligatoria.Sorted = true;
            this.selObligatoria.TabIndex = 4;
            // 
            // listaProhibidas
            // 
            this.listaProhibidas.FormattingEnabled = true;
            this.listaProhibidas.Location = new System.Drawing.Point(244, 40);
            this.listaProhibidas.Name = "listaProhibidas";
            this.listaProhibidas.Size = new System.Drawing.Size(215, 173);
            this.listaProhibidas.TabIndex = 3;
            // 
            // listaObligatorias
            // 
            this.listaObligatorias.FormattingEnabled = true;
            this.listaObligatorias.Location = new System.Drawing.Point(9, 40);
            this.listaObligatorias.Name = "listaObligatorias";
            this.listaObligatorias.Size = new System.Drawing.Size(215, 173);
            this.listaObligatorias.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Estaciones prohibidas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Estaciones obligatorias:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tamIndividuo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.probCruce);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.probMutacion);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numIteraciones);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tamPoblacion);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(483, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 291);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parámetros";
            // 
            // tamIndividuo
            // 
            this.tamIndividuo.Location = new System.Drawing.Point(6, 249);
            this.tamIndividuo.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.tamIndividuo.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tamIndividuo.Name = "tamIndividuo";
            this.tamIndividuo.Size = new System.Drawing.Size(172, 20);
            this.tamIndividuo.TabIndex = 9;
            this.tamIndividuo.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tamaño máximo del Individuo:";
            // 
            // probCruce
            // 
            this.probCruce.DecimalPlaces = 1;
            this.probCruce.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.probCruce.Location = new System.Drawing.Point(6, 199);
            this.probCruce.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.probCruce.Name = "probCruce";
            this.probCruce.Size = new System.Drawing.Size(172, 20);
            this.probCruce.TabIndex = 7;
            this.probCruce.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Probabilidad de Cruce:";
            // 
            // probMutacion
            // 
            this.probMutacion.DecimalPlaces = 1;
            this.probMutacion.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.probMutacion.Location = new System.Drawing.Point(6, 143);
            this.probMutacion.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.probMutacion.Name = "probMutacion";
            this.probMutacion.Size = new System.Drawing.Size(172, 20);
            this.probMutacion.TabIndex = 5;
            this.probMutacion.ThousandsSeparator = true;
            this.probMutacion.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Probabilidad de Mutación:";
            // 
            // numIteraciones
            // 
            this.numIteraciones.Location = new System.Drawing.Point(9, 91);
            this.numIteraciones.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numIteraciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIteraciones.Name = "numIteraciones";
            this.numIteraciones.Size = new System.Drawing.Size(172, 20);
            this.numIteraciones.TabIndex = 3;
            this.numIteraciones.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Número de Iteraciones";
            // 
            // tamPoblacion
            // 
            this.tamPoblacion.Location = new System.Drawing.Point(9, 41);
            this.tamPoblacion.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tamPoblacion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tamPoblacion.Name = "tamPoblacion";
            this.tamPoblacion.Size = new System.Drawing.Size(172, 20);
            this.tamPoblacion.TabIndex = 1;
            this.tamPoblacion.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tamaño de Población:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.penRecorrido);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.penTransbordos);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.penProhibidas);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.penObligatorias);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(12, 394);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(663, 94);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Penalizaciones";
            // 
            // penRecorrido
            // 
            this.penRecorrido.Location = new System.Drawing.Point(455, 58);
            this.penRecorrido.Name = "penRecorrido";
            this.penRecorrido.Size = new System.Drawing.Size(146, 20);
            this.penRecorrido.TabIndex = 7;
            this.penRecorrido.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(331, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Longitud de Recorrido:";
            // 
            // penTransbordos
            // 
            this.penTransbordos.Location = new System.Drawing.Point(130, 58);
            this.penTransbordos.Name = "penTransbordos";
            this.penTransbordos.Size = new System.Drawing.Size(146, 20);
            this.penTransbordos.TabIndex = 5;
            this.penTransbordos.Text = "3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Transbordos:";
            // 
            // penProhibidas
            // 
            this.penProhibidas.Location = new System.Drawing.Point(455, 22);
            this.penProhibidas.Name = "penProhibidas";
            this.penProhibidas.Size = new System.Drawing.Size(146, 20);
            this.penProhibidas.TabIndex = 3;
            this.penProhibidas.Text = "20";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(331, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Estaciones prohibidas:";
            // 
            // penObligatorias
            // 
            this.penObligatorias.Location = new System.Drawing.Point(130, 22);
            this.penObligatorias.Name = "penObligatorias";
            this.penObligatorias.Size = new System.Drawing.Size(146, 20);
            this.penObligatorias.TabIndex = 1;
            this.penObligatorias.Text = "20";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Estaciones obligatorias:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcula la Ruta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usarMutacion
            // 
            this.usarMutacion.AutoSize = true;
            this.usarMutacion.Location = new System.Drawing.Point(300, 542);
            this.usarMutacion.Name = "usarMutacion";
            this.usarMutacion.Size = new System.Drawing.Size(95, 17);
            this.usarMutacion.TabIndex = 7;
            this.usarMutacion.Text = "Usar Mutación";
            this.usarMutacion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 592);
            this.Controls.Add(this.usarMutacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(703, 630);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(703, 630);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tamIndividuo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probCruce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probMutacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIteraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamPoblacion)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox estacionDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox estacionOrigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown tamIndividuo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown probCruce;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown probMutacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numIteraciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown tamPoblacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button eliProhibida;
        private System.Windows.Forms.Button agrProhibida;
        private System.Windows.Forms.Button eliObligatoria;
        private System.Windows.Forms.Button agrObligatoria;
        private System.Windows.Forms.ComboBox selProhibida;
        private System.Windows.Forms.ComboBox selObligatoria;
        private System.Windows.Forms.ListBox listaProhibidas;
        private System.Windows.Forms.ListBox listaObligatorias;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox penRecorrido;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox penTransbordos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox penProhibidas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox penObligatorias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox usarMutacion;
    }
}

