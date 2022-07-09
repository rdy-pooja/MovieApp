using System;
using System.Collections.Generic;

#nullable disable

namespace MovieApp.Models
{
    public partial class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public DateTime Release { get; set; }
        public string Plot { get; set; }
    }
}
