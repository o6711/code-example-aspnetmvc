using DataLayer.Entities;
using System;
using System.Linq;

namespace ServicesLayer
{
    public class EncryptionSymbolsRepo
    {
        private readonly CrudRepository _repo = new CrudRepository();
        
        public void Create(string oldSymbol, string newSymbol)
        {
            var eSymbol = new EncryptionSymbol 
            { 
                EncryptionSymbolId = Guid.NewGuid(), 
                OldSymbol = oldSymbol, 
                NewSymbol = newSymbol 
            };

            _repo.Add(eSymbol);
        }

        public IQueryable<EncryptionSymbol> GetItems()
        {
            return _repo.GetItems<EncryptionSymbol>();
        }

        public EncryptionSymbol GetById(Guid id)
        {
            return _repo.GetItemById<EncryptionSymbol>(id);
        }

        public void Edit(Guid entityToChangeId, string oldSymbolToChange, string newSymbolToChange)
        {
            var entityToChange = GetById(entityToChangeId);
            if (entityToChange == null) throw new NullReferenceException();

            entityToChange.OldSymbol = oldSymbolToChange;
            entityToChange.NewSymbol = newSymbolToChange;

            _repo.Update(entityToChange);
        }

        public void Delete(Guid entityToDeleteId)
        {
            var entityToDelete = GetById(entityToDeleteId);
            if (entityToDelete == null) throw new NullReferenceException();

            _repo.Delete(entityToDelete);
        }
    }
}
