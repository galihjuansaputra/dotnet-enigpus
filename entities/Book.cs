using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_enigpus.entities
{
    public abstract class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int ReleaseYear { get; set; }

        public Book(string id, string title, string publisher, int releaseYear){
            Id = id;
            Title = title;
            Publisher = publisher;
            ReleaseYear = releaseYear;
        }
        
    }
}