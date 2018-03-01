using CommonServiceLocator;
using SiriusWebDDD.Domain.Interfaces.Domain;
using SiriusWebDDD.Infra.Data.Confinguration;
using SiriusWebDDD.Infra.Data.Context;

namespace SiriusWebDDD.Infrastructure.Data.Confinguration {
     public class UnidadeDeTrabalhoEF : IUnidadeDeTrabalho
    {
        private ContextoBanco _contexto;

        public void Iniciar()
        {
            var gerenciador = ServiceLocator.Current.GetInstance<IGerenciadorDeRepositorio>()
                              as GerenciadorDeRepositorio;

            _contexto = gerenciador.Contexto;
        }

        public void Persistir()
        {
            _contexto.SaveChanges();
        }

    }
}
