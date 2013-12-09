namespace IA_Final
{
    partial class Form2
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
            this.tablaLineas = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estacionOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estacionDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLineas)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaLineas
            // 
            this.tablaLineas.AllowUserToAddRows = false;
            this.tablaLineas.AllowUserToDeleteRows = false;
            this.tablaLineas.AllowUserToResizeColumns = false;
            this.tablaLineas.AllowUserToResizeRows = false;
            this.tablaLineas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaLineas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaLineas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLineas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.lineaOrigen,
            this.estacionOrigen,
            this.lineaDestino,
            this.estacionDestino,
            this.accion});
            this.tablaLineas.Location = new System.Drawing.Point(12, 12);
            this.tablaLineas.Name = "tablaLineas";
            this.tablaLineas.Size = new System.Drawing.Size(833, 189);
            this.tablaLineas.TabIndex = 0;
            // 
            // num
            // 
            this.num.HeaderText = "#";
            this.num.Name = "num";
            // 
            // lineaOrigen
            // 
            this.lineaOrigen.HeaderText = "Línea Origen";
            this.lineaOrigen.Name = "lineaOrigen";
            // 
            // estacionOrigen
            // 
            this.estacionOrigen.HeaderText = "Estación Origen";
            this.estacionOrigen.Name = "estacionOrigen";
            // 
            // lineaDestino
            // 
            this.lineaDestino.HeaderText = "Línea Destino";
            this.lineaDestino.Name = "lineaDestino";
            // 
            // estacionDestino
            // 
            this.estacionDestino.HeaderText = "Estación Destino";
            this.estacionDestino.Name = "estacionDestino";
            // 
            // accion
            // 
            this.accion.HeaderText = "Acción";
            this.accion.Name = "accion";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 213);
            this.Controls.Add(this.tablaLineas);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaLineas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaLineas;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn estacionOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn estacionDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn accion;

    }
}