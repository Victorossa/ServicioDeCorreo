namespace ServicioDeEnvio
{
    partial class ServicioDeEnvioMensajes
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
            this.LapsoServicioEnvio = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.LapsoServicioEnvio)).BeginInit();
            // 
            // LapsoServicioEnvio
            // 
            this.LapsoServicioEnvio.Enabled = true;
            this.LapsoServicioEnvio.Interval = 10000D;
            this.LapsoServicioEnvio.Elapsed += new System.Timers.ElapsedEventHandler(this.LapsoServicioEnvio_Elapsed);
            // 
            // ServicioDeEnvioMensajes
            // 
            this.ServiceName = "ServicioDeEnvioMensajes";
            ((System.ComponentModel.ISupportInitialize)(this.LapsoServicioEnvio)).EndInit();

        }

        #endregion

        private System.Timers.Timer LapsoServicioEnvio;
    }
}
