﻿using ConceptosStyles.Models;
using ConceptosStyles.ViewModels;
using Rg.Plugins.Popup.Extensions;
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
    public partial class SolicitudesReferenciasPersonalesContentView : Xamarin.Forms.ContentView
    {
        public SolicitudesPrincipalViewModel ViewModel
        {
            get
            {
                return (SolicitudesPrincipalViewModel)BindingContext;
            }
        }

        public SolicitudesReferenciasPersonalesContentView()
        {
            InitializeComponent();
            BindingContext = new SolicitudesPrincipalViewModel();
        }

        private async void DireccionPopUp(object sender, Xamarin.Forms.TappedEventArgs e)
        {
            var page = new DireccionContentView();
            await Navigation.PushPopupAsync(page);
        }

        private void BorrarItemListView(object sender, Xamarin.Forms.TappedEventArgs e)
        {
            try
            {
                var bookInfo = (ReferenciasModel)e.Parameter;
                ViewModel.EliminarReferenciaPersonal(bookInfo);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        private void refListView_ItemTapped(object sender, Xamarin.Forms.TappedEventArgs e)
        {
            try
            {
                var bookInfo = (ReferenciasModel)e.Parameter;
                ViewModel.CargarFormularioRefPersonal(bookInfo);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}