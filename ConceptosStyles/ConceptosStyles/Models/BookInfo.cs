using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosStyles.Models
{
    public class BookInfo : INotifyPropertyChanged
    {
        private string nombreCliente;
        private string nombreAsesor;
        private string ccCliente;
        private string estado;
        private string cupoCredito;
        private string montoDisponible;
        private int numerador;
        private bool _isVisible;

        public string NombreCliente
        {
            get { return nombreCliente; }
            set
            {
                nombreCliente = value;
                OnPropertyChanged("NombreCliente");
            }
        }

        public string NombreAsesor
        {
            get { return nombreAsesor; }
            set
            {
                nombreAsesor = value;
                OnPropertyChanged("NombreAsesor");
            }
        }

        public string CcCliente
        {
            get { return ccCliente; }
            set
            {
                ccCliente = value;
                OnPropertyChanged("CcCliente");
            }
        }

        public string Estado
        {
            get { return estado; }
            set
            {
                estado = value;
                OnPropertyChanged("Estado");
            }
        }

        
        public bool IsVisible
        {
            get { return _isVisible; }
            set
            {
                _isVisible = value;
                OnPropertyChanged("IsVisible");
            }
        }

        public string CupoCredito
        {
            get { return cupoCredito; }
            set
            {
                cupoCredito = value;
                OnPropertyChanged("CupoCredito");
            }
        }

        public string MontoDisponible
        {
            get { return montoDisponible; }
            set
            {
                montoDisponible = value;
                OnPropertyChanged("MontoDisponible");
            }
        }

        public int Numerador
        {
            get { return numerador; }
            set
            {
                numerador = value;
                OnPropertyChanged("Numerador");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
