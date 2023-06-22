using System;
using System.Globalization;

namespace DecimoProjeto
{ 
    class Pokemon
    {
        //public int id;
        public string Nome;
        public string Tipo;
        public double Altura;
        public double Peso;

        //public Pokemon(string nome, string tipo, double altura, double peso)
        //{
        //    Nome = nome;
        //    Tipo = tipo;
        //    Altura = altura;
        //    Peso = peso;
        //}
        public Pokemon()
        {
            if (Nome == null)
            {
                Nome = "???";
            }
            if (Tipo == null)
            {
                Tipo = "???";
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
        public override string ToString()
        {
            return "Dados:\nNome: " + Nome + "\nTipo: " + Tipo + "\nAltura: " + Altura + "\nPeso: " + Peso;
        }
    }
}
