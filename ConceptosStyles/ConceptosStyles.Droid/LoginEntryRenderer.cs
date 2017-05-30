using Xamarin.Forms;
using ConceptosStyles;
using ConceptosStyles.Droid;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(LoginEntry), typeof(LoginEntryRenderer))]
namespace ConceptosStyles.Droid
{
    public class LoginEntryRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetPadding(80,5,5,5);
            }
        }
    }
}