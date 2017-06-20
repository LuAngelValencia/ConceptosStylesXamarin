using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosStyles.Models
{
    public class ReferenciasModel : INotifyPropertyChanged
    {
        private string nombresRef;
        private string apellidosRef;
        private string parentescoRef;
        private string direccionRef;
        private string telefonoCasaRef;
        private string celularRef;
        private string telefonoEmpresaRef;
        private string cargosRefLab;
        private string ocupacionesRefLab;
        private string ingresosRefLab;
        private string estadoCivilRefCom;
        private string tipoViviendaRefCom;
        private string parentezcoRefPer;


        public string NombresRef
        {
            get { return nombresRef; }
            set
            {
                nombresRef = value;
                OnPropertyChanged("NombresRef");
            }
        }


        public string ApellidosRef
        {
            get { return apellidosRef; }
            set
            {
                apellidosRef = value;
                OnPropertyChanged("ApellidosRef");
            }
        }


        public string ParentescoRef
        {
            get { return parentescoRef; }
            set
            {
                parentescoRef = value;
                OnPropertyChanged("ParentescoRef");
            }
        }

        
        public string DireccionRef
        {
            get { return direccionRef; }
            set
            {
                direccionRef = value;
                OnPropertyChanged("DireccionRef");
            }
        }


        public string TelefonoCasaRef
        {
            get { return telefonoCasaRef; }
            set
            {
                telefonoCasaRef = value;
                OnPropertyChanged("TelefonoCasaRef");
            }
        }


        public string CelularRef
        {
            get { return celularRef; }
            set
            {
                celularRef = value;
                OnPropertyChanged("CelularRef");
            }
        }


        public string TelefonoEmpresaRef
        {
            get { return telefonoEmpresaRef; }
            set
            {
                telefonoEmpresaRef = value;
                OnPropertyChanged("TelefonoEmpresaRef");
            }
        }

        public string CargosRefLab
        {
            get { return cargosRefLab; }
            set
            {
                cargosRefLab = value;
                OnPropertyChanged("CargosRefLab");
            }
        }

        public string OcupacionesRefLab
        {
            get { return ocupacionesRefLab; }
            set
            {
                ocupacionesRefLab = value;
                OnPropertyChanged("OcupacionesRefLab");
            }
        }

        public string IngresosRefLab
        {
            get { return ingresosRefLab; }
            set
            {
                ingresosRefLab = value;
                OnPropertyChanged("IngresosRefLab");
            }
        }

        public string EstadoCivilRefCom
        {
            get { return estadoCivilRefCom; }
            set
            {
                estadoCivilRefCom = value;
                OnPropertyChanged("EstadoCivilRefCom");
            }
        }

        public string TipoViviendaRefCom
        {
            get { return tipoViviendaRefCom; }
            set
            {
                tipoViviendaRefCom = value;
                OnPropertyChanged("TipoViviendaRefCom");
            }
        }

        public string ParentezcoRefPer
        {
            get { return parentezcoRefPer; }
            set
            {
                parentezcoRefPer = value;
                OnPropertyChanged("ParentezcoRefPer");
            }
        }

        public string NombresApellidosRef { get { return NombresRef + " " + ApellidosRef; } }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

    }
}
