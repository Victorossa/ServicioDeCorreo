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
            this.BtnCorreoCola = new System.Windows.Forms.Button();
            this.BtnEnvioServicioCorreo = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.Btn_Seleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCorreoCola
            // 
            this.BtnCorreoCola.Location = new System.Drawing.Point(668, 111);
            this.BtnCorreoCola.Name = "BtnCorreoCola";
            this.BtnCorreoCola.Size = new System.Drawing.Size(111, 55);
            this.BtnCorreoCola.TabIndex = 2;
            this.BtnCorreoCola.Text = "Generar Archivo En Cola desde Excel";
            this.BtnCorreoCola.UseVisualStyleBackColor = true;
            this.BtnCorreoCola.Click += new System.EventHandler(this.BtnCorreoCola_Click);
            // 
            // BtnEnvioServicioCorreo
            // 
            this.BtnEnvioServicioCorreo.Location = new System.Drawing.Point(668, 213);
            this.BtnEnvioServicioCorreo.Name = "BtnEnvioServicioCorreo";
            this.BtnEnvioServicioCorreo.Size = new System.Drawing.Size(111, 55);
            this.BtnEnvioServicioCorreo.TabIndex = 3;
            this.BtnEnvioServicioCorreo.Text = "Envio a Servicio de Correo (SIMPLE)";
            this.BtnEnvioServicioCorreo.UseVisualStyleBackColor = true;
            this.BtnEnvioServicioCorreo.Click += new System.EventHandler(this.BtnEnvioServicioCorreo_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 61);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(640, 285);
            this.txtResultado.TabIndex = 5;
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(55, 354);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(597, 20);
            this.txtRuta.TabIndex = 4;
            // 
            // Btn_Seleccionar
            // 
            this.Btn_Seleccionar.Location = new System.Drawing.Point(12, 12);
            this.Btn_Seleccionar.Name = "Btn_Seleccionar";
            this.Btn_Seleccionar.Size = new System.Drawing.Size(111, 42);
            this.Btn_Seleccionar.TabIndex = 6;
            this.Btn_Seleccionar.Text = "Generar Archivo en Base 64";
            this.Btn_Seleccionar.UseVisualStyleBackColor = true;
            this.Btn_Seleccionar.Click += new System.EventHandler(this.Btn_Seleccionar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "RUTA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Seleccionar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.BtnEnvioServicioCorreo);
            this.Controls.Add(this.BtnCorreoCola);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Pruebas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCorreoCola;
        private System.Windows.Forms.Button BtnEnvioServicioCorreo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button Btn_Seleccionar;
        private System.Windows.Forms.Label label1;
    }
}

