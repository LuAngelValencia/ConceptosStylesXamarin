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

        private void TapGestureRecognizer_Tapped(object sender, SelectedItemChangedEventArgs e)
        {
           //ViewModel.DisplayActionSheetAsync();
           
            Label lbl = (Label)sender;
            int text = Int32.Parse(lbl.ClassId);

            //ViewModel.ShowContextualMenu(text);
            //actIndBackground.IsVisible = true;

            //var label = new Label();
            //label.Text = "ajaaa";

            //var y = lbl.Y; var parent = lbl.Parent; var x = lbl.X;
            //var wow = listView.SelectedItem;
            //DisplayAlert("este es", "y " + y + " x " + x + " parent" + parent+" wow "+wow , null, "ok");




            if (text == 0)
            {
                ContextualMenu.TranslationY = 125;
            }
            else
            {
                ContextualMenu.TranslationY = 125 * (text + 1);
            }

            mainContent.Children.Add (ContextualMenu);
            ContextualMenu.IsVisible = true;


        }

        private void CerrarContextualMenu(object sender, SelectedItemChangedEventArgs e)
        {
            ContextualMenu.IsVisible = false;
        }


        private  void OnTapped(object sender, SelectedItemChangedEventArgs e)
        {
            
            DisplayAlert("Item Selected",null,null, "Ok");
            Grid gr = (Grid)sender;

            gr.RowDefinitions = new RowDefinitionCollection();
            gr.ColumnDefinitions = new ColumnDefinitionCollection();

            gr.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            gr.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var lbl1 = new Label
            {
                Text = "Solicitud"
            };

            //gr.Children.Add(lbl1, 3,0);
        }

        private void OnTappedTwo(object sender, SelectedItemChangedEventArgs e)
        {

            

            StackLayout stack = (StackLayout)sender;
       
            
            //var Rel = new StackLayout
            //{
            //    BackgroundColor = Color.Red,
            //    HeightRequest = 300

            //};
            //var lbl1 = new Label
            //{
            //    Text = "Solicitud"
            //}; 
            //var lbl2 = new Label
            //{
            //    Text = "Pago"
            //};
            //var lbl3 = new Label
            //{
            //    Text = "Histórico"
            //};
            //var lbl4 = new Label
            //{
            //    Text = "Nuevo Crédito"
            //};
            //var lbl5 = new Label
            //{
            //    Text = "Aumento de Crédito"
            //};
            //var lbl6 = new Label
            //{
            //    Text = "Cerrar"
            //};

            //AbsoluteLayout.SetLayoutFlags(Rel, AbsoluteLayoutFlags.All);
            //AbsoluteLayout.SetLayoutBounds(Rel, new Rectangle(0, -30, 1, -1));

            //var controlGrid = new Grid ();
            //controlGrid.RowDefinitions.Add(new RowDefinition { Height  = new GridLength(1, GridUnitType.Star) });
            //controlGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            //controlGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            //controlGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            //controlGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            //controlGrid.Children.Add(lbl1, 0, 0);
            //controlGrid.Children.Add(lbl2, 0, 1);
            //controlGrid.Children.Add(lbl3, 0, 2);
            //controlGrid.Children.Add(lbl4, 1, 0);
            //controlGrid.Children.Add(lbl5, 1, 1);
            //controlGrid.Children.Add(lbl6, 1, 2);

            //Rel.Children.Add(lbl1);
            //Rel.Children.Add(lbl2);
            //Rel.Children.Add(lbl3);
            //Rel.Children.Add(lbl4);
            //Rel.Children.Add(lbl5);
            //Rel.Children.Add(lbl6);

            //stack.Children.Add(Rel);
            stack.Children.Add(ContextualMenu);
            ContextualMenu.IsVisible = true;
            
        }


        //private void OnTappedThree(object sender, SelectedItemChangedEventArgs e)
        //{
        //    DisplayAlert("Item Selected 3", null, null, "Ok");
        //    AbsoluteLayout abs = (AbsoluteLayout)sender;
        //    abs.Children.Add(ContextualMenu);
        //    ContextualMenu.IsVisible = true;
        //}

        private async void OnUserAnimationPupup(object sender, Xamarin.Forms.TappedEventArgs e)
        {
            var bookInfo = (BookInfo)e.Parameter;
            var page = new ContextualMenu(bookInfo);
            await Navigation.PushPopupAsync(page);
        }
       
    }
}
