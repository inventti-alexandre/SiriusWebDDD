using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using SiriusWebDDD.Domain.Interfaces.Repositories;
using SiriusWebDDD.Infra.Data.Context;
using SiriusWebDDD.Infra.Data.Confinguration;
using SiriusWebDDD.Domain.Interfaces.Domain;
using CommonServiceLocator;

namespace SiriusWebDDD.Infra.Data.Repositories {
     public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : class
    {
        protected readonly ContextoBanco _contexto;

        public RepositorioBase()
        {
            var gerenciador = (GerenciadorDeRepositorio)ServiceLocator.Current.GetInstance<IGerenciadorDeRepositorio>();
            _contexto = gerenciador.Contexto;
        }

        public void Alterar(TEntidade obj)
        {
            _contexto.Entry(obj).State = EntityState.Modified;
        }

        public void Inserir(TEntidade obj)
        {
            _contexto.Set<TEntidade>().Add(obj);
        }

        public TEntidade RecuperarPorID(int id)
        {
            return _contexto.Set<TEntidade>().Find(id);
        }

        public IList<TEntidade> RecuperarTodos()
        {
            return _contexto.Set<TEntidade>().ToList();
        }

        public void Remover(int id)
        {
            TEntidade obj = RecuperarPorID(id);
            Remover(obj);
        }

        public void Remover(TEntidade obj)
        {
            _contexto.Set<TEntidade>().Remove(obj);
        }        
    }
}
