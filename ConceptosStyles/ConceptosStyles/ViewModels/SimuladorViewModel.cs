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


        private ObservableCollection<SimuladorModel> simuladorModel;
        public ObservableCollection<SimuladorModel> SimuladorModel
        {
            get { return simuladorModel; }
            set { this.simuladorModel = value; RaisePropertyChanged("SimuladorModel"); }
        }

        internal void GenerarPlanesEspeciales()
        {
            simuladorModel = new ObservableCollection<SimuladorModel>();
            simuladorModel.Add(new SimuladorModel() { PlanesEspeciales = "Plan1" }); 
            simuladorModel.Add(new SimuladorModel() { PlanesEspeciales = "Plan2" }); 
            simuladorModel.Add(new SimuladorModel() { PlanesEspeciales = "Plan3" }); 
            simuladorModel.Add(new SimuladorModel() { PlanesEspeciales = "Plan4" }); 
            simuladorModel.Add(new SimuladorModel() { PlanesEspeciales = "Plan5" }); 
            simuladorModel.Add(new SimuladorModel() { PlanesEspeciales = "Plan6" });
        }
    }
}
