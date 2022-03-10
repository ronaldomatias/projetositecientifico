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
        public DateTime dtCriacao { get; set; }
        public int nCdCategoria { get; set; }

        public Artigo(string titulo, string descricao, DateTime dataCriacao, int categoria)
        {
            Titulo = titulo;
            Descricao = descricao;
            dtCriacao = dataCriacao;
            nCdCategoria = categoria;
        }

         public Artigo(string titulo, string descricao, DateTime dataCriacao)
        {
            Titulo = titulo;
            Descricao = descricao;
            dtCriacao = dataCriacao;
        }

        public Artigo(string titulo)
        {
            Titulo = titulo;
        }
        public Artigo()
        {
        }

    }
}