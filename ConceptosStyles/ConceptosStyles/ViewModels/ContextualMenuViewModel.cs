using ConceptosStyles.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ConceptosStyles.ViewModels
{
    public class ContextualMenuViewModel : BindableBase
    {
        private string _nombreCliente;
        public string NombreCliente
        {
            get { return _nombreCliente; }
            set { SetProperty(ref _nombreCliente, value); }
        }

        private string _ccCliente;
        public string CcCliente
        {
            get { return _ccCliente; }
            set { SetProperty(ref _ccCliente, value); }
        }

        private string _estado;
        public string Estado
        {
            get { return _estado; }
            set { SetProperty(ref _estado, value); }
        }

        private string _nombreAsesor;
        public string NombreAsesor
        {
            get { return _nombreAsesor; }
            set { SetProperty(ref _nombreAsesor, value); }
        }

        private string _cupoCredito;
        public string CupoCredito
        {
            get { return _cupoCredito; }
            set { SetProperty(ref _cupoCredito, value); }
        }

        private string _montoDisponible;
        public string MontoDisponible
        {
            get { return _montoDisponible; }
            set { SetProperty(ref _montoDisponible, value); }
        }

        public INavigationService _navigationService { get; set; }

        public ContextualMenuViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public  void CargarSolicitudPrincipalPage()
        {
            var navigationParams = new NavigationParameters();
            navigationParams.Add("_nombreCliente", NombreCliente);
            navigationParams.Add("_ccCliente", CcCliente);
            navigationParams.Add("_estado", Estado);
            navigationParams.Add("_nombreAsesor", NombreAsesor);
            navigationParams.Add("_cupoCredito", CupoCredito);
            navigationParams.Add("_montoDisponible", MontoDisponible);
            _navigationService.NavigateAsync("SolicitudesPrincipal", navigationParams);
            PopupNavigation.PopAsync();
        }
    }
}
