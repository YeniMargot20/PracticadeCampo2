﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticadeCampo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaProductos lista = new ListaProductos();

            // AÑADIENDO PRODUCTOS
            lista.Insertar(new Productos(200, "Laptop Lenovo", 10, 2400, true));
            lista.Insertar(new Productos(100, "Laptop hp", 10, 3500, true));
            lista.Insertar(new Productos(400, "Laptop Asus", 10, 3400, true));
            lista.Insertar(new Productos(300, "Laptop Dell", 10, 4400, true));
            lista.Insertar(new Productos(500, "Laptop Apple", 10, 5400, true));
            //LISTAR PRODUCTOS 
            lista.Listar();
            Console.Write("\n");
            // ELIMINAR PRODUCTO
            Console.WriteLine("\n--- ELIMINAR PRODUCTO ---");
            lista.Eliminar(300);
            lista.Listar();


        }
    }
}
