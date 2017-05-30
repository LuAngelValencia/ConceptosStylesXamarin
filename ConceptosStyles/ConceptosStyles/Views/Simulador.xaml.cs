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
    }
}
