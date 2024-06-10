using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_enigpus.entities
{
    public class Magazine : Book
    {
        public Magazine(string id, string title, string publisher, int releaseYear) : base(id, title, publisher, releaseYear)
        {

        }
    }
}