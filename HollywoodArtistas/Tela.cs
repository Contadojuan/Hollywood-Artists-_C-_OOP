using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HollywoodArtistas
{
    class Tela
    {
       
        Artista artista;
        public static void mostrarMenu()
        {
            Console.WriteLine("1 - Listar artistas ordenadamente");
            Console.WriteLine("2 - Cadastrar artista");
            Console.WriteLine("3 - Cadastrar filme");
            Console.WriteLine("4 - Mostrar dados de um filme");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite uma opção: ");
        }

        public void cadastrarArtista()
        {
            Console.WriteLine("Digite os dados do artista:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Valor do cachê: ");
            double cache = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            artista = new Artista(codigo, nome, cache);
            Program.artistas.Add(artista);
            Program.artistas.Sort();

        }

        public void cadastrarFilme()
        {
            Console.WriteLine("Digite os dados do filme: ");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Filme f = new Filme(codigo, titulo, ano);
            Console.Write("Quantas participações tem o filme? ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite os dados da " + (1 + i) + "º participação.");
                Console.Write("Artista(código): ");
                int codArtista = int.Parse(Console.ReadLine());
                int pos = Program.artistas.FindIndex(x => x.codigo == codArtista);

                if (pos == -1)
                {
                    throw new ModelException("Código do artista não encontrado: " + codigo);
                }
                Console.Write("Desconto: $");
                double desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Participacao part = new Participacao(desconto, Program.artistas[pos], f);
                f.participacoes.Add(part);
            }
            Program.filmes.Add(f);

        }
        public static void mostrarFilme()
        {
            Console.Write("Digite o código do filme: ");
            int codFilme = int.Parse(Console.ReadLine());
            int pos = Program.filmes.FindIndex(x => x.codigo == codFilme);
            if (pos == -1)
            {
                throw new ModelException("Código de filme não encontrado: " + codFilme);
            }
            Console.WriteLine(Program.filmes[pos]);
            Console.WriteLine();
        }
    }
}