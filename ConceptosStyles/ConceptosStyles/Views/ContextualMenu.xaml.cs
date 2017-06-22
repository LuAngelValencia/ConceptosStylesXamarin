using ConceptosStyles.Models;
using ConceptosStyles.ViewModels;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;

namespace ConceptosStyles.Views
{
    public partial class ContextualMenu : PopupPage
    {
        public ContextualMenuViewModel ViewModel
        {
            get { return (ContextualMenuViewModel)BindingContext; }
        }

        public ContextualMenu(BookInfo bookInfo)
        {
            InitializeComponent();

            ViewModel.NombreCliente = bookInfo.NombreCliente;
            ViewModel.CcCliente = bookInfo.CcCliente;
            ViewModel.Estado = bookInfo.Estado;
            ViewModel.NombreAsesor = bookInfo.NombreAsesor;
            ViewModel.CupoCredito = bookInfo.CupoCredito;
            ViewModel.MontoDisponible = bookInfo.MontoDisponible;
        }

        private void OnClose(object sender, EventArgs e)
        {
            PopupNavigation.PopAsync();
        }

        private  void OpenSolicitudes(object sender, Xamarin.Forms.TappedEventArgs e)
        {
            try
            {
                ViewModel.CargarSolicitudPrincipalPage();
            } catch( Exception ex) {
                throw ex;
            }
            
        }
    }
}
