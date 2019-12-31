using DataLayer.Entities;
using ServicesLayer;
using System;
using System.Collections.Generic;

namespace WebEncodeMessages.Infrastructure
{
    public class GeneratorHelper
    {
        private readonly CrudRepository _repo;

        public GeneratorHelper()
        {
            _repo = new CrudRepository();
        }

        public void GenerateEncryptionSymbolsData() 
        {
            GetEncryptionSymbolsList().ForEach(item => _repo.AddWithoutSave(item));
            _repo.Save();
        }

        private List<EncryptionSymbol> GetEncryptionSymbolsList()
        {
            return new List<EncryptionSymbol>()
            {
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(), OldSymbol = "й", NewSymbol = "q" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "ц", NewSymbol = "w" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "у", NewSymbol = "e" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "к", NewSymbol = "r" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "е", NewSymbol = "t" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "н", NewSymbol = "y" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "г", NewSymbol = "u" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "ш", NewSymbol = "i" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "щ", NewSymbol = "o" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "з", NewSymbol = "p" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "х", NewSymbol = "[" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "ъ", NewSymbol = "]" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "ф", NewSymbol = "a" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "ы", NewSymbol = "s" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "в", NewSymbol = "d" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "а", NewSymbol = "f" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "п", NewSymbol = "g" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "р", NewSymbol = "h" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "о", NewSymbol = "j" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "л", NewSymbol = "k" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "д", NewSymbol = "l" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "ж", NewSymbol = ";" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "э", NewSymbol = "==" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "я", NewSymbol = "z" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "ч", NewSymbol = "x" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "с", NewSymbol = "c" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "м", NewSymbol = "v" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "и", NewSymbol = "b" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "т", NewSymbol = "n" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "ь", NewSymbol = "m" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "б", NewSymbol = "," },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "ю", NewSymbol = "." },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = ".", NewSymbol = "--" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = " ", NewSymbol = "_" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "!", NewSymbol = "|." },

                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(), OldSymbol =  "q" , NewSymbol = "й" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "w" , NewSymbol = "ц"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "e" , NewSymbol = "у"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "r" , NewSymbol = "к"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "t" , NewSymbol = "е"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "y" , NewSymbol = "н"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "u" , NewSymbol = "г"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "i" , NewSymbol = "ш"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "o" , NewSymbol = "щ"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "p" , NewSymbol = "з"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "[" , NewSymbol = "х"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "]" , NewSymbol = "ъ"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "a" , NewSymbol = "ф"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "s" , NewSymbol = "ы"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "d" , NewSymbol = "в"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "f" , NewSymbol = "а"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "g" , NewSymbol = "п"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "h" , NewSymbol = "р"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "j" , NewSymbol = "о"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "k" , NewSymbol = "л"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "l" , NewSymbol = "д"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = ";" , NewSymbol = "ж"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "==", NewSymbol = "э" },
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "z" , NewSymbol = "я"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "x" , NewSymbol = "ч"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "c" , NewSymbol = "с"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "v" , NewSymbol = "м"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "b" , NewSymbol = "и"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "n" , NewSymbol = "т"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "m" , NewSymbol = "ь"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "," , NewSymbol = "б"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "_" , NewSymbol = " "},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "|.", NewSymbol = "!" },

                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "0" , NewSymbol = "11"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "1" , NewSymbol = "22"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "2" , NewSymbol = "33"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "3" , NewSymbol = "44"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "4" , NewSymbol = "55"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "5" , NewSymbol = "66"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "6" , NewSymbol = "77"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "7" , NewSymbol = "88"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "8" , NewSymbol = "99"},
                new EncryptionSymbol{EncryptionSymbolId = Guid.NewGuid(),  OldSymbol = "9" , NewSymbol = "0"},
            };
        }


    }
}