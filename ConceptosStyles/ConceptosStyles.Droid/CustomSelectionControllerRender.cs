using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ConceptosStyles.Droid;
using Xamarin.Forms;
using Syncfusion.SfDataGrid.XForms;
using ConceptosStyles;

[assembly: ExportRenderer(typeof(CustomSelectionController), typeof(CustomSelectionControllerRender))]

namespace ConceptosStyles.Droid
{
    public class CustomSelectionControllerRender : GridSelectionController
    {
        
        //Code to set multiple selection colors
        public override Color GetSelectionColor(int rowIndex, object rowData)
        {
           
                return Color.Red;
        }
    }
}