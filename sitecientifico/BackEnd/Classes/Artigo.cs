using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sitecientifico.BackEnd.Classes
{
    public class Artigo
    {
        public int nCdArtigo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public Artigo(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
        }
        public Artigo()
        {
        }

    }
}