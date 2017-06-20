using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosStyles.Models
{
    public class DireccionModel : INotifyPropertyChanged
    {
        private string ciudadNombre;
        private string departamentoNombre;
        private string barrioNombre;


        public string CiudadNombre
        {
            get { return ciudadNombre; }
            set
            {
                ciudadNombre = value;
                OnPropertyChanged("CiudadNombre");
            }
        }

        public string DepartamentoNombre
        {
            get { return departamentoNombre; }
            set
            {
                departamentoNombre = value;
                OnPropertyChanged("DepartamentoNombre");
            }
        }

        public string BarrioNombre
        {
            get { return barrioNombre; }
            set
            {
                barrioNombre = value;
                OnPropertyChanged("BarrioNombre");
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
