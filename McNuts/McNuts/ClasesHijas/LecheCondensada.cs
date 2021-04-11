using McNuts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace McNuts
{
    public class LecheCondensada:Dulce, ICocinarDulce,IPreparar
    {
        private Dictionary<string, int> _ingredientes;
        private int _cantidad;
        private double _precioUnitario;
        private double _precioMayor;

        public LecheCondensada(long id) : base(id, "Leche Condensada")
        {
            _ingredientes = new Dictionary<string, int>();
        }


        public override void AddIngrediente(string ingrediente, int cantidad)
        {
            _ingredientes.Add(ingrediente, cantidad);
        }
        public override void DeleteIngrendiente(string ingrediente)
        {
            _ingredientes.Remove(ingrediente);
        }

        public override void SetCantidad(int cantidad = 2)
        {
            _cantidad = cantidad;
        }
        public override void SetPrecioUnitario(double precioUnitario = 12.50)
        {
            _precioUnitario = precioUnitario;
        }
        public override void SetPrecioMayor(double precioMayor = 9.50)
        {
            _precioMayor = precioMayor;
        }


        public override Dictionary<string, int> GetIngredientes()
        {
            return _ingredientes;
        }

        public override int GetCantidad()
        {
            return _cantidad;
        }
        public override double GetPrecioUnitario()
        {
            return _precioUnitario;
        }
        public override double GetPrecioMayor()
        {
            return _precioMayor;
        }

        public  void AddAzucar(int cantidad = 50)
        {
            _ingredientes.Add("Azucar", cantidad);
        }

        public override void Preparar()
        {
            SetSabor();
            SetFechaElaboracion();
            SetFechaComienzoProduccion();
            AddAzucar();
        }
    }
}
