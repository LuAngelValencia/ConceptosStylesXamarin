using ConceptosStyles.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace ConceptosStyles.ViewModels
{
    public class ListadosViewModel : BindableBase
    {
        private ObservableCollection<BookInfo> bookInfo;
        
        public ObservableCollection<BookInfo> BookInfo
        {
            get { return bookInfo; }
            set { this.bookInfo = value; RaisePropertyChanged(); }
        }

        private IPageDialogService _pageDialogService { get; set; }
        

        public ListadosViewModel(IPageDialogService pageDialogService)
        {
            _pageDialogService = pageDialogService;
            GenerateBookInfo();
        }


        //public bool IsVisible { get; private set; }
        //public void ShowContextualMenu(int sender)
        //{
            
        //    BookInfo[sender].IsVisible = true;

        //}

        //private bool _isBusy;
        //public bool IsBusy
        //{
        //    get { return _isBusy; }
        //    set { SetProperty(ref _isBusy, value); }
        //}

       

        //public void DisplayActionSheetAsync()
        //{
        //    _pageDialogService.DisplayActionSheetAsync("Acciones", "Cancelar", null, "Aumento de Cupo", "Saldo", "Pago", "Histórico", "Solicitud", "Nuevo Crédito");
            
        //}


        internal void GenerateBookInfo()
        {
            bookInfo = new ObservableCollection<BookInfo>();
            bookInfo.Add(new BookInfo() { Numerador = 0, NombreCliente = "Natalia Florez", CcCliente="1.020.400", Estado = "ACTIVO", NombreAsesor = "Luis Angel Valencia", CupoCredito ="$600.000", MontoDisponible= "$300.000", IsVisible = false });
            bookInfo.Add(new BookInfo() { Numerador = 1, NombreCliente = "Carolina Arango", CcCliente = "1.020.304", Estado = "ACTIVO", NombreAsesor = "Luis Angel Valencia", CupoCredito = "$400.000", MontoDisponible = "$200.000", IsVisible = false });
            bookInfo.Add(new BookInfo() { Numerador = 2, NombreCliente = "Sandra Roldan", CcCliente = "1.020.500", Estado = "ACTIVO", NombreAsesor = "Luis Angel Valencia", CupoCredito = "$300.000", MontoDisponible = "$100.000", IsVisible = false });
            bookInfo.Add(new BookInfo() { Numerador = 3, NombreCliente = "Yecenia Cano", CcCliente = "1.600.304", Estado = "ACTIVO", NombreAsesor = "Luis Angel Valencia", CupoCredito = "$200.000", MontoDisponible = "$100.000", IsVisible = false });
            bookInfo.Add(new BookInfo() { Numerador = 4, NombreCliente = "William Sierra", CcCliente = "1.800.304", Estado = "ACTIVO", NombreAsesor = "Luis Angel Valencia", CupoCredito = "$100.000", MontoDisponible = "$30.000", IsVisible = false });
            bookInfo.Add(new BookInfo() { Numerador = 5, NombreCliente = "Juan David Ramirez", CcCliente = "2.020.304", Estado = "ACTIVO", NombreAsesor = "Luis Angel Valencia", CupoCredito = "$800.000", MontoDisponible = "$600.000", IsVisible = false });
            bookInfo.Add(new BookInfo() { Numerador = 6, NombreCliente = "Nicolas Alcaraz", CcCliente = "1.951.304", Estado = "ACTIVO", NombreAsesor = "Luis Angel Valencia", CupoCredito = "$900.000", MontoDisponible = "$900.000", IsVisible = false });
            bookInfo.Add(new BookInfo() { Numerador = 7, NombreCliente = "Diego Hoyos", CcCliente = "1.020.952", Estado = "ACTIVO", NombreAsesor = "Luis Angel Valencia", CupoCredito = "$600.000", MontoDisponible = "$300.000", IsVisible = false });
            bookInfo.Add(new BookInfo() { Numerador = 8, NombreCliente = "Daniel Rodas", CcCliente = "3.026.987", Estado = "ACTIVO", NombreAsesor = "Luis Angel Valencia", CupoCredito = "$700.000", MontoDisponible = "$40.000", IsVisible = false });
        }

        public BookInfo GetBookInfoById(string id)
        {
            return BookInfo.FirstOrDefault(x => x.CcCliente.Equals(id));
        }
    }
}
