using ServicesLayer;
using DataLayer.Entities;
using System.Collections.Generic;
using System.Linq;
using WebEncodeMessages.Infrastructure.EncryptionWays;

namespace WebEncodeMessages.Infrastructure
{
    public class EncryptMessagesHelper
    {
        private readonly EncryptionSymbolsRepo _encryptionSymbolsRepo;

        private IEncryptionWay _encryptionWay;

        public EncryptMessagesHelper()
        {
            _encryptionSymbolsRepo = new EncryptionSymbolsRepo();

            _encryptionWay = new SimpleEncryptionWay();
        }

        public string Encrypt(string input) =>
            _encryptionWay.Encrypt(input, GetRelevantEntities(input));


        private List<EncryptionSymbol> GetRelevantEntities(string setOfSymbols) =>
            _encryptionSymbolsRepo.GetItems().Where(x => setOfSymbols.Contains(x.OldSymbol)).ToList();
    }
}