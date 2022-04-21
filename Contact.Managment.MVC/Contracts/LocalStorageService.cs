using Hanssens.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.Managment.MVC.Contracts
{
    public class LocalStorageService : ILocalStorageService
    {
        private LocalStorage _storge;
        public LocalStorageService()
        {
            var config = new LocalStorageConfiguration()
            {
                AutoLoad = true,
                AutoSave = true,
                Filename = "CustomerLoaclStoarge"
            };
            _storge = new LocalStorage(config);
        }
        public void ClearSotrage(List<string> keys)
        {
            foreach (var key in keys)
            {
                _storge.Remove(key);
            }
        }

        public bool Exist(string key)
        {
            return _storge.Exists(key);
        }

        public T GetStorageValue<T>(string key)
        {
            return _storge.Get<T>(key);
        }

        public void SetStorageValue<T>(string key, T value)
        {
            _storge.Store(key, value);
            _storge.Persist();
        }
    }
}
