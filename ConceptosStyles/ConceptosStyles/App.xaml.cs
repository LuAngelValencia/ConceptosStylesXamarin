using Prism.Unity;
using ConceptosStyles.Views;
using Xamarin.Forms;

namespace ConceptosStyles
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        public App()
        {
            InitializeComponent();
        }

        protected override void OnInitialized()
        {
            InitializeComponent();

            //NavigationService.NavigateAsync("NavigationPage/MainPage?title=Hello%20from%20Xamarin.Forms");
            //MainPage = new MainPage();
            //MainPage = new Dashboard();
            NavigationService.NavigateAsync("NavigationPage/Simulador?title=SolicitudesDatosBasicos");

        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<Dashboard>();
            Container.RegisterTypeForNavigation<Simulador>();
            Container.RegisterTypeForNavigation<CambiarContrasena>();
            Container.RegisterTypeForNavigation<LayoutsExamples>();
            Container.RegisterTypeForNavigation<Listados>();
            Container.RegisterTypeForNavigation<ContextualMenu>();
            Container.RegisterTypeForNavigation<SolicitudesDatosBasicos>();
            Container.RegisterTypeForNavigation<SolicitudesDatosBasicos>();
            Container.RegisterTypeForNavigation<SolicitudesDatosBasicos>();
        }
    }
}
