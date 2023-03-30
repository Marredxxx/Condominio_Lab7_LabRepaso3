namespace Condominio_Lab7_LabRepaso3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCargarDatos = new System.Windows.Forms.Button();
            this.buttonOrdenarxCuotas = new System.Windows.Forms.Button();
            this.buttonPropietarioMasCuotas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCuotaAlta = new System.Windows.Forms.Label();
            this.labelCuotaBaja = new System.Windows.Forms.Label();
            this.labelPrpopietarioCuotaMasAlto = new System.Windows.Forms.Label();
            this.buttonPropMasAlta = new System.Windows.Forms.Button();
            this.labelPropietario = new System.Windows.Forms.Label();
            this.labelCuotaAcumulada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(692, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonCargarDatos
            // 
            this.buttonCargarDatos.Location = new System.Drawing.Point(784, 46);
            this.buttonCargarDatos.Name = "buttonCargarDatos";
            this.buttonCargarDatos.Size = new System.Drawing.Size(142, 39);
            this.buttonCargarDatos.TabIndex = 1;
            this.buttonCargarDatos.Text = "Cargar Datos";
            this.buttonCargarDatos.UseVisualStyleBackColor = true;
            this.buttonCargarDatos.Click += new System.EventHandler(this.buttonCargarDatos_Click);
            // 
            // buttonOrdenarxCuotas
            // 
            this.buttonOrdenarxCuotas.Location = new System.Drawing.Point(784, 119);
            this.buttonOrdenarxCuotas.Name = "buttonOrdenarxCuotas";
            this.buttonOrdenarxCuotas.Size = new System.Drawing.Size(155, 55);
            this.buttonOrdenarxCuotas.TabIndex = 2;
            this.buttonOrdenarxCuotas.Text = "Ordenar por Cuotas de mantenimiento";
            this.buttonOrdenarxCuotas.UseVisualStyleBackColor = true;
            this.buttonOrdenarxCuotas.Click += new System.EventHandler(this.buttonOrdenarxCuotas_Click);
            // 
            // buttonPropietarioMasCuotas
            // 
            this.buttonPropietarioMasCuotas.Location = new System.Drawing.Point(212, 320);
            this.buttonPropietarioMasCuotas.Name = "buttonPropietarioMasCuotas";
            this.buttonPropietarioMasCuotas.Size = new System.Drawing.Size(75, 23);
            this.buttonPropietarioMasCuotas.TabIndex = 3;
            this.buttonPropietarioMasCuotas.Text = "Mostrar Propietario";
            this.buttonPropietarioMasCuotas.UseVisualStyleBackColor = true;
            this.buttonPropietarioMasCuotas.Click += new System.EventHandler(this.buttonPropietarioMasCuotas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(72, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Las 3 cuotas de mantenimiento más altas y las 3 más bajas    ";
            // 
            // labelCuotaAlta
            // 
            this.labelCuotaAlta.AutoSize = true;
            this.labelCuotaAlta.Location = new System.Drawing.Point(89, 352);
            this.labelCuotaAlta.Name = "labelCuotaAlta";
            this.labelCuotaAlta.Size = new System.Drawing.Size(110, 16);
            this.labelCuotaAlta.TabIndex = 5;
            this.labelCuotaAlta.Text = "Cuotas más altas";
            // 
            // labelCuotaBaja
            // 
            this.labelCuotaBaja.AutoSize = true;
            this.labelCuotaBaja.Location = new System.Drawing.Point(89, 377);
            this.labelCuotaBaja.Name = "labelCuotaBaja";
            this.labelCuotaBaja.Size = new System.Drawing.Size(115, 16);
            this.labelCuotaBaja.TabIndex = 6;
            this.labelCuotaBaja.Text = "Cuotas más bajas";
            // 
            // labelPrpopietarioCuotaMasAlto
            // 
            this.labelPrpopietarioCuotaMasAlto.AutoSize = true;
            this.labelPrpopietarioCuotaMasAlto.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelPrpopietarioCuotaMasAlto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrpopietarioCuotaMasAlto.Location = new System.Drawing.Point(520, 301);
            this.labelPrpopietarioCuotaMasAlto.Name = "labelPrpopietarioCuotaMasAlto";
            this.labelPrpopietarioCuotaMasAlto.Size = new System.Drawing.Size(356, 16);
            this.labelPrpopietarioCuotaMasAlto.TabIndex = 7;
            this.labelPrpopietarioCuotaMasAlto.Text = "Propietario con la cuota total más alta                                          " +
    "";
            // 
            // buttonPropMasAlta
            // 
            this.buttonPropMasAlta.Location = new System.Drawing.Point(660, 320);
            this.buttonPropMasAlta.Name = "buttonPropMasAlta";
            this.buttonPropMasAlta.Size = new System.Drawing.Size(75, 23);
            this.buttonPropMasAlta.TabIndex = 8;
            this.buttonPropMasAlta.Text = "Mostrar";
            this.buttonPropMasAlta.UseVisualStyleBackColor = true;
            this.buttonPropMasAlta.Click += new System.EventHandler(this.buttonPropMasAlta_Click);
            // 
            // labelPropietario
            // 
            this.labelPropietario.AutoSize = true;
            this.labelPropietario.Location = new System.Drawing.Point(540, 352);
            this.labelPropietario.Name = "labelPropietario";
            this.labelPropietario.Size = new System.Drawing.Size(73, 16);
            this.labelPropietario.TabIndex = 9;
            this.labelPropietario.Text = "Propietario";
            // 
            // labelCuotaAcumulada
            // 
            this.labelCuotaAcumulada.AutoSize = true;
            this.labelCuotaAcumulada.Location = new System.Drawing.Point(540, 377);
            this.labelCuotaAcumulada.Name = "labelCuotaAcumulada";
            this.labelCuotaAcumulada.Size = new System.Drawing.Size(95, 16);
            this.labelCuotaAcumulada.TabIndex = 10;
            this.labelCuotaAcumulada.Text = "Monto a Pagar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1018, 450);
            this.Controls.Add(this.labelCuotaAcumulada);
            this.Controls.Add(this.labelPropietario);
            this.Controls.Add(this.buttonPropMasAlta);
            this.Controls.Add(this.labelPrpopietarioCuotaMasAlto);
            this.Controls.Add(this.labelCuotaBaja);
            this.Controls.Add(this.labelCuotaAlta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPropietarioMasCuotas);
            this.Controls.Add(this.buttonOrdenarxCuotas);
            this.Controls.Add(this.buttonCargarDatos);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Condominio ";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCargarDatos;
        private System.Windows.Forms.Button buttonOrdenarxCuotas;
        private System.Windows.Forms.Button buttonPropietarioMasCuotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCuotaAlta;
        private System.Windows.Forms.Label labelCuotaBaja;
        private System.Windows.Forms.Label labelPrpopietarioCuotaMasAlto;
        private System.Windows.Forms.Button buttonPropMasAlta;
        private System.Windows.Forms.Label labelPropietario;
        private System.Windows.Forms.Label labelCuotaAcumulada;
    }
}

