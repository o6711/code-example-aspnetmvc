using DataLayer.Entities;
using System;
using System.Linq;

namespace ServicesLayer
{
    public class MessagesRepo
    {
        private readonly CrudRepository _repo = new CrudRepository();

        public void Create(string text)
        {
            var message = new Message
            {
                MessageId = Guid.NewGuid(),
                Text = text,
                TimeStamp = DateTime.Now
            };

            _repo.Add(message);
        }

        public IQueryable<Message> GetItems()
        {
            return _repo.GetItems<Message>();
        }

        public Message GetById(Guid id)
        {
            return _repo.GetItemById<Message>(id);
        }

        public void Delete(Guid entityToDeleteId)
        {
            var entityToDelete = GetById(entityToDeleteId);
            if (entityToDelete == null) throw new NullReferenceException();

            _repo.Delete(entityToDelete);
        }
    }
}
