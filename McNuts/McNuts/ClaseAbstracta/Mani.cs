using System;
using System.Collections.Generic;
using System.Text;

namespace McNuts
{
    public abstract class Mani
    {
        protected long _id;
        protected string _sabor;
        protected DateTime _fechaElaboracion;
        protected DateTime _fechaVencimiento;
        protected DateTime _fechaComienzoProduccion;
        protected DateTime _fechaDescontinuacionProduccion;
        public Mani(long id)
        {
            _id = id;
        }
        public abstract void SetSabor();


        public DateTime VerificarFecha(DateTime fecha)
        {
            if(fecha==null)
            {
                fecha = DateTime.Now.ToUniversalTime();
            }
            return fecha;
        }
        public void SetFechaElaboracion()
        {
            _fechaElaboracion = DateTime.Now.ToUniversalTime();
        }
        public void SetFechaVencimiento(DateTime fechaVencimiento)
        {
            _fechaVencimiento = VerificarFecha(fechaVencimiento);
        }


        public void SetFechaComienzoProduccion()
        {
            _fechaComienzoProduccion = DateTime.Now.ToUniversalTime();
        }
        public void SetFechaDescontinuacionProduccion()
        {
            _fechaDescontinuacionProduccion = DateTime.Now.ToUniversalTime();
        }


        public long GetId()
        {
            return _id;
        }

    
        public DateTime GetFechaElaboracion()
        {
            return _fechaElaboracion;
        }
        public DateTime GetFechaVencimiento()
        {
            return _fechaVencimiento;
        }

        public DateTime GetFechaComienzoProduccion()
        {
            return _fechaComienzoProduccion;
        }
        public DateTime GetFechaDescontinuacionProduccion()
        {
            return _fechaDescontinuacionProduccion;
        }

        public abstract string GetSabor();

        public virtual void SetEstadoProduccion()
        {
        }
        public virtual void SetNombre(string nombre)
        {
        }
        public virtual string GetNombre()
        {
            return "Mani";
        }
        public virtual bool GetEstadoProduccion()
        {
            return true;
        }
       public virtual void AddIngrediente(string ingrediente, int cantidad)
        {
           
        }
        public virtual void DeleteIngrendiente(string ingrediente)
        {
           
        }
        public virtual void SetCantidad(int cantidad = 2)
        {
           
        }
        public virtual void SetPrecioUnitario(double precioUnitario = 12.50)
        {
           
        }
        public virtual void SetPrecioMayor(double precioMayor = 9.50)
        {
            
        }
        public virtual Dictionary<string, int> GetIngredientes()
        {
            return null;
        }
        public virtual int GetCantidad()
        {
            return 0;
        }
        public virtual double GetPrecioUnitario()
        {
            return 0;
        }
        public virtual double GetPrecioMayor()
        {
            return 0;
        }
        public virtual void Preparar()
        {
          
        }

    }
}
