using ConceptosStyles.Models;
using Microsoft.Practices.ObjectBuilder2;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ConceptosStyles.ViewModels
{
    public class DireccionContentViewViewModel : BindableBase
    {
        public DireccionContentViewViewModel()
        {
            GenerarDepartamentos();
            GenerarCiudades();
            GenerarBarrios();
        }

        private ObservableCollection<DireccionModel> departamentos;
        public ObservableCollection<DireccionModel> Departamentos
        {
            get { return departamentos; }
            set { this.departamentos = value; RaisePropertyChanged("Departamentos"); }
        }


        private ObservableCollection<DireccionModel> ciudades;
        public ObservableCollection<DireccionModel> Ciudades
        {
            get { return ciudades; }
            set { this.ciudades = value; RaisePropertyChanged("Ciudades"); }
        }


        private ObservableCollection<DireccionModel> ciudadesFiltered;
        public ObservableCollection<DireccionModel> CiudadesFiltered
        {
            get { return ciudadesFiltered; }
            set { this.ciudadesFiltered = value; RaisePropertyChanged("CiudadesFiltered"); }
        }



        private ObservableCollection<DireccionModel> barrios;
        public ObservableCollection<DireccionModel> Barrios
        {
            get { return barrios; }
            set { this.barrios = value; RaisePropertyChanged("Barrios"); }
        }

        private ObservableCollection<DireccionModel> barriosFiltered;
        public ObservableCollection<DireccionModel> BarriosFiltered
        {
            get { return barriosFiltered; }
            set { this.barriosFiltered = value; RaisePropertyChanged("BarriosFiltered"); }
        }

        
        internal void GenerarDepartamentos()
        {
            departamentos = new ObservableCollection<DireccionModel>();
            departamentos.Add(new DireccionModel() { DepartamentoNombre = "Antioquia" });
            departamentos.Add(new DireccionModel() { DepartamentoNombre = "Caldas" });
            departamentos.Add(new DireccionModel() { DepartamentoNombre = "Cundinamarca" });
            departamentos.Add(new DireccionModel() { DepartamentoNombre = "Valle del Cauca" });
            departamentos.Add(new DireccionModel() { DepartamentoNombre = "Vichada" });
        }

        internal void GenerarCiudades()
        {
            ciudades = new ObservableCollection<DireccionModel>();
            ciudades.Add(new DireccionModel() { DepartamentoNombre = "Antioquia", CiudadNombre = "Bello" });
            ciudades.Add(new DireccionModel() { DepartamentoNombre = "Antioquia", CiudadNombre = "Medellín" });
            ciudades.Add(new DireccionModel() { DepartamentoNombre = "Antioquia", CiudadNombre = "Santa Fé de Antioquia" });
            ciudades.Add(new DireccionModel() { DepartamentoNombre = "Caldas", CiudadNombre = "Aguadas" });
            ciudades.Add(new DireccionModel() { DepartamentoNombre = "Caldas", CiudadNombre = "Manizales" });
            ciudades.Add(new DireccionModel() { DepartamentoNombre = "Caldas", CiudadNombre = "Supía" });
            ciudades.Add(new DireccionModel() { DepartamentoNombre = "Cundinamarca", CiudadNombre = "Bogotá" });
            ciudades.Add(new DireccionModel() { DepartamentoNombre = "Cundinamarca", CiudadNombre = "Chía" });
            ciudades.Add(new DireccionModel() { DepartamentoNombre = "Cundinamarca", CiudadNombre = "Zipaquirá" });
            ciudades.Add(new DireccionModel() { DepartamentoNombre = "Valle del Cauca", CiudadNombre = "Buga" });
            ciudades.Add(new DireccionModel() { DepartamentoNombre = "Valle del Cauca", CiudadNombre = "Cali" });
            ciudades.Add(new DireccionModel() { DepartamentoNombre = "Valle del Cauca", CiudadNombre = "Palmira" });
            ciudades.Add(new DireccionModel() { DepartamentoNombre = "Vichada", CiudadNombre = "Cumaribo" });
            ciudades.Add(new DireccionModel() { DepartamentoNombre = "Vichada", CiudadNombre = "Inírida" });
            ciudades.Add(new DireccionModel() { DepartamentoNombre = "Vichada", CiudadNombre = "Puerto Carreño" });
            ciudades.ToList();
        }

        internal void GenerarBarrios()
        {
            barrios = new ObservableCollection<DireccionModel>();
            barrios.Add(new DireccionModel() { CiudadNombre = "Bello", BarrioNombre = "Barrio 1 de Bello" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Bello", BarrioNombre = "Barrio 2 de Bello" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Medellín", BarrioNombre = "Barrio 1 de Medellín" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Medellín", BarrioNombre = "Barrio 2 de Medellín" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Santa Fé de Antioquia", BarrioNombre = "Barrio 1 de Santa Fé de Antioquia" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Santa Fé de Antioquia", BarrioNombre = "Barrio 2 de Santa Fé de Antioquia" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Aguadas", BarrioNombre = "Barrio 1 de Aguadas" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Aguadas", BarrioNombre = "Barrio 2 de Aguadas" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Manizales", BarrioNombre = "Barrio 1 de Manizales" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Manizales", BarrioNombre = "Barrio 2 de Manizales" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Supía", BarrioNombre = "Barrio 1 de Supía" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Supía", BarrioNombre = "Barrio 2 de Supía" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Bogotá", BarrioNombre = "Barrio 1 de Bogotá" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Bogotá", BarrioNombre = "Barrio 2 de Bogotá" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Chía", BarrioNombre = "Barrio 1 de Chía" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Chía", BarrioNombre = "Barrio 2 de Chía" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Zipaquirá", BarrioNombre = "Barrio 1 de Zipaquirá" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Zipaquirá", BarrioNombre = "Barrio 2 de Zipaquirá" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Buga", BarrioNombre = "Barrio 1 de Buga" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Buga", BarrioNombre = "Barrio 2 de Buga" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Cali", BarrioNombre = "Barrio 1 de Cali" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Cali", BarrioNombre = "Barrio 2 de Cali" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Palmira", BarrioNombre = "Barrio 1 de Palmira" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Palmira", BarrioNombre = "Barrio 2 de Palmira" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Cumaribo", BarrioNombre = "Barrio 1 de Cumaribo" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Cumaribo", BarrioNombre = "Barrio 2 de Cumaribo" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Inírida", BarrioNombre = "Barrio 1 de Inírida" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Inírida", BarrioNombre = "Barrio 2 de Inírida" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Puerto Carreño", BarrioNombre = "Barrio 1 de Puerto Carreño" });
            barrios.Add(new DireccionModel() { CiudadNombre = "Puerto Carreño", BarrioNombre = "Barrio 2 de Puerto Carreño" });
            barrios.ToList();
        }

        
        public void FiltrarCiudades(string departamento)
        {
            CiudadesFiltered = new ObservableCollection<DireccionModel>();

            var filterred = Ciudades.Where(x => x.DepartamentoNombre.Equals(departamento));

            filterred.ForEach(x => CiudadesFiltered.Add(x));
        }

        public void FiltrarBarrios(string ciudad)
        {
            BarriosFiltered = new ObservableCollection<DireccionModel>();

            var filtered = Barrios.Where(x => x.CiudadNombre.Equals(ciudad));

            filtered.ForEach(x => BarriosFiltered.Add(x));
        }
    }
}
