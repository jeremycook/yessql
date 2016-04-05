﻿using System.Threading.Tasks;
using YesSql.Core.Storage;

namespace YesSql.Storage.InMemory
{
    public class InMemoryDocumentStorageFactory : IDocumentStorageFactory
    {
        private InMemoryDocumentStorage _storage;

        public IDocumentStorage CreateDocumentStorage()
        {
            if(_storage == null)
            {
                _storage = new InMemoryDocumentStorage();
            }

            return _storage;
        }

        public Task InitializeAsync()
        {
#if NET451
            return Task.FromResult(0);
#else
            return Task.CompletedTask;
#endif
        }

    }
}
