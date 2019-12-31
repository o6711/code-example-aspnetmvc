using DataLayer.Entities;
using System.Collections.Generic;

namespace WebEncodeMessages.Infrastructure.EncryptionWays
{
    public interface IEncryptionWay
    {
        string Encrypt(string input, IEnumerable<EncryptionSymbol> setFromDb);
    }
}
