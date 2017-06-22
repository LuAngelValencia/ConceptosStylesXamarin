using ConceptosStyles.ViewModels;
using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConceptosStyles.ContentView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SolicitudesDocAdicionalesContentView : Xamarin.Forms.ContentView
    {
        public SolicitudesPrincipalViewModel ViewModel
        {
            get
            {
                return (SolicitudesPrincipalViewModel)BindingContext;
            }
        }

        public SolicitudesDocAdicionalesContentView()
        {
            InitializeComponent();
            BindingContext = new SolicitudesPrincipalViewModel();
        }

        private async void TakePicture(object sender, EventArgs e)
        {
            Image fuente = (Image)sender;
            Image destino = null;

            await CrossMedia.Current.Initialize();

            if(!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await App.Current.MainPage.DisplayAlert("Camara no disponible", "No se encuentra ninguna cámara disponible en tu dispositivo :( ", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(
                new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {
                    SaveToAlbum = false
                });

            if (file == null)
                return;

            if (fuente.ClassId == "fuenteFotoCliente")
            {
                destino = fotoCliente;
            }
            if (fuente.ClassId == "fuenteFotoClienteDelantera")
            {
                destino = fotoClienteDelantera;
            }
            if (fuente.ClassId == "fuenteFotoClienteTrasera")
            {
                destino = fotoClienteTrasera;
            }


            destino.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });



        }

        private async void MorePictures(object sender, EventArgs e)
        {
            var file = await CrossMedia.Current.TakePhotoAsync(
               new Plugin.Media.Abstractions.StoreCameraMediaOptions
               {
                   SaveToAlbum = false
               });

            Image newImage = new Image
            {
                WidthRequest = 150,
                Margin = new Thickness(0, 0, 0, 5)
            };

            string url = file.AlbumPath;
            newImage.Source = url;

            ContenedorImagenesAdicionales.Children.Add(newImage);
        }
    }
}