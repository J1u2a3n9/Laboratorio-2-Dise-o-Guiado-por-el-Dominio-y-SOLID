using System;
using System.Collections.Generic;
using System.Text;

namespace McNuts.ClasesPadres
{
    public class Salado : Mani
    {
        private string _nombre;
        private bool _estadoProduccion;
        public Salado(long id, string nombre) : base(id)
        {
            _nombre = nombre;
            _estadoProduccion = true;
        }


        public override void SetNombre(string nombre)
        {
            _nombre = nombre;
        }

        public override void SetSabor()
        {
            _sabor = "Salado";
        }
        public override void SetEstadoProduccion()
        {
            if (_estadoProduccion == true)
            {
                _estadoProduccion = false;
            }
            else
            {
                _estadoProduccion = true;
            }
        }
        public override string GetNombre()
        {
            return _nombre;
        }
        public override string GetSabor()
        {
            return "Sabor Salado";
        }
        public override bool GetEstadoProduccion()
        {
            return _estadoProduccion;
        }
    }
}


