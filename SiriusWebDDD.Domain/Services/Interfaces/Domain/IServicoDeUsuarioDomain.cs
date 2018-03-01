using SiriusWebDDD.Domain.Entities;
using System.Collections.Generic;

namespace SiriusWebDDD.Domain.Interfaces.Domain {
     public interface IServicoDeUsuarioDomain
    {
        Usuario LogaUsuario(string email, string senha);
        Usuario RecuperaUsuarioPorEmail(string email);
        List<Usuario> RecuperaUsuariosDoPerfil(int idPerfilUsuario);
        List<PerfilUsuario> RecuperaTodosPerfisAtivos();
        void CadastraUsuario(Usuario usuario);
    }
}
