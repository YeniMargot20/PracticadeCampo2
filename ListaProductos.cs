﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticadeCampo2
{
    public class ListaProductos
    {
        NodoProducto nuevo, ptr, ptr1, raiz1, raiz2;

        public ListaProductos() 
        {
            raiz1 = raiz2 = null;
        }

        public void Insertar(Productos dato)
        {
            nuevo = new NodoProducto();
            nuevo.info = dato;
            if (raiz1 == null)
            {
                nuevo.sig = nuevo;
                nuevo.ant = nuevo;
                raiz1 = raiz2 = nuevo;
            }
            else
            {
                nuevo.ant = raiz2;
                nuevo.sig = raiz1;

                raiz2.sig = nuevo;
                raiz1.ant = nuevo;

                raiz2 = nuevo;

            }
        }

        
        public void Listar() //Responsable: Yeni Lloclle
        {
            ptr = raiz1;
            Console.WriteLine("\n---LISTADO ---");
            do
            {
                Console.WriteLine("\n{0} {1} {2} {3} {4}",
                    ptr.info.IdProducto,
                    ptr.info.Descripcion,
                    ptr.info.Stock,
                    ptr.info.Precio,
                    ptr.info.Estado);
                ptr = ptr.sig;
            } while (ptr != raiz1);
        }
        public void Buscar(int IdProducto) //Responsable: Bryan Becerra
        {
        }

        public void Eliminar(int IdProducto)//Responsable: Bryan Benavides
        {
            bool encontrado = false;
            if (ptr != null && raiz1.info.IdProducto == IdProducto)
            {
                raiz1 = raiz1.sig;
                raiz2.sig = raiz1;
                raiz1.ant = raiz2;

            } else if (raiz2.info.IdProducto == IdProducto)
            {
                raiz2 = raiz1.ant;
                raiz1.ant = raiz2;
                raiz2.sig = raiz1; 
                encontrado = true;

            }
            else
            {
                ptr=raiz1;
                do
                {
                    if (ptr.info.IdProducto == IdProducto)
                    {
                        ptr.ant.sig = ptr.sig;
                        ptr.sig.ant = ptr.ant;
                        break;
                    }
                    ptr = ptr.sig;
                } while (ptr!=raiz1);
                Console.WriteLine("\n{0}, PRODUCTO {1}", IdProducto, (encontrado ? "ELIMINADO" : "ELIMINADO"));
            }
        }
        public void Ordenar()//Responsable: Alessandra Ventura
        {
        }
    }
    }
