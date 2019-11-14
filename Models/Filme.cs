using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocadoraFilmes.Models
{
    public class Filme
    {
        public int FilmeID { get; set; }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public Char Ativo { get; set; }
        public int GeneroID { get; set; }

        [Foreignkey("GeneroID")]
        public virtual Genero Genero { get; set; }
    }
}