namespace pryEtapa5Ambordt
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
            clsVehiculo vehiculoAleatorio = clsVehiculo.CrearVehiculoAleatorio();

            
            CargarImagen(vehiculoAleatorio.Tipo);
        }

        private void CargarImagen(string tipoVehiculo)
        {
            
            Image imagen = ObtenerImagen(tipoVehiculo);

            
            pctImagen.Image = imagen;
        }

        private Image ObtenerImagen(string tipoVehiculo)
        {
            
            string rutaImagen = "";

            switch (tipoVehiculo)
            {
                case "Auto":
                    rutaImagen = "auto";
                    break;
                case "Barco":
                    rutaImagen = "barco";
                    break;
                case "Avión":
                    rutaImagen = "avion";
                    break;
                default:
                    
                    rutaImagen = "imagenPredeterminada";
                    MessageBox.Show("Tipo de vehículo no reconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

          
            return Properties.Resources.ResourceManager.GetObject(rutaImagen) as Image;
        }
    }
}
