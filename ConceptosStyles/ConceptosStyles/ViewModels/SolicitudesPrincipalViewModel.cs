using ConceptosStyles.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ConceptosStyles.ViewModels
{
    public class SolicitudesPrincipalViewModel : BindableBase
    {

        private ObservableCollection<ReferenciasModel> referenciasModel;

        public ObservableCollection<ReferenciasModel> ReferenciasModel
        {
            get { return referenciasModel; }
            set { this.referenciasModel = value; RaisePropertyChanged(); }
        }
        

        public SolicitudesPrincipalViewModel()
        {
            GenerateBookInfo();
        }

        internal void GenerateBookInfo()
        {
            referenciasModel = new ObservableCollection<ReferenciasModel>();
            referenciasModel.Add(new ReferenciasModel() { NombresRef = "Natalia", ApellidosRef= "Florez", ParentescoRef = "Tía", DireccionRef = "Cra 46 - 23 San Jeronimo Medellín, Antioquia", TelefonoCasaRef = "987654", CelularRef = "3002003015", TelefonoEmpresaRef = "2445566" });
            referenciasModel.Add(new ReferenciasModel() { NombresRef = "Carolina", ApellidosRef = "Arango", ParentescoRef = "Mamá", DireccionRef = "Cra 47 - 23 San Felipe Medellín, Antioquia", TelefonoCasaRef = "156623", CelularRef = "3002086515", TelefonoEmpresaRef = "2589674" });
            referenciasModel.Add(new ReferenciasModel() { NombresRef = "Sandra", ApellidosRef = "Roldan", ParentescoRef = "Abuela", DireccionRef = "Cra 6 - 23 Manrique Medellín, Antioquia", TelefonoCasaRef = "147852", CelularRef = "3256985741", TelefonoEmpresaRef = "2456987" });
            referenciasModel.Add(new ReferenciasModel() { NombresRef = "Yecenia", ApellidosRef = "Cano", ParentescoRef = "Amiga", DireccionRef = "Clle 8 - 23 Prado Medellín, Antioquia", TelefonoCasaRef = "365987", CelularRef = "3102569857", TelefonoEmpresaRef = "2103020" });            
            referenciasModel.Add(new ReferenciasModel() { NombresRef = "Diego", ApellidosRef = "Hoyos", ParentescoRef = "Papá", DireccionRef = "Clle 8 - 23 Prado Medellín, Antioquia", TelefonoCasaRef = "365987", CelularRef = "3002568996", TelefonoEmpresaRef = "2103099" });
            referenciasModel.Add(new ReferenciasModel() { NombresRef = "Juan David", ApellidosRef = "Ramirez", ParentescoRef = "Hermano", DireccionRef = "Clle 8 - 23 Prado Medellín, Antioquia", TelefonoCasaRef = "365987", CelularRef = "32102365659", TelefonoEmpresaRef = "951623" });
        }

    }
}
