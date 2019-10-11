namespace FormularioPruebas
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
            this.BtnPruebaServicio = new System.Windows.Forms.Button();
            this.BtnPruebaLog = new System.Windows.Forms.Button();
            this.BtnCorreoCola = new System.Windows.Forms.Button();
            this.BtnEnvioServicioCorreo = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.Btn_Seleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPruebaServicio
            // 
            this.BtnPruebaServicio.Location = new System.Drawing.Point(12, 12);
            this.BtnPruebaServicio.Name = "BtnPruebaServicio";
            this.BtnPruebaServicio.Size = new System.Drawing.Size(111, 42);
            this.BtnPruebaServicio.TabIndex = 0;
            this.BtnPruebaServicio.Text = "Probar Servicio";
            this.BtnPruebaServicio.UseVisualStyleBackColor = true;
            // 
            // BtnPruebaLog
            // 
            this.BtnPruebaLog.Location = new System.Drawing.Point(129, 12);
            this.BtnPruebaLog.Name = "BtnPruebaLog";
            this.BtnPruebaLog.Size = new System.Drawing.Size(111, 42);
            this.BtnPruebaLog.TabIndex = 1;
            this.BtnPruebaLog.Text = "Prueba Log";
            this.BtnPruebaLog.UseVisualStyleBackColor = true;
            // 
            // BtnCorreoCola
            // 
            this.BtnCorreoCola.Location = new System.Drawing.Point(677, 109);
            this.BtnCorreoCola.Name = "BtnCorreoCola";
            this.BtnCorreoCola.Size = new System.Drawing.Size(111, 42);
            this.BtnCorreoCola.TabIndex = 2;
            this.BtnCorreoCola.Text = "Generar Archivo En Cola desde Excel";
            this.BtnCorreoCola.UseVisualStyleBackColor = true;
            this.BtnCorreoCola.Click += new System.EventHandler(this.BtnCorreoCola_Click);
            // 
            // BtnEnvioServicioCorreo
            // 
            this.BtnEnvioServicioCorreo.Location = new System.Drawing.Point(677, 265);
            this.BtnEnvioServicioCorreo.Name = "BtnEnvioServicioCorreo";
            this.BtnEnvioServicioCorreo.Size = new System.Drawing.Size(111, 55);
            this.BtnEnvioServicioCorreo.TabIndex = 3;
            this.BtnEnvioServicioCorreo.Text = "Envio a Servicio de Correo (SIMPLE)";
            this.BtnEnvioServicioCorreo.UseVisualStyleBackColor = true;
            this.BtnEnvioServicioCorreo.Click += new System.EventHandler(this.BtnEnvioServicioCorreo_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 109);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(640, 294);
            this.txtResultado.TabIndex = 5;
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(12, 411);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(640, 20);
            this.txtRuta.TabIndex = 4;
            // 
            // Btn_Seleccionar
            // 
            this.Btn_Seleccionar.Location = new System.Drawing.Point(12, 60);
            this.Btn_Seleccionar.Name = "Btn_Seleccionar";
            this.Btn_Seleccionar.Size = new System.Drawing.Size(111, 42);
            this.Btn_Seleccionar.TabIndex = 6;
            this.Btn_Seleccionar.Text = "Cargar Para Base 64";
            this.Btn_Seleccionar.UseVisualStyleBackColor = true;
            this.Btn_Seleccionar.Click += new System.EventHandler(this.Btn_Seleccionar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Seleccionar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.BtnEnvioServicioCorreo);
            this.Controls.Add(this.BtnCorreoCola);
            this.Controls.Add(this.BtnPruebaLog);
            this.Controls.Add(this.BtnPruebaServicio);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Pruebas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPruebaServicio;
        private System.Windows.Forms.Button BtnPruebaLog;
        private System.Windows.Forms.Button BtnCorreoCola;
        private System.Windows.Forms.Button BtnEnvioServicioCorreo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button Btn_Seleccionar;
    }
}

