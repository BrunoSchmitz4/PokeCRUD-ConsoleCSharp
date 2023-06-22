using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace DecimoProjeto
{ 
    class Pokemon
    {
        public int Id;
        public string Nome;
        public string Tipo;
        public double Altura;
        public double Peso;

        private Pokemon[] pokeVet;
        public Pokemon()
        {
            if (Nome == null)
            {
                Nome = "?????";
            }
            if (Tipo == null)
            {
                Tipo = "?????";
            }
        }
        public void ShowPoke()
        {
            Console.WriteLine(ToString());
        }
        public void AddPoke()
        {
            Console.WriteLine("Aí sim! Como ele se chama?");
            Nome = Console.ReadLine();
            Console.WriteLine($"Hmm... qual a tipagem de {Nome}?");
            Tipo = Console.ReadLine();
            Console.WriteLine($"Um novo pokémon do tipo {Tipo}? Interessante...\nQual a altura de {Nome}?");
            Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Parece fazer sentido! E qual o peso de {Nome}?");
            Peso = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Muito bem! Vamos adicionar o pokémon do tipo {Tipo}, {Nome} à PokeWiki!");

        }
        
        public void AttPoke()
        {
            string option = "";
            option.ToUpper();
            while ((option != "N") || (option != "T") || (option != "A") || (option != "P") || (option != "C"))
            {
                Console.WriteLine($"Escolha o que quer que seja atualizado:" +
                $"\nOpções:\n(N) - Nome: {Nome}\n(T) - Tipo: {Tipo}\n(A) - Altura: {Altura}\n(P) - Peso: {Peso}\n(C) - Cancelar" +
                "\n");
                option = (Console.ReadLine().ToUpper());
                if (option == "N")
                {
                    Console.Clear();
                    Console.WriteLine($"Como {Nome} se chamará agora?");
                    Nome = Console.ReadLine();
                    Console.WriteLine("Dado atualizado!");
                    option = "";
                }
                else if (option == "T")
                {
                    Console.Clear();
                    Console.WriteLine($"Qual tipagem substituirá o tipo {Tipo} de {Nome}?");
                    Tipo = Console.ReadLine();
                    Console.WriteLine("Dado atualizado!");
                    option = "";
                }
                else if (option == "A")
                {
                    Console.Clear();
                    Console.WriteLine($"Qual a nova altura de {Nome}?");
                    Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Dado atualizado!");
                    option = "";
                }
                else if (option == "P")
                {
                    Console.Clear();
                    Console.WriteLine($"Qual o novo peso de {Nome}?");
                    Peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Dado atualizado!");
                    option = "";
                }
                else if (option == "C")
                {
                    break;
                }
            }
        }

        public void DeletaPoke()
        {
            string option = "";
            option.ToUpper();
            while((option != "S") || (option != "N") ||(option != "C")){
                Console.WriteLine("Tem certeza que deseja excluir o pokémon da WikiPoke?\n(S) - Sim || (N) - Não || (C) - Cancelar");
                option = Console.ReadLine().ToUpper();
                if (option == "S")
                {
                    Nome = "???";
                    Tipo = "???";
                    Peso = 0;
                    Altura = 0;
                    Console.WriteLine("Dados do pokémon excluido.");
                    break;
                }else if ((option == "N") || (option == "C")) { break; }
            }
        }

        public void AddListaPoke()
        {
            Console.WriteLine("Quantos pokémons deseja adicionar?");
            int qtdP = int.Parse(Console.ReadLine());
            pokeVet = new Pokemon[qtdP];

            for (int i = 0; i < qtdP; i++)
            {
                int id = i + 1;
                Console.WriteLine("Quem é este pokémon?:");
                string nome = Console.ReadLine();
                Console.WriteLine($"Qual o tipo de {nome}?");
                string tipo = Console.ReadLine();
                Console.WriteLine($"Um novo pokémon do tipo {tipo}? Interessante...\nQual a altura de {nome}?");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Parece fazer sentido! E qual o peso de {nome}?");
                double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Muito bem! Vamos adicionar o pokémon do tipo {tipo}, {nome} à PokeWiki!");
                pokeVet[i] = new Pokemon() { Id = id, Nome = nome, Tipo = tipo, Altura = altura, Peso = peso};
            }

            Console.WriteLine("Todos os pokémons foram adicionados!");
        }

        public void SeeListaPoke()
        {
            if ((pokeVet.Length <= 0) || pokeVet.Length == null) { Console.WriteLine("Nenhum pokémon adicionado!"); }
            else
            {
                Console.WriteLine("----------PokeWiki Database----------");
                for (int i = 0; i < pokeVet.Length; i++)
                {
                    Console.WriteLine($"ID: {pokeVet[i].Id}");
                    Console.WriteLine($"Nome: {pokeVet[i].Nome}");
                    Console.WriteLine($"Tipo: {pokeVet[i].Tipo}");
                    Console.WriteLine($"Altura: {pokeVet[i].Altura}m");
                    Console.WriteLine($"Peso: {pokeVet[i].Peso}kg");
                    Console.WriteLine("-------------------------------------");
                }
            }
            
        }

        public void AttListaPoke()
        {
            Console.WriteLine("----------PokeWiki Database----------");
            for (int i = 0; i < pokeVet.Length; i++)
            {
                Console.WriteLine($"ID: {pokeVet[i].Id}");
                Console.WriteLine($"Nome: {pokeVet[i].Nome}");
                Console.WriteLine($"Tipo: {pokeVet[i].Tipo}");
                Console.WriteLine($"Altura: {pokeVet[i].Altura}m");
                Console.WriteLine($"Peso: {pokeVet[i].Peso}kg");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("Selecione o ID do pokémon que queres atualizar");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                string option = "";
                if (i == n)
                {
                    i--;
                    while ((option != "N") || (option != "T") || (option != "A") || (option != "P") || (option != "C"))
                    {
                        Console.Clear();
                        Console.WriteLine($"Qual dos dados abaixos de {pokeVet[i].Nome} desejas atualizar?");
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine($"ID: {pokeVet[i].Id}");
                        Console.WriteLine($"(N) - Nome: {pokeVet[i].Nome}");
                        Console.WriteLine($"(T) - Tipo: {pokeVet[i].Tipo}");
                        Console.WriteLine($"(A) - Altura: {pokeVet[i].Altura}m");
                        Console.WriteLine($"(P) - Peso: {pokeVet[i].Peso}kg");
                        Console.WriteLine("(C) - Cancelar");
                        Console.WriteLine("-------------------------------------");
                        option = Console.ReadLine().ToUpper();
                        if (option == "N")
                        {
                            Console.WriteLine($"Como {pokeVet[i].Nome} passará a se chamar?");
                            pokeVet[i].Nome = Console.ReadLine();
                            option = "";
                        }else if (option == "T")
                        {
                            Console.WriteLine($"Qual será a tipagem que substituirá o tipo {pokeVet[i].Tipo} de {pokeVet[i].Nome}?");
                            pokeVet[i].Tipo = Console.ReadLine();
                        }
                        else if (option == "A")
                        {
                            Console.WriteLine($"Qual será a nova altura de {pokeVet[i].Nome}?");
                            pokeVet[i].Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        }
                        else if (option == "P")
                        {
                            Console.WriteLine($"Qual será a nova altura de {pokeVet[i].Nome}?");
                            pokeVet[i].Peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        }
                        else if (option == "C")
                        {
                            break;
                        }
                    }

                    break;
                }
            }
            
        }
        public override string ToString()
        {
            return "Dados:\nNome: " + Nome + "\nTipo: " + Tipo + "\nAltura: " + Altura + "\nPeso: " + Peso;
        }
    }
}
