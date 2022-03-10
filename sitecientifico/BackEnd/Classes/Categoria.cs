using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sitecientifico.BackEnd.Classes
{
    public class Categoria
    {
        public int nCdCategoria { get; set; }
        public string sdsCategoria { get; set; }

        public Categoria(int nCdCategoria, string sdsCategoria)
        {
            this.nCdCategoria = nCdCategoria;
            this.sdsCategoria = sdsCategoria;
        }
    }
}