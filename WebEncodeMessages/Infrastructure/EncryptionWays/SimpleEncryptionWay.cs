using DataLayer.Entities;
using System.Collections.Generic;
using System.Linq;

namespace WebEncodeMessages.Infrastructure.EncryptionWays
{
    public class SimpleEncryptionWay : IEncryptionWay
    {
        public string Encrypt(string input, IEnumerable<EncryptionSymbol> setFromDb)
        {
            return string.Concat(input.Select(charInput => setFromDb.First(entityDb => charInput.ToString().Equals(entityDb.OldSymbol)))
                                      .Select(x => x.NewSymbol));
        }
    }
}