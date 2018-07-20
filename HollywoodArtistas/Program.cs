using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HollywoodArtistas
{
    class Program
    {
        public static List<Artista> artistas = new List<Artista>();
        public static List<Filme> filmes = new List<Filme>();
        public static List<Participacao> p = new List<Participacao>();
        public static Artista artista;

        static void Main(string[] args)
        {
            int leituraOpcao = 0;
            Tela tela = new Tela();

            artistas.Add(new Artista(102, "Chris Evans", 250000.00));
            artistas.Add(new Artista(104, "Morgan Freeman", 450000.00));
            artistas.Add(new Artista(103, "Robert Downey Jr.", 300000.00));
            artistas.Add(new Artista(101, "Scarlett Johansson", 450000.00));
            artistas.Sort();




            while (leituraOpcao != 5)
            {
                Console.Clear();
                Tela.mostrarMenu();
               
                try
                {
                    leituraOpcao = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    leituraOpcao = 0;

                }
                if (leituraOpcao == 1)
                {
                    Console.WriteLine("LISTAGEM DE ARTISTAS");
                    for (int i = 0; i < artistas.Count; i++)
                    {

                        Console.WriteLine(artistas[i]);
                    }
                }
                else if (leituraOpcao == 2)
                {
                    try { 
                    tela.cadastrarArtista();
                    } catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (leituraOpcao == 3)
                {
                  
                        try
                        {
                            tela.cadastrarFilme();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }

                }
                else if (leituraOpcao == 4)
                {
                    try
                    {
                        Tela.mostrarFilme();
                    }
                    catch (ModelException e)
                    {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (leituraOpcao == 5)
                {
                    Console.WriteLine("Muito obrigado por usar nosso software!");
                }
                else
                {

                    Console.WriteLine("Opção inválida");
                }
                Console.ReadLine();
            }

        }
    }
}
