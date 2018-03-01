using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SiriusWebDDD.Domain.Entities {

     [Table("Condominio")]
     public class Condominio {

          public Condominio() {
               this.EdificacaoList = new List<Edificacao>(); 
          }
                 
          public int IdCondominio { get; set; }

         
          public string Nome { get; set; }
          public DateTime DataCadastro { get; set; }
          public virtual ICollection<Edificacao> EdificacaoList { get; set; }


     }
}
