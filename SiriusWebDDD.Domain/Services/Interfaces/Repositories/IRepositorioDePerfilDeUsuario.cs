using SiriusWebDDD.Domain.Entities;
using System.Collections.Generic;

namespace SiriusWebDDD.Domain.Interfaces.Repositories {
     public interface IRepositorioDePerfilDeUsuario : IRepositorioBase<PerfilUsuario>
    {
        List<Usuario> RetornaUsuariosDoPerfil(int idPerfilUsuario);
    }
}
