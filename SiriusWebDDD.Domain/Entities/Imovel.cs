using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusWebDDD.Domain.Entities {
     public class Imovel {

          public int IdImovel { get; set; }
       
          public int EdificacaoId { get; set; }


          public string NomeIdentificado { get; set; }


          public int ResponsalId { get; set; }


          public int ProprietarioId { get; set; }

          public DateTime DataCadastro { get; set; }

          public int TipoIMovelId { get; set; }


          public virtual Edificacao Edificacao { get; set; }
          public virtual TipoImovel TipoImovel { get; set; }


     }
}
