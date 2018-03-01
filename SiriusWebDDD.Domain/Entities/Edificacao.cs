using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusWebDDD.Domain.Entities {

     public class Edificacao {

          public Edificacao() {
               this.ImovelLista = new List<Imovel>();
          }
          public int IdEdificacao { get; set; }


          public int CondominioId { get; set; }

          public virtual Condominio condominio { get; set; }


     
          public string Nome { get; set; }


          public string Telefone { get; set; }
          public string Logradouro { get; set; }

          public string Numero { get; set; }

          public string Complemento { get; set; }

          public string Bairro { get; set; }

          public string Cidade { get; set; }

          public string Uf { get; set; }
          public string Cep { get; set; }

          public DateTime DataCadastro { get; set; }
          public virtual ICollection<Imovel> ImovelLista { get; set; }
     }

}