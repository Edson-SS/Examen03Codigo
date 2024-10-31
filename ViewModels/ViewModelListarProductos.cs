using Examen03Codigo.Models;
using Examen03Codigo.Utilitario;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Examen03Codigo.ViewModels
{
    public class ViewModelListarProductos : ViewModelBase
    {
        #region Propiedades
        private string _Resultado;
        public string Resultado
        {
            get { return _Resultado; }
            set
            {
                _Resultado = value;
                OnPropertyChanged(nameof(Resultado));
            }
        }
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                _Nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }
        private decimal _Precio;
        public decimal Precio
        {
            get { return Precio; }
            set
            {
                _Precio = value;
                OnPropertyChanged(nameof(Precio));
            }
        }
        private string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                _Descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
            }
        }
        public ObservableCollection<Producto> Productos { get; }
        #endregion

        #region Comando
        public ICommand AgregarProductoCommand { get; }

        public ViewModelListarProductos()
        {
            AgregarProductoCommand = new RelayCommand(Guardar);
            Productos = new ObservableCollection<Producto>();
        }
        private void Guardar()
        {
            Resultado = string.Concat(Nombre, " ", Precio.ToString(), " ", Descripcion);
            Productos.Add(new Producto
            {
                Nombre = this.Nombre,
                Precio = Convert.ToInt32(this.Precio),
                Descripcion = this.Descripcion
            });
        }
        #endregion
    }
}
