using Xamarin.Forms;

namespace ConceptosStyles.Views
{
    public partial class SolicitudesPrincipal : ContentPage
    {
        public SolicitudesPrincipal()
        {
            InitializeComponent();

            cvSolicitudesRefPersonales.BindingContext = BindingContext;

        }
    }
}
