using HelpDesk.Bll;
using HelpDesk.Dal;
using HelpDesk.Dal.Common;
using HelpDesk.UI.Formularios;
using HelpDesk.UI.Formularios.Seguridad;

namespace HelpDesk.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ConfiguracionDal configuracionDal = new();

            // Si no existe la configuración, solicitarla
            if(!configuracionDal.ExisteConfiguracion())
            {
                FrmConfiguracionConexion frmConfig = new FrmConfiguracionConexion();
                DialogResult resultado = frmConfig.ShowDialog();

                if (resultado != DialogResult.OK)
                    return;
            }

            // Leer la configuración guardada
            var config = configuracionDal.Obtener();

            if(config is null)
            {
                MessageBox.Show("No fue posible cargar la configuración de conexión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // construir la cadae de conexión
            Conexion.CadenaConexion =
                $"Server={config.Servidor};" +
                $"Database={config.BaseDatos};" +
                $"User Id={config.UsuarioSql};" +
                $"Password={config.Password};" +
                $"TrustServerCertificate=True;";

            try
            {
                SistemaBll sistemaBll = new SistemaBll(new SistemaDal());

                sistemaBll.CrearAdministradorInicialAsync()
                    .GetAwaiter()
                    .GetResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Run(new FrmPrincipal());
        }
    }
}