using ConceptosStyles.Models;
using ConceptosStyles.ViewModels;
using Syncfusion.ListView.XForms;
using System;
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
            //BookInfoRepository viewModel = new BookInfoRepository();
            //viewModel.GenerateBookInfo();
            //listView = new SfListView();
            //listView.ItemSize = 100;
            //listView.ItemsSource = viewModel.BookInfo;
            //listView.ItemTemplate = new DataTemplate(() =>
            //{
            //    var grid = new Grid();
            //    var bookname = new Label { FontAttributes = FontAttributes.Bold, BackgroundColor = Color.Teal, FontSize = 21 };
            //    bookname.SetBinding(Label.TextProperty, new Binding("BookName"));
            //    var bookdescription = new Label { BackgroundColor = Color.Teal, FontSize = 15 };
            //    bookdescription.SetBinding(Label.TextProperty, new Binding("BookDescription"));

            //    grid.Children.Add(bookname);
            //    grid.Children.Add(bookdescription, 1, 0);

            //    return grid;
            //});

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
           ViewModel.DisplayActionSheetAsync();
           //ViewModel.ShowContextualMenu(sender);
            Label lbl = (Label)sender;
            int text = Int32.Parse(lbl.ClassId);

            ViewModel.ShowContextualMenu(text);


        }

        


    }
}
