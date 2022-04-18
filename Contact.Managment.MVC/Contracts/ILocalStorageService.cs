using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.Managment.MVC.Contracts
{
    public interface ILocalStorageService
    {
        void ClearSotrage(List<string> key);
        bool Exist(string key);
        T GetStorageValue<T>(string key);
        void SetStorageValue<T>(string key, T value);
    }
}
