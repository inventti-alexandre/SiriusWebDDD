using System.Collections.Generic;

namespace SiriusWebDDD.Domain.Interfaces.Repositories {
     public interface IRepositorioBase<TEntidade> where TEntidade : class
    {
        IList<TEntidade> RecuperarTodos();
         TEntidade RecuperarPorID(int id);
        void Inserir(TEntidade obj);
        void Alterar(TEntidade obj);
        void Remover(TEntidade obj);
        void Remover(int id);
    }
}
