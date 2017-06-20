using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosStyles.Models
{
    public class SimuladorModel: INotifyPropertyChanged
    {
        private string planes;
        private string frecuencia;
        private string planesEspeciales;

        public string Planes
        {
            get { return planes; }
            set
            {
                planes = value;
                OnPropertyChanged("Planes");
            }
        }


        public string Frecuencia
        {
            get { return frecuencia; }
            set
            {
                frecuencia = value;
                OnPropertyChanged("Frecuencia");
            }
        }


        public string PlanesEspeciales
        {
            get { return planesEspeciales; }
            set
            {
                planesEspeciales = value;
                OnPropertyChanged("PlanesEspeciales");
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
