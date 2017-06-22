using ConceptosStyles.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ConceptosStyles.ViewModels
{
    public class SolicitudesPrincipalViewModel : BindableBase, INavigationAware
    {
        /*
         * Variables para traer la info del cliente seleccionado en los listados
         * */

        private string _nombreCliente;
        public string NombreCliente
        {
            get { return _nombreCliente; }
            set { SetProperty(ref _nombreCliente, value); }
        }

        private string _ccCliente;
        public string CcCliente
        {
            get { return _ccCliente; }
            set { SetProperty(ref _ccCliente, value); }
        }

        private string _estado;
        public string Estado
        {
            get { return _estado; }
            set { SetProperty(ref _estado, value); }
        }

        private string _nombreAsesor;
        public string NombreAsesor
        {
            get { return _nombreAsesor; }
            set { SetProperty(ref _nombreAsesor, value); }
        }

        private string _cupoCredito;
        public string CupoCredito
        {
            get { return _cupoCredito; }
            set { SetProperty(ref _cupoCredito, value); }
        }

        private string _montoDisponible;
        public string MontoDisponible
        {
            get { return _montoDisponible; }
            set { SetProperty(ref _montoDisponible, value); }
        }
        /*FIN*/

        private ObservableCollection<ReferenciasModel> referenciasModel;
        public ObservableCollection<ReferenciasModel> ReferenciasModel
        {
            get { return referenciasModel; }
            set { this.referenciasModel = value; RaisePropertyChanged("ReferenciasModel"); }
        }
        


        private ReferenciasModel referenciasModelSelected;
        public ReferenciasModel ReferenciasModelSelected
        {
            get { return referenciasModelSelected; }
            set { SetProperty(ref referenciasModelSelected, value); }
        }

        
        private ObservableCollection<ReferenciasModel> cargos;
        public ObservableCollection<ReferenciasModel> Cargos
        {
            get { return cargos; }
            set { this.cargos = value; RaisePropertyChanged("Cargos"); }
        }


        private ObservableCollection<ReferenciasModel> ocupaciones;
        public ObservableCollection<ReferenciasModel> Ocupaciones
        {
            get { return ocupaciones; }
            set { this.ocupaciones = value; RaisePropertyChanged("Ocupaciones"); }
        }

        private ObservableCollection<ReferenciasModel> ingresos;
        public ObservableCollection<ReferenciasModel> Ingresos
        {
            get { return ingresos; }
            set { this.ingresos = value; RaisePropertyChanged("Ingresos"); }
        }

        private ObservableCollection<ReferenciasModel> estadoCivil;
        public ObservableCollection<ReferenciasModel> EstadoCivil
        {
            get { return estadoCivil; }
            set { this.estadoCivil = value; RaisePropertyChanged("EstadoCivil"); }
        }

        private ObservableCollection<ReferenciasModel> tipoVivienda;
        public ObservableCollection<ReferenciasModel> TipoVivienda
        {
            get { return tipoVivienda; }
            set { this.tipoVivienda = value; RaisePropertyChanged("TipoVivienda"); }
        }

        private ObservableCollection<ReferenciasModel> parentezcos;
        public ObservableCollection<ReferenciasModel> Parentezcos
        {
            get { return parentezcos; }
            set { this.parentezcos = value; RaisePropertyChanged("Parentezcos"); }
        }

        private ObservableCollection<ReferenciasModel> fotosAdicionales;
        public ObservableCollection<ReferenciasModel> FotosAdicionales
        {
            get { return fotosAdicionales; }
            set { this.fotosAdicionales = value; RaisePropertyChanged("FotosAdicionales"); }
        }

        public SolicitudesPrincipalViewModel()
        {
            GenerateBookInfo();
            GenerarCargos();
            GenerarOcupaciones();
            GenerarIngresos();
            GenerarEstadoCivil();
            GenerarTipoVivienda();
            GenerarParentezcos();
            fotosAdicionales = new ObservableCollection<ReferenciasModel>();
        }

        internal void GenerateBookInfo()
        {
            referenciasModel = new ObservableCollection<ReferenciasModel>();
            referenciasModel.Add(new ReferenciasModel() { CodigoRef = "1", NombresRef = "Natalia", ApellidosRef = "Florez", ParentescoRef = "Tía", DireccionRef = "Cra 46 - 23 San Jeronimo Medellín, Antioquia", TelefonoCasaRef = "987654", CelularRef = "3002003015", TelefonoEmpresaRef = "2445566" });
            referenciasModel.Add(new ReferenciasModel() { CodigoRef = "2", NombresRef = "Carolina", ApellidosRef = "Arango", ParentescoRef = "Mamá", DireccionRef = "Cra 47 - 23 San Felipe Medellín, Antioquia", TelefonoCasaRef = "156623", CelularRef = "3002086515", TelefonoEmpresaRef = "2589674" });
            referenciasModel.Add(new ReferenciasModel() { CodigoRef = "3", NombresRef = "Sandra", ApellidosRef = "Roldan", ParentescoRef = "Hija", DireccionRef = "Cra 6 - 23 Manrique Medellín, Antioquia", TelefonoCasaRef = "147852", CelularRef = "3256985741", TelefonoEmpresaRef = "2456987" });
            referenciasModel.Add(new ReferenciasModel() { CodigoRef = "4", NombresRef = "Yecenia", ApellidosRef = "Cano", ParentescoRef = "Amiga", DireccionRef = "Clle 8 - 23 Prado Medellín, Antioquia", TelefonoCasaRef = "365987", CelularRef = "3102569857", TelefonoEmpresaRef = "2103020" });
            referenciasModel.Add(new ReferenciasModel() { CodigoRef = "5", NombresRef = "Diego", ApellidosRef = "Hoyos", ParentescoRef = "Papá", DireccionRef = "Clle 8 - 23 Prado Medellín, Antioquia", TelefonoCasaRef = "365987", CelularRef = "3002568996", TelefonoEmpresaRef = "2103099" });
            referenciasModel.Add(new ReferenciasModel() { CodigoRef = "6", NombresRef = "Juan David", ApellidosRef = "Ramirez", ParentescoRef = "Hermano", DireccionRef = "Clle 8 - 23 Prado Medellín, Antioquia", TelefonoCasaRef = "365987", CelularRef = "32102365659", TelefonoEmpresaRef = "951623" });
            referenciasModel.Add(new ReferenciasModel() { CodigoRef = "7", NombresRef = "Maria del Socorro", ApellidosRef = "Gertrudis Ramirez", ParentescoRef = "Amiga", DireccionRef = "Clle 10 - 23 San Javier Medellín, Antioquia", TelefonoCasaRef = "256459", CelularRef = "32015236589", TelefonoEmpresaRef = "2568923" });
        }

        internal void GenerarCargos()
        {
            cargos = new ObservableCollection<ReferenciasModel>();
            cargos.Add(new ReferenciasModel() { CargosRefLab = "Directivo" });
            cargos.Add(new ReferenciasModel() { CargosRefLab = "Empleado Oficina" });
            cargos.Add(new ReferenciasModel() { CargosRefLab = "Operario" });
            cargos.Add(new ReferenciasModel() { CargosRefLab = "Otro" });
            cargos.Add(new ReferenciasModel() { CargosRefLab = "Supervisor" });
        }


        internal void GenerarOcupaciones()
        {
            ocupaciones = new ObservableCollection<ReferenciasModel>();
            ocupaciones.Add(new ReferenciasModel() { OcupacionesRefLab = "Ama de casa" });
            ocupaciones.Add(new ReferenciasModel() { OcupacionesRefLab = "Empleado" });
            ocupaciones.Add(new ReferenciasModel() { OcupacionesRefLab = "Estudiante" });
            ocupaciones.Add(new ReferenciasModel() { OcupacionesRefLab = "Independiente" });
            ocupaciones.Add(new ReferenciasModel() { OcupacionesRefLab = "Jubilado" });
        }


        internal void GenerarIngresos()
        {
            ingresos = new ObservableCollection<ReferenciasModel>();
            ingresos.Add(new ReferenciasModel() { IngresosRefLab = "Menos de 600" });
            ingresos.Add(new ReferenciasModel() { IngresosRefLab = "601 a 1,200" });
            ingresos.Add(new ReferenciasModel() { IngresosRefLab = "1,201 a 2,000" });
            ingresos.Add(new ReferenciasModel() { IngresosRefLab = "2,001 a 3,000" });
            ingresos.Add(new ReferenciasModel() { IngresosRefLab = "Más de 3,000" });
        }

        internal void GenerarEstadoCivil()
        {
            estadoCivil = new ObservableCollection<ReferenciasModel>();
            estadoCivil.Add(new ReferenciasModel() { EstadoCivilRefCom = "Casado" });
            estadoCivil.Add(new ReferenciasModel() { EstadoCivilRefCom = "Separado" });
            estadoCivil.Add(new ReferenciasModel() { EstadoCivilRefCom = "Soltero" });
            estadoCivil.Add(new ReferenciasModel() { EstadoCivilRefCom = "Viudo" });
            estadoCivil.Add(new ReferenciasModel() { EstadoCivilRefCom = "Union Libre" });
            estadoCivil.Add(new ReferenciasModel() { EstadoCivilRefCom = "Otro" });
        }

        internal void GenerarTipoVivienda()
        {
            tipoVivienda = new ObservableCollection<ReferenciasModel>();
            tipoVivienda.Add(new ReferenciasModel() { TipoViviendaRefCom = "Arrendada" });
            tipoVivienda.Add(new ReferenciasModel() { TipoViviendaRefCom = "Familiar" });
            tipoVivienda.Add(new ReferenciasModel() { TipoViviendaRefCom = "Propia" });
        }

        internal void GenerarParentezcos()
        {
            parentezcos = new ObservableCollection<ReferenciasModel>();
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "ABUELO(A)" });
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "AMIGO(A)" });
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "CUÑADO(A)" });
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "ESPOSO(A)" });
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "HERMANO(A)" });
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "HIJO(A)" });
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "MADRE" });
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "NIETO(A)" });
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "NOVIO(A)" });
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "NUERA" });
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "PADRE" });
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "PRIMO(A)" });
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "SOBRINO(A)" });
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "SUEGRO(A)" });
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "TIO(A)" });
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "YERNO" });
            parentezcos.Add(new ReferenciasModel() { ParentezcoRefPer = "VECINO(A)" });
        }


        public void CargarFormularioRefPersonal(ReferenciasModel bookInfo)
        {
            ReferenciasModelSelected = bookInfo;
        }


        public void EliminarReferenciaPersonal(ReferenciasModel bookInfo)
        {
            var item = referenciasModel.Where(x => x.CodigoRef == bookInfo.CodigoRef);
            if (item != null)
            {
                referenciasModel.Remove(item.FirstOrDefault());
            }           
        }

        public void AgregarFotoAdicional(string url)
        {
            fotosAdicionales.Add(new ReferenciasModel() { UrlFotoDocAdi = url });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {            

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
                NombreCliente = (string)parameters["_nombreCliente"];
                CcCliente = (string)parameters["_ccCliente"];
                Estado = (string)parameters["_estado"];
                NombreAsesor = (string)parameters["_nombreAsesor"];
                CupoCredito = (string)parameters["_cupoCredito"];
                MontoDisponible = (string)parameters["_montoDisponible"];
            
        }
    }
}
