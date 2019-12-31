using System;

namespace DataLayer.Entities
{
    public class EncryptionSymbol
    {
        public Guid EncryptionSymbolId { get; set; }

        public string OldSymbol { get; set; }

        public string NewSymbol { get; set; }
    }
}
