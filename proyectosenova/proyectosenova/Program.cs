using System;

namespace proyectosenova
{
    class Program
    {
        static void Main(string[] args)
        {



            int edad;
            int puntaje = 0;
            Proyecto miProyecto = new Proyecto();
            Proyecto miProyecto2 = new Proyecto();
            Proyecto miProyecto3 = new Proyecto();
            Proyecto miProyecto4 = new Proyecto("Realidad aumentada", 12540, "Sistemas",10);
            Proyecto miProyecto5 = new Proyecto("Talento humano",5);
            miProyecto4.ImprimirProyecto();
            miProyecto5.ImprimirProyecto();
            miProyecto3.ImprimirProyecto();
            miProyecto3.IngresarProyecto();
         
            miProyecto.Area = "Sistemas";
            miProyecto.Codigo = 12000;
            miProyecto.Duracion = 13;
            miProyecto.Nombre = "Desarrollo Internet de las cosas IOT";
            Console.WriteLine(miProyecto.Area);
            Console.WriteLine(miProyecto.Codigo);
            Console.WriteLine(miProyecto.Duracion);
            Console.WriteLine($" Area: {miProyecto.Nombre}");
            Console.ReadLine();

            miProyecto2.Area = "Sistemas";
            miProyecto2.Codigo = 12000;
            miProyecto2.Duracion = 13;
            miProyecto2.Nombre = "Desarrollo Internet de las cosas IOT";
            Console.WriteLine(miProyecto2.Area);
            Console.WriteLine(miProyecto2.Codigo);
            Console.WriteLine(miProyecto2.Duracion);
            Console.WriteLine($" Area: {miProyecto2.Nombre}");
            Console.WriteLine($" Codigo: {miProyecto2.Codigo}");
            Console.WriteLine($" Duracion: {miProyecto2.Duracion}");
            Console.WriteLine($" Nombre: {miProyecto2.Nombre}");
            Console.WriteLine($" Area: {miProyecto2.Area}");
            Console.WriteLine($" Codigo: {miProyecto2.Codigo}");


            Console.ReadLine();





        }
    }
}
