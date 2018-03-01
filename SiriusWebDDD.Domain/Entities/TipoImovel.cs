using System;
using System.Collections.Generic;

namespace SiriusWebDDD.Domain.Entities {
     public class TipoImovel {
          public TipoImovel() {
               this.Imoveis = new List<Imovel>();
          }
          public int IdTipoImovel { get; set; }
          public string Nome { get; set; }
          public DateTime DataCadastro { get; set; }

          //Um Tipo de Imovel pode ter varios imoveis
          public virtual ICollection<Imovel> Imoveis { get; set; }
     }
}