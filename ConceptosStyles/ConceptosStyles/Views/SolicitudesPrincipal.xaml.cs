using ConceptosStyles.ContentView;
using Xamarin.Forms;

namespace ConceptosStyles.Views
{
    public partial class SolicitudesPrincipal : ContentPage
    {
        public SolicitudesPrincipal()
        {
            InitializeComponent();

            cvSolicitudesRefPersonales.BindingContext = BindingContext;
            cvSolicitudesDatosBasicos.BindingContext = BindingContext;
        }

        private void ShowDatosBasicos(object sender, Xamarin.Forms.TappedEventArgs e)
        {
            if( !cvSolicitudesDatosBasicos.IsVisible )
            {
                cvSolicitudesDatosBasicos.IsVisible = true;

                cvSolicitudesDatosComplementarios.IsVisible = false;
                cvSolicitudesRefLaborales.IsVisible = false;
                cvSolicitudesRefPersonales.IsVisible = false;
                cvSolicitudesDocAdicionales.IsVisible = false;
            }
        }


        private void ShowDatosComplementarios(object sender, Xamarin.Forms.TappedEventArgs e)
        {
            if (!cvSolicitudesDatosComplementarios.IsVisible)
            {
                cvSolicitudesDatosComplementarios.IsVisible = true;

                cvSolicitudesDatosBasicos.IsVisible = false;
                cvSolicitudesRefLaborales.IsVisible = false;
                cvSolicitudesRefPersonales.IsVisible = false;
                cvSolicitudesDocAdicionales.IsVisible = false;
            }
        }


        private void ShowRefLaborales(object sender, Xamarin.Forms.TappedEventArgs e)
        {
            if (!cvSolicitudesRefLaborales.IsVisible)
            {
                cvSolicitudesRefLaborales.IsVisible = true;

                cvSolicitudesDatosComplementarios.IsVisible = false;
                cvSolicitudesDatosBasicos.IsVisible = false;
                cvSolicitudesRefPersonales.IsVisible = false;
                cvSolicitudesDocAdicionales.IsVisible = false;
            }
        }


        private void ShowRefPersonales(object sender, Xamarin.Forms.TappedEventArgs e)
        {
            if (!cvSolicitudesRefPersonales.IsVisible)
            {
                cvSolicitudesRefPersonales.IsVisible = true;

                cvSolicitudesDatosComplementarios.IsVisible = false;
                cvSolicitudesRefLaborales.IsVisible = false;
                cvSolicitudesDatosBasicos.IsVisible = false;
                cvSolicitudesDocAdicionales.IsVisible = false;
            }
        }

        private void ShowDocsAdicionales(object sender, Xamarin.Forms.TappedEventArgs e)
        {
            if (!cvSolicitudesDocAdicionales.IsVisible)
            {
                cvSolicitudesDocAdicionales.IsVisible = true;

                cvSolicitudesDatosComplementarios.IsVisible = false;
                cvSolicitudesRefLaborales.IsVisible = false;
                cvSolicitudesRefPersonales.IsVisible = false;
                cvSolicitudesDatosBasicos.IsVisible = false;
            }
        }

        

    }
}
