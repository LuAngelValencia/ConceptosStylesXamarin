using Syncfusion.SfDataGrid.XForms;
using Xamarin.Forms;

namespace ConceptosStyles
{
    public class CustomSelectionController : DataGridStyle
    {
       

        public CustomSelectionController()
        {
        }
        public override Color GetSelectionBackgroundColor()
        {
            return Color.FromHex("#2578B2");
        }

        public override Color GetAlternatingRowBackgroundColor()
        {
            return Color.FromHex("#F7F7F7");
        }

        //public void gridControl1_QueryCellInfo(object sender, Syncfusion.SfDataGrid.XForms.GridCell e)

        //{

        //    if (e.RowIndex % 2 == 0 && e.RowIndex != 0)

        //        e.BackgroundColor = Color.FromHex("#2578B2");

        //}
    }
}
