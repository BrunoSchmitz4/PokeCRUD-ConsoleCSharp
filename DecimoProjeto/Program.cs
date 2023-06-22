using DecimoProjeto;
using System;
using System.Globalization;

namespace ProjetoPokemom
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            Pokemon p = new Pokemon();
            option.ToUpper();

            int qtdP;
            Pokemon[] pokeV;

            Console.WriteLine("------Bem Vindo ao PokeWiki!-----");

            while ((option != "ADD") || (option != "SEE"))
            {
                //if (((p.Nome != null) || (p.Nome != "???")) || (p.Nome != "???") || (p.Peso != null) && (p.Peso > 0.0) || (p.Altura != null) || (p.Altura > 0.0) || (p.Tipo != null) || (p.Tipo != "???"))
                //{
                //    Console.WriteLine("Do que precisa?\n(ADD) - Adicionar pokémon;\n(SEE) - Mostrar pokémon;\n(ATT) - Atualizar pokémon;\n(DEL) - Deleta pokémon\n(OFF) - Sair");
                //}
                //else
                //{
                //    Console.WriteLine("Do que precisa?\n(ADD) - Adicionar pokémon;\n(OFF) - Sair");
                //}
                Console.WriteLine("Do que precisa?\n(ADD) - Adicionar pokémon;\n(SEE) - Mostrar pokémon;\n(ATT) - Atualizar pokémon;\n(DEL) - Deleta pokémon\n(OFF) - Sair");
                option = Console.ReadLine().ToUpper();
                option.ToUpper();
                if (option == "ADD")
                {
                    Console.Clear();
                    p.AddListaPoke();
                    Console.WriteLine("\n\n");
                }
                else if (option == "SEE")
                {
                    Console.Clear();
                    p.SeeListaPoke();
                    Console.WriteLine("\n\n");
                }else if (option == "ATT")
                {
                    Console.Clear();
                    p.AttListaPoke();
                    Console.WriteLine("\n\n");

                }else if (option == "DEL")
                {
                    Console.Clear();
                    p.DeletaPoke();
                    Console.WriteLine("\n\n");
                }
                else if (option == "OFF"){ break; }
            }
        }
    }   
}