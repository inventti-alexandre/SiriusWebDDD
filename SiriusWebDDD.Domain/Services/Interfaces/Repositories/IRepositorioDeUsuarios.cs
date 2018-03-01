using SiriusWebDDD.Domain.Entities;

namespace SiriusWebDDD.Domain.Interfaces.Repositories
{
    public interface IRepositorioDeUsuarios : IRepositorioBase<Usuario>
    {
        Usuario RecuperarUsuarioPorEmail(string email);
        Usuario LogaUsuario(string email, string senha);
        Usuario CadastraUsuario(Usuario user);
    }
}
