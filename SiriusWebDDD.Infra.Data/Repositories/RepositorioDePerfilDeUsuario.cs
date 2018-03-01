using System.Collections.Generic;
using System.Linq;
using SiriusWebDDD.Domain.Interfaces.Repositories;
using SiriusWebDDD.Domain.Entities;

namespace SiriusWebDDD.Infra.Data.Repositories {
     public class RepositorioDePerfilDeUsuario : RepositorioBase<PerfilUsuario>, IRepositorioDePerfilDeUsuario
    {
        public List<Usuario> RetornaUsuariosDoPerfil(int idPerfilUsuario)
        {
            var perfil = _contexto.PerfilUsuario.Where(x => x.IdPerfilUsuario == idPerfilUsuario).FirstOrDefault();
            return perfil.Usuarios.ToList();
        }
    }
}
