using ConceptosStyles.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ConceptosStyles.ViewModels
{
    public class SimuladorViewModel : BindableBase
    {
        public SimuladorViewModel()
        {
            SetRowstoGenerate(5);
            GenerarPlanesEspeciales();
            GenerarPlanes();
            GenerarFrecuencias();
        }      

        #region ItemsSource

        private OrderInfoRepository order;

        private ObservableCollection<OrderInfo> ordersInfo;

        public ObservableCollection<OrderInfo> OrdersInfo
        {
            get { return ordersInfo; }
            set { this.ordersInfo = value; RaisePropertyChanged("OrdersInfo"); }
        }

        #endregion

        #region ItemSource Generator

        public void SetRowstoGenerate(int count)
        {
            order = new OrderInfoRepository();
            ordersInfo = order.GetOrderDetails(count);
        }

        #endregion

        private Random random = new Random();

        internal void ItemsSourceRefresh()
        {
            var count = random.Next(1, 6);

            for (int i = 11000; i < 11000 + count; i++)
            {
                int val = i + random.Next(100, 150);
                this.OrdersInfo.Insert(0, order.RefreshItemsource(val));
            }
        }


        private ObservableCollection<SimuladorModel> tipoPlanes;
        public ObservableCollection<SimuladorModel> TipoPlanes
        {
            get { return tipoPlanes; }
            set { this.tipoPlanes = value; RaisePropertyChanged("TipoPlanes"); }
        }

        private ObservableCollection<SimuladorModel> planesEspeciales;
        public ObservableCollection<SimuladorModel> PlanesEspeciales
        {
            get { return planesEspeciales; }
            set { this.planesEspeciales = value; RaisePropertyChanged("PlanesEspeciales"); }
        }

        private ObservableCollection<SimuladorModel> frecuencias;
        public ObservableCollection<SimuladorModel> Frecuencias
        {
            get { return frecuencias; }
            set { this.frecuencias = value; RaisePropertyChanged("Frecuencias"); }
        }

        internal void GenerarPlanesEspeciales()
        {
            planesEspeciales = new ObservableCollection<SimuladorModel>();
            planesEspeciales.Add(new SimuladorModel() { PlanesEspeciales = "Plan1" }); 
            planesEspeciales.Add(new SimuladorModel() { PlanesEspeciales = "Plan2" }); 
            planesEspeciales.Add(new SimuladorModel() { PlanesEspeciales = "Plan3" }); 
            planesEspeciales.Add(new SimuladorModel() { PlanesEspeciales = "Plan4" }); 
            planesEspeciales.Add(new SimuladorModel() { PlanesEspeciales = "Plan5" }); 
            planesEspeciales.Add(new SimuladorModel() { PlanesEspeciales = "Plan6" });
        }


        internal void GenerarPlanes()
        {
            tipoPlanes = new ObservableCollection<SimuladorModel>();
            tipoPlanes.Add(new SimuladorModel() { Planes = "Normales" });
            tipoPlanes.Add(new SimuladorModel() { Planes = "Especiales" });
        }

        internal void GenerarFrecuencias()
        {
            frecuencias = new ObservableCollection<SimuladorModel>();
            frecuencias.Add(new SimuladorModel() { Frecuencia = "Quincenal" });
            frecuencias.Add(new SimuladorModel() { Frecuencia = "Mensual" });
        }
    }
}
