using ConceptosStyles.Models;
using ConceptosStyles.ViewModels;
using Rg.Plugins.Popup.Pages;
using Syncfusion.ListView.XForms;
using System.Linq;
using Xamarin.Forms;

namespace ConceptosStyles.ContentView
{
    public partial class DireccionContentView : PopupPage
    {

        public DireccionContentViewViewModel ViewModel
        {
            get
            {
                return (DireccionContentViewViewModel)BindingContext;
            }
        }

        public DireccionContentView()
        {
            InitializeComponent();
            BindingContext = new DireccionContentViewViewModel();
        }

        private void pckCiudades_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedItem = (Picker)sender;

            if (selectedItem.SelectedItem != null)
            {
                var item = (DireccionModel)selectedItem.SelectedItem;

                ViewModel.FiltrarBarrios(item.CiudadNombre);
            }           
        }

        private void pckDepartamentos_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedItem = (Picker)sender;

            if (selectedItem.SelectedItem != null)
            {
                var item = (DireccionModel)selectedItem.SelectedItem;

                ViewModel.FiltrarCiudades(item.DepartamentoNombre);
            }            

            if (ViewModel.BarriosFiltered != null )
            {
                ViewModel.BarriosFiltered.Clear();
            }
        }

        private void pckBarrios_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
        }
    }
}
