using System;
using System.Collections.Generic;

namespace SiriusWebDDD.Domain.Entities { 
    public partial class ModulosAcesso
    {
        public ModulosAcesso()
        {
            this.PerfisUsuario = new List<PerfilUsuario>();
        }
        public int IdModulo { get; set; }
        public string NomeModulo { get; set; }
        public string NomeMenuAcesso { get; set; }
        public string UrlMenu { get; set; }
        public bool FlAtivo { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? IdModuloPai { get; set; }

        public virtual ModulosAcesso ModulosAcessos { get; set; }

        /* Um modulo pode ter varios perfisUsuario*/
        public virtual ICollection<PerfilUsuario> PerfisUsuario { get; set; }
    }
}