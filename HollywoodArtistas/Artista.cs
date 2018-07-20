using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HollywoodArtistas
{
    class Artista : IComparable 
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public double cache { get; set; }
        public Participacao participacao;


        public Artista(int codigo, string nome, double cache)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cache = cache;
        }

        public override string ToString()
        {
            return codigo +
                ", " + nome +
                ", Cachê: $" + cache.ToString("F2", CultureInfo.InvariantCulture);

        }

        public int CompareTo(object obj)
        {
            Artista outroArtista = (Artista)obj;
            int resultado = nome.CompareTo(outroArtista.nome);
            if (resultado != 0)
            {
                return resultado;
            }
            throw new NotImplementedException();
        }
    }
}
