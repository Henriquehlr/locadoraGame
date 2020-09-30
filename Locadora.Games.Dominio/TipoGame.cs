using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Games.Dominio
{
    public class TipoGame
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Grafico { get; set; }
        public string Classificacao { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }

    }
}
