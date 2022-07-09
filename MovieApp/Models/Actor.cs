using System;
using System.Collections.Generic;

#nullable disable

namespace MovieApp.Models
{
    public partial class Actor
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
