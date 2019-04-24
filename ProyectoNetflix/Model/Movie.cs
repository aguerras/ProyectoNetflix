using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoNetflix.Model
{
    public class Movie
    {
        private String name;
        private String picture;
        private String category;
        private String description;

        public Movie(string name, string picture, string category, string description)
        {
            this.name = name;
            this.picture = picture;
            this.category = category;
            this.description = description;
        }

        public string Name { get => name; set => name = value; }
        public string Picture { get => picture; set => picture = value; }
        public string Category { get => category; set => category = value; }
        public string Description { get => description; set => description = value; }
    }
}