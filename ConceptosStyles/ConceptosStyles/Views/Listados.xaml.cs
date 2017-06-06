using ConceptosStyles.Models;
using ConceptosStyles.ViewModels;
using Rg.Plugins.Popup.Extensions;
using Syncfusion.ListView.XForms;
using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace ConceptosStyles.Views
{
    public partial class Listados : ContentPage
    {

        public ListadosViewModel ViewModel
        {
            get
            {
                return (ListadosViewModel)BindingContext;
            }
            set {
                BindingContext = value;
            }
        }

        public Listados()
        {
            InitializeComponent();
            

            ViewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName.Equals("IsVisible"))
                {
                    IsVisible = true;
                }
            };

           

            

        }
          
        
    

        private async void OnUserAnimationPupup(object sender, Xamarin.Forms.TappedEventArgs e)
        {
            var bookInfo = (BookInfo)e.Parameter;
            var page = new ContextualMenu(bookInfo);
            await Navigation.PushPopupAsync(page);
        }
       
    }
}
