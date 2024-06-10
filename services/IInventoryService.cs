using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_enigpus.services
{
    public interface IInventoryService
    {
        void AddBook();
        void SearchBook();
        void GetAllBooks();
    }
}