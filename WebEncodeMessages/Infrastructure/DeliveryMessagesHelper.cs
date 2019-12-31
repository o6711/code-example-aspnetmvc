using ServicesLayer;
using System.Collections.Generic;
using System.Linq;
using WebEncodeMessages.Models;

namespace WebEncodeMessages.Infrastructure
{
    public class DeliveryMessagesHelper
    {
        private readonly MessagesRepo _messagesRepo;
        private readonly EncryptMessagesHelper _encryptMessagesHelper;


        public DeliveryMessagesHelper()
        {
            _messagesRepo = new MessagesRepo();
            _encryptMessagesHelper = new EncryptMessagesHelper();
        }

        public List<VmEncryptedMessages> GetAllMessages()
        {

            return _messagesRepo.GetItems()
                 .OrderByDescending(x => x.TimeStamp)
                 .ToList()
                 .Select(x => new VmEncryptedMessages
                 {
                     MessageText = _encryptMessagesHelper.Encrypt(x.Text),
                     TimeStampText = x.TimeStamp.ToString()
                 })
                .ToList(); 

        }

        public void SaveMessage(string message) =>
            _messagesRepo.Create(message);
    }

}
