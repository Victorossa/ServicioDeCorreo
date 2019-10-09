namespace EnvioAServicioMensajeria
{
    partial class EnvioServicioMensajeria
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LapsoEnvioServicioMensajeria = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.LapsoEnvioServicioMensajeria)).BeginInit();
            // 
            // LapsoEnvioServicioMensajeria
            // 
            this.LapsoEnvioServicioMensajeria.Enabled = true;
            this.LapsoEnvioServicioMensajeria.Interval = 3000D;
            this.LapsoEnvioServicioMensajeria.Elapsed += new System.Timers.ElapsedEventHandler(this.LapsoEnvioServicioMensajeria_Elapsed);
            // 
            // EnvioServicioMensajeria
            // 
            this.ServiceName = "EnvioServicioMensajeria";
            ((System.ComponentModel.ISupportInitialize)(this.LapsoEnvioServicioMensajeria)).EndInit();

        }

        #endregion

        private System.Timers.Timer LapsoEnvioServicioMensajeria;
    }
}
