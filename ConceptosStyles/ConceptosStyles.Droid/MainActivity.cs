using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Android.Util;

namespace ConceptosStyles.Droid
{
    [Activity(Label = "ConceptosStyles", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.tabs;
            ToolbarResource = Resource.Layout.toolbar;

            base.OnCreate(bundle);

            //Wire Unhandled Android Exepctions 
            AppDomain currentDomain = AppDomain.CurrentDomain;

            currentDomain.UnhandledException += HandleExceptions;

            AndroidEnvironment.UnhandledExceptionRaiser += HandleAndroidException;

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App(new AndroidInitializer()));
        }

        #region Errors Handle Exceptions

        private void HandleAndroidException(object sender, RaiseThrowableEventArgs e)
        {
            var a = e;
            Log.Debug("ERROR", e.Exception.Message + " TRACE: " + e.Exception.StackTrace);
        }

        private static void HandleExceptions(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = (Exception)e.ExceptionObject;

            Log.Debug("ERROR", ex.Message + " TRACE: " + ex.StackTrace);
        }

        #endregion
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {

        }
    }
}

