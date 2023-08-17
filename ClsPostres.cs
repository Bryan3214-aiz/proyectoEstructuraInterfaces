using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoEstructuraInterfaces
{
    public class Postre
    {
        public string Nombre { get; set; }
        public LinkedList<string> Ingredientes { get; set; }
        public Postre(string nombre, LinkedList<string> ingredientes)
        {
            Nombre = nombre;
            Ingredientes = ingredientes;
        }
    }
    public class PostresManager
    {
        private Postre[] postres;

        public PostresManager()
        {
            postres = new Postre[10];

            for (int i = 0; i < postres.Length; i++)
            {
                postres[i] = new Postre(null, new LinkedList<string>());
            }
        }

        private int BuscarIndice(string nombrePostre)
        {
            for (int i = 0; i < postres.Length; i++)
            {
                if (postres[i].Nombre == null)
                {
                    return i; // Devuelve el primer índice disponible
                }

                if (postres[i].Nombre == nombrePostre)
                {
                    return i;
                }
            }
            return -1;
        }

        public void AgregarPostre(string nombrePostre, LinkedList<string> ingredientes)
        {
            int indice = BuscarIndice(null);

            if (indice != -1)
            {
                postres[indice] = new Postre(nombrePostre, ingredientes);
            }
        }

        public void EliminarPostre(string nombrePostre)
        {
            int indice = BuscarIndice(nombrePostre);

            if (indice != -1)
            {
                postres[indice] = new Postre(null, new LinkedList<string>());

                for (int i = indice; i < postres.Length - 1; i++)
                {
                    if (postres[i + 1].Nombre != null)
                    {
                        postres[i] = postres[i + 1];
                        postres[i + 1] = new Postre(null, new LinkedList<string>());
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public void AgregarIngrediente(string nombrePostre, string nombreIngrediente)
        {
            int indice = BuscarIndice(nombrePostre);

            if (indice != -1)
            {
                postres[indice].Ingredientes.AddLast(nombreIngrediente);
            }
        }

        public void EliminarIngrediente(string nombrePostre, string nombreIngrediente)
        {
            int indice = BuscarIndice(nombrePostre);

            if (indice != -1)
            {
                postres[indice].Ingredientes.Remove(nombreIngrediente);
            }
        }

        public void ImprimirIngredientes(string nombrePostre)
        {
            int indice = BuscarIndice(nombrePostre);

            if (indice != -1)
            {
                Console.WriteLine($"Ingredientes de {nombrePostre}:");
                foreach (var ingrediente in postres[indice].Ingredientes)
                {
                    Console.WriteLine(ingrediente);
                }
            }
            else
            {
                Console.WriteLine($"El postre '{nombrePostre}' no existe.");
            }
        }
    }
}
