using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathematic_app
{
    public class Film
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string Type { get; set;}

        public Film(string name, string description, int rating, string type)
        {
            Name = name;
            Description = description;
            Rating = rating;
            Type = type;
        }
    }
}
