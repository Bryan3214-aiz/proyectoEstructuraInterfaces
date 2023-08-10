﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoEstructuraInterfaces
{
    public class Postre
    {
        /* Definir el nombre ya que es lo que va a diferenciar 
           los postres y así poder hacer un pullup de la lista correcta */
        public string nombre { get; set; }
        public string ingrediente { get; set; }

        private LinkedList<string> postre = new LinkedList<string>();

        public void DefinirIngrediente()
        {
            Console.WriteLine("Agregue ingrediente");
            ingrediente = Console.ReadLine();
            Agregar();
        }

        private void Agregar()
        {
            postre.AddLast(ingrediente);
        }
    }
}
