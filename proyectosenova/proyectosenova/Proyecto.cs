using System;
using System.Collections.Generic;
using System.Text;

namespace proyectosenova
{
    public class Proyecto
    {
        #region Atributos
        #region propiedades

        #endregion
        #endregion

        public string Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }

        #region Metodos
        public void IngresarProyecto()
        {
            Console.WriteLine("Ingrese el nombre del proyecto");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo");
            Codigo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo");
            Area = Console.ReadLine();
            Console.WriteLine("Ingrese la duracion del proyecto");
            var dura = Console.ReadLine();
            Duracion = int.Parse(dura);
        }
        public void ImprimirProyecto()
        {
            Console.WriteLine($"el nombre es:{Nombre}");
            Console.WriteLine($"el nombre es:("{Codigo}");
            Console.WriteLine($"el nombre es:{ Area}");
            Console.WriteLine($"el nombre es:{ Duracion}");


        }
        public Proyecto(string nombre, double codigo,string area,int duracion)
        {
            Nombre = nombre;
            Codigo = codigo;
            Area = area;
            Duracion = duracion;



        }
        public Proyecto()
        {




        }
        #endregion


    }
}
