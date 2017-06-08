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


        public string NombresApellidosRef { get { return NombresRef + " " + ApellidosRef; } }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

    }
}
