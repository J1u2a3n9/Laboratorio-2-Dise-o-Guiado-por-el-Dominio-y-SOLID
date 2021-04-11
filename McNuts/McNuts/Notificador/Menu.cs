using McNuts.ClasesHijas;
using McNuts.ClasesPadres;
using McNuts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

enum SaboresGeneralesMani
{
    Dulce=5,
    Salado=6
}
namespace McNuts.Notificador
{
    public class Menu:INotificador
    {
        Mani mani ;
        private int cont = 1;
        public void Inicio()
        {
            int opc;
            do
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("             BIENVENIDO AL SISTEMA DE ADMINISTRACION MC NUTS             ");
                Console.WriteLine("             1)Ver Sabores especificos que se pueden producir                ");
                Console.WriteLine("             2)Producir Sabor             ");
                Console.WriteLine("             3)Modificar Produccion de un sabor              ");
                Console.WriteLine("             4)Mostrar sabor             ");
                Console.WriteLine("             5)Salir             ");
                Console.WriteLine("------------------------------------------------------------");
                Console.Write("Escoja su opcion: ");
                opc = Convert.ToInt32(Console.ReadLine());
                SubMenu(opc);
            } while (opc <= 4);
        }

        public void SubMenu(int opc)
        {
            int eleccion;
            switch (opc)
            {
                case 1:
                    MostrarSabores();
                    break;
                case 2:
                    MostrarSabores();
                    Console.Write("Escoja un sabor: ");
                    eleccion = Convert.ToInt32(Console.ReadLine());
                    ProducirSabor(eleccion);
                    break;
                case 3:
                    if(Validar()==false)
                    {
                        SubMenu(2);
                    }
                    ModificarProduccion();
                    break;
                case 4:
                    if (Validar() == false)
                    {
                        SubMenu(2);
                    }
                    MostrarSabor();
                    break;

            }
        }
        public bool Validar()
        {
            if (mani==null)
            {
                return false;
            }
            return true;
        }
        public void MostrarSabores()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("             Sabores Especificos de MCNUTS             ");
            Console.WriteLine("             1)Leche condensada                ");
            Console.WriteLine("             2)Miel Y Mostaza              ");
            Console.WriteLine("             3)Oreo                ");
            Console.WriteLine("             4)Picante             ");
            Console.WriteLine("------------------------------------------------------------");
        }

        public void ProducirSabor(int eleccion)
        {
            
            switch (eleccion)
            {
                case 1:
                    mani = new LecheCondensada(cont);
                    break;
                case 2:
                    mani = new MielYMostaza(cont);
                    break;
                case 3:
                    mani = new Oreo(cont);
                    break;
                case 4:
                    mani = new Picante(cont);
                    break;
            }
            AgregarInformacionDeProduccion(mani);
            mani.Preparar();
            cont++;

        }

        public void AgregarInformacionDeProduccion(Mani mani)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("Ingrese la cantidad de mani que producira:");
            mani.SetCantidad(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Ingrese el precio unitario de mani que producira:");
            mani.SetPrecioUnitario(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Ingrese el precio por mayor de mani que producira:");
            mani.SetPrecioMayor(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Ingrese la fecha de vencimiento del mani que producira:");
            mani.SetFechaVencimiento(Convert.ToDateTime(Console.ReadLine()));
        }


        public void ModificarProduccion()
        {
            mani.SetEstadoProduccion();
        }

        public void MostrarSabor()
        {
            MostrarDetalles(mani);
        }
        

        public void MostrarDetalles(Mani mani)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"El id del mani es: {mani.GetId()}");
            Console.WriteLine($"El nombre del mani es : {mani.GetNombre()}");
            Console.WriteLine($"La fecha de elaboracion del mani es: {mani.GetFechaElaboracion()}");
            Console.WriteLine($"La fecha de vencimiento del Mani es: {mani.GetFechaVencimiento()}");
            Console.WriteLine($"El precio unitario es: {mani.GetPrecioUnitario()} Bs.");
            Console.WriteLine($"El precio por mayor es: {mani.GetPrecioMayor()} Bs.");
            Console.WriteLine($"La cantidad de mani que se producio es  {mani.GetCantidad()} unidades");
            Console.WriteLine($"El estado de produccion del mani es {mani.GetEstadoProduccion()}");
        }

        public void ImprimirLinea()
        {
            Console.WriteLine("------------------------------------------------------------");
        }
    }

}







