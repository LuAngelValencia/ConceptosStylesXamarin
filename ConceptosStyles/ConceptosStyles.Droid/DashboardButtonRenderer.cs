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
using Xamarin.Forms;
using ConceptosStyles;
using ConceptosStyles.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(DashboardButton), typeof(DashboardButtonRenderer))]

namespace ConceptosStyles.Droid
{
    public class DashboardButtonRenderer : ButtonRenderer
    {


        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                
            }

           
        }
        
    }
}