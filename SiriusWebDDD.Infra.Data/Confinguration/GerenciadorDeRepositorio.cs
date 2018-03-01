using SiriusWebDDD.Domain.Interfaces.Domain;
using SiriusWebDDD.Infra.Data.Context;
using System.Web;

namespace SiriusWebDDD.Infra.Data.Confinguration {
     public class GerenciadorDeRepositorio : IGerenciadorDeRepositorio
    {
        public const string ContextoHttp = "ContextoHttp";

        public ContextoBanco Contexto
        {
            get
            {   //Se nao tiver um nome com esse contexto
                if (HttpContext.Current.Items[ContextoHttp] == null)
                    HttpContext.Current.Items[ContextoHttp] = new ContextoBanco();

                return HttpContext.Current.Items[ContextoHttp] as ContextoBanco;
            }
        }

        public void Finalizar()
        {
            if (HttpContext.Current.Items[ContextoHttp] != null)
                (HttpContext.Current.Items[ContextoHttp] as ContextoBanco).Dispose();
        }
    }
}
