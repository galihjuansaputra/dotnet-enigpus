using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_enigpus.entities
{
public class Novel : Book
{
    public string Author { get; set; }

    public Novel(string id, string title, string publisher, int releaseYear, string author) : base(id, title, publisher, releaseYear)
    {
        Author = author;
    }
}
}