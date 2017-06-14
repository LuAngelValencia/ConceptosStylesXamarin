using Xamarin.Forms;
using ConceptosStyles;
using Syncfusion.SfDataGrid.XForms;

namespace ConceptosStyles.Views
{
    public partial class Simulador : ContentPage
    {
        public Simulador()
        {
            InitializeComponent();

            //CustomSelectionController datagrid = new CustomSelectionController();
            //datagrid.GetSelectionBackgroundColor();
            //dataGrid.SelectionMode = SelectionMode.Multiple;
            dataGrid.GridStyle = new CustomSelectionController();
        }

        private void pckPlanes_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedValue = pckPlanes.Items[pckPlanes.SelectedIndex];
            if(selectedValue == "Especiales")
            {
                NormalesPicked.IsVisible = false;
                EspecialesPicked.IsVisible = true;
            } else
            {
                NormalesPicked.IsVisible = true;
                EspecialesPicked.IsVisible = false;
            }
        }
    }
}
