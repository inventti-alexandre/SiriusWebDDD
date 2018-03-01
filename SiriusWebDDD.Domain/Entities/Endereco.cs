using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusWebDDD.Domain.Entities {
     public class Endereco {
          public Endereco() {
               IdEndereco = Guid.NewGuid();
          }

          public Guid IdEndereco { get; set; }
          public string Logradouro { get; set; }
          public string Numero { get; set; }
          public string Complemento { get; set; }
          public string Bairro { get; set; }
          public string Uf{ get; set; }
          public string Cidade { get; set; }
          public string Cep { get; set; }
          public DateTime DataCadastro { get; set; }
     }
}
