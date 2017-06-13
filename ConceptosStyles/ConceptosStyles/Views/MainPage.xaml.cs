using ConceptosStyles.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using ConceptosStyles.Animations;

namespace ConceptosStyles.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {          
            InitializeComponent();
            flipperCtrl.FlipOnTap = false;
            flipperCtrl.FlipState = FlipState.Front;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (flipperCtrl.FlipState == FlipState.Back)
            {
                flipperCtrl.FlipState = FlipState.Front;
            }
            else
            {
                flipperCtrl.FlipState = FlipState.Back;
            }            
        }
    }   
}
